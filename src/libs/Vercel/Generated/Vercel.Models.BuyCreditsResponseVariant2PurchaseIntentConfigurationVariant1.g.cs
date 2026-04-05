
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration for a credit purchase
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1
    {
        /// <summary>
        /// Purchase configuration specific options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1TypeJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1" /> class.
        /// </summary>
        /// <param name="options">
        /// Purchase configuration specific options
        /// </param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1(
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options options,
            object? output,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Type type)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Output = output;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1()
        {
        }
    }
}