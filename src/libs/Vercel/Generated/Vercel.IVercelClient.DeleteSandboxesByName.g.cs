#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">
        /// The sandbox name to delete.<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="projectId">
        /// The project ID that owns the named sandbox. When provided, takes precedence over OIDC project context.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteSandboxesByNameResponse> DeleteSandboxesByNameAsync(
            string name,
            string? projectId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">
        /// The sandbox name to delete.<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="projectId">
        /// The project ID that owns the named sandbox. When provided, takes precedence over OIDC project context.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.DeleteSandboxesByNameResponse>> DeleteSandboxesByNameAsResponseAsync(
            string name,
            string? projectId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}