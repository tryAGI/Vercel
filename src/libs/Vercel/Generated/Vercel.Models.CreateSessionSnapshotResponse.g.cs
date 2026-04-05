
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionSnapshotResponse
    {
        /// <summary>
        /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Snapshot Snapshot { get; set; }

        /// <summary>
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Session Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionSnapshotResponse" /> class.
        /// </summary>
        /// <param name="snapshot">
        /// This object contains information related to a Snapshot of a Vercel Sandbox session (v2 API).
        /// </param>
        /// <param name="session">
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionSnapshotResponse(
            global::Vercel.Snapshot snapshot,
            global::Vercel.Session session)
        {
            this.Snapshot = snapshot ?? throw new global::System.ArgumentNullException(nameof(snapshot));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionSnapshotResponse" /> class.
        /// </summary>
        public CreateSessionSnapshotResponse()
        {
        }
    }
}