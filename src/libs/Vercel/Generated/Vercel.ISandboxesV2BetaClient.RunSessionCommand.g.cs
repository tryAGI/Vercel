#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.RunSessionCommandResponse> RunSessionCommandAsync(
            string sessionId,

            global::Vercel.RunSessionCommandRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a command<br/>
        /// Executes a shell command inside a running session. The command runs asynchronously and returns immediately with a command ID that can be used to track its progress and retrieve its output. Optionally, use the `wait` parameter to stream the command status until completion.
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}