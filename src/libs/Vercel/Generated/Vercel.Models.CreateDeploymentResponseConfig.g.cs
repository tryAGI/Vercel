
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since February 2025 the configuration must include snapshot data at the time of deployment creation to capture properties for the /deployments/:id/config endpoint utilized for displaying Deployment Configuration on the frontend This is optional because older deployments may not have this data captured
    /// </summary>
    public sealed partial class CreateDeploymentResponseConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseConfigFunctionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseConfigFunctionType FunctionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionMemoryType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseConfigFunctionMemoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseConfigFunctionMemoryType FunctionMemoryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionTimeout")]
        public double? FunctionTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secureComputePrimaryRegion")]
        public string? SecureComputePrimaryRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secureComputeFallbackRegion")]
        public string? SecureComputeFallbackRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUsingActiveCPU")]
        public bool? IsUsingActiveCPU { get; set; }

        /// <summary>
        /// Build resource configuration snapshot for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.CreateDeploymentResponseConfigResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseConfig" /> class.
        /// </summary>
        /// <param name="functionType"></param>
        /// <param name="functionMemoryType"></param>
        /// <param name="version"></param>
        /// <param name="functionTimeout"></param>
        /// <param name="secureComputePrimaryRegion"></param>
        /// <param name="secureComputeFallbackRegion"></param>
        /// <param name="isUsingActiveCPU"></param>
        /// <param name="resourceConfig">
        /// Build resource configuration snapshot for this deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseConfig(
            global::Vercel.CreateDeploymentResponseConfigFunctionType functionType,
            global::Vercel.CreateDeploymentResponseConfigFunctionMemoryType functionMemoryType,
            double? version,
            double? functionTimeout,
            string? secureComputePrimaryRegion,
            string? secureComputeFallbackRegion,
            bool? isUsingActiveCPU,
            global::Vercel.CreateDeploymentResponseConfigResourceConfig? resourceConfig)
        {
            this.Version = version;
            this.FunctionType = functionType;
            this.FunctionMemoryType = functionMemoryType;
            this.FunctionTimeout = functionTimeout;
            this.SecureComputePrimaryRegion = secureComputePrimaryRegion;
            this.SecureComputeFallbackRegion = secureComputeFallbackRegion;
            this.IsUsingActiveCPU = isUsingActiveCPU;
            this.ResourceConfig = resourceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseConfig" /> class.
        /// </summary>
        public CreateDeploymentResponseConfig()
        {
        }
    }
}