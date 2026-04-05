#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Accept project transfer request<br/>
        /// Accept a project transfer request initated by another team. &lt;br/&gt; The `code` is generated using the `POST /projects/:idOrName/transfer-request` endpoint.
        /// </summary>
        /// <param name="code">
        /// The code of the project transfer request.
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.AcceptProjectTransferRequestResponseVariant1, object>> AcceptProjectTransferRequestAsync(
            string code,

            global::Vercel.AcceptProjectTransferRequestRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Accept project transfer request<br/>
        /// Accept a project transfer request initated by another team. &lt;br/&gt; The `code` is generated using the `POST /projects/:idOrName/transfer-request` endpoint.
        /// </summary>
        /// <param name="code">
        /// The code of the project transfer request.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="newProjectName">
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </param>
        /// <param name="paidFeatures"></param>
        /// <param name="acceptedPolicies"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.AcceptProjectTransferRequestResponseVariant1, object>> AcceptProjectTransferRequestAsync(
            string code,
            string? teamId = default,
            string? slug = default,
            string? newProjectName = default,
            global::Vercel.AcceptProjectTransferRequestRequestPaidFeatures? paidFeatures = default,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AcceptProjectTransferRequestRequestAcceptedPolicies2>? acceptedPolicies = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}