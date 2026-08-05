#nullable enable

namespace Vercel
{
    public partial interface IVcrClient
    {
        /// <summary>
        /// GET /v2/ Docker Registry v2 version check. Returns a 401 challenge when no credentials are provided, prompting the Docker client to send auth. With valid credentials, returns 200 so the client can proceed.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRootAsync(
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GET /v2/ Docker Registry v2 version check. Returns a 401 challenge when no credentials are provided, prompting the Docker client to send auth. With valid credentials, returns 200 so the client can proceed.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> GetRootAsResponseAsync(
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}