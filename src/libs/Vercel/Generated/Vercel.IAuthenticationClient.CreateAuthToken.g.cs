#nullable enable

namespace Vercel
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Create an Auth Token<br/>
        /// Creates and returns a new authentication token for the currently authenticated User. The `bearerToken` property is only provided once, in the response body, so be sure to save it on the client for use with API requests.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAuthTokenResponse> CreateAuthTokenAsync(

            global::Vercel.CreateAuthTokenRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Auth Token<br/>
        /// Creates and returns a new authentication token for the currently authenticated User. The `bearerToken` property is only provided once, in the response body, so be sure to save it on the client for use with API requests.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name"></param>
        /// <param name="expiresAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateAuthTokenResponse> CreateAuthTokenAsync(
            string name,
            string? teamId = default,
            string? slug = default,
            double? expiresAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}