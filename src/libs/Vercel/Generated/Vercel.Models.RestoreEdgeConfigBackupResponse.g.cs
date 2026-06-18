
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestoreEdgeConfigBackupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RestoreEdgeConfigBackupResponseStatusJsonConverter))]
        public global::Vercel.RestoreEdgeConfigBackupResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restoredFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RestoredFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousDigest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousDigest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreEdgeConfigBackupResponse" /> class.
        /// </summary>
        /// <param name="restoredFrom"></param>
        /// <param name="previousDigest"></param>
        /// <param name="digest"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreEdgeConfigBackupResponse(
            string restoredFrom,
            string previousDigest,
            string digest,
            global::Vercel.RestoreEdgeConfigBackupResponseStatus status)
        {
            this.Status = status;
            this.RestoredFrom = restoredFrom ?? throw new global::System.ArgumentNullException(nameof(restoredFrom));
            this.PreviousDigest = previousDigest ?? throw new global::System.ArgumentNullException(nameof(previousDigest));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreEdgeConfigBackupResponse" /> class.
        /// </summary>
        public RestoreEdgeConfigBackupResponse()
        {
        }

    }
}