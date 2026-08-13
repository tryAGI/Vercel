
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the subscription change is applied to Orb.
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3
    {
        /// <summary>
        /// The ISO 8601 date-time that the subscription change was applied to Orb.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppliedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3ModeJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3StatusJsonConverter))]
        public global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3" /> class.
        /// </summary>
        /// <param name="appliedAt">
        /// The ISO 8601 date-time that the subscription change was applied to Orb.
        /// </param>
        /// <param name="mode"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3(
            string appliedAt,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Mode mode,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3Status status)
        {
            this.AppliedAt = appliedAt ?? throw new global::System.ArgumentNullException(nameof(appliedAt));
            this.Mode = mode;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3" /> class.
        /// </summary>
        public BuyCreditsResponseVariant3OrbSubscriptionIntentOrbUpdateVariant3()
        {
        }

    }
}