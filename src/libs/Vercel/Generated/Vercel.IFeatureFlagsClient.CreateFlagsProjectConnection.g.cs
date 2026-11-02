#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Connect a project to the flags of this project<br/>
        /// Connects a project in the same team to the flags of this project. The consumer project reads this project's flags with its own deployment identity by naming this project in the Flags SDK. Connections grant read and evaluate access across environments, with the consumer deployment's environment selecting the source environment. Requires connection management permission on the source project and read access to the consumer project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateFlagsProjectConnectionResponse> CreateFlagsProjectConnectionAsync(
            string projectIdOrName,

            global::Vercel.CreateFlagsProjectConnectionRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect a project to the flags of this project<br/>
        /// Connects a project in the same team to the flags of this project. The consumer project reads this project's flags with its own deployment identity by naming this project in the Flags SDK. Connections grant read and evaluate access across environments, with the consumer deployment's environment selecting the source environment. Requires connection management permission on the source project and read access to the consumer project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateFlagsProjectConnectionResponse>> CreateFlagsProjectConnectionAsResponseAsync(
            string projectIdOrName,

            global::Vercel.CreateFlagsProjectConnectionRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect a project to the flags of this project<br/>
        /// Connects a project in the same team to the flags of this project. The consumer project reads this project's flags with its own deployment identity by naming this project in the Flags SDK. Connections grant read and evaluate access across environments, with the consumer deployment's environment selecting the source environment. Requires connection management permission on the source project and read access to the consumer project.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="consumerProjectId">
        /// The project in the same team that may read the flags of this project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateFlagsProjectConnectionResponse> CreateFlagsProjectConnectionAsync(
            string projectIdOrName,
            string consumerProjectId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}