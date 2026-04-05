
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSessionSnapshotResponse
    {
        /// <summary>
        /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Snapshot Snapshot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionSnapshotResponse" /> class.
        /// </summary>
        /// <param name="snapshot">
        /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSessionSnapshotResponse(
            global::Vercel.Snapshot snapshot)
        {
            this.Snapshot = snapshot ?? throw new global::System.ArgumentNullException(nameof(snapshot));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionSnapshotResponse" /> class.
        /// </summary>
        public GetSessionSnapshotResponse()
        {
        }
    }
}