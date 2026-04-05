
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The line items that make up the Purchase Intent.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentLineItem
    {
        /// <summary>
        /// The ID of the line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The description of the line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The name of the line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the product being purchased
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// The quantity of the line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantity { get; set; }

        /// <summary>
        /// The unit amount of the line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitAmount { get; set; }

        /// <summary>
        /// Optional metadata for the line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The alias of the product being purchased
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productAlias")]
        public string? ProductAlias { get; set; }

        /// <summary>
        /// The amount of the line item that has been refunded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refund")]
        public string? Refund { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentLineItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the line item
        /// </param>
        /// <param name="description">
        /// The description of the line item
        /// </param>
        /// <param name="name">
        /// The name of the line item
        /// </param>
        /// <param name="productId">
        /// The ID of the product being purchased
        /// </param>
        /// <param name="quantity">
        /// The quantity of the line item
        /// </param>
        /// <param name="unitAmount">
        /// The unit amount of the line item
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the line item
        /// </param>
        /// <param name="productAlias">
        /// The alias of the product being purchased
        /// </param>
        /// <param name="refund">
        /// The amount of the line item that has been refunded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentLineItem(
            string id,
            string description,
            string name,
            string productId,
            string quantity,
            string unitAmount,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? productAlias,
            string? refund)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.Quantity = quantity ?? throw new global::System.ArgumentNullException(nameof(quantity));
            this.UnitAmount = unitAmount ?? throw new global::System.ArgumentNullException(nameof(unitAmount));
            this.Metadata = metadata;
            this.ProductAlias = productAlias;
            this.Refund = refund;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentLineItem" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentLineItem()
        {
        }
    }
}