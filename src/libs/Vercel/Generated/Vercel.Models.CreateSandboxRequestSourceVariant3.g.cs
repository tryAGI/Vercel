
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restore the sandbox filesystem from an existing snapshot.
    /// </summary>
    public sealed partial class CreateSandboxRequestSourceVariant3
    {
        /// <summary>
        /// Indicates the source is a snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The unique identifier of the snapshot to restore.<br/>
        /// Example: snap_abc123
        /// </summary>
        /// <example>snap_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnapshotId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestSourceVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates the source is a snapshot.
        /// </param>
        /// <param name="snapshotId">
        /// The unique identifier of the snapshot to restore.<br/>
        /// Example: snap_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxRequestSourceVariant3(
            object type,
            string snapshotId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SnapshotId = snapshotId ?? throw new global::System.ArgumentNullException(nameof(snapshotId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestSourceVariant3" /> class.
        /// </summary>
        public CreateSandboxRequestSourceVariant3()
        {
        }
    }
}