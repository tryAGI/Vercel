
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4ActionJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant1, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant1, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2> Route { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public string? Actor { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCascading")]
        public bool? IsCascading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4" /> class.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="createdAt"></param>
        /// <param name="action"></param>
        /// <param name="statusCode"></param>
        /// <param name="caseId"></param>
        /// <param name="actor"></param>
        /// <param name="comment"></param>
        /// <param name="ineligibleForAppeal"></param>
        /// <param name="isCascading"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4(
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant1, global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2> route,
            double createdAt,
            global::Vercel.GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4Action action,
            double? statusCode,
            string? caseId,
            string? actor,
            string? comment,
            bool? ineligibleForAppeal,
            bool? isCascading)
        {
            this.Action = action;
            this.Route = route;
            this.StatusCode = statusCode;
            this.CreatedAt = createdAt;
            this.CaseId = caseId;
            this.Actor = actor;
            this.Comment = comment;
            this.IneligibleForAppeal = ineligibleForAppeal;
            this.IsCascading = isCascading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4()
        {
        }
    }
}