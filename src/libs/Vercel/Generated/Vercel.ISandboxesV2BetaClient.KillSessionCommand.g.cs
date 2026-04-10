#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Kill a command<br/>
        /// Sends a signal to terminate a running command in a session. The signal can be used to gracefully stop (SIGTERM) or forcefully kill (SIGKILL) the process. The command must still be running for this operation to succeed.
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to terminate.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
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
        global::System.Threading.Tasks.Task<global::Vercel.KillSessionCommandResponse> KillSessionCommandAsync(
            string cmdId,
            string sessionId,

            global::Vercel.KillSessionCommandRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Kill a command<br/>
        /// Sends a signal to terminate a running command in a session. The signal can be used to gracefully stop (SIGTERM) or forcefully kill (SIGKILL) the process. The command must still be running for this operation to succeed.
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to terminate.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="signal">
        /// The POSIX signal number to send to the process. Common values: 15 (SIGTERM) for graceful termination, 9 (SIGKILL) for forced termination.<br/>
        /// Example: 15
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.KillSessionCommandResponse> KillSessionCommandAsync(
            string cmdId,
            string sessionId,
            double signal,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}