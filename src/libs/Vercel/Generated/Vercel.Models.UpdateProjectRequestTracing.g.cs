
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Tracing configuration for this project
    /// </summary>
    public sealed partial class UpdateProjectRequestTracing
    {
        /// <summary>
        /// Comma-separated list of drain endpoint domains
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public string? Domains { get; set; }

        /// <summary>
        /// Paths to ignore for tracing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignorePaths")]
        public global::System.Collections.Generic.IList<string>? IgnorePaths { get; set; }

        /// <summary>
        /// Sampling rules for trace collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplingRules")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTracingSamplingRule>? SamplingRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTracing" /> class.
        /// </summary>
        /// <param name="domains">
        /// Comma-separated list of drain endpoint domains
        /// </param>
        /// <param name="ignorePaths">
        /// Paths to ignore for tracing
        /// </param>
        /// <param name="samplingRules">
        /// Sampling rules for trace collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTracing(
            string? domains,
            global::System.Collections.Generic.IList<string>? ignorePaths,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTracingSamplingRule>? samplingRules)
        {
            this.Domains = domains;
            this.IgnorePaths = ignorePaths;
            this.SamplingRules = samplingRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTracing" /> class.
        /// </summary>
        public UpdateProjectRequestTracing()
        {
        }
    }
}