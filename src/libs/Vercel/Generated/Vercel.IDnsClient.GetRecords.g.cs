#nullable enable

namespace Vercel
{
    public partial interface IDnsClient
    {
        /// <summary>
        /// List existing DNS records<br/>
        /// Retrieves a list of DNS records created for a domain name. By default it returns 20 records if no limit is provided. The rest can be retrieved using the pagination options.
        /// </summary>
        /// <param name="domain">
        /// Example: example.com
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to list from a request.<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Get records created after this JavaScript timestamp.<br/>
        /// Example: 1609499532000L
        /// </param>
        /// <param name="until">
        /// Get records created before this JavaScript timestamp.<br/>
        /// Example: 1612264332000L
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<string, global::Vercel.GetRecordsResponseVariant2, global::Vercel.GetRecordsResponseVariant3>> GetRecordsAsync(
            string domain,
            string? limit = default,
            string? since = default,
            string? until = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}