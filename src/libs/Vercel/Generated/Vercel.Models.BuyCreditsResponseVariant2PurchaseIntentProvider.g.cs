
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentProvider
    {
        /// <summary>
        /// Provider resource id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// The type of the purchase provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType Type { get; set; }

        /// <summary>
        /// The currency conversion rate used by the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currencyConversionRate")]
        public string? CurrencyConversionRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentProvider" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// Provider resource id
        /// </param>
        /// <param name="type">
        /// The type of the purchase provider
        /// </param>
        /// <param name="currencyConversionRate">
        /// The currency conversion rate used by the provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentProvider(
            string resourceId,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProviderType type,
            string? currencyConversionRate)
        {
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.Type = type;
            this.CurrencyConversionRate = currencyConversionRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentProvider" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentProvider()
        {
        }
    }
}