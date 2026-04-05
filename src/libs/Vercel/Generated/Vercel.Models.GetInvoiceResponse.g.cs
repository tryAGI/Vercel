
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInvoiceResponse
    {
        /// <summary>
        /// Whether the invoice is in the testmode (no real transaction created).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Vercel Marketplace Invoice ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceId { get; set; }

        /// <summary>
        /// Partner-supplied Invoice ID, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Invoice state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetInvoiceResponseStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetInvoiceResponseState State { get; set; }

        /// <summary>
        /// User-readable invoice number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceNumber")]
        public string? InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice date. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceDate { get; set; }

        /// <summary>
        /// Subscription period for this billing cycle. ISO 8601 timestamps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetInvoiceResponsePeriod Period { get; set; }

        /// <summary>
        /// Moment the invoice was paid. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidAt")]
        public string? PaidAt { get; set; }

        /// <summary>
        /// Most recent moment the invoice was refunded. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refundedAt")]
        public string? RefundedAt { get; set; }

        /// <summary>
        /// Additional memo for the invoice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// Invoice items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetInvoiceResponseItem> Items { get; set; }

        /// <summary>
        /// Invoice discounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discounts")]
        public global::System.Collections.Generic.IList<global::Vercel.GetInvoiceResponseDiscount>? Discounts { get; set; }

        /// <summary>
        /// Invoice total amount. A dollar-based decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Total { get; set; }

        /// <summary>
        /// The reason for refund. Only applicable for states "refunded" or "refund_request".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refundReason")]
        public string? RefundReason { get; set; }

        /// <summary>
        /// Refund amount. Only applicable for states "refunded" or "refund_request". A dollar-based decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refundTotal")]
        public string? RefundTotal { get; set; }

        /// <summary>
        /// System creation date. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Created { get; set; }

        /// <summary>
        /// System update date. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse" /> class.
        /// </summary>
        /// <param name="invoiceId">
        /// Vercel Marketplace Invoice ID.
        /// </param>
        /// <param name="state">
        /// Invoice state.
        /// </param>
        /// <param name="invoiceDate">
        /// Invoice date. ISO 8601 timestamp.
        /// </param>
        /// <param name="period">
        /// Subscription period for this billing cycle. ISO 8601 timestamps.
        /// </param>
        /// <param name="items">
        /// Invoice items.
        /// </param>
        /// <param name="total">
        /// Invoice total amount. A dollar-based decimal string.
        /// </param>
        /// <param name="created">
        /// System creation date. ISO 8601 timestamp.
        /// </param>
        /// <param name="updated">
        /// System update date. ISO 8601 timestamp.
        /// </param>
        /// <param name="test">
        /// Whether the invoice is in the testmode (no real transaction created).
        /// </param>
        /// <param name="externalId">
        /// Partner-supplied Invoice ID, if applicable.
        /// </param>
        /// <param name="invoiceNumber">
        /// User-readable invoice number.
        /// </param>
        /// <param name="paidAt">
        /// Moment the invoice was paid. ISO 8601 timestamp.
        /// </param>
        /// <param name="refundedAt">
        /// Most recent moment the invoice was refunded. ISO 8601 timestamp.
        /// </param>
        /// <param name="memo">
        /// Additional memo for the invoice.
        /// </param>
        /// <param name="discounts">
        /// Invoice discounts.
        /// </param>
        /// <param name="refundReason">
        /// The reason for refund. Only applicable for states "refunded" or "refund_request".
        /// </param>
        /// <param name="refundTotal">
        /// Refund amount. Only applicable for states "refunded" or "refund_request". A dollar-based decimal string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInvoiceResponse(
            string invoiceId,
            global::Vercel.GetInvoiceResponseState state,
            string invoiceDate,
            global::Vercel.GetInvoiceResponsePeriod period,
            global::System.Collections.Generic.IList<global::Vercel.GetInvoiceResponseItem> items,
            string total,
            string created,
            string updated,
            bool? test,
            string? externalId,
            string? invoiceNumber,
            string? paidAt,
            string? refundedAt,
            string? memo,
            global::System.Collections.Generic.IList<global::Vercel.GetInvoiceResponseDiscount>? discounts,
            string? refundReason,
            string? refundTotal)
        {
            this.Test = test;
            this.InvoiceId = invoiceId ?? throw new global::System.ArgumentNullException(nameof(invoiceId));
            this.ExternalId = externalId;
            this.State = state;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceDate = invoiceDate ?? throw new global::System.ArgumentNullException(nameof(invoiceDate));
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.PaidAt = paidAt;
            this.RefundedAt = refundedAt;
            this.Memo = memo;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Discounts = discounts;
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.RefundReason = refundReason;
            this.RefundTotal = refundTotal;
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Updated = updated ?? throw new global::System.ArgumentNullException(nameof(updated));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse" /> class.
        /// </summary>
        public GetInvoiceResponse()
        {
        }
    }
}