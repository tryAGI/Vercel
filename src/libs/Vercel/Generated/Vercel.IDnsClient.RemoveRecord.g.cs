#nullable enable

namespace Vercel
{
    public partial interface IDnsClient
    {
        /// <summary>
        /// Delete a DNS record<br/>
        /// Removes an existing DNS record from a domain name.
        /// </summary>
        /// <param name="domain">
        /// Example: example.com
        /// </param>
        /// <param name="recordId">
        /// Example: rec_V0fra8eEgQwEpFhYG2vTzC3K
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveRecordAsync(
            string domain,
            string recordId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}