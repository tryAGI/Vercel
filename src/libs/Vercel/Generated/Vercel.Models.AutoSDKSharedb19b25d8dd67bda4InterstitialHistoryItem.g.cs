
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public string? Actor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseId")]
        public string? CaseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Plain thread ID, recorded separately from `caseId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threadId")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItem" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="createdAt"></param>
        /// <param name="actor"></param>
        /// <param name="caseId"></param>
        /// <param name="comment"></param>
        /// <param name="reason"></param>
        /// <param name="threadId">
        /// Plain thread ID, recorded separately from `caseId`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItem(
            global::Vercel.AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItemAction action,
            double createdAt,
            string? actor,
            string? caseId,
            string? comment,
            string? reason,
            string? threadId)
        {
            this.Action = action;
            this.Actor = actor;
            this.CaseId = caseId;
            this.Comment = comment;
            this.CreatedAt = createdAt;
            this.Reason = reason;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItem" /> class.
        /// </summary>
        public AutoSDKSharedb19b25d8dd67bda4InterstitialHistoryItem()
        {
        }

    }
}