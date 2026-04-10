#nullable enable

namespace Vercel
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get the User<br/>
        /// Retrieves information related to the currently authenticated User.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetAuthUserResponse> GetAuthUserAsync(
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}