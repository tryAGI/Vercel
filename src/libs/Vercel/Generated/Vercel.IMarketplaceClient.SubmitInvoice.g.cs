#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Submit Invoice<br/>
        /// This endpoint allows the partner to submit an invoice to Vercel. The invoice is created in Vercel's billing system and sent to the customer. Depending on the type of billing plan, the invoice can be sent at a time of signup, at the start of the billing period, or at the end of the billing period.&lt;br/&gt; &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request. &lt;br/&gt; There are several limitations to the invoice submission:&lt;br/&gt; &lt;br/&gt; 1. A resource can only be billed once per the billing period and the billing plan.&lt;br/&gt; 2. The billing plan used to bill the resource must have been active for this resource during the billing period.&lt;br/&gt; 3. The billing plan used must be a subscription plan.&lt;br/&gt; 4. The interim usage data must be sent hourly for all types of subscriptions. See [Send subscription billing and usage data](#send-subscription-billing-and-usage-data) API on how to send interim billing and usage data.&lt;br/&gt;
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SubmitInvoiceResponse> SubmitInvoiceAsync(
            string integrationConfigurationId,

            global::Vercel.SubmitInvoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Invoice<br/>
        /// This endpoint allows the partner to submit an invoice to Vercel. The invoice is created in Vercel's billing system and sent to the customer. Depending on the type of billing plan, the invoice can be sent at a time of signup, at the start of the billing period, or at the end of the billing period.&lt;br/&gt; &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request. &lt;br/&gt; There are several limitations to the invoice submission:&lt;br/&gt; &lt;br/&gt; 1. A resource can only be billed once per the billing period and the billing plan.&lt;br/&gt; 2. The billing plan used to bill the resource must have been active for this resource during the billing period.&lt;br/&gt; 3. The billing plan used must be a subscription plan.&lt;br/&gt; 4. The interim usage data must be sent hourly for all types of subscriptions. See [Send subscription billing and usage data](#send-subscription-billing-and-usage-data) API on how to send interim billing and usage data.&lt;br/&gt;
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="externalId"></param>
        /// <param name="invoiceDate">
        /// Invoice date. Must be within the period's start and end.
        /// </param>
        /// <param name="memo">
        /// Additional memo for the invoice.
        /// </param>
        /// <param name="period">
        /// Subscription period for this billing cycle.
        /// </param>
        /// <param name="items"></param>
        /// <param name="discounts"></param>
        /// <param name="final">
        /// Set this to `true` if this is the final invoice for the installation. Can only be set when the installation is pending deletion.
        /// </param>
        /// <param name="test">
        /// Test mode
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SubmitInvoiceResponse> SubmitInvoiceAsync(
            string integrationConfigurationId,
            global::System.DateTime invoiceDate,
            global::Vercel.SubmitInvoiceRequestPeriod period,
            global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestItem> items,
            string? externalId = default,
            string? memo = default,
            global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestDiscount>? discounts = default,
            bool? final = default,
            global::Vercel.SubmitInvoiceRequestTest? test = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}