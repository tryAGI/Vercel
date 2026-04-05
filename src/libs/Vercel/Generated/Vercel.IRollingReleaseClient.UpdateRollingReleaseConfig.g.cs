#nullable enable

namespace Vercel
{
    public partial interface IRollingReleaseClient
    {
        /// <summary>
        /// Update the rolling release settings for the project<br/>
        /// Update (or disable) Rolling Releases for a project. When disabling with the resolve-on-disable feature flag enabled, any active rolling release document is resolved using the disableRolloutAction parameter: "abort" to roll back (default), or "complete" to promote the canary to production. When enabling or updating config, changes only affect the next production deployment and do not alter a rollout that's already in-flight. Note: Enabling Rolling Releases automatically enables skew protection on the project with the default value if it wasn't configured already.
        /// </summary>
        /// <param name="idOrName">
        /// Project ID or project name (URL-encoded)
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>> UpdateRollingReleaseConfigAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}