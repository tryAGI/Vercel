#nullable enable

namespace Vercel
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Get Auth Token Metadata<br/>
        /// Retrieve metadata about an authentication token belonging to the currently authenticated User.
        /// </summary>
        /// <param name="tokenId">
        /// The identifier of the token to retrieve. The special value \"current\" may be supplied, which returns the metadata for the token that the current HTTP request is authenticated with.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetAuthTokenResponse> GetAuthTokenAsync(
            string tokenId,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}