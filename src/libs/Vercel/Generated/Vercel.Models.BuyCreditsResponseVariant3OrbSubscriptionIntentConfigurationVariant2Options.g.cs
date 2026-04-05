
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration input options for increasing plan item quantity.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Options
    {
        /// <summary>
        /// The alias of the product to increase quantity for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productAlias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductAlias { get; set; }

        /// <summary>
        /// The resource IDs to incrementally add. The quantity of the plan item will be increased by the number of resource IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Options" /> class.
        /// </summary>
        /// <param name="productAlias">
        /// The alias of the product to increase quantity for.
        /// </param>
        /// <param name="resourceIds">
        /// The resource IDs to incrementally add. The quantity of the plan item will be increased by the number of resource IDs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Options(
            string productAlias,
            global::System.Collections.Generic.IList<string> resourceIds)
        {
            this.ProductAlias = productAlias ?? throw new global::System.ArgumentNullException(nameof(productAlias));
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant2Options()
        {
        }
    }
}