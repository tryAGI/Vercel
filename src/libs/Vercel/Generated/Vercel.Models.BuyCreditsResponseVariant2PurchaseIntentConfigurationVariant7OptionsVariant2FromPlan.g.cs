
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan
    {
        /// <summary>
        /// The owned active source subscription recorded by Copper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan" /> class.
        /// </summary>
        /// <param name="orbSubscriptionId">
        /// The owned active source subscription recorded by Copper
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan(
            string orbSubscriptionId)
        {
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2FromPlan()
        {
        }

    }
}