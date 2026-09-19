
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListRepositoryTagsResponseTag
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        public string? Arch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListRepositoryTagsResponseTagKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListRepositoryTagsResponseTagKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifestDigest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestDigest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushedBy")]
        public string? PushedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListRepositoryTagsResponseTagStatusJsonConverter))]
        public global::Vercel.ListRepositoryTagsResponseTagStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoryTagsResponseTag" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="imageId"></param>
        /// <param name="kind"></param>
        /// <param name="manifestDigest"></param>
        /// <param name="sizeInBytes"></param>
        /// <param name="tag"></param>
        /// <param name="updatedAt"></param>
        /// <param name="arch"></param>
        /// <param name="platform"></param>
        /// <param name="pushedBy"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRepositoryTagsResponseTag(
            string createdAt,
            string imageId,
            global::Vercel.ListRepositoryTagsResponseTagKind kind,
            string manifestDigest,
            double sizeInBytes,
            string tag,
            string updatedAt,
            string? arch,
            string? platform,
            string? pushedBy,
            global::Vercel.ListRepositoryTagsResponseTagStatus? status)
        {
            this.Arch = arch;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.Kind = kind;
            this.ManifestDigest = manifestDigest ?? throw new global::System.ArgumentNullException(nameof(manifestDigest));
            this.Platform = platform;
            this.PushedBy = pushedBy;
            this.SizeInBytes = sizeInBytes;
            this.Status = status;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoryTagsResponseTag" /> class.
        /// </summary>
        public ListRepositoryTagsResponseTag()
        {
        }

    }
}