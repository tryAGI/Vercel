
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project resource config returned by the API. `buildMachineType` is a fixed machine type or `elastic`; the active Elastic machine is reported through `elasticBuildMachine`.
    /// </summary>
    public sealed partial class AutoSDKSharedd67d8d405d3f0000
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReasonJsonConverter))]
        public global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason? BuildMachineElasticReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineElasticTransition")]
        public global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransition? BuildMachineElasticTransition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd67d8d405d3f0000BuildMachineSelectionJsonConverter))]
        public global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineSelection? BuildMachineSelection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildQueue? BuildQueue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticBuildMachine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant1, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant2, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant1, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant2, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4>? ElasticBuildMachine { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType? FunctionDefaultMemoryType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd67d8d405d3f0000BuildMachineTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineType? BuildMachineType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd67d8d405d3f0000" /> class.
        /// </summary>
        /// <param name="functionDefaultRegions"></param>
        /// <param name="buildMachineElasticLastUpdated"></param>
        /// <param name="buildMachineElasticReason"></param>
        /// <param name="buildMachineElasticTransition"></param>
        /// <param name="buildMachineSelection"></param>
        /// <param name="buildQueue"></param>
        /// <param name="elasticBuildMachine"></param>
        /// <param name="elasticConcurrencyEnabled"></param>
        /// <param name="enableFunctionsBeta"></param>
        /// <param name="fluid"></param>
        /// <param name="functionDefaultMemoryType"></param>
        /// <param name="functionDefaultTimeout"></param>
        /// <param name="functionZeroConfigFailover"></param>
        /// <param name="isNSNBDisabled"></param>
        /// <param name="buildMachineType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd67d8d405d3f0000(
            global::System.Collections.Generic.IList<string> functionDefaultRegions,
            double? buildMachineElasticLastUpdated,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineElasticReason? buildMachineElasticReason,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransition? buildMachineElasticTransition,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineSelection? buildMachineSelection,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildQueue? buildQueue,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant1, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant2, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3, global::Vercel.AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4>? elasticBuildMachine,
            bool? elasticConcurrencyEnabled,
            bool? enableFunctionsBeta,
            bool? fluid,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType? functionDefaultMemoryType,
            double? functionDefaultTimeout,
            bool? functionZeroConfigFailover,
            bool? isNSNBDisabled,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000BuildMachineType? buildMachineType)
        {
            this.BuildMachineElasticLastUpdated = buildMachineElasticLastUpdated;
            this.BuildMachineElasticReason = buildMachineElasticReason;
            this.BuildMachineElasticTransition = buildMachineElasticTransition;
            this.BuildMachineSelection = buildMachineSelection;
            this.BuildQueue = buildQueue;
            this.ElasticBuildMachine = elasticBuildMachine;
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.EnableFunctionsBeta = enableFunctionsBeta;
            this.Fluid = fluid;
            this.FunctionDefaultMemoryType = functionDefaultMemoryType;
            this.FunctionDefaultRegions = functionDefaultRegions ?? throw new global::System.ArgumentNullException(nameof(functionDefaultRegions));
            this.FunctionDefaultTimeout = functionDefaultTimeout;
            this.FunctionZeroConfigFailover = functionZeroConfigFailover;
            this.IsNSNBDisabled = isNSNBDisabled;
            this.BuildMachineType = buildMachineType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd67d8d405d3f0000" /> class.
        /// </summary>
        public AutoSDKSharedd67d8d405d3f0000()
        {
        }

    }
}