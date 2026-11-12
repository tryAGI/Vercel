
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Destination-only licensed quantities; shared quantities come from Copper
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie" /> class.
        /// </summary>
        /// <param name="planItemId"></param>
        /// <param name="quantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie(
            string planItemId,
            double quantity)
        {
            this.PlanItemId = planItemId ?? throw new global::System.ArgumentNullException(nameof(planItemId));
            this.Quantity = quantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie()
        {
        }

    }
}