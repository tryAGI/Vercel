
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant35
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
        [global::System.Text.Json.Serialization.JsonPropertyName("newInvoiceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewInvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settlementMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant35SettlementMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant35SettlementMethod SettlementMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant35" /> class.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="newInvoiceId"></param>
        /// <param name="settlementMethod"></param>
        /// <param name="amount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant35(
            string invoiceId,
            string newInvoiceId,
            global::Vercel.UserEventPayloadVariant35SettlementMethod settlementMethod,
            double amount)
        {
            this.InvoiceId = invoiceId ?? throw new global::System.ArgumentNullException(nameof(invoiceId));
            this.NewInvoiceId = newInvoiceId ?? throw new global::System.ArgumentNullException(nameof(newInvoiceId));
            this.SettlementMethod = settlementMethod;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant35" /> class.
        /// </summary>
        public UserEventPayloadVariant35()
        {
        }
    }
}