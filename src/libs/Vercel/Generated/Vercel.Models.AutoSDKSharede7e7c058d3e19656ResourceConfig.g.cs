
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede7e7c058d3e19656ResourceConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticLastUpdated")]
        public double? BuildMachineElasticLastUpdated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticReasonJsonConverter))]
        public global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticReason? BuildMachineElasticReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticTransition")]
        public global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition? BuildMachineElasticTransition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelectionJsonConverter))]
        public global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection? BuildMachineSelection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineTypeJsonConverter))]
        public global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType? BuildMachineType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildQueue? BuildQueue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        public bool? ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableFunctionsBeta")]
        public bool? EnableFunctionsBeta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fluid")]
        public bool? Fluid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultMemoryType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryTypeJsonConverter))]
        public global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType? FunctionDefaultMemoryType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("functionZeroConfigFailover")]
        public bool? FunctionZeroConfigFailover { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharede7e7c058d3e19656ResourceConfig" /> class.
        /// </summary>
        /// <param name="functionDefaultRegions"></param>
        /// <param name="buildMachineElasticLastUpdated"></param>
        /// <param name="buildMachineElasticReason"></param>
        /// <param name="buildMachineElasticTransition"></param>
        /// <param name="buildMachineSelection"></param>
        /// <param name="buildMachineType"></param>
        /// <param name="buildQueue"></param>
        /// <param name="elasticConcurrencyEnabled"></param>
        /// <param name="enableFunctionsBeta"></param>
        /// <param name="fluid"></param>
        /// <param name="functionDefaultMemoryType"></param>
        /// <param name="functionDefaultTimeout"></param>
        /// <param name="functionZeroConfigFailover"></param>
        /// <param name="isNSNBDisabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede7e7c058d3e19656ResourceConfig(
            global::System.Collections.Generic.IList<string> functionDefaultRegions,
            double? buildMachineElasticLastUpdated,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticReason? buildMachineElasticReason,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition? buildMachineElasticTransition,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection? buildMachineSelection,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineType? buildMachineType,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildQueue? buildQueue,
            bool? elasticConcurrencyEnabled,
            bool? enableFunctionsBeta,
            bool? fluid,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType? functionDefaultMemoryType,
            double? functionDefaultTimeout,
            bool? functionZeroConfigFailover,
            bool? isNSNBDisabled)
        {
            this.BuildMachineElasticLastUpdated = buildMachineElasticLastUpdated;
            this.BuildMachineElasticReason = buildMachineElasticReason;
            this.BuildMachineElasticTransition = buildMachineElasticTransition;
            this.BuildMachineSelection = buildMachineSelection;
            this.BuildMachineType = buildMachineType;
            this.BuildQueue = buildQueue;
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.EnableFunctionsBeta = enableFunctionsBeta;
            this.Fluid = fluid;
            this.FunctionDefaultMemoryType = functionDefaultMemoryType;
            this.FunctionDefaultRegions = functionDefaultRegions ?? throw new global::System.ArgumentNullException(nameof(functionDefaultRegions));
            this.FunctionDefaultTimeout = functionDefaultTimeout;
            this.FunctionZeroConfigFailover = functionZeroConfigFailover;
            this.IsNSNBDisabled = isNSNBDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7e7c058d3e19656ResourceConfig" /> class.
        /// </summary>
        public AutoSDKSharede7e7c058d3e19656ResourceConfig()
        {
        }

    }
}