#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get a command<br/>
        /// Retrieves the current status and details of a command executed in a sandbox. Use the `wait` parameter to block until the command finishes execution.
        /// </summary>
        /// <param name="sandboxId">
        /// The unique identifier of the sandbox containing the command.<br/>
        /// Example: sbx_abc123
        /// </param>
        /// <param name="cmdId">
        /// The unique identifier of the command to retrieve.<br/>
        /// Example: cmd_abc123
        /// </param>
        /// <param name="wait">
        /// If set to \"true\", the request will block until the command finishes execution. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetCommandResponse> GetCommandAsync(
            string sandboxId,
            string cmdId,
            global::Vercel.GetCommandWait? wait = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}