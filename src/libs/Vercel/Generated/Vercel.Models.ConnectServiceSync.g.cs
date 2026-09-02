
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Provider-side configuration synchronization result.
    /// </summary>
    public sealed partial class ConnectServiceSync
    {
        /// <summary>
        /// done means the external service was updated. required means the Vercel update was saved, but provider-side configuration still needs attention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectServiceSyncStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectServiceSyncStatus Status { get; set; }

        /// <summary>
        /// Provider synchronization errors. Present when serviceSync.status is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectServiceSyncError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectServiceSync" /> class.
        /// </summary>
        /// <param name="status">
        /// done means the external service was updated. required means the Vercel update was saved, but provider-side configuration still needs attention.
        /// </param>
        /// <param name="errors">
        /// Provider synchronization errors. Present when serviceSync.status is required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectServiceSync(
            global::Vercel.ConnectServiceSyncStatus status,
            global::System.Collections.Generic.IList<global::Vercel.ConnectServiceSyncError>? errors)
        {
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectServiceSync" /> class.
        /// </summary>
        public ConnectServiceSync()
        {
        }

    }
}