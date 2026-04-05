#nullable enable

namespace Vercel
{
    public partial interface ISandboxesV2BetaClient
    {
        /// <summary>
        /// Stream command logs<br/>
        /// Streams the output of a command in real-time using newline-delimited JSON (ND-JSON). Each entry includes the output data and stream type. Stream types include `stdout`, `stderr`, and `error` (for stream failures).
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vercel.OneOf<global::Vercel.GetSessionCommandLogsResponseVariant1, global::Vercel.GetSessionCommandLogsResponseVariant2>> GetSessionCommandLogsAsync(
            string sessionId,
            string cmdId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}