#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Delete a microfrontends group<br/>
        /// Deletes a microfrontends group from the team associated with the group ID.
        /// </summary>
        /// <param name="groupId">
        /// The microfrontend group ID to delete.<br/>
        /// Example: mfe_
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteMicrofrontendsGroupAsync(
            string groupId,
            string teamId,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}