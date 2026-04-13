
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information about which features are blocked for a user. Blocks can be either soft (the user can still access the feature, but with a warning, e.g. prompting an upgrade) or hard (the user cannot access the feature at all).
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerFeatureBlocks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// A soft block indicates a temporary pause in data collection (ex limit exceeded for the current cycle) A hard block indicates a stoppage in data collection that requires manual intervention (ex upgrading a pro trial)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoring")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoring? Monitoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityPlus")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlus? ObservabilityPlus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksDataCache? DataCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptimizationTransformation")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformation? ImageOptimizationTransformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceImages")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksSourceImages? SourceImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant2>? Blob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant2>? Postgres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redis")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant2>? Redis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendsRequest")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequest? MicrofrontendsRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowStorage")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksWorkflowStorage? WorkflowStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowStep")]
        public global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksWorkflowStep? WorkflowStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerFeatureBlocks" /> class.
        /// </summary>
        /// <param name="webAnalytics"></param>
        /// <param name="monitoring">
        /// A soft block indicates a temporary pause in data collection (ex limit exceeded for the current cycle) A hard block indicates a stoppage in data collection that requires manual intervention (ex upgrading a pro trial)
        /// </param>
        /// <param name="observabilityPlus"></param>
        /// <param name="dataCache"></param>
        /// <param name="imageOptimizationTransformation"></param>
        /// <param name="sourceImages"></param>
        /// <param name="blob"></param>
        /// <param name="postgres"></param>
        /// <param name="redis"></param>
        /// <param name="microfrontendsRequest"></param>
        /// <param name="workflowStorage"></param>
        /// <param name="workflowStep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerFeatureBlocks(
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalytics? webAnalytics,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoring? monitoring,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlus? observabilityPlus,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksDataCache? dataCache,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformation? imageOptimizationTransformation,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksSourceImages? sourceImages,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksBlobVariant2>? blob,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksPostgresVariant2>? postgres,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1, global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant2>? redis,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequest? microfrontendsRequest,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksWorkflowStorage? workflowStorage,
            global::Vercel.UserEventPayloadVariant116NewOwnerFeatureBlocksWorkflowStep? workflowStep)
        {
            this.WebAnalytics = webAnalytics;
            this.Monitoring = monitoring;
            this.ObservabilityPlus = observabilityPlus;
            this.DataCache = dataCache;
            this.ImageOptimizationTransformation = imageOptimizationTransformation;
            this.SourceImages = sourceImages;
            this.Blob = blob;
            this.Postgres = postgres;
            this.Redis = redis;
            this.MicrofrontendsRequest = microfrontendsRequest;
            this.WorkflowStorage = workflowStorage;
            this.WorkflowStep = workflowStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerFeatureBlocks" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerFeatureBlocks()
        {
        }
    }
}