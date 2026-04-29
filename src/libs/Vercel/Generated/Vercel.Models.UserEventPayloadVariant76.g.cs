
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant76
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant76JobVariant1, global::Vercel.UserEventPayloadVariant76JobVariant2, global::Vercel.UserEventPayloadVariant76JobVariant3, global::Vercel.UserEventPayloadVariant76JobVariant4, global::Vercel.UserEventPayloadVariant76JobVariant5, global::Vercel.UserEventPayloadVariant76JobVariant6, global::Vercel.UserEventPayloadVariant76JobVariant7, global::Vercel.UserEventPayloadVariant76JobVariant8>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant76JobVariant1, global::Vercel.UserEventPayloadVariant76JobVariant2, global::Vercel.UserEventPayloadVariant76JobVariant3, global::Vercel.UserEventPayloadVariant76JobVariant4, global::Vercel.UserEventPayloadVariant76JobVariant5, global::Vercel.UserEventPayloadVariant76JobVariant6, global::Vercel.UserEventPayloadVariant76JobVariant7, global::Vercel.UserEventPayloadVariant76JobVariant8> Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant76" /> class.
        /// </summary>
        /// <param name="job"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant76(
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant76JobVariant1, global::Vercel.UserEventPayloadVariant76JobVariant2, global::Vercel.UserEventPayloadVariant76JobVariant3, global::Vercel.UserEventPayloadVariant76JobVariant4, global::Vercel.UserEventPayloadVariant76JobVariant5, global::Vercel.UserEventPayloadVariant76JobVariant6, global::Vercel.UserEventPayloadVariant76JobVariant7, global::Vercel.UserEventPayloadVariant76JobVariant8> job)
        {
            this.Job = job;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant76" /> class.
        /// </summary>
        public UserEventPayloadVariant76()
        {
        }
    }
}