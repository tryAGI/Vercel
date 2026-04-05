#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Updates one or more shared environment variables<br/>
        /// Updates a given Shared Environment Variable for a Team.
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateSharedEnvVariableResponse> UpdateSharedEnvVariableAsync(

            global::Vercel.UpdateSharedEnvVariableRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates one or more shared environment variables<br/>
        /// Updates a given Shared Environment Variable for a Team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="updates">
        /// An object where each key is an environment variable ID (not the key name) and the value is the update to apply<br/>
        /// Example: {"env_2WjyKQmM8ZnGcJsPWMrHRHrE":{"key":"API_URL","value":"https://api.vercel.com","target":["production","preview"],"projectIdUpdates":{"link":["prj_2WjyKQmM8ZnGcJsPWMrHRHrE"]}}}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateSharedEnvVariableResponse> UpdateSharedEnvVariableAsync(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateSharedEnvVariableRequestUpdates2> updates,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}