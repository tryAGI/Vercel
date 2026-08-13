
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the subscription change is applied to Orb.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1ModeJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1(
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1Mode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant1()
        {
        }

    }
}