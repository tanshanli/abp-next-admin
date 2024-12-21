﻿using LINGYUN.Abp.AspNetCore.Wrapper;
using LINGYUN.Abp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.Authorization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.ExceptionHandling;
using Volo.Abp.Http;
using Volo.Abp.Json;

namespace LINGYUN.Abp.AspNetCore.Mvc.Wrapper.ExceptionHandling;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(AbpExceptionPageFilter))]
public class AbpExceptionPageWrapResultFilter: AbpExceptionPageFilter, ITransientDependency
{
    protected override async Task HandleAndWrapException(PageHandlerExecutedContext context)
    {
        var wrapResultChecker = context.GetRequiredService<IWrapResultChecker>();
        if (!wrapResultChecker.WrapOnException(context))
        {
            await base.HandleAndWrapException(context);
            return;
        }

        var wrapOptions = context.GetRequiredService<IOptions<AbpWrapperOptions>>().Value;
        var exceptionHandlingOptions = context.GetRequiredService<IOptions<AbpExceptionHandlingOptions>>().Value;
        var exceptionToErrorInfoConverter = context.GetRequiredService<IExceptionToErrorInfoConverter>();
        var remoteServiceErrorInfo = exceptionToErrorInfoConverter.Convert(context.Exception, options =>
        {
            options.SendExceptionsDetailsToClients = exceptionHandlingOptions.SendExceptionsDetailsToClients;
            options.SendStackTraceToClients = exceptionHandlingOptions.SendStackTraceToClients;
        });

        var logLevel = context.Exception.GetLogLevel();

        var remoteServiceErrorInfoBuilder = new StringBuilder();
        remoteServiceErrorInfoBuilder.AppendLine($"---------- {nameof(RemoteServiceErrorInfo)} ----------");
        remoteServiceErrorInfoBuilder.AppendLine(context.GetRequiredService<IJsonSerializer>().Serialize(remoteServiceErrorInfo, indented: true));

        var logger = context.GetService<ILogger<AbpExceptionPageWrapResultFilter>>(NullLogger<AbpExceptionPageWrapResultFilter>.Instance);
        logger.LogWithLevel(logLevel, remoteServiceErrorInfoBuilder.ToString());

        logger.LogException(context.Exception, logLevel);

        await context.GetRequiredService<IExceptionNotifier>().NotifyAsync(new ExceptionNotificationContext(context.Exception));

        var isAuthenticated = context.HttpContext.User?.Identity?.IsAuthenticated ?? false;

        if (context.Exception is AbpAuthorizationException)
        {
            if (!wrapOptions.IsWrapUnauthorizedEnabled)
            {
                await context.HttpContext.RequestServices.GetRequiredService<IAbpAuthorizationExceptionHandler>()
                        .HandleAsync(context.Exception.As<AbpAuthorizationException>(), context.HttpContext);

                context.Exception = null;

                return;
            }

            if (isAuthenticated)
            {
                await context.HttpContext.RequestServices.GetRequiredService<IAbpAuthorizationExceptionHandler>()
                        .HandleAsync(context.Exception.As<AbpAuthorizationException>(), context.HttpContext);

                context.Exception = null;

                return;
            }
        }

        var httpResponseWrapper = context.GetRequiredService<IHttpResponseWrapper>();
        var statusCodFinder = context.GetRequiredService<IHttpExceptionStatusCodeFinder>();
        var exceptionWrapHandler = context.GetRequiredService<IExceptionWrapHandlerFactory>();
        var exceptionWrapContext = new ExceptionWrapContext(
            context.Exception,
            remoteServiceErrorInfo,
            context.HttpContext.RequestServices,
            statusCodFinder.GetStatusCode(context.HttpContext, context.Exception));
        exceptionWrapHandler.CreateFor(exceptionWrapContext).Wrap(exceptionWrapContext);

        var wrapperHeaders = new Dictionary<string, string>()
            {
                { AbpHttpWrapConsts.AbpWrapResult, "true" }
            };
        var responseWrapperContext = new HttpResponseWrapperContext(
            context.HttpContext,
            (int)wrapOptions.HttpStatusCode,
            wrapperHeaders);

        httpResponseWrapper.Wrap(responseWrapperContext);

        context.Result = new ObjectResult(new WrapResult(
            exceptionWrapContext.ErrorInfo.Code,
            exceptionWrapContext.ErrorInfo.Message,
            exceptionWrapContext.ErrorInfo.Details));

        context.Exception = null; //Handled!
    }
}
