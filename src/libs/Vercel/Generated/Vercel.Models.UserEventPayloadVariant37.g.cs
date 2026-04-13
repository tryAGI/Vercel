
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant37
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethodId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PaymentMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        public string? Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant37" /> class.
        /// </summary>
        /// <param name="paymentMethodId"></param>
        /// <param name="brand"></param>
        /// <param name="last4"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant37(
            string paymentMethodId,
            string? brand,
            string? last4)
        {
            this.PaymentMethodId = paymentMethodId ?? throw new global::System.ArgumentNullException(nameof(paymentMethodId));
            this.Brand = brand;
            this.Last4 = last4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant37" /> class.
        /// </summary>
        public UserEventPayloadVariant37()
        {
        }
    }
}