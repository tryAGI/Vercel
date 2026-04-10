
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant197
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant197ConsentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant197Consent Consent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant197" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="consent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant197(
            string projectName,
            global::Vercel.UserEventPayloadVariant197Consent consent)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.Consent = consent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant197" /> class.
        /// </summary>
        public UserEventPayloadVariant197()
        {
        }
    }
}