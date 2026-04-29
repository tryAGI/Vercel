
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant282
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant282PlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant282Plan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial")]
        public global::Vercel.UserEventPayloadVariant282Trial? Trial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant282" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="trial"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant282(
            global::Vercel.UserEventPayloadVariant282Plan plan,
            global::Vercel.UserEventPayloadVariant282Trial? trial)
        {
            this.Plan = plan;
            this.Trial = trial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant282" /> class.
        /// </summary>
        public UserEventPayloadVariant282()
        {
        }
    }
}