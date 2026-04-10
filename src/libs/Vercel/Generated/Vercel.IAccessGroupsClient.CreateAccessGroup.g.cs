#nullable enable

namespace Vercel
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// Creates an access group<br/>
        /// Allows to create an access group
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAccessGroupResponse> CreateAccessGroupAsync(

            global::Vercel.CreateAccessGroupRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an access group<br/>
        /// Allows to create an access group
        /// </summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAccessGroupResponse> CreateAccessGroupAsync(
            string name,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupRequestProject>? projects = default,
            global::System.Collections.Generic.IList<string>? membersToAdd = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}