#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list snapshots for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="name">
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="limit">
        /// Maximum number of snapshots to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for results by creation time.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.GetSandboxesSnapshotsResponseVariant2>> GetSandboxesSnapshotsAsync(
            string? project = default,
            string? name = default,
            double? limit = default,
            string? cursor = default,
            global::Vercel.GetSandboxesSnapshotsSortOrder? sortOrder = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list snapshots for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="name">
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="limit">
        /// Maximum number of snapshots to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for results by creation time.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<object, global::Vercel.GetSandboxesSnapshotsResponseVariant2>>> GetSandboxesSnapshotsAsResponseAsync(
            string? project = default,
            string? name = default,
            double? limit = default,
            string? cursor = default,
            global::Vercel.GetSandboxesSnapshotsSortOrder? sortOrder = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}