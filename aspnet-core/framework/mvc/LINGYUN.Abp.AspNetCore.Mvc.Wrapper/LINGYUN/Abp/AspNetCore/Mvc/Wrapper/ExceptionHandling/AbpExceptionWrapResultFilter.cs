﻿using LINGYUN.Abp.AspNetCore.Wrapper;
using LINGYUN.Abp.Wrapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.Authorization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.ExceptionHandling;

namespace LINGYUN.Abp.AspNetCore.Mvc.Wrapper.ExceptionHandling;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(AbpExceptionFilter))]
public class AbpExceptionWrapResultFilter : AbpExceptionFilter, ITransientDependency
{
    protected async override Task HandleAndWrapException(ExceptionContext context)
    {
        var wrapResultChecker = context.GetRequiredService<IWrapResultChecker>();

        if (!wrapResultChecker.WrapOnException(context))
        {
            await base.HandleAndWrapException(context);
            return;
        }

        LogException(context, out var remoteServiceErrorInfo);

        await context.GetRequiredService<IExceptionNotifier>().NotifyAsync(new ExceptionNotificationContext(context.Exception));

        var isAuthenticated = context.HttpContext.User?.Identity?.IsAuthenticated ?? false;
        var wrapOptions = context.GetRequiredService<IOptions<AbpWrapperOptions>>().Value;

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
