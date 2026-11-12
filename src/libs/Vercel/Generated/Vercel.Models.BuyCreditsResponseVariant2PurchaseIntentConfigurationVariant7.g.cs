
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration for a credit purchase
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2> Options { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Output Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7TypeJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7(
            global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2> options,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Output output,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7Type type)
        {
            this.Options = options;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7()
        {
        }

    }
}