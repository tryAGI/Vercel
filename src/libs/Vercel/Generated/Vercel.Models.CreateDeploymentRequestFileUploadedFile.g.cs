
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Used in the case you want to reference a file that was already uploaded
    /// </summary>
    public sealed partial class CreateDeploymentRequestFileUploadedFile
    {
        /// <summary>
        /// The file path relative to the project root<br/>
        /// Example: folder/file.js
        /// </summary>
        /// <example>folder/file.js</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string File { get; set; }

        /// <summary>
        /// The file contents hashed with SHA1, used to check the integrity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The file size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestFileUploadedFile" /> class.
        /// </summary>
        /// <param name="file">
        /// The file path relative to the project root<br/>
        /// Example: folder/file.js
        /// </param>
        /// <param name="sha">
        /// The file contents hashed with SHA1, used to check the integrity
        /// </param>
        /// <param name="size">
        /// The file size in bytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestFileUploadedFile(
            string file,
            string? sha,
            int? size)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Sha = sha;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestFileUploadedFile" /> class.
        /// </summary>
        public CreateDeploymentRequestFileUploadedFile()
        {
        }
    }
}