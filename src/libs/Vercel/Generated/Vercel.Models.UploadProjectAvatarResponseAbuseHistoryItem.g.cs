
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseAbuseHistoryItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double At { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string By { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ById { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scanner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseAbuseHistoryItem" /> class.
        /// </summary>
        /// <param name="at"></param>
        /// <param name="by"></param>
        /// <param name="byId"></param>
        /// <param name="reason"></param>
        /// <param name="scanner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseAbuseHistoryItem(
            double at,
            string by,
            string byId,
            string reason,
            string scanner)
        {
            this.At = at;
            this.By = by ?? throw new global::System.ArgumentNullException(nameof(by));
            this.ById = byId ?? throw new global::System.ArgumentNullException(nameof(byId));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Scanner = scanner ?? throw new global::System.ArgumentNullException(nameof(scanner));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseAbuseHistoryItem" /> class.
        /// </summary>
        public UploadProjectAvatarResponseAbuseHistoryItem()
        {
        }

    }
}