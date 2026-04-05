
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Resources that were changed as part of this intent. Tracks all logical changes including the primary change and any side effects.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2TypeJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2" /> class.
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
        /// <param name="resourceIds">
        /// Resource IDs that were added.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2(
            string productAlias,
            string productId,
            double quantity,
            global::System.Collections.Generic.IList<string> resourceIds,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2Type type)
        {
            this.ProductAlias = productAlias ?? throw new global::System.ArgumentNullException(nameof(productAlias));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.Quantity = quantity;
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4OutputChangedResourceVariant2()
        {
        }
    }
}