
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb19b25d8dd67bda4Block
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedb19b25d8dd67bda4BlockActionJsonConverter))]
        public global::Vercel.AutoSDKSharedb19b25d8dd67bda4BlockAction Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("ineligibleForAppeal")]
        public bool? IneligibleForAppeal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCascading")]
        public bool? IsCascading { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Since September 2026. Set on the live `abuse.block` only, by the consumer that auto-registers this project's production git SHA in the lineage blocklist, so unblocking can disable the row this block created. Absent means this block registered nothing, which includes the case where registration was skipped because the SHA already belonged to an earlier block. Unblock must therefore clear only what is named here, never the project's current SHA, or it would disable another block's row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registeredShaBlock")]
        public global::Vercel.AutoSDKSharedb19b25d8dd67bda4BlockRegisteredShaBlock? RegisteredShaBlock { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusCode { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedb19b25d8dd67bda4Block" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="reason"></param>
        /// <param name="statusCode"></param>
        /// <param name="action"></param>
        /// <param name="actor"></param>
        /// <param name="caseId"></param>
        /// <param name="comment"></param>
        /// <param name="ineligibleForAppeal"></param>
        /// <param name="isCascading"></param>
        /// <param name="registeredShaBlock">
        /// Since September 2026. Set on the live `abuse.block` only, by the consumer that auto-registers this project's production git SHA in the lineage blocklist, so unblocking can disable the row this block created. Absent means this block registered nothing, which includes the case where registration was skipped because the SHA already belonged to an earlier block. Unblock must therefore clear only what is named here, never the project's current SHA, or it would disable another block's row.
        /// </param>
        /// <param name="threadId">
        /// Plain thread ID, recorded separately from `caseId`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb19b25d8dd67bda4Block(
            double createdAt,
            string reason,
            double statusCode,
            global::Vercel.AutoSDKSharedb19b25d8dd67bda4BlockAction action,
            string? actor,
            string? caseId,
            string? comment,
            bool? ineligibleForAppeal,
            bool? isCascading,
            global::Vercel.AutoSDKSharedb19b25d8dd67bda4BlockRegisteredShaBlock? registeredShaBlock,
            string? threadId)
        {
            this.Action = action;
            this.Actor = actor;
            this.CaseId = caseId;
            this.Comment = comment;
            this.CreatedAt = createdAt;
            this.IneligibleForAppeal = ineligibleForAppeal;
            this.IsCascading = isCascading;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.RegisteredShaBlock = registeredShaBlock;
            this.StatusCode = statusCode;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb19b25d8dd67bda4Block" /> class.
        /// </summary>
        public AutoSDKSharedb19b25d8dd67bda4Block()
        {
        }

    }
}