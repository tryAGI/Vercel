
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since June 2023
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public string? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ineligibleForAppeal")]
        public bool? IneligibleForAppeal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItem" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="createdAt"></param>
        /// <param name="reason"></param>
        /// <param name="caseId"></param>
        /// <param name="actor"></param>
        /// <param name="statusCode"></param>
        /// <param name="comment"></param>
        /// <param name="ineligibleForAppeal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItem(
            global::Vercel.UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction action,
            double createdAt,
            string reason,
            string? caseId,
            string? actor,
            double? statusCode,
            string? comment,
            bool? ineligibleForAppeal)
        {
            this.Action = action;
            this.CreatedAt = createdAt;
            this.CaseId = caseId;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Actor = actor;
            this.StatusCode = statusCode;
            this.Comment = comment;
            this.IneligibleForAppeal = ineligibleForAppeal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItem" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItem()
        {
        }
    }
}