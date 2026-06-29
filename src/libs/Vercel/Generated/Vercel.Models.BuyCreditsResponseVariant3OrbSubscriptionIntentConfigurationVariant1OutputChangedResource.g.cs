
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Resources that were changed as part of this intent. Tracks all logical changes including the primary change and any side effects.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputChangedResource
    {
        /// <summary>
        /// The alias of the product that was changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productAlias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductAlias { get; set; }

        /// <summary>
        /// The ID of the product that was changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// The resulting quantity after this change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Resource IDs that were added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedResourceIds")]
        public global::System.Collections.Generic.IList<string>? AddedResourceIds { get; set; }

        /// <summary>
        /// When this resource change should take effect for downstream consumers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveAt")]
        public string? EffectiveAt { get; set; }

        /// <summary>
        /// Resource IDs that were removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedResourceIds")]
        public global::System.Collections.Generic.IList<string>? RemovedResourceIds { get; set; }

        /// <summary>
        /// The full set of resource IDs after the change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        public global::System.Collections.Generic.IList<string>? ResourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputChangedResource" /> class.
        /// </summary>
        /// <param name="productAlias">
        /// The alias of the product that was changed.
        /// </param>
        /// <param name="productId">
        /// The ID of the product that was changed.
        /// </param>
        /// <param name="quantity">
        /// The resulting quantity after this change.
        /// </param>
        /// <param name="addedResourceIds">
        /// Resource IDs that were added.
        /// </param>
        /// <param name="effectiveAt">
        /// When this resource change should take effect for downstream consumers.
        /// </param>
        /// <param name="removedResourceIds">
        /// Resource IDs that were removed.
        /// </param>
        /// <param name="resourceIds">
        /// The full set of resource IDs after the change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputChangedResource(
            string productAlias,
            string productId,
            double quantity,
            global::System.Collections.Generic.IList<string>? addedResourceIds,
            string? effectiveAt,
            global::System.Collections.Generic.IList<string>? removedResourceIds,
            global::System.Collections.Generic.IList<string>? resourceIds)
        {
            this.ProductAlias = productAlias ?? throw new global::System.ArgumentNullException(nameof(productAlias));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.Quantity = quantity;
            this.AddedResourceIds = addedResourceIds;
            this.EffectiveAt = effectiveAt;
            this.RemovedResourceIds = removedResourceIds;
            this.ResourceIds = resourceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputChangedResource" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1OutputChangedResource()
        {
        }

    }
}