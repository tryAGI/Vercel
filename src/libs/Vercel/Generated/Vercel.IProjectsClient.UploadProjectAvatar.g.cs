#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Upload a project avatar<br/>
        /// Upload an image as the avatar of the project identified by `idOrName`. The request body is the raw bytes of a JPG, PNG, or SVG image; the `Content-Type` header must declare which. SVG payloads are sanitized and optimized server-side before storage. The final SHA-1 of the stored bytes becomes the project's `avatar` value.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UploadProjectAvatarResponse> UploadProjectAvatarAsync(
            string idOrName,

            byte[] request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a project avatar<br/>
        /// Upload an image as the avatar of the project identified by `idOrName`. The request body is the raw bytes of a JPG, PNG, or SVG image; the `Content-Type` header must declare which. SVG payloads are sanitized and optimized server-side before storage. The final SHA-1 of the stored bytes becomes the project's `avatar` value.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.UploadProjectAvatarResponse>> UploadProjectAvatarAsResponseAsync(
            string idOrName,

            byte[] request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}