#nullable enable

namespace Vercel
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Delete an authentication token<br/>
        /// Invalidate an authentication token, such that it will no longer be valid for future HTTP requests.
        /// </summary>
        /// <param name="tokenId">
        /// The identifier of the token to invalidate. The special value \"current\" may be supplied, which invalidates the token that the HTTP request was authenticated with.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.DeleteAuthTokenResponse> DeleteAuthTokenAsync(
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}