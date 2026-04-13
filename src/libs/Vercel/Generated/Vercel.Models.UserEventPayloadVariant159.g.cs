
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant159
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldElasticConcurrencyEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OldElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueueConfiguration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant159BuildQueueConfigurationJsonConverter))]
        public global::Vercel.UserEventPayloadVariant159BuildQueueConfiguration? BuildQueueConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldBuildQueueConfiguration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant159OldBuildQueueConfigurationJsonConverter))]
        public global::Vercel.UserEventPayloadVariant159OldBuildQueueConfiguration? OldBuildQueueConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant159" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="elasticConcurrencyEnabled"></param>
        /// <param name="oldElasticConcurrencyEnabled"></param>
        /// <param name="buildQueueConfiguration"></param>
        /// <param name="oldBuildQueueConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant159(
            string projectId,
            string projectName,
            bool elasticConcurrencyEnabled,
            bool oldElasticConcurrencyEnabled,
            global::Vercel.UserEventPayloadVariant159BuildQueueConfiguration? buildQueueConfiguration,
            global::Vercel.UserEventPayloadVariant159OldBuildQueueConfiguration? oldBuildQueueConfiguration)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.OldElasticConcurrencyEnabled = oldElasticConcurrencyEnabled;
            this.BuildQueueConfiguration = buildQueueConfiguration;
            this.OldBuildQueueConfiguration = oldBuildQueueConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant159" /> class.
        /// </summary>
        public UserEventPayloadVariant159()
        {
        }
    }
}