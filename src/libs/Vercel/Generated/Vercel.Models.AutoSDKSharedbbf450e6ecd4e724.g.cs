
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbbf450e6ecd4e724
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReasonJsonConverter))]
        public global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason? BuildMachineElasticReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticTransition")]
        public global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticTransition? BuildMachineElasticTransition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbbf450e6ecd4e724BuildMachineSelectionJsonConverter))]
        public global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineSelection? BuildMachineSelection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbbf450e6ecd4e724BuildMachineTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineType? BuildMachineType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildQueue? BuildQueue { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType? FunctionDefaultMemoryType { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticBuildMachine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant1, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant1, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4>? ElasticBuildMachine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbbf450e6ecd4e724" /> class.
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
        /// <param name="elasticBuildMachine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbbf450e6ecd4e724(
            global::System.Collections.Generic.IList<string> functionDefaultRegions,
            double? buildMachineElasticLastUpdated,
            global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticReason? buildMachineElasticReason,
            global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineElasticTransition? buildMachineElasticTransition,
            global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineSelection? buildMachineSelection,
            global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildMachineType? buildMachineType,
            global::Vercel.AutoSDKSharedbbf450e6ecd4e724BuildQueue? buildQueue,
            bool? elasticConcurrencyEnabled,
            bool? enableFunctionsBeta,
            bool? fluid,
            global::Vercel.AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType? functionDefaultMemoryType,
            double? functionDefaultTimeout,
            bool? functionZeroConfigFailover,
            bool? isNSNBDisabled,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant1, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3, global::Vercel.AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4>? elasticBuildMachine)
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
            this.ElasticBuildMachine = elasticBuildMachine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbbf450e6ecd4e724" /> class.
        /// </summary>
        public AutoSDKSharedbbf450e6ecd4e724()
        {
        }

    }
}