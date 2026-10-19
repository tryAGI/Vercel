#nullable enable

namespace Vercel
{
    public partial interface IDaemonsClient
    {
        /// <summary>
        /// Force restart a project daemon instance<br/>
        /// Force restarts the user container of one running daemon instance. The instance's controller stops the current user container and starts a new one from the same configuration, so in-flight requests are interrupted and any state that only lives inside the container is lost. The instance keeps its ID and region. The response returns as soon as the controller accepts the restart, before the new container is running. Only production instances can be restarted. Accepts a Vercel token that can update the project, or a production project OIDC token issued for the same project. No request body or Content-Type header is required.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="daemonName">
        /// The name of the daemon that owns the instance
        /// </param>
        /// <param name="instanceId">
        /// The ID of the daemon instance whose user container is restarted, for example `dmni_01k7d0q5w3x8y9z0a1b2c3d4e5`
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
        global::System.Threading.Tasks.Task<global::Vercel.RestartProjectDaemonInstanceResponse> RestartProjectDaemonInstanceAsync(
            string idOrName,
            string daemonName,
            string instanceId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Force restart a project daemon instance<br/>
        /// Force restarts the user container of one running daemon instance. The instance's controller stops the current user container and starts a new one from the same configuration, so in-flight requests are interrupted and any state that only lives inside the container is lost. The instance keeps its ID and region. The response returns as soon as the controller accepts the restart, before the new container is running. Only production instances can be restarted. Accepts a Vercel token that can update the project, or a production project OIDC token issued for the same project. No request body or Content-Type header is required.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="daemonName">
        /// The name of the daemon that owns the instance
        /// </param>
        /// <param name="instanceId">
        /// The ID of the daemon instance whose user container is restarted, for example `dmni_01k7d0q5w3x8y9z0a1b2c3d4e5`
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.RestartProjectDaemonInstanceResponse>> RestartProjectDaemonInstanceAsResponseAsync(
            string idOrName,
            string daemonName,
            string instanceId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}