
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
    /// </summary>
    public sealed partial class Snapshot
    {
        /// <summary>
        /// CPU architecture required to restore the snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SnapshotArchitectureJsonConverter))]
        public global::Vercel.SnapshotArchitecture? Architecture { get; set; }

        /// <summary>
        /// The time when the snapshot was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The method used to create the snapshot.<br/>
        /// Example: manual
        /// </summary>
        /// <example>manual</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SnapshotCreationMethodJsonConverter))]
        public global::Vercel.SnapshotCreationMethod? CreationMethod { get; set; }

        /// <summary>
        /// The time when the snapshot will expire, in milliseconds since the epoch. If not set, the snapshot does not have any expiration.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// The unique identifier of the snapshot.<br/>
        /// Example: snap_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>snap_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The last time the snapshot was used (e.g. to resume or create a sandbox), in milliseconds since the epoch. Falls back to `createdAt` for older snapshots that predate this field.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastUsedAt { get; set; }

        /// <summary>
        /// The unique identifier of the parent snapshot, if this snapshot was created from another snapshot.<br/>
        /// Example: snap_parent123
        /// </summary>
        /// <example>snap_parent123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// The region where the snapshot is stored.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The regions where the snapshot is available.<br/>
        /// Example: [iad1, sfo1]
        /// </summary>
        /// <example>[iad1, sfo1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        /// The size of the snapshot in bytes.<br/>
        /// Example: 104857600
        /// </summary>
        /// <example>104857600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeBytes { get; set; }

        /// <summary>
        /// The unique identifier of the session from which the snapshot was created.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>sbx_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceSessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceSessionId { get; set; }

        /// <summary>
        /// The status of the snapshot.<br/>
        /// Example: created
        /// </summary>
        /// <example>created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SnapshotStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SnapshotStatus Status { get; set; }

        /// <summary>
        /// The last time the snapshot was updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time when the snapshot was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="id">
        /// The unique identifier of the snapshot.<br/>
        /// Example: snap_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="lastUsedAt">
        /// The last time the snapshot was used (e.g. to resume or create a sandbox), in milliseconds since the epoch. Falls back to `createdAt` for older snapshots that predate this field.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the snapshot in bytes.<br/>
        /// Example: 104857600
        /// </param>
        /// <param name="sourceSessionId">
        /// The unique identifier of the session from which the snapshot was created.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="status">
        /// The status of the snapshot.<br/>
        /// Example: created
        /// </param>
        /// <param name="updatedAt">
        /// The last time the snapshot was updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="architecture">
        /// CPU architecture required to restore the snapshot.
        /// </param>
        /// <param name="creationMethod">
        /// The method used to create the snapshot.<br/>
        /// Example: manual
        /// </param>
        /// <param name="expiresAt">
        /// The time when the snapshot will expire, in milliseconds since the epoch. If not set, the snapshot does not have any expiration.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="parentId">
        /// The unique identifier of the parent snapshot, if this snapshot was created from another snapshot.<br/>
        /// Example: snap_parent123
        /// </param>
        /// <param name="region">
        /// The region where the snapshot is stored.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="regions">
        /// The regions where the snapshot is available.<br/>
        /// Example: [iad1, sfo1]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Snapshot(
            double createdAt,
            string id,
            double lastUsedAt,
            double sizeBytes,
            string sourceSessionId,
            global::Vercel.SnapshotStatus status,
            double updatedAt,
            global::Vercel.SnapshotArchitecture? architecture,
            global::Vercel.SnapshotCreationMethod? creationMethod,
            double? expiresAt,
            string? parentId,
            string? region,
            global::System.Collections.Generic.IList<string>? regions)
        {
            this.Architecture = architecture;
            this.CreatedAt = createdAt;
            this.CreationMethod = creationMethod;
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastUsedAt = lastUsedAt;
            this.ParentId = parentId;
            this.Region = region;
            this.Regions = regions;
            this.SizeBytes = sizeBytes;
            this.SourceSessionId = sourceSessionId ?? throw new global::System.ArgumentNullException(nameof(sourceSessionId));
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        public Snapshot()
        {
        }

    }
}