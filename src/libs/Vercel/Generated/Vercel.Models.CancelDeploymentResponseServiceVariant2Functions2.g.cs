
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Function configuration scoped to this service.
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2Functions2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2FunctionsArchitectureJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsArchitecture? Architecture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsMaxDuration?>))]
        public global::Vercel.OneOf<double?, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsMaxDuration?>? MaxDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrency")]
        public double? MaxConcurrency { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant2, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3>>? ExperimentalTriggers { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Functions2" /> class.
        /// </summary>
        /// <param name="architecture"></param>
        /// <param name="memory"></param>
        /// <param name="maxDuration"></param>
        /// <param name="maxConcurrency"></param>
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
        public CancelDeploymentResponseServiceVariant2Functions2(
            global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsArchitecture? architecture,
            double? memory,
            global::Vercel.OneOf<double?, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsMaxDuration?>? maxDuration,
            double? maxConcurrency,
            global::System.Collections.Generic.IList<string>? regions,
            global::System.Collections.Generic.IList<string>? functionFailoverRegions,
            string? runtime,
            string? includeFiles,
            string? excludeFiles,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant2, global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3>>? experimentalTriggers,
            bool? supportsCancellation)
        {
            this.Architecture = architecture;
            this.Memory = memory;
            this.MaxDuration = maxDuration;
            this.MaxConcurrency = maxConcurrency;
            this.Regions = regions;
            this.FunctionFailoverRegions = functionFailoverRegions;
            this.Runtime = runtime;
            this.IncludeFiles = includeFiles;
            this.ExcludeFiles = excludeFiles;
            this.ExperimentalTriggers = experimentalTriggers;
            this.SupportsCancellation = supportsCancellation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Functions2" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2Functions2()
        {
        }

    }
}