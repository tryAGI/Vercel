
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSnapshotResponse
    {
        /// <summary>
        /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Snapshot Snapshot { get; set; }

        /// <summary>
        /// This object contains information related to a Vercel Sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Sandbox Sandbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSnapshotResponse" /> class.
        /// </summary>
        /// <param name="snapshot">
        /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
        /// </param>
        /// <param name="sandbox">
        /// This object contains information related to a Vercel Sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSnapshotResponse(
            global::Vercel.Snapshot snapshot,
            global::Vercel.Sandbox sandbox)
        {
            this.Snapshot = snapshot ?? throw new global::System.ArgumentNullException(nameof(snapshot));
            this.Sandbox = sandbox ?? throw new global::System.ArgumentNullException(nameof(sandbox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSnapshotResponse" /> class.
        /// </summary>
        public CreateSnapshotResponse()
        {
        }
    }
}