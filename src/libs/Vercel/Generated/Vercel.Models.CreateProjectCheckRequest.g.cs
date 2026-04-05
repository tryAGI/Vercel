
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectCheckRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRerequestable")]
        public bool? IsRerequestable { get; set; }

        /// <summary>
        /// Default Value: deployment-url
        /// </summary>
        /// <default>global::Vercel.CreateProjectCheckRequestRequires.DeploymentUrl</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectCheckRequestRequiresJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectCheckRequestRequires Requires { get; set; } = global::Vercel.CreateProjectCheckRequestRequires.DeploymentUrl;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<string>? Targets { get; set; }

        /// <summary>
        /// Default Value: deployment-alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectCheckRequestBlocksJsonConverter))]
        public global::Vercel.CreateProjectCheckRequestBlocks? Blocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateProjectCheckRequestSourceVariant1, global::Vercel.CreateProjectCheckRequestSourceVariant2, global::Vercel.CreateProjectCheckRequestSourceVariant3>))]
        public global::Vercel.OneOf<global::Vercel.CreateProjectCheckRequestSourceVariant1, global::Vercel.CreateProjectCheckRequestSourceVariant2, global::Vercel.CreateProjectCheckRequestSourceVariant3>? Source { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateProjectCheckRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requires">
        /// Default Value: deployment-url
        /// </param>
        /// <param name="isRerequestable"></param>
        /// <param name="targets"></param>
        /// <param name="blocks">
        /// Default Value: deployment-alias
        /// </param>
        /// <param name="source"></param>
        /// <param name="timeout">
        /// Default Value: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectCheckRequest(
            string name,
            global::Vercel.CreateProjectCheckRequestRequires requires,
            bool? isRerequestable,
            global::System.Collections.Generic.IList<string>? targets,
            global::Vercel.CreateProjectCheckRequestBlocks? blocks,
            global::Vercel.OneOf<global::Vercel.CreateProjectCheckRequestSourceVariant1, global::Vercel.CreateProjectCheckRequestSourceVariant2, global::Vercel.CreateProjectCheckRequestSourceVariant3>? source,
            double? timeout)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsRerequestable = isRerequestable;
            this.Requires = requires;
            this.Targets = targets;
            this.Blocks = blocks;
            this.Source = source;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCheckRequest" /> class.
        /// </summary>
        public CreateProjectCheckRequest()
        {
        }
    }
}