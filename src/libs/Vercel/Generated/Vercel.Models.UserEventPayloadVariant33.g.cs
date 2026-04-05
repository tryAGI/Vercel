
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant33
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refundReason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefundReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineItemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LineItemCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant33" /> class.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="amount"></param>
        /// <param name="refundReason"></param>
        /// <param name="lineItemCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant33(
            string invoiceId,
            double amount,
            string refundReason,
            double lineItemCount)
        {
            this.InvoiceId = invoiceId ?? throw new global::System.ArgumentNullException(nameof(invoiceId));
            this.Amount = amount;
            this.RefundReason = refundReason ?? throw new global::System.ArgumentNullException(nameof(refundReason));
            this.LineItemCount = lineItemCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant33" /> class.
        /// </summary>
        public UserEventPayloadVariant33()
        {
        }
    }
}