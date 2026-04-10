#nullable enable

namespace Vercel
{
    public partial interface IEnvironmentClient
    {
        /// <summary>
        /// Retrieve a custom environment<br/>
        /// Retrieve a custom environment for the project. Must not be named 'Production' or 'Preview'.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="environmentSlugOrId">
        /// The unique custom environment identifier within the project
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
        global::System.Threading.Tasks.Task<global::Vercel.GetCustomEnvironmentResponse> GetCustomEnvironmentAsync(
            string idOrName,
            string environmentSlugOrId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}