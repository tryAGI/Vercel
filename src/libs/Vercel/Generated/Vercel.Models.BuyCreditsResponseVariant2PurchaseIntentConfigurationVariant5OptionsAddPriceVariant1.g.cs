
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The prices to add to the subscription
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1
    {
        /// <summary>
        /// The ID of the price to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PriceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1" /> class.
        /// </summary>
        /// <param name="priceId">
        /// The ID of the price to add
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1(
            string priceId)
        {
            this.PriceId = priceId ?? throw new global::System.ArgumentNullException(nameof(priceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1()
        {
        }
    }
}