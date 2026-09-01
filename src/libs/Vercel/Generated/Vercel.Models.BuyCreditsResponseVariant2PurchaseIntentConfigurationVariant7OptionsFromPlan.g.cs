
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current plan being replaced by this purchase
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlan
    {
        /// <summary>
        /// The end of the current plan billing cycle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentCycleEndDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentCycleEndDate { get; set; }

        /// <summary>
        /// The Orb subscription ID currently active for the owner on the source plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// The ID of the plan currently assigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// The current plan item quantities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemQuantities")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemQuantitie>? PlanItemQuantities { get; set; }

        /// <summary>
        /// The rate variant currently assigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateVariantKey")]
        public string? RateVariantKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlan" /> class.
        /// </summary>
        /// <param name="currentCycleEndDate">
        /// The end of the current plan billing cycle
        /// </param>
        /// <param name="orbSubscriptionId">
        /// The Orb subscription ID currently active for the owner on the source plan
        /// </param>
        /// <param name="planId">
        /// The ID of the plan currently assigned
        /// </param>
        /// <param name="planItemQuantities">
        /// The current plan item quantities
        /// </param>
        /// <param name="rateVariantKey">
        /// The rate variant currently assigned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlan(
            string currentCycleEndDate,
            string orbSubscriptionId,
            string planId,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanPlanItemQuantitie>? planItemQuantities,
            string? rateVariantKey)
        {
            this.CurrentCycleEndDate = currentCycleEndDate ?? throw new global::System.ArgumentNullException(nameof(currentCycleEndDate));
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.PlanItemQuantities = planItemQuantities;
            this.RateVariantKey = rateVariantKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlan" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlan()
        {
        }

    }
}