
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant196
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant196ReasonCodeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant196ReasonCode? ReasonCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant196" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="reasonCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant196(
            string projectId,
            global::Vercel.UserEventPayloadVariant196ReasonCode? reasonCode)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant196" /> class.
        /// </summary>
        public UserEventPayloadVariant196()
        {
        }
    }
}