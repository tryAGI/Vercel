
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration for the Orb subscription intent.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3
    {
        /// <summary>
        /// Configuration input options for decreasing plan item quantity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Options Options { get; set; }

        /// <summary>
        /// Output returned after configuring an OrbSubscriptionIntent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3TypeJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3" /> class.
        /// </summary>
        /// <param name="options">
        /// Configuration input options for decreasing plan item quantity.
        /// </param>
        /// <param name="output">
        /// Output returned after configuring an OrbSubscriptionIntent.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3(
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Options options,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Output output,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3Type type)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant3()
        {
        }
    }
}