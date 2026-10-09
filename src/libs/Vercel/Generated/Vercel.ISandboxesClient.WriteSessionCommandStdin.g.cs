#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Write to command stdin<br/>
        /// Writes data to the stdin of a running command, and optionally closes it. The command must have been started with `attachStdin` set to true. Writes are applied in the order they are received. Send them one at a time to keep the data in order. A write returns once the command has accepted the data, and fails with a 504 after 30 seconds if the command is not reading stdin. Each write counts against the sandbox control plane rate limit, so batch small writes where possible. Set `offset` to the position in stdin where `data` starts to make a request safe to resend, for example after a 502 or 504: bytes the command has already received are skipped, and an offset past them fails with a 409. The response returns `bytesWritten`, the total written so far, and a 504 includes it in the error when the sandbox reports it. A request with no `data` and no `close` writes nothing and returns it. If a request with an `offset` gets a response without `bytesWritten`, the sandbox predates offsets and ignored it, so resending that request is not safe.
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to write to.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.WriteSessionCommandStdinResponse> WriteSessionCommandStdinAsync(
            string cmdId,
            string sessionId,

            global::Vercel.WriteSessionCommandStdinRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Write to command stdin<br/>
        /// Writes data to the stdin of a running command, and optionally closes it. The command must have been started with `attachStdin` set to true. Writes are applied in the order they are received. Send them one at a time to keep the data in order. A write returns once the command has accepted the data, and fails with a 504 after 30 seconds if the command is not reading stdin. Each write counts against the sandbox control plane rate limit, so batch small writes where possible. Set `offset` to the position in stdin where `data` starts to make a request safe to resend, for example after a 502 or 504: bytes the command has already received are skipped, and an offset past them fails with a 409. The response returns `bytesWritten`, the total written so far, and a 504 includes it in the error when the sandbox reports it. A request with no `data` and no `close` writes nothing and returns it. If a request with an `offset` gets a response without `bytesWritten`, the sandbox predates offsets and ignored it, so resending that request is not safe.
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to write to.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.WriteSessionCommandStdinResponse>> WriteSessionCommandStdinAsResponseAsync(
            string cmdId,
            string sessionId,

            global::Vercel.WriteSessionCommandStdinRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Write to command stdin<br/>
        /// Writes data to the stdin of a running command, and optionally closes it. The command must have been started with `attachStdin` set to true. Writes are applied in the order they are received. Send them one at a time to keep the data in order. A write returns once the command has accepted the data, and fails with a 504 after 30 seconds if the command is not reading stdin. Each write counts against the sandbox control plane rate limit, so batch small writes where possible. Set `offset` to the position in stdin where `data` starts to make a request safe to resend, for example after a 502 or 504: bytes the command has already received are skipped, and an offset past them fails with a 409. The response returns `bytesWritten`, the total written so far, and a 504 includes it in the error when the sandbox reports it. A request with no `data` and no `close` writes nothing and returns it. If a request with an `offset` gets a response without `bytesWritten`, the sandbox predates offsets and ignored it, so resending that request is not safe.
        /// </summary>
        /// <param name="cmdId">
        /// The unique identifier of the command to write to.<br/>
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
        /// <param name="data">
        /// Base64-encoded bytes to write to the command stdin. The request body is limited to 1 MB, so send at most about 700 KB of data per request.<br/>
        /// Example: aGVsbG8K
        /// </param>
        /// <param name="offset">
        /// The position in the command stdin where `data` starts. Bytes before the total already written are skipped, so a resent request does not write them twice. Fails with 409 if it is past the bytes written so far. Without it, `data` is appended.<br/>
        /// Example: 0
        /// </param>
        /// <param name="close">
        /// If true, closes the command stdin after writing `data`. Use this for commands that wait for end of input.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.WriteSessionCommandStdinResponse> WriteSessionCommandStdinAsync(
            string cmdId,
            string sessionId,
            string? teamId = default,
            string? slug = default,
            string? data = default,
            int? offset = default,
            bool? close = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}