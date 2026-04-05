
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateInvoiceRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateInvoiceRequestActionJsonConverter))]
        public global::Vercel.UpdateInvoiceRequestAction? Action { get; set; }

        /// <summary>
        /// Refund reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The total amount to be refunded. Must be less than or equal to the total amount of the invoice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public string? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoiceRequest2" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="reason">
        /// Refund reason.
        /// </param>
        /// <param name="total">
        /// The total amount to be refunded. Must be less than or equal to the total amount of the invoice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInvoiceRequest2(
            global::Vercel.UpdateInvoiceRequestAction? action,
            string? reason,
            string? total)
        {
            this.Action = action;
            this.Reason = reason;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoiceRequest2" /> class.
        /// </summary>
        public UpdateInvoiceRequest2()
        {
        }
    }
}