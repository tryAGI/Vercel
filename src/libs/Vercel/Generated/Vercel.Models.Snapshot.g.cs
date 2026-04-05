
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
    /// </summary>
    public sealed partial class Snapshot
    {
        /// <summary>
        /// The unique identifier of the snapshot.<br/>
        /// Example: snap_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>snap_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier of the session from which the snapshot was created.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>sbx_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceSessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceSessionId { get; set; }

        /// <summary>
        /// The region where the snapshot is stored.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

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
        /// The size of the snapshot in bytes.<br/>
        /// Example: 104857600
        /// </summary>
        /// <example>104857600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeBytes { get; set; }

        /// <summary>
        /// The time when the snapshot will expire, in milliseconds since the epoch. If not set, the snapshot does not have any expiration.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// The time when the snapshot was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

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
        /// <param name="id">
        /// The unique identifier of the snapshot.<br/>
        /// Example: snap_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="sourceSessionId">
        /// The unique identifier of the session from which the snapshot was created.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="region">
        /// The region where the snapshot is stored.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="status">
        /// The status of the snapshot.<br/>
        /// Example: created
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the snapshot in bytes.<br/>
        /// Example: 104857600
        /// </param>
        /// <param name="createdAt">
        /// The time when the snapshot was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="updatedAt">
        /// The last time the snapshot was updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="expiresAt">
        /// The time when the snapshot will expire, in milliseconds since the epoch. If not set, the snapshot does not have any expiration.<br/>
        /// Example: 1750344501629L
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Snapshot(
            string id,
            string sourceSessionId,
            string region,
            global::Vercel.SnapshotStatus status,
            double sizeBytes,
            double createdAt,
            double updatedAt,
            double? expiresAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SourceSessionId = sourceSessionId ?? throw new global::System.ArgumentNullException(nameof(sourceSessionId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Status = status;
            this.SizeBytes = sizeBytes;
            this.ExpiresAt = expiresAt;
            this.CreatedAt = createdAt;
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