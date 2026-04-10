#nullable enable

namespace Vercel
{
    public partial interface IDomainsRegistrarClient
    {
        /// <summary>
        /// Get TLD<br/>
        /// Get the metadata for a specific TLD.
        /// </summary>
        /// <param name="tld">
        /// A valid TLD name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetTldResponse> GetTldAsync(
            string tld,
            string? teamId = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}