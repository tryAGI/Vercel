
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Used in the case you want to inline a file inside the request
    /// </summary>
    public sealed partial class CreateDeploymentRequestFileInlinedFile
    {
        /// <summary>
        /// The file content, it could be either a `base64` (useful for images, etc.) of the files or the plain content for source code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The file content encoding, it could be either a base64 (useful for images, etc.) of the files or the plain text for source code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestFileInlinedFileEncodingJsonConverter))]
        public global::Vercel.CreateDeploymentRequestFileInlinedFileEncoding? Encoding { get; set; }

        /// <summary>
        /// The file name including the whole path<br/>
        /// Example: folder/file.js
        /// </summary>
        /// <example>folder/file.js</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestFileInlinedFile" /> class.
        /// </summary>
        /// <param name="data">
        /// The file content, it could be either a `base64` (useful for images, etc.) of the files or the plain content for source code
        /// </param>
        /// <param name="file">
        /// The file name including the whole path<br/>
        /// Example: folder/file.js
        /// </param>
        /// <param name="encoding">
        /// The file content encoding, it could be either a base64 (useful for images, etc.) of the files or the plain text for source code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestFileInlinedFile(
            string data,
            string file,
            global::Vercel.CreateDeploymentRequestFileInlinedFileEncoding? encoding)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Encoding = encoding;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestFileInlinedFile" /> class.
        /// </summary>
        public CreateDeploymentRequestFileInlinedFile()
        {
        }
    }
}