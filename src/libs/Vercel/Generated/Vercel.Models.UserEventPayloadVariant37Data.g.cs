
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant37Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planSlug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant37DataPlanSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant37DataPlanSlug PlanSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant37DataReasonJsonConverter))]
        public global::Vercel.UserEventPayloadVariant37DataReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant37Data" /> class.
        /// </summary>
        /// <param name="planSlug"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant37Data(
            global::Vercel.UserEventPayloadVariant37DataPlanSlug planSlug,
            global::Vercel.UserEventPayloadVariant37DataReason? reason)
        {
            this.PlanSlug = planSlug;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant37Data" /> class.
        /// </summary>
        public UserEventPayloadVariant37Data()
        {
        }
    }
}