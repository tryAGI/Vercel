
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The absolute price that replaces the plan item price, after any rate variant
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePrice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModelJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel Model { get; set; }

        /// <summary>
        /// The non-negative per-unit USD amount, with at most two decimal places
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePrice" /> class.
        /// </summary>
        /// <param name="unitAmount">
        /// The non-negative per-unit USD amount, with at most two decimal places
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePrice(
            string unitAmount,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePriceModel model)
        {
            this.Model = model;
            this.UnitAmount = unitAmount ?? throw new global::System.ArgumentNullException(nameof(unitAmount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePrice" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemPricePrice()
        {
        }

    }
}