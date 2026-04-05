
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specifies resource override configuration for the project
    /// </summary>
    public sealed partial class UpdateProjectRequestResourceConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestResourceConfigBuildMachineTypeJsonConverter))]
        public global::Vercel.UpdateProjectRequestResourceConfigBuildMachineType? BuildMachineType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.UpdateProjectRequestResourceConfigBuildQueue? BuildQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fluid")]
        public bool? Fluid { get; set; }

        /// <summary>
        /// The regions to deploy Vercel Functions to for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultRegions")]
        public global::System.Collections.Generic.IList<string>? FunctionDefaultRegions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultTimeout")]
        public double? FunctionDefaultTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultMemoryType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestResourceConfigFunctionDefaultMemoryTypeJsonConverter))]
        public global::Vercel.UpdateProjectRequestResourceConfigFunctionDefaultMemoryType? FunctionDefaultMemoryType { get; set; }

        /// <summary>
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionZeroConfigFailover")]
        public bool? FunctionZeroConfigFailover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        public bool? ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestResourceConfigBuildMachineSelectionJsonConverter))]
        public global::Vercel.UpdateProjectRequestResourceConfigBuildMachineSelection? BuildMachineSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticLastUpdated")]
        public double? BuildMachineElasticLastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isNSNBDisabled")]
        public bool? IsNSNBDisabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestResourceConfig" /> class.
        /// </summary>
        /// <param name="buildMachineType"></param>
        /// <param name="buildQueue"></param>
        /// <param name="fluid"></param>
        /// <param name="functionDefaultRegions">
        /// The regions to deploy Vercel Functions to for this project
        /// </param>
        /// <param name="functionDefaultTimeout"></param>
        /// <param name="functionDefaultMemoryType"></param>
        /// <param name="functionZeroConfigFailover">
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </param>
        /// <param name="elasticConcurrencyEnabled"></param>
        /// <param name="buildMachineSelection"></param>
        /// <param name="buildMachineElasticLastUpdated"></param>
        /// <param name="isNSNBDisabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestResourceConfig(
            global::Vercel.UpdateProjectRequestResourceConfigBuildMachineType? buildMachineType,
            global::Vercel.UpdateProjectRequestResourceConfigBuildQueue? buildQueue,
            bool? fluid,
            global::System.Collections.Generic.IList<string>? functionDefaultRegions,
            double? functionDefaultTimeout,
            global::Vercel.UpdateProjectRequestResourceConfigFunctionDefaultMemoryType? functionDefaultMemoryType,
            bool? functionZeroConfigFailover,
            bool? elasticConcurrencyEnabled,
            global::Vercel.UpdateProjectRequestResourceConfigBuildMachineSelection? buildMachineSelection,
            double? buildMachineElasticLastUpdated,
            bool? isNSNBDisabled)
        {
            this.BuildMachineType = buildMachineType;
            this.BuildQueue = buildQueue;
            this.Fluid = fluid;
            this.FunctionDefaultRegions = functionDefaultRegions;
            this.FunctionDefaultTimeout = functionDefaultTimeout;
            this.FunctionDefaultMemoryType = functionDefaultMemoryType;
            this.FunctionZeroConfigFailover = functionZeroConfigFailover;
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.BuildMachineSelection = buildMachineSelection;
            this.BuildMachineElasticLastUpdated = buildMachineElasticLastUpdated;
            this.IsNSNBDisabled = isNSNBDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestResourceConfig" /> class.
        /// </summary>
        public UpdateProjectRequestResourceConfig()
        {
        }
    }
}