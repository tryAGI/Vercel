#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Create one or more shared environment variables<br/>
        /// Creates shared environment variable(s) for a team.
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateSharedEnvVariableResponse> CreateSharedEnvVariableAsync(

            global::Vercel.CreateSharedEnvVariableRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create one or more shared environment variables<br/>
        /// Creates shared environment variable(s) for a team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="evs"></param>
        /// <param name="type">
        /// The type of environment variable<br/>
        /// Example: encrypted
        /// </param>
        /// <param name="target">
        /// The target environment of the Shared Environment Variable<br/>
        /// Example: [production, preview]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSharedEnvVariableResponse> CreateSharedEnvVariableAsync(
            global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableRequestEv> evs,
            string? teamId = default,
            string? slug = default,
            global::Vercel.CreateSharedEnvVariableRequestType? type = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableRequestTargetItem>? target = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}