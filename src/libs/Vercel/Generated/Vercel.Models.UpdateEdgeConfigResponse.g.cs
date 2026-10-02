
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A Global Config
    /// </summary>
    public sealed partial class UpdateEdgeConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The ID of the user who created the Global Config, optional because it is not always set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        /// Name for the Global Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEdgeConfigResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="digest"></param>
        /// <param name="id"></param>
        /// <param name="itemCount"></param>
        /// <param name="ownerId"></param>
        /// <param name="sizeInBytes"></param>
        /// <param name="slug">
        /// Name for the Global Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="createdBy">
        /// The ID of the user who created the Global Config, optional because it is not always set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEdgeConfigResponse(
            double createdAt,
            string digest,
            string id,
            double itemCount,
            string ownerId,
            double sizeInBytes,
            string slug,
            double updatedAt,
            string? createdBy)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ItemCount = itemCount;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.SizeInBytes = sizeInBytes;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEdgeConfigResponse" /> class.
        /// </summary>
        public UpdateEdgeConfigResponse()
        {
        }

    }
}