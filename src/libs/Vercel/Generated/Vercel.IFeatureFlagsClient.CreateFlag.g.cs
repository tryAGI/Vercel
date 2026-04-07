#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Create a flag<br/>
        /// Create a new feature flag for a project. The flag must have a unique slug within the project and specify its kind (boolean, string, number, or json).
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateFlagResponse> CreateFlagAsync(
            string projectIdOrName,

            global::Vercel.CreateFlagRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a flag<br/>
        /// Create a new feature flag for a project. The flag must have a unique slug within the project and specify its kind (boolean, string, number, or json).
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestSlug">
        /// A unique (per project) key for the flag, composed of letters, numbers, dashes, and underscores
        /// </param>
        /// <param name="kind">
        /// The kind of flag
        /// </param>
        /// <param name="variants">
        /// The variants of the flag
        /// </param>
        /// <param name="environments">
        /// The configuration for the flag in different environments
        /// </param>
        /// <param name="seed">
        /// A random seed to prevent split points in different flags from having the same targets
        /// </param>
        /// <param name="description">
        /// A description of the flag
        /// </param>
        /// <param name="state"></param>
        /// <param name="permanent">
        /// Whether this flag is marked as permanent, indicating it should not be removed
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateFlagResponse> CreateFlagAsync(
            string projectIdOrName,
            string requestSlug,
            global::Vercel.CreateFlagRequestKind kind,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateFlagRequestEnvironments2> environments,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestVariant>? variants = default,
            double? seed = default,
            string? description = default,
            global::Vercel.CreateFlagRequestState? state = default,
            bool? permanent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}