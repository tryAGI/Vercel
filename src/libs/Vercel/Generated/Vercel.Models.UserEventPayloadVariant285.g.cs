
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant285
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant285TierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant285Tier Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant285" /> class.
        /// </summary>
        /// <param name="tier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant285(
            global::Vercel.UserEventPayloadVariant285Tier tier)
        {
            this.Tier = tier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant285" /> class.
        /// </summary>
        public UserEventPayloadVariant285()
        {
        }
    }
}