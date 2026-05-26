#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list named sandboxes for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of named sandboxes to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by.<br/>
        /// Default Value: createdAt
        /// </param>
        /// <param name="namePrefix">
        /// Filter named sandboxes whose name starts with this prefix. Only valid when sortBy=name.
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to desc.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="tags">
        /// Filter sandboxes by tag. Format: \"key:value\". Only one tag filter is supported at a time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetSandboxesResponse> GetSandboxesAsync(
            string? project = default,
            double? limit = default,
            global::Vercel.GetSandboxesSortBy? sortBy = default,
            string? namePrefix = default,
            string? cursor = default,
            global::Vercel.GetSandboxesSortOrder? sortOrder = default,
            global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project">
        /// The unique identifier or name of the project to list named sandboxes for.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of named sandboxes to return in the response. Used for pagination.<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by.<br/>
        /// Default Value: createdAt
        /// </param>
        /// <param name="namePrefix">
        /// Filter named sandboxes whose name starts with this prefix. Only valid when sortBy=name.
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Defaults to desc.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="tags">
        /// Filter sandboxes by tag. Format: \"key:value\". Only one tag filter is supported at a time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetSandboxesResponse>> GetSandboxesAsResponseAsync(
            string? project = default,
            double? limit = default,
            global::Vercel.GetSandboxesSortBy? sortBy = default,
            string? namePrefix = default,
            string? cursor = default,
            global::Vercel.GetSandboxesSortOrder? sortOrder = default,
            global::Vercel.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}