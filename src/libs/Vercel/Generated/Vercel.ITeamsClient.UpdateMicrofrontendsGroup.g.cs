#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a microfrontends group<br/>
        /// Updates the name (and slug) of a microfrontends group.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateMicrofrontendsGroupResponse> UpdateMicrofrontendsGroupAsync(
            string groupId,
            string teamId,

            global::Vercel.UpdateMicrofrontendsGroupRequest request,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a microfrontends group<br/>
        /// Updates the name (and slug) of a microfrontends group.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// The new name for the existing microfrontends group.<br/>
        /// Example: MFE Group 1
        /// </param>
        /// <param name="fallbackEnvironment">
        /// The new fallback environment for the microfrontends group. Must be \"SAME_ENV\", \"PRODUCTION\", or a valid custom environment slug from the default app.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateMicrofrontendsGroupResponse> UpdateMicrofrontendsGroupAsync(
            string groupId,
            string teamId,
            string? slug = default,
            string? name = default,
            string? fallbackEnvironment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}