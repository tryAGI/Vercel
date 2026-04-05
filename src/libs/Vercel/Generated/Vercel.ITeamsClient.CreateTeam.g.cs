#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Create a Team<br/>
        /// Create a new Team under your account. You need to send a POST request with the desired Team slug, and optionally the Team name.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateTeamResponse> CreateTeamAsync(

            global::Vercel.CreateTeamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Team<br/>
        /// Create a new Team under your account. You need to send a POST request with the desired Team slug, and optionally the Team name.
        /// </summary>
        /// <param name="slug">
        /// The desired slug for the Team<br/>
        /// Example: a-random-team
        /// </param>
        /// <param name="name">
        /// The desired name for the Team. It will be generated from the provided slug if nothing is provided<br/>
        /// Example: A Random Team
        /// </param>
        /// <param name="attribution">
        /// Attribution information for the session or current page
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateTeamResponse> CreateTeamAsync(
            string slug,
            string? name = default,
            global::Vercel.CreateTeamRequestAttribution? attribution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}