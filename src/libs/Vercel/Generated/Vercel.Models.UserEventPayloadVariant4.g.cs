
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant4ActionJsonConverter))]
        public global::Vercel.UserEventPayloadVariant4Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant4" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="action"></param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant4(
            global::System.Collections.Generic.IList<string> environment,
            global::Vercel.UserEventPayloadVariant4Action action,
            string? projectName,
            string? projectId)
        {
            this.Action = action;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant4" /> class.
        /// </summary>
        public UserEventPayloadVariant4()
        {
        }
    }
}