
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A single image with its tags, status and resolved Dockerfile layer history.
    /// </summary>
    public sealed partial class VcrImageDetail
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.VcrImageLayer> Layers { get; set; }

        /// <summary>
        /// Tags pointing at this image's manifest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Internal identifier of the image.<br/>
        /// Example: img_a1b2c3d4e5f6
        /// </summary>
        /// <example>img_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the repository the image belongs to.<br/>
        /// Example: repo_a1b2c3d4e5f6
        /// </summary>
        /// <example>repo_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryId { get; set; }

        /// <summary>
        /// SHA-256 digest of the image manifest.<br/>
        /// Example: sha256:2c4e8f3a1b9d0e5c7a6f4b2d8e1c9a0b3d5f7e9c1a2b4d6f8e0c2a4b6d8f0e2c
        /// </summary>
        /// <example>sha256:2c4e8f3a1b9d0e5c7a6f4b2d8e1c9a0b3d5f7e9c1a2b4d6f8e0c2a4b6d8f0e2c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifestDigest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestDigest { get; set; }

        /// <summary>
        /// Whether the manifest is a multi-platform image index, a single-platform image manifest or an attestation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageDetailKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrImageDetailKind Kind { get; set; }

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
        /// Total size in bytes of the image's resources (manifest, config and layer blobs) stored by the registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        /// VHS-readiness status, or `null` for a multi-platform index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageDetailStatusJsonConverter))]
        public global::Vercel.VcrImageDetailStatus? Status { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the image was created.<br/>
        /// Example: 2026-06-30T10:00:00.000Z
        /// </summary>
        /// <example>2026-06-30T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageDetail" /> class.
        /// </summary>
        /// <param name="layers"></param>
        /// <param name="tags">
        /// Tags pointing at this image's manifest.
        /// </param>
        /// <param name="id">
        /// Internal identifier of the image.<br/>
        /// Example: img_a1b2c3d4e5f6
        /// </param>
        /// <param name="repositoryId">
        /// Identifier of the repository the image belongs to.<br/>
        /// Example: repo_a1b2c3d4e5f6
        /// </param>
        /// <param name="manifestDigest">
        /// SHA-256 digest of the image manifest.<br/>
        /// Example: sha256:2c4e8f3a1b9d0e5c7a6f4b2d8e1c9a0b3d5f7e9c1a2b4d6f8e0c2a4b6d8f0e2c
        /// </param>
        /// <param name="kind">
        /// Whether the manifest is a multi-platform image index, a single-platform image manifest or an attestation.
        /// </param>
        /// <param name="sizeInBytes">
        /// Total size in bytes of the image's resources (manifest, config and layer blobs) stored by the registry.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the image was created.<br/>
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
        public VcrImageDetail(
            global::System.Collections.Generic.IList<global::Vercel.VcrImageLayer> layers,
            global::System.Collections.Generic.IList<string> tags,
            string id,
            string repositoryId,
            string manifestDigest,
            global::Vercel.VcrImageDetailKind kind,
            double sizeInBytes,
            string createdAt,
            string? platform,
            string? arch,
            string? pushedBy,
            global::Vercel.VcrImageDetailStatus? status)
        {
            this.Layers = layers ?? throw new global::System.ArgumentNullException(nameof(layers));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RepositoryId = repositoryId ?? throw new global::System.ArgumentNullException(nameof(repositoryId));
            this.ManifestDigest = manifestDigest ?? throw new global::System.ArgumentNullException(nameof(manifestDigest));
            this.Kind = kind;
            this.Platform = platform;
            this.Arch = arch;
            this.PushedBy = pushedBy;
            this.SizeInBytes = sizeInBytes;
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageDetail" /> class.
        /// </summary>
        public VcrImageDetail()
        {
        }

    }
}