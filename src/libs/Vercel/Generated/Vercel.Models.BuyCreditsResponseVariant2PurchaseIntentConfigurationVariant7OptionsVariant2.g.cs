
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restart-cycle purchase options
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromPlan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan FromPlan { get; set; }

        /// <summary>
        /// The destination plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// Destination-only licensed quantities; shared quantities come from Copper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planItemQuantities")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie>? PlanItemQuantities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2Transition Transition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2" /> class.
        /// </summary>
        /// <param name="fromPlan"></param>
        /// <param name="planId">
        /// The destination plan
        /// </param>
        /// <param name="transition"></param>
        /// <param name="planItemQuantities">
        /// Destination-only licensed quantities; shared quantities come from Copper
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2(
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan fromPlan,
            string planId,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2Transition transition,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2PlanItemQuantitie>? planItemQuantities)
        {
            this.FromPlan = fromPlan ?? throw new global::System.ArgumentNullException(nameof(fromPlan));
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.PlanItemQuantities = planItemQuantities;
            this.Transition = transition ?? throw new global::System.ArgumentNullException(nameof(transition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2()
        {
        }

    }
}