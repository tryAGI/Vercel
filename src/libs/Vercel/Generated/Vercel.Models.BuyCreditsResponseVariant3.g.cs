
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionIntent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntent OrbSubscriptionIntent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3" /> class.
        /// </summary>
        /// <param name="orbSubscriptionIntent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3(
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntent orbSubscriptionIntent)
        {
            this.OrbSubscriptionIntent = orbSubscriptionIntent ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionIntent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3()
        {
        }
    }
}