#nullable enable

namespace Vercel
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get the User<br/>
        /// Retrieves information related to the currently authenticated User.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetAuthUserResponse> GetAuthUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}