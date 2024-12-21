﻿using System;
using System.Collections.Generic;

namespace LINGYUN.Abp.Webhooks
{
    public class WebhookSubscriptionInfo
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Subscribed Tenant's id .
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Subscription webhook endpoint
        /// </summary>
        public string WebhookUri { get; set; }

        /// <summary>
        /// Webhook secret
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Is subscription active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Subscribed webhook definitions unique names.It contains webhook definitions list as json
        /// </summary>
        public List<string> Webhooks { get; set; }

        /// <summary>
        /// Gets a set of additional HTTP headers.That headers will be sent with the webhook. It contains webhook header dictionary as json
        /// </summary>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Request timeout time, in seconds
        /// </summary>
        public int? TimeoutDuration { get; set; }

        public WebhookSubscriptionInfo()
        {
            IsActive = true;
            Headers = new Dictionary<string, string>();
            Webhooks = new List<string>();
        }
    }
}