#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Delete one or more Env Var<br/>
        /// Deletes one or many Shared Environment Variables for a given team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteSharedEnvVariableResponse> DeleteSharedEnvVariableAsync(

            global::Vercel.DeleteSharedEnvVariableRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete one or more Env Var<br/>
        /// Deletes one or many Shared Environment Variables for a given team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="ids">
        /// IDs of the Shared Environment Variables to delete<br/>
        /// Example: [env_abc123, env_abc124]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteSharedEnvVariableResponse> DeleteSharedEnvVariableAsync(
            global::System.Collections.Generic.IList<string> ids,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}