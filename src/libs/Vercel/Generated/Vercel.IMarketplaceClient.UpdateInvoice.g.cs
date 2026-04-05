#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Invoice Actions<br/>
        /// This endpoint allows the partner to request a refund for an invoice to Vercel. The invoice is created using the [Submit Invoice API](#submit-invoice-api).
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="invoiceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateInvoiceAsync(
            string integrationConfigurationId,
            string invoiceId,

            global::Vercel.UpdateInvoiceRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoice Actions<br/>
        /// This endpoint allows the partner to request a refund for an invoice to Vercel. The invoice is created using the [Submit Invoice API](#submit-invoice-api).
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="invoiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateInvoiceAsync(
            string integrationConfigurationId,
            string invoiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}