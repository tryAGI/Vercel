
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Output returned after configuring an OrbSubscriptionIntent.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Output
    {
        /// <summary>
        /// The Orb price ID for the subscription item being modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbPriceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbPriceId { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant2, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant3, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant4>>? ChangedResources { get; set; }

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
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Output" /> class.
        /// </summary>
        /// <param name="orbPriceId">
        /// The Orb price ID for the subscription item being modified.
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
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Output(
            string orbPriceId,
            string productId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant1, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant2, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant3, global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2OutputChangedResourceVariant4>>? changedResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? pendingSubscriptionChangeId)
        {
            this.OrbPriceId = orbPriceId ?? throw new global::System.ArgumentNullException(nameof(orbPriceId));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.ChangedResources = changedResources;
            this.Metadata = metadata;
            this.PendingSubscriptionChangeId = pendingSubscriptionChangeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Output" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Output()
        {
        }
    }
}