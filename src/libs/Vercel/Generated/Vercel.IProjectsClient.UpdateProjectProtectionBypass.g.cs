#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update Protection Bypass for Automation<br/>
        /// Update the deployment protection automation bypass for a project
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectProtectionBypassResponse> UpdateProjectProtectionBypassAsync(
            string idOrName,

            global::Vercel.UpdateProjectProtectionBypassRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Protection Bypass for Automation<br/>
        /// Update the deployment protection automation bypass for a project
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="revoke">
        /// Optional instructions for revoking and regenerating a automation bypass
        /// </param>
        /// <param name="generate">
        /// Generate a new secret. If neither generate or revoke are provided, a new random secret will be generated.
        /// </param>
        /// <param name="update">
        /// Update an existing bypass
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectProtectionBypassResponse> UpdateProjectProtectionBypassAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::Vercel.UpdateProjectProtectionBypassRequestRevoke? revoke = default,
            global::Vercel.UpdateProjectProtectionBypassRequestGenerate? generate = default,
            global::Vercel.UpdateProjectProtectionBypassRequestUpdate? update = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}