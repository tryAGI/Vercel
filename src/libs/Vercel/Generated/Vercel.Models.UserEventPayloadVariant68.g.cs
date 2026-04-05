
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant68
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant68JobVariant1, global::Vercel.UserEventPayloadVariant68JobVariant2, global::Vercel.UserEventPayloadVariant68JobVariant3, global::Vercel.UserEventPayloadVariant68JobVariant4, global::Vercel.UserEventPayloadVariant68JobVariant5, global::Vercel.UserEventPayloadVariant68JobVariant6, global::Vercel.UserEventPayloadVariant68JobVariant7, global::Vercel.UserEventPayloadVariant68JobVariant8>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant68JobVariant1, global::Vercel.UserEventPayloadVariant68JobVariant2, global::Vercel.UserEventPayloadVariant68JobVariant3, global::Vercel.UserEventPayloadVariant68JobVariant4, global::Vercel.UserEventPayloadVariant68JobVariant5, global::Vercel.UserEventPayloadVariant68JobVariant6, global::Vercel.UserEventPayloadVariant68JobVariant7, global::Vercel.UserEventPayloadVariant68JobVariant8> Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68" /> class.
        /// </summary>
        /// <param name="job"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant68(
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant68JobVariant1, global::Vercel.UserEventPayloadVariant68JobVariant2, global::Vercel.UserEventPayloadVariant68JobVariant3, global::Vercel.UserEventPayloadVariant68JobVariant4, global::Vercel.UserEventPayloadVariant68JobVariant5, global::Vercel.UserEventPayloadVariant68JobVariant6, global::Vercel.UserEventPayloadVariant68JobVariant7, global::Vercel.UserEventPayloadVariant68JobVariant8> job)
        {
            this.Job = job;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68" /> class.
        /// </summary>
        public UserEventPayloadVariant68()
        {
        }
    }
}