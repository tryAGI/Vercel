
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current plan item price overrides
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPrice
    {
        /// <summary>
        /// The ID of the plan item to set the price for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanItemId { get; set; }

        /// <summary>
        /// The absolute price that replaces the plan item price, after any rate variant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPricePrice Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPrice" /> class.
        /// </summary>
        /// <param name="planItemId">
        /// The ID of the plan item to set the price for
        /// </param>
        /// <param name="price">
        /// The absolute price that replaces the plan item price, after any rate variant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPrice(
            string planItemId,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPricePrice price)
        {
            this.PlanItemId = planItemId ?? throw new global::System.ArgumentNullException(nameof(planItemId));
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPrice" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemPrice()
        {
        }

    }
}