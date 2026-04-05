
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The dispute details, if any.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentDispute
    {
        /// <summary>
        /// The unique ID of the dispute entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The disputed amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// When the dispute was first recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The dispute currency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// The external provider dispute ID (e.g. Stripe dispute ID).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// The dispute reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The dispute status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// When the dispute was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentDispute" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the dispute entity.
        /// </param>
        /// <param name="amount">
        /// The disputed amount.
        /// </param>
        /// <param name="createdAt">
        /// When the dispute was first recorded.
        /// </param>
        /// <param name="currency">
        /// The dispute currency.
        /// </param>
        /// <param name="providerId">
        /// The external provider dispute ID (e.g. Stripe dispute ID).
        /// </param>
        /// <param name="status">
        /// The dispute status.
        /// </param>
        /// <param name="updatedAt">
        /// When the dispute was last updated.
        /// </param>
        /// <param name="reason">
        /// The dispute reason.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentDispute(
            string id,
            string amount,
            string createdAt,
            string currency,
            string providerId,
            string status,
            string updatedAt,
            string? reason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Reason = reason;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentDispute" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentDispute()
        {
        }
    }
}