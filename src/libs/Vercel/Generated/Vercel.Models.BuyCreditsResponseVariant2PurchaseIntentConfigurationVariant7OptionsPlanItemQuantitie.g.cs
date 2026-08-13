
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The plan item quantities to set for the subscription
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie
    {
        /// <summary>
        /// The ID of the plan item to set the quantity for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanItemId { get; set; }

        /// <summary>
        /// The nonnegative integer quantity for the plan item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// The resource IDs to associate with the plan item quantity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        public global::System.Collections.Generic.IList<string>? ResourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie" /> class.
        /// </summary>
        /// <param name="planItemId">
        /// The ID of the plan item to set the quantity for
        /// </param>
        /// <param name="quantity">
        /// The nonnegative integer quantity for the plan item
        /// </param>
        /// <param name="resourceIds">
        /// The resource IDs to associate with the plan item quantity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie(
            string planItemId,
            double quantity,
            global::System.Collections.Generic.IList<string>? resourceIds)
        {
            this.PlanItemId = planItemId ?? throw new global::System.ArgumentNullException(nameof(planItemId));
            this.Quantity = quantity;
            this.ResourceIds = resourceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie()
        {
        }

    }
}