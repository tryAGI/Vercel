
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerResourceConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeType")]
        public string? NodeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentBuilds")]
        public double? ConcurrentBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        public bool? ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildEntitlements")]
        public global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigBuildEntitlements? BuildEntitlements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigBuildQueue? BuildQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccountType")]
        public string? AwsAccountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccountIds")]
        public global::System.Collections.Generic.IList<string>? AwsAccountIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfZoneName")]
        public string? CfZoneName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptimizationType")]
        public string? ImageOptimizationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigs")]
        public double? EdgeConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigSize")]
        public double? EdgeConfigSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeFunctionMaxSizeBytes")]
        public double? EdgeFunctionMaxSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeFunctionExecutionTimeoutMs")]
        public double? EdgeFunctionExecutionTimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionMaxMemorySize")]
        public double? ServerlessFunctionMaxMemorySize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kvDatabases")]
        public double? KvDatabases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgresDatabases")]
        public double? PostgresDatabases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobStores")]
        public double? BlobStores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationStores")]
        public double? IntegrationStores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cronJobsPerProject")]
        public double? CronJobsPerProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendGroupsPerTeam")]
        public double? MicrofrontendGroupsPerTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendProjectsPerGroup")]
        public double? MicrofrontendProjectsPerGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagsExplorerOverridesThreshold")]
        public double? FlagsExplorerOverridesThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagsExplorerUnlimitedOverrides")]
        public bool? FlagsExplorerUnlimitedOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentsPerProject")]
        public double? CustomEnvironmentsPerProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachine")]
        public global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigBuildMachine? BuildMachine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigSecurity? Security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulkRedirectsFreeLimitOverride")]
        public double? BulkRedirectsFreeLimitOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerResourceConfig" /> class.
        /// </summary>
        /// <param name="nodeType"></param>
        /// <param name="concurrentBuilds"></param>
        /// <param name="elasticConcurrencyEnabled"></param>
        /// <param name="buildEntitlements"></param>
        /// <param name="buildQueue"></param>
        /// <param name="awsAccountType"></param>
        /// <param name="awsAccountIds"></param>
        /// <param name="cfZoneName"></param>
        /// <param name="imageOptimizationType"></param>
        /// <param name="edgeConfigs"></param>
        /// <param name="edgeConfigSize"></param>
        /// <param name="edgeFunctionMaxSizeBytes"></param>
        /// <param name="edgeFunctionExecutionTimeoutMs"></param>
        /// <param name="serverlessFunctionMaxMemorySize"></param>
        /// <param name="kvDatabases"></param>
        /// <param name="postgresDatabases"></param>
        /// <param name="blobStores"></param>
        /// <param name="integrationStores"></param>
        /// <param name="cronJobsPerProject"></param>
        /// <param name="microfrontendGroupsPerTeam"></param>
        /// <param name="microfrontendProjectsPerGroup"></param>
        /// <param name="flagsExplorerOverridesThreshold"></param>
        /// <param name="flagsExplorerUnlimitedOverrides"></param>
        /// <param name="customEnvironmentsPerProject"></param>
        /// <param name="buildMachine"></param>
        /// <param name="security"></param>
        /// <param name="bulkRedirectsFreeLimitOverride"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerResourceConfig(
            string? nodeType,
            double? concurrentBuilds,
            bool? elasticConcurrencyEnabled,
            global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigBuildEntitlements? buildEntitlements,
            global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigBuildQueue? buildQueue,
            string? awsAccountType,
            global::System.Collections.Generic.IList<string>? awsAccountIds,
            string? cfZoneName,
            string? imageOptimizationType,
            double? edgeConfigs,
            double? edgeConfigSize,
            double? edgeFunctionMaxSizeBytes,
            double? edgeFunctionExecutionTimeoutMs,
            double? serverlessFunctionMaxMemorySize,
            double? kvDatabases,
            double? postgresDatabases,
            double? blobStores,
            double? integrationStores,
            double? cronJobsPerProject,
            double? microfrontendGroupsPerTeam,
            double? microfrontendProjectsPerGroup,
            double? flagsExplorerOverridesThreshold,
            bool? flagsExplorerUnlimitedOverrides,
            double? customEnvironmentsPerProject,
            global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigBuildMachine? buildMachine,
            global::Vercel.UserEventPayloadVariant114NewOwnerResourceConfigSecurity? security,
            double? bulkRedirectsFreeLimitOverride)
        {
            this.NodeType = nodeType;
            this.ConcurrentBuilds = concurrentBuilds;
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.BuildEntitlements = buildEntitlements;
            this.BuildQueue = buildQueue;
            this.AwsAccountType = awsAccountType;
            this.AwsAccountIds = awsAccountIds;
            this.CfZoneName = cfZoneName;
            this.ImageOptimizationType = imageOptimizationType;
            this.EdgeConfigs = edgeConfigs;
            this.EdgeConfigSize = edgeConfigSize;
            this.EdgeFunctionMaxSizeBytes = edgeFunctionMaxSizeBytes;
            this.EdgeFunctionExecutionTimeoutMs = edgeFunctionExecutionTimeoutMs;
            this.ServerlessFunctionMaxMemorySize = serverlessFunctionMaxMemorySize;
            this.KvDatabases = kvDatabases;
            this.PostgresDatabases = postgresDatabases;
            this.BlobStores = blobStores;
            this.IntegrationStores = integrationStores;
            this.CronJobsPerProject = cronJobsPerProject;
            this.MicrofrontendGroupsPerTeam = microfrontendGroupsPerTeam;
            this.MicrofrontendProjectsPerGroup = microfrontendProjectsPerGroup;
            this.FlagsExplorerOverridesThreshold = flagsExplorerOverridesThreshold;
            this.FlagsExplorerUnlimitedOverrides = flagsExplorerUnlimitedOverrides;
            this.CustomEnvironmentsPerProject = customEnvironmentsPerProject;
            this.BuildMachine = buildMachine;
            this.Security = security;
            this.BulkRedirectsFreeLimitOverride = bulkRedirectsFreeLimitOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerResourceConfig" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerResourceConfig()
        {
        }
    }
}