#nullable enable

namespace Vercel
{
    public partial interface IDnsClient
    {
        /// <summary>
        /// Update an existing DNS record<br/>
        /// Updates an existing DNS record for a domain name.
        /// </summary>
        /// <param name="recordId">
        /// The id of the DNS record<br/>
        /// Example: rec_2qn7pzrx89yxy34vezpd31y9
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateRecordResponse> UpdateRecordAsync(
            string recordId,

            global::Vercel.UpdateRecordRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing DNS record<br/>
        /// Updates an existing DNS record for a domain name.
        /// </summary>
        /// <param name="recordId">
        /// The id of the DNS record<br/>
        /// Example: rec_2qn7pzrx89yxy34vezpd31y9
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// The name of the DNS record<br/>
        /// Example: example-1
        /// </param>
        /// <param name="value">
        /// The value of the DNS record<br/>
        /// Example: google.com
        /// </param>
        /// <param name="type">
        /// The type of the DNS record<br/>
        /// Example: A
        /// </param>
        /// <param name="ttl">
        /// The Time to live (TTL) value of the DNS record<br/>
        /// Example: 60
        /// </param>
        /// <param name="mxPriority">
        /// The MX priority value of the DNS record
        /// </param>
        /// <param name="srv"></param>
        /// <param name="https"></param>
        /// <param name="comment">
        /// A comment to add context on what this DNS record is for<br/>
        /// Example: used to verify ownership of domain
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateRecordResponse> UpdateRecordAsync(
            string recordId,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            string? value = default,
            global::Vercel.UpdateRecordRequestType? type = default,
            int? ttl = default,
            int? mxPriority = default,
            global::Vercel.UpdateRecordRequestSrv? srv = default,
            global::Vercel.UpdateRecordRequestHttps? https = default,
            string? comment = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}