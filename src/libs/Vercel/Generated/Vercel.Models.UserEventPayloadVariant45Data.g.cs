
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant45Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planSlug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant45DataPlanSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant45DataPlanSlug PlanSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant45DataReasonJsonConverter))]
        public global::Vercel.UserEventPayloadVariant45DataReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant45Data" /> class.
        /// </summary>
        /// <param name="planSlug"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant45Data(
            global::Vercel.UserEventPayloadVariant45DataPlanSlug planSlug,
            global::Vercel.UserEventPayloadVariant45DataReason? reason)
        {
            this.PlanSlug = planSlug;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant45Data" /> class.
        /// </summary>
        public UserEventPayloadVariant45Data()
        {
        }
    }
}