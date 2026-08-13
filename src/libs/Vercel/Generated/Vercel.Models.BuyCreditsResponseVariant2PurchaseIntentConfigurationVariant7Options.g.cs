
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Purchase configuration specific options
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Options
    {
        /// <summary>
        /// The ID of the plan to subscribe to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// The plan item quantities to set for the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemQuantities")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie>? PlanItemQuantities { get; set; }

        /// <summary>
        /// The rate variant key to apply to the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateVariantKey")]
        public string? RateVariantKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Options" /> class.
        /// </summary>
        /// <param name="planId">
        /// The ID of the plan to subscribe to
        /// </param>
        /// <param name="planItemQuantities">
        /// The plan item quantities to set for the subscription
        /// </param>
        /// <param name="rateVariantKey">
        /// The rate variant key to apply to the subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Options(
            string planId,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsPlanItemQuantitie>? planItemQuantities,
            string? rateVariantKey)
        {
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.PlanItemQuantities = planItemQuantities;
            this.RateVariantKey = rateVariantKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Options()
        {
        }

    }
}