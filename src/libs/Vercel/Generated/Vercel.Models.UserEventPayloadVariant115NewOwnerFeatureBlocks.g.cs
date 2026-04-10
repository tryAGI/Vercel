
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information about which features are blocked for a user. Blocks can be either soft (the user can still access the feature, but with a warning, e.g. prompting an upgrade) or hard (the user cannot access the feature at all).
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerFeatureBlocks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// A soft block indicates a temporary pause in data collection (ex limit exceeded for the current cycle) A hard block indicates a stoppage in data collection that requires manual intervention (ex upgrading a pro trial)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoring")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring? Monitoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityPlus")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlus? ObservabilityPlus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksDataCache? DataCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptimizationTransformation")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformation? ImageOptimizationTransformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceImages")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksSourceImages? SourceImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant2>? Blob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant2>? Postgres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redis")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant2>? Redis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendsRequest")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMicrofrontendsRequest? MicrofrontendsRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowStorage")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStorage? WorkflowStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowStep")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStep? WorkflowStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerFeatureBlocks" /> class.
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
        public UserEventPayloadVariant115NewOwnerFeatureBlocks(
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalytics? webAnalytics,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoring? monitoring,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlus? observabilityPlus,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksDataCache? dataCache,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformation? imageOptimizationTransformation,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksSourceImages? sourceImages,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksBlobVariant2>? blob,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksPostgresVariant2>? postgres,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant2>? redis,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksMicrofrontendsRequest? microfrontendsRequest,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStorage? workflowStorage,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocksWorkflowStep? workflowStep)
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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerFeatureBlocks" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerFeatureBlocks()
        {
        }
    }
}