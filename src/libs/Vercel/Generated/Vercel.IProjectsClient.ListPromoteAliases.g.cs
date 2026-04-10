#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets a list of aliases with status for the current promote<br/>
        /// Get a list of aliases related to the last promote request with their mapping status
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Maximum number of aliases to list from a request (max 100).<br/>
        /// Example: 20
        /// </param>
        /// <param name="since">
        /// Get aliases created after this epoch timestamp.<br/>
        /// Example: 1609499532000L
        /// </param>
        /// <param name="until">
        /// Get aliases created before this epoch timestamp.<br/>
        /// Example: 1612264332000L
        /// </param>
        /// <param name="failedOnly">
        /// Filter results down to aliases that failed to map to the requested deployment
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.ListPromoteAliasesResponseVariant2>> ListPromoteAliasesAsync(
            string projectId,
            double? limit = default,
            double? since = default,
            double? until = default,
            bool? failedOnly = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}