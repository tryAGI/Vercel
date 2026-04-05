
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadSessionFileRequest
    {
        /// <summary>
        /// The base directory for resolving relative paths. If not specified, paths are resolved from the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </summary>
        /// <example>/home/vercel-sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// The path of the file to read. Can be absolute or relative to the working directory.<br/>
        /// Example: dist/agent-output.md
        /// </summary>
        /// <example>dist/agent-output.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadSessionFileRequest" /> class.
        /// </summary>
        /// <param name="path">
        /// The path of the file to read. Can be absolute or relative to the working directory.<br/>
        /// Example: dist/agent-output.md
        /// </param>
        /// <param name="cwd">
        /// The base directory for resolving relative paths. If not specified, paths are resolved from the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadSessionFileRequest(
            string path,
            string? cwd)
        {
            this.Cwd = cwd;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadSessionFileRequest" /> class.
        /// </summary>
        public ReadSessionFileRequest()
        {
        }
    }
}