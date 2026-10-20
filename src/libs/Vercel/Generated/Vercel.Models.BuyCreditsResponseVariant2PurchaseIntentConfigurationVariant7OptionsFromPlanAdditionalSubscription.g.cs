
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Additional source subscriptions replaced by this purchase
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanAdditionalSubscription
    {
        /// <summary>
        /// The end of the additional source subscription billing cycle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentCycleEndDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentCycleEndDate { get; set; }

        /// <summary>
        /// The additional source Orb subscription ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// The ID of the plan assigned to the additional source subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanAdditionalSubscription" /> class.
        /// </summary>
        /// <param name="currentCycleEndDate">
        /// The end of the additional source subscription billing cycle
        /// </param>
        /// <param name="orbSubscriptionId">
        /// The additional source Orb subscription ID
        /// </param>
        /// <param name="planId">
        /// The ID of the plan assigned to the additional source subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanAdditionalSubscription(
            string currentCycleEndDate,
            string orbSubscriptionId,
            string planId)
        {
            this.CurrentCycleEndDate = currentCycleEndDate ?? throw new global::System.ArgumentNullException(nameof(currentCycleEndDate));
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanAdditionalSubscription" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsFromPlanAdditionalSubscription()
        {
        }

    }
}