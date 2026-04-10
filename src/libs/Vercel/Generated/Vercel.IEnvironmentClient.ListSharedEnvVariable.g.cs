#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Lists all Shared Environment Variables for a team<br/>
        /// Lists all Shared Environment Variables for a team, taking into account optional filters.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId">
        /// Filter SharedEnvVariables that belong to a project<br/>
        /// Example: prj_2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="ids">
        /// Filter SharedEnvVariables based on comma separated ids<br/>
        /// Example: env_2WjyKQmM8ZnGcJsPWMrHRHrE,env_2WjyKQmM8ZnGcJsPWMrHRCRV
        /// </param>
        /// <param name="excludeIds">
        /// Filter SharedEnvVariables based on comma separated ids<br/>
        /// Example: env_2WjyKQmM8ZnGcJsPWMrHRHrE,env_2WjyKQmM8ZnGcJsPWMrHRCRV
        /// </param>
        /// <param name="excludeIds2">
        /// Filter SharedEnvVariables based on comma separated ids<br/>
        /// Example: env_2WjyKQmM8ZnGcJsPWMrHRHrE,env_2WjyKQmM8ZnGcJsPWMrHRCRV
        /// </param>
        /// <param name="excludeProjectId">
        /// Filter SharedEnvVariables that belong to a project<br/>
        /// Example: prj_2WjyKQmM8ZnGcJsPWMrHRHrE
        /// </param>
        /// <param name="excludeProjectId2">
        /// Filter SharedEnvVariables that belong to a project<br/>
        /// Example: prj_2WjyKQmM8ZnGcJsPWMrHRHrE
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
        global::System.Threading.Tasks.Task<global::Vercel.ListSharedEnvVariableResponse> ListSharedEnvVariableAsync(
            string? search = default,
            string? projectId = default,
            string? ids = default,
            string? excludeIds = default,
            string? excludeIds2 = default,
            string? excludeProjectId = default,
            string? excludeProjectId2 = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}