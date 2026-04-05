
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDirectoryRequest
    {
        /// <summary>
        /// The base directory for resolving relative paths. If not specified, paths are resolved from the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </summary>
        /// <example>/home/vercel-sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// The path of the directory to create. Can be absolute or relative to the working directory.<br/>
        /// Example: src/components
        /// </summary>
        /// <example>src/components</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// If true, creates parent directories as needed (like `mkdir -p`). If false, fails if parent directories do not exist.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recursive")]
        public bool? Recursive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDirectoryRequest" /> class.
        /// </summary>
        /// <param name="path">
        /// The path of the directory to create. Can be absolute or relative to the working directory.<br/>
        /// Example: src/components
        /// </param>
        /// <param name="cwd">
        /// The base directory for resolving relative paths. If not specified, paths are resolved from the sandbox home directory.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="recursive">
        /// If true, creates parent directories as needed (like `mkdir -p`). If false, fails if parent directories do not exist.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDirectoryRequest(
            string path,
            string? cwd,
            bool? recursive)
        {
            this.Cwd = cwd;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Recursive = recursive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDirectoryRequest" /> class.
        /// </summary>
        public CreateDirectoryRequest()
        {
        }
    }
}