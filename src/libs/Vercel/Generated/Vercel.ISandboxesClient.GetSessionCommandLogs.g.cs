#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Stream command logs<br/>
        /// Streams the output of a command in real-time using newline-delimited JSON (ND-JSON). Each entry includes the output data and stream type. Stream types include `stdout`, `stderr`, and `error` (for stream failures). Send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the raw output bytes as a CBOR Sequence (RFC 8742) instead. Each item is a two-element array `[TYPE, PAYLOAD]`, where `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, or `3` for a stream failure with a `{ code, message }` map.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to stream logs for.<br/>
        /// Example: cmd_abc123
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
        global::System.Threading.Tasks.Task<byte[]> GetSessionCommandLogsAsync(
            string sessionId,
            string cmdId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream command logs<br/>
        /// Streams the output of a command in real-time using newline-delimited JSON (ND-JSON). Each entry includes the output data and stream type. Stream types include `stdout`, `stderr`, and `error` (for stream failures). Send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the raw output bytes as a CBOR Sequence (RFC 8742) instead. Each item is a two-element array `[TYPE, PAYLOAD]`, where `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, or `3` for a stream failure with a `{ code, message }` map.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to stream logs for.<br/>
        /// Example: cmd_abc123
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
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetSessionCommandLogsAsStreamAsync(
            string sessionId,
            string cmdId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream command logs<br/>
        /// Streams the output of a command in real-time using newline-delimited JSON (ND-JSON). Each entry includes the output data and stream type. Stream types include `stdout`, `stderr`, and `error` (for stream failures). Send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the raw output bytes as a CBOR Sequence (RFC 8742) instead. Each item is a two-element array `[TYPE, PAYLOAD]`, where `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, or `3` for a stream failure with a `{ code, message }` map.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to stream logs for.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::System.IO.Stream>> GetSessionCommandLogsAsStreamAsResponseAsync(
            string sessionId,
            string cmdId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream command logs<br/>
        /// Streams the output of a command in real-time using newline-delimited JSON (ND-JSON). Each entry includes the output data and stream type. Stream types include `stdout`, `stderr`, and `error` (for stream failures). Send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the raw output bytes as a CBOR Sequence (RFC 8742) instead. Each item is a two-element array `[TYPE, PAYLOAD]`, where `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, or `3` for a stream failure with a `{ code, message }` map.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to stream logs for.<br/>
        /// Example: cmd_abc123
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<byte[]>> GetSessionCommandLogsAsResponseAsync(
            string sessionId,
            string cmdId,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}