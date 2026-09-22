
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Function configuration scoped to this service.
    /// </summary>
    public sealed partial class AutoSDKShared7882ff81487eef12
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affinity")]
        public global::Vercel.AutoSDKShared7882ff81487eef12Affinity? Affinity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared7882ff81487eef12ArchitectureJsonConverter))]
        public global::Vercel.AutoSDKShared7882ff81487eef12Architecture? Architecture { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrency")]
        public double? MaxConcurrency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, global::Vercel.AutoSDKShared7882ff81487eef12MaxDuration?>))]
        public global::Vercel.OneOf<double?, global::Vercel.AutoSDKShared7882ff81487eef12MaxDuration?>? MaxDuration { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared7882ff81487eef12" /> class.
        /// </summary>
        /// <param name="affinity"></param>
        /// <param name="architecture"></param>
        /// <param name="excludeFiles"></param>
        /// <param name="experimentalTriggers"></param>
        /// <param name="functionFailoverRegions"></param>
        /// <param name="includeFiles"></param>
        /// <param name="maxConcurrency"></param>
        /// <param name="maxDuration"></param>
        /// <param name="memory"></param>
        /// <param name="regions"></param>
        /// <param name="runtime"></param>
        /// <param name="supportsCancellation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared7882ff81487eef12(
            global::Vercel.AutoSDKShared7882ff81487eef12Affinity? affinity,
            global::Vercel.AutoSDKShared7882ff81487eef12Architecture? architecture,
            string? excludeFiles,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda0db2c4b058f2749>? experimentalTriggers,
            global::System.Collections.Generic.IList<string>? functionFailoverRegions,
            string? includeFiles,
            double? maxConcurrency,
            global::Vercel.OneOf<double?, global::Vercel.AutoSDKShared7882ff81487eef12MaxDuration?>? maxDuration,
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
            this.MaxConcurrency = maxConcurrency;
            this.MaxDuration = maxDuration;
            this.Memory = memory;
            this.Regions = regions;
            this.Runtime = runtime;
            this.SupportsCancellation = supportsCancellation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7882ff81487eef12" /> class.
        /// </summary>
        public AutoSDKShared7882ff81487eef12()
        {
        }

    }
}