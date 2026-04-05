#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project transfer request<br/>
        /// Initiates a project transfer request from one team to another. &lt;br/&gt; Returns a `code` that remains valid for 24 hours and can be used to accept the transfer request by another team using the `PUT /projects/transfer-request/:code` endpoint. &lt;br/&gt; Users can also accept the project transfer request using the claim URL: `https://vercel.com/claim-deployment?code=&lt;code&gt;&amp;returnUrl=&lt;returnUrl&gt;`. &lt;br/&gt; The `code` parameter specifies the project transfer request code generated using this endpoint. &lt;br/&gt; The `returnUrl` parameter redirects users to a specific page of the application if the claim URL is invalid or expired.
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the project to transfer.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectTransferRequestResponse> CreateProjectTransferRequestAsync(
            string idOrName,

            global::Vercel.CreateProjectTransferRequestRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project transfer request<br/>
        /// Initiates a project transfer request from one team to another. &lt;br/&gt; Returns a `code` that remains valid for 24 hours and can be used to accept the transfer request by another team using the `PUT /projects/transfer-request/:code` endpoint. &lt;br/&gt; Users can also accept the project transfer request using the claim URL: `https://vercel.com/claim-deployment?code=&lt;code&gt;&amp;returnUrl=&lt;returnUrl&gt;`. &lt;br/&gt; The `code` parameter specifies the project transfer request code generated using this endpoint. &lt;br/&gt; The `returnUrl` parameter redirects users to a specific page of the application if the claim URL is invalid or expired.
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the project to transfer.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="callbackUrl">
        /// The URL to send a webhook to when the transfer is accepted.
        /// </param>
        /// <param name="callbackSecret">
        /// The secret to use to sign the webhook payload with HMAC-SHA256.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectTransferRequestResponse> CreateProjectTransferRequestAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            string? callbackUrl = default,
            string? callbackSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}