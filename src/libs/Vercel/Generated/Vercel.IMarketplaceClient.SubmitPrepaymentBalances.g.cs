#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Submit Prepayment Balances<br/>
        /// Sends the prepayment balances. The partner should do this at least once a day and ideally once per hour. &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task SubmitPrepaymentBalancesAsync(
            string integrationConfigurationId,

            global::Vercel.SubmitPrepaymentBalancesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Prepayment Balances<br/>
        /// Sends the prepayment balances. The partner should do this at least once a day and ideally once per hour. &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="timestamp">
        /// Server time of your integration, used to determine the most recent data for race conditions &amp; updates. Only the latest usage data for a given day, week, and month will be kept.
        /// </param>
        /// <param name="balances"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SubmitPrepaymentBalancesAsync(
            string integrationConfigurationId,
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<global::Vercel.SubmitPrepaymentBalancesRequestBalance> balances,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}