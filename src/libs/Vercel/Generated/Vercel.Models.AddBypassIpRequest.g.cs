
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddBypassIpRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// If the specified bypass will apply to all domains for a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectScope")]
        public bool? ProjectScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceIp")]
        public string? SourceIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allSources")]
        public bool? AllSources { get; set; }

        /// <summary>
        /// Time to live in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpRequest" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="projectScope">
        /// If the specified bypass will apply to all domains for a project.
        /// </param>
        /// <param name="sourceIp"></param>
        /// <param name="allSources"></param>
        /// <param name="ttl">
        /// Time to live in milliseconds
        /// </param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddBypassIpRequest(
            string? domain,
            bool? projectScope,
            string? sourceIp,
            bool? allSources,
            double? ttl,
            string? note)
        {
            this.Domain = domain;
            this.ProjectScope = projectScope;
            this.SourceIp = sourceIp;
            this.AllSources = allSources;
            this.Ttl = ttl;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBypassIpRequest" /> class.
        /// </summary>
        public AddBypassIpRequest()
        {
        }
    }
}