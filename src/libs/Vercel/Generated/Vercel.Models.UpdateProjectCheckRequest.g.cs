
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectCheckRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRerequestable")]
        public bool? IsRerequestable { get; set; }

        /// <summary>
        /// Default Value: deployment-url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectCheckRequestRequiresJsonConverter))]
        public global::Vercel.UpdateProjectCheckRequestRequires? Requires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<string>? Targets { get; set; }

        /// <summary>
        /// Default Value: deployment-alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectCheckRequestBlocksJsonConverter))]
        public global::Vercel.UpdateProjectCheckRequestBlocks? Blocks { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectCheckRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isRerequestable"></param>
        /// <param name="requires">
        /// Default Value: deployment-url
        /// </param>
        /// <param name="targets"></param>
        /// <param name="blocks">
        /// Default Value: deployment-alias
        /// </param>
        /// <param name="timeout">
        /// Default Value: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectCheckRequest(
            string? name,
            bool? isRerequestable,
            global::Vercel.UpdateProjectCheckRequestRequires? requires,
            global::System.Collections.Generic.IList<string>? targets,
            global::Vercel.UpdateProjectCheckRequestBlocks? blocks,
            double? timeout)
        {
            this.Name = name;
            this.IsRerequestable = isRerequestable;
            this.Requires = requires;
            this.Targets = targets;
            this.Blocks = blocks;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectCheckRequest" /> class.
        /// </summary>
        public UpdateProjectCheckRequest()
        {
        }
    }
}