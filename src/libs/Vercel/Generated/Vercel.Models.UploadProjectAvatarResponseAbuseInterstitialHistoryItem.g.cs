
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseAbuseInterstitialHistoryItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UploadProjectAvatarResponseAbuseInterstitialHistoryItemActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UploadProjectAvatarResponseAbuseInterstitialHistoryItemAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseId")]
        public string? CaseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public string? Actor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseAbuseInterstitialHistoryItem" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="createdAt"></param>
        /// <param name="caseId"></param>
        /// <param name="reason"></param>
        /// <param name="actor"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseAbuseInterstitialHistoryItem(
            global::Vercel.UploadProjectAvatarResponseAbuseInterstitialHistoryItemAction action,
            double createdAt,
            string? caseId,
            string? reason,
            string? actor,
            string? comment)
        {
            this.Action = action;
            this.CreatedAt = createdAt;
            this.CaseId = caseId;
            this.Reason = reason;
            this.Actor = actor;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseAbuseInterstitialHistoryItem" /> class.
        /// </summary>
        public UploadProjectAvatarResponseAbuseInterstitialHistoryItem()
        {
        }

    }
}