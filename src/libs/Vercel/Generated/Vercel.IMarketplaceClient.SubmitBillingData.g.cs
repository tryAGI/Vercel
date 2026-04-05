#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Submit Billing Data<br/>
        /// Sends the billing and usage data. The partner should do this at least once a day and ideally once per hour. &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task SubmitBillingDataAsync(
            string integrationConfigurationId,

            global::Vercel.SubmitBillingDataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Billing Data<br/>
        /// Sends the billing and usage data. The partner should do this at least once a day and ideally once per hour. &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="timestamp">
        /// Server time of your integration, used to determine the most recent data for race conditions &amp; updates. Only the latest usage data for a given day, week, and month will be kept.
        /// </param>
        /// <param name="eod">
        /// End of Day, the UTC datetime for when the end of the billing/usage day is in UTC time. This tells us which day the usage data is for, and also allows for your \"end of day\" to be different from UTC 00:00:00. eod must be within the period dates, and cannot be older than 24h earlier from our server's current time.
        /// </param>
        /// <param name="period">
        /// Period for the billing cycle. The period end date cannot be older than 24 hours earlier than our current server's time.
        /// </param>
        /// <param name="billing">
        /// Billing data (interim invoicing data).
        /// </param>
        /// <param name="usage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SubmitBillingDataAsync(
            string integrationConfigurationId,
            global::System.DateTime timestamp,
            global::System.DateTime eod,
            global::Vercel.SubmitBillingDataRequestPeriod period,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling> billing,
            global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestUsageItem> usage,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}