#nullable enable

namespace Vercel
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Delete User Account<br/>
        /// Initiates the deletion process for the currently authenticated User, by sending a deletion confirmation email. The email contains a link that the user needs to visit in order to proceed with the deletion process.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RequestDeleteResponse> RequestDeleteAsync(

            global::Vercel.RequestDeleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User Account<br/>
        /// Initiates the deletion process for the currently authenticated User, by sending a deletion confirmation email. The email contains a link that the user needs to visit in order to proceed with the deletion process.
        /// </summary>
        /// <param name="reasons">
        /// Optional array of objects that describe the reason why the User account is being deleted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RequestDeleteResponse> RequestDeleteAsync(
            global::System.Collections.Generic.IList<global::Vercel.RequestDeleteRequestReason>? reasons = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}