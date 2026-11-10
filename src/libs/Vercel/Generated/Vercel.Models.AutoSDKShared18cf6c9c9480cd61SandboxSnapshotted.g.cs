
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxSnapshotId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxSnapshotId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workingDirectory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkingDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshottedAt")]
        public double? SnapshottedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted" /> class.
        /// </summary>
        /// <param name="sandboxSnapshotId"></param>
        /// <param name="workingDirectory"></param>
        /// <param name="snapshottedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted(
            string sandboxSnapshotId,
            string workingDirectory,
            double? snapshottedAt)
        {
            this.SandboxSnapshotId = sandboxSnapshotId ?? throw new global::System.ArgumentNullException(nameof(sandboxSnapshotId));
            this.WorkingDirectory = workingDirectory ?? throw new global::System.ArgumentNullException(nameof(workingDirectory));
            this.SnapshottedAt = snapshottedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted" /> class.
        /// </summary>
        public AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted()
        {
        }

    }
}