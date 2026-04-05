
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The prices to replace in the subscription
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice
    {
        /// <summary>
        /// The quantity for the fixed price
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixedPriceQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FixedPriceQuantity { get; set; }

        /// <summary>
        /// The ID of the price to replace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacesPriceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplacesPriceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice" /> class.
        /// </summary>
        /// <param name="fixedPriceQuantity">
        /// The quantity for the fixed price
        /// </param>
        /// <param name="replacesPriceId">
        /// The ID of the price to replace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice(
            double fixedPriceQuantity,
            string replacesPriceId)
        {
            this.FixedPriceQuantity = fixedPriceQuantity;
            this.ReplacesPriceId = replacesPriceId ?? throw new global::System.ArgumentNullException(nameof(replacesPriceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice()
        {
        }
    }
}