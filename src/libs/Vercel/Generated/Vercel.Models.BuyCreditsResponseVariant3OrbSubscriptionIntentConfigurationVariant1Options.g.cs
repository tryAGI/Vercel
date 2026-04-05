
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration input options for setting plan item quantity.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1Options
    {
        /// <summary>
        /// The alias of the product to set quantity for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productAlias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductAlias { get; set; }

        /// <summary>
        /// The quantity to set for the plan item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// The resource IDs for the plan item. Only set if SKU requires resource entitlements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        public global::System.Collections.Generic.IList<string>? ResourceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1Options" /> class.
        /// </summary>
        /// <param name="productAlias">
        /// The alias of the product to set quantity for.
        /// </param>
        /// <param name="quantity">
        /// The quantity to set for the plan item.
        /// </param>
        /// <param name="resourceIds">
        /// The resource IDs for the plan item. Only set if SKU requires resource entitlements.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1Options(
            string productAlias,
            double quantity,
            global::System.Collections.Generic.IList<string>? resourceIds)
        {
            this.ProductAlias = productAlias ?? throw new global::System.ArgumentNullException(nameof(productAlias));
            this.Quantity = quantity;
            this.ResourceIds = resourceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant1Options()
        {
        }
    }
}