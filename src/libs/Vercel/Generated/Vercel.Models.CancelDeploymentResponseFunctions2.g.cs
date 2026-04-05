
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseFunctions2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseFunctionsArchitectureJsonConverter))]
        public global::Vercel.CancelDeploymentResponseFunctionsArchitecture? Architecture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, global::Vercel.CancelDeploymentResponseFunctionsMaxDuration?>))]
        public global::Vercel.OneOf<double?, global::Vercel.CancelDeploymentResponseFunctionsMaxDuration?>? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionFailoverRegions")]
        public global::System.Collections.Generic.IList<string>? FunctionFailoverRegions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeFiles")]
        public string? IncludeFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeFiles")]
        public string? ExcludeFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentalTriggers")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseFunctionsExperimentalTriggerVariant1, global::Vercel.CancelDeploymentResponseFunctionsExperimentalTriggerVariant2>>? ExperimentalTriggers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsCancellation")]
        public bool? SupportsCancellation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseFunctions2" /> class.
        /// </summary>
        /// <param name="architecture"></param>
        /// <param name="memory"></param>
        /// <param name="maxDuration"></param>
        /// <param name="regions"></param>
        /// <param name="functionFailoverRegions"></param>
        /// <param name="runtime"></param>
        /// <param name="includeFiles"></param>
        /// <param name="excludeFiles"></param>
        /// <param name="experimentalTriggers"></param>
        /// <param name="supportsCancellation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseFunctions2(
            global::Vercel.CancelDeploymentResponseFunctionsArchitecture? architecture,
            double? memory,
            global::Vercel.OneOf<double?, global::Vercel.CancelDeploymentResponseFunctionsMaxDuration?>? maxDuration,
            global::System.Collections.Generic.IList<string>? regions,
            global::System.Collections.Generic.IList<string>? functionFailoverRegions,
            string? runtime,
            string? includeFiles,
            string? excludeFiles,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseFunctionsExperimentalTriggerVariant1, global::Vercel.CancelDeploymentResponseFunctionsExperimentalTriggerVariant2>>? experimentalTriggers,
            bool? supportsCancellation)
        {
            this.Architecture = architecture;
            this.Memory = memory;
            this.MaxDuration = maxDuration;
            this.Regions = regions;
            this.FunctionFailoverRegions = functionFailoverRegions;
            this.Runtime = runtime;
            this.IncludeFiles = includeFiles;
            this.ExcludeFiles = excludeFiles;
            this.ExperimentalTriggers = experimentalTriggers;
            this.SupportsCancellation = supportsCancellation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseFunctions2" /> class.
        /// </summary>
        public CancelDeploymentResponseFunctions2()
        {
        }
    }
}