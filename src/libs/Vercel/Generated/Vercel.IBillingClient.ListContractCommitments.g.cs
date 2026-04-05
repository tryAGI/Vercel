#nullable enable

namespace Vercel
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// List FOCUS contract commitments<br/>
        /// Returns commitment allocations per contract period in FOCUS v1.3 JSONL format for a specified Vercel team. The response is streamed as newline-delimited JSON (JSONL). This endpoint is only applicable to Enterprise Vercel customers. An empty response is returned for non-Enterprise (Pro/Flex) customers.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ListContractCommitmentsResponse> ListContractCommitmentsAsync(
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}