#nullable enable

namespace Vercel
{
    public partial interface IDnsClient
    {
        /// <summary>
        /// Create a DNS record<br/>
        /// Creates a DNS record for a domain.
        /// </summary>
        /// <param name="domain">
        /// The domain used to create the DNS record.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.CreateRecordResponseVariant1, global::Vercel.CreateRecordResponseVariant2>> CreateRecordAsync(
            string domain,

            global::Vercel.CreateRecordRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a DNS record<br/>
        /// Creates a DNS record for a domain.
        /// </summary>
        /// <param name="domain">
        /// The domain used to create the DNS record.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="type">
        /// The type of record, it could be one of the valid DNS records.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.CreateRecordResponseVariant1, global::Vercel.CreateRecordResponseVariant2>> CreateRecordAsync(
            string domain,
            global::Vercel.CreateRecordRequestType type,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}