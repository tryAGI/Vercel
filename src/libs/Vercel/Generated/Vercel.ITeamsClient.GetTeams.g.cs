#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List all teams<br/>
        /// Get a paginated list of all the Teams the authenticated User is a member of.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of Teams which may be returned.<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Timestamp (in milliseconds) to only include Teams created since then.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="until">
        /// Timestamp (in milliseconds) to only include Teams created until then.<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetTeamsResponse> GetTeamsAsync(
            double? limit = default,
            double? since = default,
            double? until = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}