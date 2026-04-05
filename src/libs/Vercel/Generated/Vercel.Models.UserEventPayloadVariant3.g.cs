
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant3ActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant3Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

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
        public required string Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant3" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="environment"></param>
        /// <param name="label"></param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant3(
            global::Vercel.UserEventPayloadVariant3Action action,
            string environment,
            string? label,
            string? projectName,
            string? projectId)
        {
            this.Action = action;
            this.Label = label;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant3" /> class.
        /// </summary>
        public UserEventPayloadVariant3()
        {
        }
    }
}