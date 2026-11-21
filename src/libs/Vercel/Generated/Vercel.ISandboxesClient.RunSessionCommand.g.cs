#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion. When `wait` is true, send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the stream as a CBOR Sequence (RFC 8742) instead of ND-JSON. Each item is a two-element array `[TYPE, PAYLOAD]`. `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, `3` for a stream failure with a `{ code, message }` map, or `128` for the `SessionCommand` as a map, sent when the command starts and again when it finishes.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session in which to execute the command.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.RunSessionCommandResponse> RunSessionCommandAsync(
            string sessionId,

            global::Vercel.RunSessionCommandRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion. When `wait` is true, send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the stream as a CBOR Sequence (RFC 8742) instead of ND-JSON. Each item is a two-element array `[TYPE, PAYLOAD]`. `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, `3` for a stream failure with a `{ code, message }` map, or `128` for the `SessionCommand` as a map, sent when the command starts and again when it finishes.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session in which to execute the command.<br/>
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.RunSessionCommandResponse>> RunSessionCommandAsResponseAsync(
            string sessionId,

            global::Vercel.RunSessionCommandRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion. When `wait` is true, send `Accept: application/vnd.vercel.sandbox.command-stream+cbor-seq` to receive the stream as a CBOR Sequence (RFC 8742) instead of ND-JSON. Each item is a two-element array `[TYPE, PAYLOAD]`. `TYPE` is `1` for stdout or `2` for stderr with the raw output as a byte string, `3` for a stream failure with a `{ code, message }` map, or `128` for the `SessionCommand` as a map, sent when the command starts and again when it finishes.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the session in which to execute the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="command">
        /// The executable or shell command to run. This is the program name without arguments.<br/>
        /// Example: npm
        /// </param>
        /// <param name="args">
        /// Arguments to pass to the command. Each argument should be a separate array element.<br/>
        /// Example: [install, --save, lodash]
        /// </param>
        /// <param name="cwd">
        /// The working directory in which to execute the command. Defaults to the sandbox home directory if not specified.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="env">
        /// Additional environment variables to set for this command. These are merged with the sandbox environment.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","DEBUG":"true"}
        /// </param>
        /// <param name="sudo">
        /// Execute the command with root (superuser) privileges.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="wait">
        /// If true, returns an ND-JSON stream that emits the command status when started and again when finished. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="logs">
        /// If true, stream the logs of the command execution in real-time via ND-JSON. This is only applicable if `wait` is also true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Maximum duration in milliseconds the command may run before it is killed with SIGKILL, up to 5 hours. Enforced at exec time, independently of `wait`.<br/>
        /// Example: 30000
        /// </param>
        /// <param name="attachStdin">
        /// If true, keeps the command stdin open so it can be written to with the stdin endpoint while the command runs. When false, the command reads from an empty stdin.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RunSessionCommandResponse> RunSessionCommandAsync(
            string sessionId,
            string command,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? args = default,
            string? cwd = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            bool? sudo = default,
            bool? wait = default,
            bool? logs = default,
            int? timeout = default,
            bool? attachStdin = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}