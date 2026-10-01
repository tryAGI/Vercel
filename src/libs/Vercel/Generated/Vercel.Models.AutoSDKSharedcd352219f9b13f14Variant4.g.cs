
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedcd352219f9b13f14Variant4
    {
        /// <summary>
        /// Since October 2026. The abuse agent run whose verdict led to this block. Absent on blocks made before the field existed, even agent-led ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abuseAgentRunId")]
        public string? AbuseAgentRunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedcd352219f9b13f14Variant4ActionJsonConverter))]
        public global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4Action Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4RouteVariant1, global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4RouteVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4RouteVariant1, global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4RouteVariant2> Route { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedcd352219f9b13f14Variant4" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="route"></param>
        /// <param name="abuseAgentRunId">
        /// Since October 2026. The abuse agent run whose verdict led to this block. Absent on blocks made before the field existed, even agent-led ones.
        /// </param>
        /// <param name="action"></param>
        /// <param name="actor"></param>
        /// <param name="caseId"></param>
        /// <param name="comment"></param>
        /// <param name="ineligibleForAppeal"></param>
        /// <param name="isCascading"></param>
        /// <param name="statusCode"></param>
        /// <param name="threadId">
        /// Plain thread ID, recorded separately from `caseId`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedcd352219f9b13f14Variant4(
            double createdAt,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4RouteVariant1, global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4RouteVariant2> route,
            string? abuseAgentRunId,
            global::Vercel.AutoSDKSharedcd352219f9b13f14Variant4Action action,
            string? actor,
            string? caseId,
            string? comment,
            bool? ineligibleForAppeal,
            bool? isCascading,
            double? statusCode,
            string? threadId)
        {
            this.AbuseAgentRunId = abuseAgentRunId;
            this.Action = action;
            this.Actor = actor;
            this.CaseId = caseId;
            this.Comment = comment;
            this.CreatedAt = createdAt;
            this.IneligibleForAppeal = ineligibleForAppeal;
            this.IsCascading = isCascading;
            this.Route = route;
            this.StatusCode = statusCode;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcd352219f9b13f14Variant4" /> class.
        /// </summary>
        public AutoSDKSharedcd352219f9b13f14Variant4()
        {
        }

    }
}