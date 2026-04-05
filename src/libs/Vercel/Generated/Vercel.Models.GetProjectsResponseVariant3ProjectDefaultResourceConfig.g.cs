
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectDefaultResourceConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        public bool? ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fluid")]
        public bool? Fluid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultRegions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FunctionDefaultRegions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultTimeout")]
        public double? FunctionDefaultTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultMemoryType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryTypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType? FunctionDefaultMemoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionZeroConfigFailover")]
        public bool? FunctionZeroConfigFailover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineTypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType? BuildMachineType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelectionJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection? BuildMachineSelection { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildQueue? BuildQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectDefaultResourceConfig" /> class.
        /// </summary>
        /// <param name="functionDefaultRegions"></param>
        /// <param name="elasticConcurrencyEnabled"></param>
        /// <param name="fluid"></param>
        /// <param name="functionDefaultTimeout"></param>
        /// <param name="functionDefaultMemoryType"></param>
        /// <param name="functionZeroConfigFailover"></param>
        /// <param name="buildMachineType"></param>
        /// <param name="buildMachineSelection"></param>
        /// <param name="buildMachineElasticLastUpdated"></param>
        /// <param name="isNSNBDisabled"></param>
        /// <param name="buildQueue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectDefaultResourceConfig(
            global::System.Collections.Generic.IList<string> functionDefaultRegions,
            bool? elasticConcurrencyEnabled,
            bool? fluid,
            double? functionDefaultTimeout,
            global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType? functionDefaultMemoryType,
            bool? functionZeroConfigFailover,
            global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineType? buildMachineType,
            global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection? buildMachineSelection,
            double? buildMachineElasticLastUpdated,
            bool? isNSNBDisabled,
            global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildQueue? buildQueue)
        {
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.Fluid = fluid;
            this.FunctionDefaultRegions = functionDefaultRegions ?? throw new global::System.ArgumentNullException(nameof(functionDefaultRegions));
            this.FunctionDefaultTimeout = functionDefaultTimeout;
            this.FunctionDefaultMemoryType = functionDefaultMemoryType;
            this.FunctionZeroConfigFailover = functionZeroConfigFailover;
            this.BuildMachineType = buildMachineType;
            this.BuildMachineSelection = buildMachineSelection;
            this.BuildMachineElasticLastUpdated = buildMachineElasticLastUpdated;
            this.IsNSNBDisabled = isNSNBDisabled;
            this.BuildQueue = buildQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectDefaultResourceConfig" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectDefaultResourceConfig()
        {
        }
    }
}