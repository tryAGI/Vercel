
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Output returned after configuring an OrbSubscriptionIntent.
    /// </summary>
    public sealed partial class AutoSDKShareda15210bade0a7c46
    {
        /// <summary>
        /// Resources that were changed as part of this intent. Tracks all logical changes including the primary change and any side effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changedResources")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda15210bade0a7c46ChangedResource>? ChangedResources { get; set; }

        /// <summary>
        /// The Orb customer's timezone when the intent was created. Omitted for legacy intents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerTimezone")]
        public string? CustomerTimezone { get; set; }

        /// <summary>
        /// When the subscription change should take effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveBehavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda15210bade0a7c46EffectiveBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda15210bade0a7c46EffectiveBehavior EffectiveBehavior { get; set; }

        /// <summary>
        /// Optional metadata associated with the intent to update the Orb subscription with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The Orb price ID for the subscription item being modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbPriceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbPriceId { get; set; }

        /// <summary>
        /// The ID of the pending subscription change if there is one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingSubscriptionChangeId")]
        public string? PendingSubscriptionChangeId { get; set; }

        /// <summary>
        /// The source used as the authoritative price for this intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda15210bade0a7c46PricingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda15210bade0a7c46PricingSource PricingSource { get; set; }

        /// <summary>
        /// The product ID associated with this intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// The canonical reference-product billing period at intent creation. Omitted for historical intents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceBillingPeriod")]
        public global::Vercel.AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod? ReferenceBillingPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda15210bade0a7c46" /> class.
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
        /// <param name="customerTimezone">
        /// The Orb customer's timezone when the intent was created. Omitted for legacy intents.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the intent to update the Orb subscription with.
        /// </param>
        /// <param name="pendingSubscriptionChangeId">
        /// The ID of the pending subscription change if there is one.
        /// </param>
        /// <param name="referenceBillingPeriod">
        /// The canonical reference-product billing period at intent creation. Omitted for historical intents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda15210bade0a7c46(
            global::Vercel.AutoSDKShareda15210bade0a7c46EffectiveBehavior effectiveBehavior,
            string orbPriceId,
            global::Vercel.AutoSDKShareda15210bade0a7c46PricingSource pricingSource,
            string productId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda15210bade0a7c46ChangedResource>? changedResources,
            string? customerTimezone,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? pendingSubscriptionChangeId,
            global::Vercel.AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod? referenceBillingPeriod)
        {
            this.ChangedResources = changedResources;
            this.CustomerTimezone = customerTimezone;
            this.EffectiveBehavior = effectiveBehavior;
            this.Metadata = metadata;
            this.OrbPriceId = orbPriceId ?? throw new global::System.ArgumentNullException(nameof(orbPriceId));
            this.PendingSubscriptionChangeId = pendingSubscriptionChangeId;
            this.PricingSource = pricingSource;
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.ReferenceBillingPeriod = referenceBillingPeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda15210bade0a7c46" /> class.
        /// </summary>
        public AutoSDKShareda15210bade0a7c46()
        {
        }

    }
}