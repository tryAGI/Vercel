
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectTracing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public string? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignorePaths")]
        public global::System.Collections.Generic.IList<string>? IgnorePaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplingRules")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectTracingSamplingRule>? SamplingRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTracing" /> class.
        /// </summary>
        /// <param name="domains"></param>
        /// <param name="ignorePaths"></param>
        /// <param name="samplingRules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectTracing(
            string? domains,
            global::System.Collections.Generic.IList<string>? ignorePaths,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectTracingSamplingRule>? samplingRules)
        {
            this.Domains = domains;
            this.IgnorePaths = ignorePaths;
            this.SamplingRules = samplingRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTracing" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectTracing()
        {
        }
    }
}