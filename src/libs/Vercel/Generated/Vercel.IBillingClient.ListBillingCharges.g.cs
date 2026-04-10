#nullable enable

namespace Vercel
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// List FOCUS billing charges<br/>
        /// Returns the billing charge data in FOCUS v1.3 JSONL format for a specified Vercel team, within a date range specified by `from` and `to` query parameters. Supports 1-day granularity with a maximum date range of 1 year. The response is streamed as newline-delimited JSON (JSONL) and can be optionally compressed with gzip if the `Accept-Encoding: gzip` header is provided. This is only available for Owner, Member, Developer, Security, Billing, and Enterprise Viewer roles for the supplied team.
        /// </summary>
        /// <param name="from">
        /// Inclusive start of the date range as an ISO 8601 date-time string in UTC.<br/>
        /// Example: 2025-01-01T00:00:00.000Z
        /// </param>
        /// <param name="to">
        /// Exclusive end of the date range as an ISO 8601 date-time string in UTC.<br/>
        /// Example: 2025-01-31T00:00:00.000Z
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        /// <remarks>
        /// curl -N --request GET \<br/>
        ///   --url 'https://api.vercel.com/v1/billing/charges?teamId=&lt;team&gt;&amp;from=&lt;from_date&gt;&amp;to=&lt;to_date&gt;' \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Accept-Encoding: gzip' \<br/>
        ///   --compressed
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vercel.ListBillingChargesResponse> ListBillingChargesAsync(
            string from,
            string to,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}