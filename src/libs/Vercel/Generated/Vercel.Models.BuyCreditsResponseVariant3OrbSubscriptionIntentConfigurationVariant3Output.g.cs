
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Output returned after configuring an OrbSubscriptionIntent.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output
    {
        /// <summary>
        /// When the subscription change should take effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveBehavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputEffectiveBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputEffectiveBehavior EffectiveBehavior { get; set; }

        /// <summary>
        /// The Orb price ID for the subscription item being modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbPriceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbPriceId { get; set; }

        /// <summary>
        /// The source used as the authoritative price for this intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource PricingSource { get; set; }

        /// <summary>
        /// The product ID associated with this intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// Resources that were changed as part of this intent. Tracks all logical changes including the primary change and any side effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changedResources")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResource>? ChangedResources { get; set; }

        /// <summary>
        /// Optional metadata associated with the intent to update the Orb subscription with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The ID of the pending subscription change if there is one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingSubscriptionChangeId")]
        public string? PendingSubscriptionChangeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output" /> class.
        /// </summary>
        /// <param name="effectiveBehavior">
        /// When the subscription change should take effect.
        /// </param>
        /// <param name="orbPriceId">
        /// The Orb price ID for the subscription item being modified.
        /// </param>
        /// <param name="pricingSource">
        /// The source used as the authoritative price for this intent.
        /// </param>
        /// <param name="productId">
        /// The product ID associated with this intent.
        /// </param>
        /// <param name="changedResources">
        /// Resources that were changed as part of this intent. Tracks all logical changes including the primary change and any side effects.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the intent to update the Orb subscription with.
        /// </param>
        /// <param name="pendingSubscriptionChangeId">
        /// The ID of the pending subscription change if there is one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output(
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputEffectiveBehavior effectiveBehavior,
            string orbPriceId,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputPricingSource pricingSource,
            string productId,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3OutputChangedResource>? changedResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? pendingSubscriptionChangeId)
        {
            this.EffectiveBehavior = effectiveBehavior;
            this.OrbPriceId = orbPriceId ?? throw new global::System.ArgumentNullException(nameof(orbPriceId));
            this.PricingSource = pricingSource;
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.ChangedResources = changedResources;
            this.Metadata = metadata;
            this.PendingSubscriptionChangeId = pendingSubscriptionChangeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output()
        {
        }

    }
}