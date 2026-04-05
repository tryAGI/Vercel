
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration input options for adjusting plan item quantity.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Options
    {
        /// <summary>
        /// The resource IDs to incrementally add. The quantity of the plan item will be increased by the number of resource IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedResourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AddedResourceIds { get; set; }

        /// <summary>
        /// The alias of the product to adjust quantity for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productAlias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductAlias { get; set; }

        /// <summary>
        /// The resource IDs to incrementally remove. The quantity of the plan item will be decreased by the number of resource IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedResourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RemovedResourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Options" /> class.
        /// </summary>
        /// <param name="addedResourceIds">
        /// The resource IDs to incrementally add. The quantity of the plan item will be increased by the number of resource IDs.
        /// </param>
        /// <param name="productAlias">
        /// The alias of the product to adjust quantity for.
        /// </param>
        /// <param name="removedResourceIds">
        /// The resource IDs to incrementally remove. The quantity of the plan item will be decreased by the number of resource IDs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Options(
            global::System.Collections.Generic.IList<string> addedResourceIds,
            string productAlias,
            global::System.Collections.Generic.IList<string> removedResourceIds)
        {
            this.AddedResourceIds = addedResourceIds ?? throw new global::System.ArgumentNullException(nameof(addedResourceIds));
            this.ProductAlias = productAlias ?? throw new global::System.ArgumentNullException(nameof(productAlias));
            this.RemovedResourceIds = removedResourceIds ?? throw new global::System.ArgumentNullException(nameof(removedResourceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Options()
        {
        }
    }
}