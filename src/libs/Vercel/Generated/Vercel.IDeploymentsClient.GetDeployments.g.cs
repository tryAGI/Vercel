#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// List deployments<br/>
        /// List deployments under the authenticated user or team. If a deployment hasn't finished uploading (is incomplete), the `url` property will have a value of `null`.
        /// </summary>
        /// <param name="app">
        /// Name of the deployment.<br/>
        /// Example: docs
        /// </param>
        /// <param name="from">
        /// Gets the deployment created after this Date timestamp. (default: current time)<br/>
        /// Example: 1612948664566L
        /// </param>
        /// <param name="limit">
        /// Maximum number of deployments to list from a request.<br/>
        /// Example: 10
        /// </param>
        /// <param name="projectId">
        /// Filter deployments from the given ID or name.<br/>
        /// Example: QmXGTs7mvAMMC7WW5ebrM33qKG32QK3h4vmQMjmY
        /// </param>
        /// <param name="projectIds">
        /// Filter deployments from the given project IDs. Cannot be used when projectId is specified.<br/>
        /// Example: [prj_123, prj_456]
        /// </param>
        /// <param name="target">
        /// Filter deployments based on the environment.<br/>
        /// Example: production
        /// </param>
        /// <param name="to">
        /// Gets the deployment created before this Date timestamp. (default: current time)<br/>
        /// Example: 1612948664566L
        /// </param>
        /// <param name="users">
        /// Filter out deployments based on users who have created the deployment.<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf,K4amb7K9dAt5R2vBJWF32bmY
        /// </param>
        /// <param name="since">
        /// Get Deployments created after this JavaScript timestamp.<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Get Deployments created before this JavaScript timestamp.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="state">
        /// Filter deployments based on their state (`BUILDING`, `ERROR`, `INITIALIZING`, `QUEUED`, `READY`, `CANCELED`)<br/>
        /// Example: BUILDING,READY
        /// </param>
        /// <param name="rollbackCandidate">
        /// Filter deployments based on their rollback candidacy
        /// </param>
        /// <param name="branch">
        /// Filter deployments based on the branch name
        /// </param>
        /// <param name="sha">
        /// Filter deployments based on the SHA
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetDeploymentsResponse> GetDeploymentsAsync(
            string? app = default,
            double? from = default,
            double? limit = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            string? target = default,
            double? to = default,
            string? users = default,
            double? since = default,
            double? until = default,
            string? state = default,
            bool? rollbackCandidate = default,
            string? branch = default,
            string? sha = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}