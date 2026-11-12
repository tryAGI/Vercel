
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restart-cycle purchase options
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1
    {
        /// <summary>
        /// The current plan being replaced by this purchase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromPlan")]
        public global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1FromPlan? FromPlan { get; set; }

        /// <summary>
        /// The ID of the plan to subscribe to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// The plan item prices to set for the subscription, independent of quantities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemPrices")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPrice>? PlanItemPrices { get; set; }

        /// <summary>
        /// The plan item quantities to set for the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemQuantities")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemQuantitie>? PlanItemQuantities { get; set; }

        /// <summary>
        /// The rate variant key to apply to the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateVariantKey")]
        public string? RateVariantKey { get; set; }

        /// <summary>
        /// Replacement billing-cycle policy. Defaults to restart_cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition")]
        public global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1Transition? Transition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1" /> class.
        /// </summary>
        /// <param name="planId">
        /// The ID of the plan to subscribe to
        /// </param>
        /// <param name="fromPlan">
        /// The current plan being replaced by this purchase
        /// </param>
        /// <param name="planItemPrices">
        /// The plan item prices to set for the subscription, independent of quantities
        /// </param>
        /// <param name="planItemQuantities">
        /// The plan item quantities to set for the subscription
        /// </param>
        /// <param name="rateVariantKey">
        /// The rate variant key to apply to the subscription
        /// </param>
        /// <param name="transition">
        /// Replacement billing-cycle policy. Defaults to restart_cycle.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1(
            string planId,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1FromPlan? fromPlan,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemPrice>? planItemPrices,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1PlanItemQuantitie>? planItemQuantities,
            string? rateVariantKey,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1Transition? transition)
        {
            this.FromPlan = fromPlan;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.PlanItemPrices = planItemPrices;
            this.PlanItemQuantities = planItemQuantities;
            this.RateVariantKey = rateVariantKey;
            this.Transition = transition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1()
        {
        }

    }
}