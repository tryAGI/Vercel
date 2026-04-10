
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant220
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstEnabledAt")]
        public double? FirstEnabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant220" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="updatedAt"></param>
        /// <param name="firstEnabledAt"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant220(
            bool enabled,
            double updatedAt,
            double? firstEnabledAt,
            string? projectId,
            string? projectName)
        {
            this.Enabled = enabled;
            this.UpdatedAt = updatedAt;
            this.FirstEnabledAt = firstEnabledAt;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant220" /> class.
        /// </summary>
        public UserEventPayloadVariant220()
        {
        }
    }
}