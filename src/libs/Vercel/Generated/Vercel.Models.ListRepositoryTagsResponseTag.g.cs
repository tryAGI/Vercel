
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
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifestDigest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestDigest { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        public string? Arch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushedBy")]
        public string? PushedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListRepositoryTagsResponseTagStatusJsonConverter))]
        public global::Vercel.ListRepositoryTagsResponseTagStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

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
        /// <param name="tag"></param>
        /// <param name="manifestDigest"></param>
        /// <param name="imageId"></param>
        /// <param name="kind"></param>
        /// <param name="sizeInBytes"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="platform"></param>
        /// <param name="arch"></param>
        /// <param name="pushedBy"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRepositoryTagsResponseTag(
            string tag,
            string manifestDigest,
            string imageId,
            global::Vercel.ListRepositoryTagsResponseTagKind kind,
            double sizeInBytes,
            string createdAt,
            string updatedAt,
            string? platform,
            string? arch,
            string? pushedBy,
            global::Vercel.ListRepositoryTagsResponseTagStatus? status)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.ManifestDigest = manifestDigest ?? throw new global::System.ArgumentNullException(nameof(manifestDigest));
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.Kind = kind;
            this.Platform = platform;
            this.Arch = arch;
            this.PushedBy = pushedBy;
            this.Status = status;
            this.SizeInBytes = sizeInBytes;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
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