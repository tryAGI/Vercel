#nullable enable

namespace Vercel
{
    public partial interface IProjectMembersClient
    {
        /// <summary>
        /// List project members<br/>
        /// Lists all members of a project.
        /// </summary>
        /// <param name="idOrName">
        /// The ID or name of the Project.<br/>
        /// Example: prj_pavWOn1iLObbXLRiwVvzmPrTWyTf
        /// </param>
        /// <param name="limit">
        /// Limit how many project members should be returned<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Timestamp in milliseconds to only include members added since then.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="until">
        /// Timestamp in milliseconds to only include members added until then.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="search">
        /// Search project members by their name, username, and email.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.GetProjectMembersResponseVariant2>> GetProjectMembersAsync(
            string idOrName,
            int? limit = default,
            int? since = default,
            int? until = default,
            string? search = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}