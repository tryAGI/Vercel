
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2Options
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem> Items { get; set; }

        /// <summary>
        /// The order ID of the domain name purchase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2Options" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="orderId">
        /// The order ID of the domain name purchase
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2Options(
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem> items,
            string orderId)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2Options()
        {
        }
    }
}