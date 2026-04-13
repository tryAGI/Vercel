
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant111
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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Restore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfigVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configChangeCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfigChangeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configChanges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> ConfigChanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant111" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="restore"></param>
        /// <param name="configVersion"></param>
        /// <param name="configChangeCount"></param>
        /// <param name="configChanges"></param>
        /// <param name="projectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant111(
            string projectId,
            bool restore,
            double configVersion,
            double configChangeCount,
            global::System.Collections.Generic.IList<object> configChanges,
            string? projectName)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName;
            this.Restore = restore;
            this.ConfigVersion = configVersion;
            this.ConfigChangeCount = configChangeCount;
            this.ConfigChanges = configChanges ?? throw new global::System.ArgumentNullException(nameof(configChanges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant111" /> class.
        /// </summary>
        public UserEventPayloadVariant111()
        {
        }
    }
}