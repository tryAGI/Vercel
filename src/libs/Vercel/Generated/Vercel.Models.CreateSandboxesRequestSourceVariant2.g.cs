
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Download and extract a gzipped tarball into the sandbox.
    /// </summary>
    public sealed partial class CreateSandboxesRequestSourceVariant2
    {
        /// <summary>
        /// Indicates the source is a tarball.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// URL of a gzipped tarball (.tar.gz) to download and extract.<br/>
        /// Example: https://example.com/project.tar.gz
        /// </summary>
        /// <example>https://example.com/project.tar.gz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestSourceVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates the source is a tarball.
        /// </param>
        /// <param name="url">
        /// URL of a gzipped tarball (.tar.gz) to download and extract.<br/>
        /// Example: https://example.com/project.tar.gz
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesRequestSourceVariant2(
            object type,
            string url)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestSourceVariant2" /> class.
        /// </summary>
        public CreateSandboxesRequestSourceVariant2()
        {
        }
    }
}