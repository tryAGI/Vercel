#nullable enable

namespace Vercel
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="skipMetadata"></param>
        /// <param name="includeGuides"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetStorageStoresByIdResponse> GetStorageStoresByIdAsync(
            string id,
            bool? skipMetadata = default,
            bool? includeGuides = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="skipMetadata"></param>
        /// <param name="includeGuides"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.GetStorageStoresByIdResponse>> GetStorageStoresByIdAsResponseAsync(
            string id,
            bool? skipMetadata = default,
            bool? includeGuides = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}