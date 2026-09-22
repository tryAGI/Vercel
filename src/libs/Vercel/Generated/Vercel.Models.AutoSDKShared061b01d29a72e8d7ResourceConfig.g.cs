
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared061b01d29a72e8d7ResourceConfig
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineElasticReasonJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineElasticReason? BuildMachineElasticReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticTransition")]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineElasticTransition? BuildMachineElasticTransition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineSelectionJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineSelection? BuildMachineSelection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineTypeJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType? BuildMachineType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildQueue? BuildQueue { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7ResourceConfigFunctionDefaultMemoryTypeJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigFunctionDefaultMemoryType? FunctionDefaultMemoryType { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7ResourceConfig" /> class.
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
        public AutoSDKShared061b01d29a72e8d7ResourceConfig(
            global::System.Collections.Generic.IList<string> functionDefaultRegions,
            double? buildMachineElasticLastUpdated,
            global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineElasticReason? buildMachineElasticReason,
            global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineElasticTransition? buildMachineElasticTransition,
            global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineSelection? buildMachineSelection,
            global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildMachineType? buildMachineType,
            global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigBuildQueue? buildQueue,
            bool? elasticConcurrencyEnabled,
            bool? enableFunctionsBeta,
            bool? fluid,
            global::Vercel.AutoSDKShared061b01d29a72e8d7ResourceConfigFunctionDefaultMemoryType? functionDefaultMemoryType,
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
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7ResourceConfig" /> class.
        /// </summary>
        public AutoSDKShared061b01d29a72e8d7ResourceConfig()
        {
        }

    }
}