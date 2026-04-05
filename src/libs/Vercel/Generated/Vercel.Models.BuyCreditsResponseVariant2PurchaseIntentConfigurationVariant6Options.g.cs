
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Options
    {
        /// <summary>
        /// The ID of the Orb customer to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbCustomerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbCustomerId { get; set; }

        /// <summary>
        /// The external ID of the Orb customer to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbExternalCustomerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbExternalCustomerId { get; set; }

        /// <summary>
        /// The external ID of the Orb plan to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbExternalPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbExternalPlanId { get; set; }

        /// <summary>
        /// The ID of the pending subscription change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbPendingSubscriptionChangeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbPendingSubscriptionChangeId { get; set; }

        /// <summary>
        /// The ID of the Orb plan to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbPlanId { get; set; }

        /// <summary>
        /// The ID of the Orb subscription to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// The line items that make up the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineItems")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6OptionsLineItem>? LineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Options" /> class.
        /// </summary>
        /// <param name="orbCustomerId">
        /// The ID of the Orb customer to create
        /// </param>
        /// <param name="orbExternalCustomerId">
        /// The external ID of the Orb customer to create
        /// </param>
        /// <param name="orbExternalPlanId">
        /// The external ID of the Orb plan to create
        /// </param>
        /// <param name="orbPendingSubscriptionChangeId">
        /// The ID of the pending subscription change
        /// </param>
        /// <param name="orbPlanId">
        /// The ID of the Orb plan to create
        /// </param>
        /// <param name="orbSubscriptionId">
        /// The ID of the Orb subscription to create
        /// </param>
        /// <param name="lineItems">
        /// The line items that make up the Purchase Intent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Options(
            string orbCustomerId,
            string orbExternalCustomerId,
            string orbExternalPlanId,
            string orbPendingSubscriptionChangeId,
            string orbPlanId,
            string orbSubscriptionId,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6OptionsLineItem>? lineItems)
        {
            this.OrbCustomerId = orbCustomerId ?? throw new global::System.ArgumentNullException(nameof(orbCustomerId));
            this.OrbExternalCustomerId = orbExternalCustomerId ?? throw new global::System.ArgumentNullException(nameof(orbExternalCustomerId));
            this.OrbExternalPlanId = orbExternalPlanId ?? throw new global::System.ArgumentNullException(nameof(orbExternalPlanId));
            this.OrbPendingSubscriptionChangeId = orbPendingSubscriptionChangeId ?? throw new global::System.ArgumentNullException(nameof(orbPendingSubscriptionChangeId));
            this.OrbPlanId = orbPlanId ?? throw new global::System.ArgumentNullException(nameof(orbPlanId));
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
            this.LineItems = lineItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6Options()
        {
        }
    }
}