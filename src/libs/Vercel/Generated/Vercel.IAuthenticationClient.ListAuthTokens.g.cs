#nullable enable

namespace Vercel
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// List Auth Tokens<br/>
        /// Retrieve a list of the current User's authentication tokens.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.ListAuthTokensResponseVariant1, global::Vercel.ListAuthTokensResponseVariant2>> ListAuthTokensAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}