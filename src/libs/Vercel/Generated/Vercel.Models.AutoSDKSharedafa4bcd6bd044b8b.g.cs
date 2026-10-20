
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Function configuration scoped to this service.
    /// </summary>
    public sealed partial class AutoSDKSharedafa4bcd6bd044b8b
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affinity")]
        public global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinity? Affinity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedafa4bcd6bd044b8bArchitectureJsonConverter))]
        public global::Vercel.AutoSDKSharedafa4bcd6bd044b8bArchitecture? Architecture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeFiles")]
        public string? ExcludeFiles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentalTriggers")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda0db2c4b058f2749>? ExperimentalTriggers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionFailoverRegions")]
        public global::System.Collections.Generic.IList<string>? FunctionFailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeFiles")]
        public string? IncludeFiles { get; set; }

        /// <summary>
        /// Overrides how dependencies are installed for this function. An empty string skips the install. Only honored by `@vercel/node`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrency")]
        public double? MaxConcurrency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, global::Vercel.AutoSDKSharedafa4bcd6bd044b8bMaxDuration?>))]
        public global::Vercel.OneOf<double?, global::Vercel.AutoSDKSharedafa4bcd6bd044b8bMaxDuration?>? MaxDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedafa4bcd6bd044b8b" /> class.
        /// </summary>
        /// <param name="affinity"></param>
        /// <param name="architecture"></param>
        /// <param name="excludeFiles"></param>
        /// <param name="experimentalTriggers"></param>
        /// <param name="functionFailoverRegions"></param>
        /// <param name="includeFiles"></param>
        /// <param name="installCommand">
        /// Overrides how dependencies are installed for this function. An empty string skips the install. Only honored by `@vercel/node`.
        /// </param>
        /// <param name="maxConcurrency"></param>
        /// <param name="maxDuration"></param>
        /// <param name="memory"></param>
        /// <param name="regions"></param>
        /// <param name="runtime"></param>
        /// <param name="supportsCancellation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedafa4bcd6bd044b8b(
            global::Vercel.AutoSDKSharedafa4bcd6bd044b8bAffinity? affinity,
            global::Vercel.AutoSDKSharedafa4bcd6bd044b8bArchitecture? architecture,
            string? excludeFiles,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda0db2c4b058f2749>? experimentalTriggers,
            global::System.Collections.Generic.IList<string>? functionFailoverRegions,
            string? includeFiles,
            string? installCommand,
            double? maxConcurrency,
            global::Vercel.OneOf<double?, global::Vercel.AutoSDKSharedafa4bcd6bd044b8bMaxDuration?>? maxDuration,
            double? memory,
            global::System.Collections.Generic.IList<string>? regions,
            string? runtime,
            bool? supportsCancellation)
        {
            this.Affinity = affinity;
            this.Architecture = architecture;
            this.ExcludeFiles = excludeFiles;
            this.ExperimentalTriggers = experimentalTriggers;
            this.FunctionFailoverRegions = functionFailoverRegions;
            this.IncludeFiles = includeFiles;
            this.InstallCommand = installCommand;
            this.MaxConcurrency = maxConcurrency;
            this.MaxDuration = maxDuration;
            this.Memory = memory;
            this.Regions = regions;
            this.Runtime = runtime;
            this.SupportsCancellation = supportsCancellation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedafa4bcd6bd044b8b" /> class.
        /// </summary>
        public AutoSDKSharedafa4bcd6bd044b8b()
        {
        }

    }
}