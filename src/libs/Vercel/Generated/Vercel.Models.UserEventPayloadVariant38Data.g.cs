
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant38Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planSlug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant38DataPlanSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant38DataPlanSlug PlanSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant38Data" /> class.
        /// </summary>
        /// <param name="planSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant38Data(
            global::Vercel.UserEventPayloadVariant38DataPlanSlug planSlug)
        {
            this.PlanSlug = planSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant38Data" /> class.
        /// </summary>
        public UserEventPayloadVariant38Data()
        {
        }
    }
}