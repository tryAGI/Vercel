#nullable enable

namespace Vercel
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// List Auth Tokens<br/>
        /// Retrieve a list of the current User's authentication tokens.
        /// </summary>
        /// <param name="kind">
        /// Filter by token kind. Omit or use `all` to include every kind.
        /// </param>
        /// <param name="status">
        /// Filter by token status. Omit or use `all` to include every status.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.ListAuthTokensResponseVariant1, global::Vercel.ListAuthTokensResponseVariant2>> ListAuthTokensAsync(
            global::Vercel.ListAuthTokensKind? kind = default,
            global::Vercel.ListAuthTokensStatus? status = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Auth Tokens<br/>
        /// Retrieve a list of the current User's authentication tokens.
        /// </summary>
        /// <param name="kind">
        /// Filter by token kind. Omit or use `all` to include every kind.
        /// </param>
        /// <param name="status">
        /// Filter by token status. Omit or use `all` to include every status.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<global::Vercel.ListAuthTokensResponseVariant1, global::Vercel.ListAuthTokensResponseVariant2>>> ListAuthTokensAsResponseAsync(
            global::Vercel.ListAuthTokensKind? kind = default,
            global::Vercel.ListAuthTokensStatus? status = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}