#nullable enable

namespace Vercel
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List integration billing plans<br/>
        /// Get a list of billing plans for an integration and product.
        /// </summary>
        /// <param name="integrationIdOrSlug"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="productIdOrSlug"></param>
        /// <param name="metadata"></param>
        /// <param name="source"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetBillingPlansResponse> GetBillingPlansAsync(
            string integrationIdOrSlug,
            string productIdOrSlug,
            string? integrationConfigurationId = default,
            string? metadata = default,
            global::Vercel.GetBillingPlansSource? source = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}