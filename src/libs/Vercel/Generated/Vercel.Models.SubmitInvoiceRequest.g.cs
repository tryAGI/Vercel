
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitInvoiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Invoice date. Must be within the period's start and end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Additional memo for the invoice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// Subscription period for this billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SubmitInvoiceRequestPeriod Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discounts")]
        public global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestDiscount>? Discounts { get; set; }

        /// <summary>
        /// Set this to `true` if this is the final invoice for the installation. Can only be set when the installation is pending deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final")]
        public bool? Final { get; set; }

        /// <summary>
        /// Test mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public global::Vercel.SubmitInvoiceRequestTest? Test { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceRequest" /> class.
        /// </summary>
        /// <param name="invoiceDate">
        /// Invoice date. Must be within the period's start and end.
        /// </param>
        /// <param name="period">
        /// Subscription period for this billing cycle.
        /// </param>
        /// <param name="items"></param>
        /// <param name="externalId"></param>
        /// <param name="memo">
        /// Additional memo for the invoice.
        /// </param>
        /// <param name="discounts"></param>
        /// <param name="final">
        /// Set this to `true` if this is the final invoice for the installation. Can only be set when the installation is pending deletion.
        /// </param>
        /// <param name="test">
        /// Test mode
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitInvoiceRequest(
            global::System.DateTime invoiceDate,
            global::Vercel.SubmitInvoiceRequestPeriod period,
            global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestItem> items,
            string? externalId,
            string? memo,
            global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestDiscount>? discounts,
            bool? final,
            global::Vercel.SubmitInvoiceRequestTest? test)
        {
            this.ExternalId = externalId;
            this.InvoiceDate = invoiceDate;
            this.Memo = memo;
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Discounts = discounts;
            this.Final = final;
            this.Test = test;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceRequest" /> class.
        /// </summary>
        public SubmitInvoiceRequest()
        {
        }
    }
}