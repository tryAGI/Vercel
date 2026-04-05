#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Get Invoice<br/>
        /// Get Invoice details and status for a given invoice ID.&lt;br/&gt; &lt;br/&gt; See [Billing Events with Webhooks documentation](https://vercel.com/docs/integrations/create-integration/marketplace-api#working-with-billing-events-through-webhooks) on how to receive invoice events. This endpoint is used to retrieve the invoice details.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="invoiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetInvoiceResponse> GetInvoiceAsync(
            string integrationConfigurationId,
            string invoiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}