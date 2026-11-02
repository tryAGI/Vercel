#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// List flags project connections<br/>
        /// Lists the flags project connections of a project. By default these are the projects that may read this project's flags; with `role=consumer` these are the projects whose flags this project may read. Connections are within one team and apply across environments. Requires permission to list connections on the selected project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="role">
        /// List connections where this project is the source (default) or the consumer
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.GetFlagsProjectConnectionsResponseVariant2>> GetFlagsProjectConnectionsAsync(
            string projectIdOrName,
            global::Vercel.GetFlagsProjectConnectionsRole? role = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List flags project connections<br/>
        /// Lists the flags project connections of a project. By default these are the projects that may read this project's flags; with `role=consumer` these are the projects whose flags this project may read. Connections are within one team and apply across environments. Requires permission to list connections on the selected project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="role">
        /// List connections where this project is the source (default) or the consumer
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OneOf<object, global::Vercel.GetFlagsProjectConnectionsResponseVariant2>>> GetFlagsProjectConnectionsAsResponseAsync(
            string projectIdOrName,
            global::Vercel.GetFlagsProjectConnectionsRole? role = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}