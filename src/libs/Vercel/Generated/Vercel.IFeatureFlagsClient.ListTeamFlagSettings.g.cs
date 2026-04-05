#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List team project flag settings<br/>
        /// Retrieve feature flag settings for projects in a team.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of settings to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor to continue from.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.ListTeamFlagSettingsResponseVariant2>> ListTeamFlagSettingsAsync(
            string teamId,
            int? limit = default,
            string? cursor = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}