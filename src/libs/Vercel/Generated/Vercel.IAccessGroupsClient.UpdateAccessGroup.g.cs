#nullable enable

namespace Vercel
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// Update an access group<br/>
        /// Allows to update an access group metadata
        /// </summary>
        /// <param name="idOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateAccessGroupResponse> UpdateAccessGroupAsync(
            string idOrName,

            global::Vercel.UpdateAccessGroupRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an access group<br/>
        /// Allows to update an access group metadata
        /// </summary>
        /// <param name="idOrName"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// The name of the access group<br/>
        /// Example: My access group
        /// </param>
        /// <param name="projects"></param>
        /// <param name="membersToAdd">
        /// List of members to add to the access group.<br/>
        /// Example: [usr_1a2b3c4d5e6f7g8h9i0j, usr_2b3c4d5e6f7g8h9i0j1k]
        /// </param>
        /// <param name="membersToRemove">
        /// List of members to remove from the access group.<br/>
        /// Example: [usr_1a2b3c4d5e6f7g8h9i0j, usr_2b3c4d5e6f7g8h9i0j1k]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateAccessGroupResponse> UpdateAccessGroupAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateAccessGroupRequestProject>? projects = default,
            global::System.Collections.Generic.IList<string>? membersToAdd = default,
            global::System.Collections.Generic.IList<string>? membersToRemove = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}