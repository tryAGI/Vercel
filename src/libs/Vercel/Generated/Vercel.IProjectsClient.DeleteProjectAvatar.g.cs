#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project avatar<br/>
        /// Remove the avatar of the project identified by `idOrName`. Deletes the chosen avatar field so the next production deploy can run auto-detection again. Does not delete the stored image.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKSharede870b907cc1fb37e> DeleteProjectAvatarAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a project avatar<br/>
        /// Remove the avatar of the project identified by `idOrName`. Deletes the chosen avatar field so the next production deploy can run auto-detection again. Does not delete the stored image.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AutoSDKSharede870b907cc1fb37e>> DeleteProjectAvatarAsResponseAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}