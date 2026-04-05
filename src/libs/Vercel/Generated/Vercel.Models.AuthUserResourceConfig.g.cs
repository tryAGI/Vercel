
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public sealed partial class AuthUserResourceConfig
    {
        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeType")]
        public string? NodeType { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentBuilds")]
        public double? ConcurrentBuilds { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        public bool? ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildEntitlements")]
        public global::Vercel.AuthUserResourceConfigBuildEntitlements? BuildEntitlements { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.AuthUserResourceConfigBuildQueue? BuildQueue { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccountType")]
        public string? AwsAccountType { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccountIds")]
        public global::System.Collections.Generic.IList<string>? AwsAccountIds { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfZoneName")]
        public string? CfZoneName { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptimizationType")]
        public string? ImageOptimizationType { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigs")]
        public double? EdgeConfigs { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigSize")]
        public double? EdgeConfigSize { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeFunctionMaxSizeBytes")]
        public double? EdgeFunctionMaxSizeBytes { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeFunctionExecutionTimeoutMs")]
        public double? EdgeFunctionExecutionTimeoutMs { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionMaxMemorySize")]
        public double? ServerlessFunctionMaxMemorySize { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kvDatabases")]
        public double? KvDatabases { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgresDatabases")]
        public double? PostgresDatabases { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobStores")]
        public double? BlobStores { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationStores")]
        public double? IntegrationStores { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cronJobsPerProject")]
        public double? CronJobsPerProject { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendGroupsPerTeam")]
        public double? MicrofrontendGroupsPerTeam { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontendProjectsPerGroup")]
        public double? MicrofrontendProjectsPerGroup { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagsExplorerOverridesThreshold")]
        public double? FlagsExplorerOverridesThreshold { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagsExplorerUnlimitedOverrides")]
        public bool? FlagsExplorerUnlimitedOverrides { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentsPerProject")]
        public double? CustomEnvironmentsPerProject { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachine")]
        public global::Vercel.AuthUserResourceConfigBuildMachine? BuildMachine { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.AuthUserResourceConfigSecurity? Security { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulkRedirectsFreeLimitOverride")]
        public double? BulkRedirectsFreeLimitOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfig" /> class.
        /// </summary>
        /// <param name="nodeType">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="concurrentBuilds">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="elasticConcurrencyEnabled">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="buildEntitlements">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="buildQueue">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="awsAccountType">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="awsAccountIds">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="cfZoneName">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="imageOptimizationType">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="edgeConfigs">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="edgeConfigSize">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="edgeFunctionMaxSizeBytes">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="edgeFunctionExecutionTimeoutMs">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="serverlessFunctionMaxMemorySize">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="kvDatabases">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="postgresDatabases">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="blobStores">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="integrationStores">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="cronJobsPerProject">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="microfrontendGroupsPerTeam">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="microfrontendProjectsPerGroup">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="flagsExplorerOverridesThreshold">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="flagsExplorerUnlimitedOverrides">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="customEnvironmentsPerProject">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="buildMachine">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="security">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="bulkRedirectsFreeLimitOverride">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserResourceConfig(
            string? nodeType,
            double? concurrentBuilds,
            bool? elasticConcurrencyEnabled,
            global::Vercel.AuthUserResourceConfigBuildEntitlements? buildEntitlements,
            global::Vercel.AuthUserResourceConfigBuildQueue? buildQueue,
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
            global::Vercel.AuthUserResourceConfigBuildMachine? buildMachine,
            global::Vercel.AuthUserResourceConfigSecurity? security,
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
        /// Initializes a new instance of the <see cref="AuthUserResourceConfig" /> class.
        /// </summary>
        public AuthUserResourceConfig()
        {
        }
    }
}