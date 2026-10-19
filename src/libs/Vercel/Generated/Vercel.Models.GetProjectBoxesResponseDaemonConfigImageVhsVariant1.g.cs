
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonConfigImageVhsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant1Config? Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        public double? SizeInBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigImageVhsVariant1" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="path"></param>
        /// <param name="repositoryName"></param>
        /// <param name="config"></param>
        /// <param name="sizeInBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonConfigImageVhsVariant1(
            string digest,
            string path,
            string repositoryName,
            global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant1Config? config,
            double? sizeInBytes)
        {
            this.Config = config;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.RepositoryName = repositoryName ?? throw new global::System.ArgumentNullException(nameof(repositoryName));
            this.SizeInBytes = sizeInBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigImageVhsVariant1" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonConfigImageVhsVariant1()
        {
        }

    }
}