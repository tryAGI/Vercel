
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A deployment file tree entry
    /// </summary>
    public sealed partial class FileTree
    {
        /// <summary>
        /// The name of the file tree entry<br/>
        /// Example: my-file.json
        /// </summary>
        /// <example>my-file.json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// String indicating the type of file tree entry.<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FileTreeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FileTreeType Type { get; set; }

        /// <summary>
        /// The unique identifier of the file (only valid for the `file` type)<br/>
        /// Example: 2d4aad419917f15b1146e9e03ddc9bb31747e4d0
        /// </summary>
        /// <example>2d4aad419917f15b1146e9e03ddc9bb31747e4d0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The list of children files of the directory (only valid for the `directory` type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::Vercel.FileTree>? Children { get; set; }

        /// <summary>
        /// The content-type of the file (only valid for the `file` type)<br/>
        /// Example: application/json
        /// </summary>
        /// <example>application/json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The file "mode" indicating file type and permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileTree" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the file tree entry<br/>
        /// Example: my-file.json
        /// </param>
        /// <param name="type">
        /// String indicating the type of file tree entry.<br/>
        /// Example: file
        /// </param>
        /// <param name="mode">
        /// The file "mode" indicating file type and permissions.
        /// </param>
        /// <param name="uid">
        /// The unique identifier of the file (only valid for the `file` type)<br/>
        /// Example: 2d4aad419917f15b1146e9e03ddc9bb31747e4d0
        /// </param>
        /// <param name="children">
        /// The list of children files of the directory (only valid for the `directory` type)
        /// </param>
        /// <param name="contentType">
        /// The content-type of the file (only valid for the `file` type)<br/>
        /// Example: application/json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileTree(
            string name,
            global::Vercel.FileTreeType type,
            double mode,
            string? uid,
            global::System.Collections.Generic.IList<global::Vercel.FileTree>? children,
            string? contentType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Uid = uid;
            this.Children = children;
            this.ContentType = contentType;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileTree" /> class.
        /// </summary>
        public FileTree()
        {
        }
    }
}