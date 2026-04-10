
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant260
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant260PlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant260Plan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial")]
        public global::Vercel.UserEventPayloadVariant260Trial? Trial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant260" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="trial"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant260(
            global::Vercel.UserEventPayloadVariant260Plan plan,
            global::Vercel.UserEventPayloadVariant260Trial? trial)
        {
            this.Plan = plan;
            this.Trial = trial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant260" /> class.
        /// </summary>
        public UserEventPayloadVariant260()
        {
        }
    }
}