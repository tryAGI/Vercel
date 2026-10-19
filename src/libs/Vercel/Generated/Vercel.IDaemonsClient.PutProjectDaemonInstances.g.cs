#nullable enable

namespace Vercel
{
    public partial interface IDaemonsClient
    {
        /// <summary>
        /// Override a project daemon's instance counts<br/>
        /// Override an existing daemon's instance counts by region. Each region in the map replaces the configured count for that region. Regions not in the map keep their configured count. An empty map removes the overrides. The daemon configuration is not changed. Missing or deleted daemons return 404. Repeating the same overrides succeeds without a storage write or reconciliation event.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="daemonName">
        /// The name of the daemon to scale
        /// </param>
        /// <param name="target">
        /// The deployment target for the daemon configuration.<br/>
        /// Default Value: production
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
        global::System.Threading.Tasks.Task<global::Vercel.PutProjectDaemonInstancesResponse> PutProjectDaemonInstancesAsync(
            string idOrName,
            string daemonName,

            global::System.Collections.Generic.Dictionary<string, int> request,
            global::Vercel.PutProjectDaemonInstancesTarget? target = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Override a project daemon's instance counts<br/>
        /// Override an existing daemon's instance counts by region. Each region in the map replaces the configured count for that region. Regions not in the map keep their configured count. An empty map removes the overrides. The daemon configuration is not changed. Missing or deleted daemons return 404. Repeating the same overrides succeeds without a storage write or reconciliation event.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="daemonName">
        /// The name of the daemon to scale
        /// </param>
        /// <param name="target">
        /// The deployment target for the daemon configuration.<br/>
        /// Default Value: production
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.PutProjectDaemonInstancesResponse>> PutProjectDaemonInstancesAsResponseAsync(
            string idOrName,
            string daemonName,

            global::System.Collections.Generic.Dictionary<string, int> request,
            global::Vercel.PutProjectDaemonInstancesTarget? target = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Override a project daemon's instance counts<br/>
        /// Override an existing daemon's instance counts by region. Each region in the map replaces the configured count for that region. Regions not in the map keep their configured count. An empty map removes the overrides. The daemon configuration is not changed. Missing or deleted daemons return 404. Repeating the same overrides succeeds without a storage write or reconciliation event.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="daemonName">
        /// The name of the daemon to scale
        /// </param>
        /// <param name="target">
        /// The deployment target for the daemon configuration.<br/>
        /// Default Value: production
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.PutProjectDaemonInstancesResponse> PutProjectDaemonInstancesAsync(
            string idOrName,
            string daemonName,
            global::Vercel.PutProjectDaemonInstancesTarget? target = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}