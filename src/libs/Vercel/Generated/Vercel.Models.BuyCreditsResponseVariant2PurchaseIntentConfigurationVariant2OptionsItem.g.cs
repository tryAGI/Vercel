
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The subtotal of the domain name purchase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subtotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType Type { get; set; }

        /// <summary>
        /// The number of years to purchase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Years { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="subtotal">
        /// The subtotal of the domain name purchase
        /// </param>
        /// <param name="type"></param>
        /// <param name="years">
        /// The number of years to purchase
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem(
            string name,
            string subtotal,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType type,
            double years)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Subtotal = subtotal ?? throw new global::System.ArgumentNullException(nameof(subtotal));
            this.Type = type;
            this.Years = years;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItem()
        {
        }
    }
}