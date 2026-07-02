
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A tag pointing at an image in a Vercel Container Registry repository, enriched with the backing image's metadata and VHS-readiness status.
    /// </summary>
    public sealed partial class VcrTag
    {
        /// <summary>
        /// The tag name.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// SHA-256 digest of the image manifest the tag points at.<br/>
        /// Example: sha256:2c4e8f3a1b9d0e5c7a6f4b2d8e1c9a0b3d5f7e9c1a2b4d6f8e0c2a4b6d8f0e2c
        /// </summary>
        /// <example>sha256:2c4e8f3a1b9d0e5c7a6f4b2d8e1c9a0b3d5f7e9c1a2b4d6f8e0c2a4b6d8f0e2c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifestDigest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestDigest { get; set; }

        /// <summary>
        /// Internal identifier of the image the tag points at.<br/>
        /// Example: img_a1b2c3d4e5f6
        /// </summary>
        /// <example>img_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

        /// <summary>
        /// Whether the manifest is a multi-platform image index or a single-platform image manifest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrTagKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrTagKind Kind { get; set; }

        /// <summary>
        /// Operating system the manifest targets. Only present for single-platform manifests.<br/>
        /// Example: linux
        /// </summary>
        /// <example>linux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// CPU architecture the manifest targets. Only present for single-platform manifests.<br/>
        /// Example: amd64
        /// </summary>
        /// <example>amd64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arch")]
        public string? Arch { get; set; }

        /// <summary>
        /// Identifier of the actor that pushed the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushedBy")]
        public string? PushedBy { get; set; }

        /// <summary>
        /// VHS-readiness status, or `null` for a multi-platform index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrTagStatusJsonConverter))]
        public global::Vercel.VcrTagStatus? Status { get; set; }

        /// <summary>
        /// Total size in bytes of the image's resources (manifest, config and layer blobs) stored by the registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the tag was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </summary>
        /// <example>2026-06-30T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the tag was last updated.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </summary>
        /// <example>2026-06-30T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrTag" /> class.
        /// </summary>
        /// <param name="tag">
        /// The tag name.<br/>
        /// Example: latest
        /// </param>
        /// <param name="manifestDigest">
        /// SHA-256 digest of the image manifest the tag points at.<br/>
        /// Example: sha256:2c4e8f3a1b9d0e5c7a6f4b2d8e1c9a0b3d5f7e9c1a2b4d6f8e0c2a4b6d8f0e2c
        /// </param>
        /// <param name="imageId">
        /// Internal identifier of the image the tag points at.<br/>
        /// Example: img_a1b2c3d4e5f6
        /// </param>
        /// <param name="kind">
        /// Whether the manifest is a multi-platform image index or a single-platform image manifest.
        /// </param>
        /// <param name="sizeInBytes">
        /// Total size in bytes of the image's resources (manifest, config and layer blobs) stored by the registry.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the tag was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the tag was last updated.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </param>
        /// <param name="platform">
        /// Operating system the manifest targets. Only present for single-platform manifests.<br/>
        /// Example: linux
        /// </param>
        /// <param name="arch">
        /// CPU architecture the manifest targets. Only present for single-platform manifests.<br/>
        /// Example: amd64
        /// </param>
        /// <param name="pushedBy">
        /// Identifier of the actor that pushed the image.
        /// </param>
        /// <param name="status">
        /// VHS-readiness status, or `null` for a multi-platform index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrTag(
            string tag,
            string manifestDigest,
            string imageId,
            global::Vercel.VcrTagKind kind,
            double sizeInBytes,
            string createdAt,
            string updatedAt,
            string? platform,
            string? arch,
            string? pushedBy,
            global::Vercel.VcrTagStatus? status)
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
        /// Initializes a new instance of the <see cref="VcrTag" /> class.
        /// </summary>
        public VcrTag()
        {
        }

    }
}