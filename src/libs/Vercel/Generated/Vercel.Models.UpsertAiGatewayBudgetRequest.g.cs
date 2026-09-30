
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertAiGatewayBudgetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpsertAiGatewayBudgetRequestScopeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpsertAiGatewayBudgetRequestScopeType ScopeType { get; set; }

        /// <summary>
        /// Required when scopeType is "project".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Required when scopeType is "user".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Budget limit in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitAmount { get; set; }

        /// <summary>
        /// Default Value: monthly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpsertAiGatewayBudgetRequestRefreshPeriodJsonConverter))]
        public global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod? RefreshPeriod { get; set; }

        /// <summary>
        /// Whether BYOK usage counts toward this budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeByokInQuota")]
        public bool? IncludeByokInQuota { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertThresholds")]
        public global::System.Collections.Generic.IList<double>? AlertThresholds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertAiGatewayBudgetRequest" /> class.
        /// </summary>
        /// <param name="scopeType"></param>
        /// <param name="limitAmount">
        /// Budget limit in dollars.
        /// </param>
        /// <param name="projectId">
        /// Required when scopeType is "project".
        /// </param>
        /// <param name="userId">
        /// Required when scopeType is "user".
        /// </param>
        /// <param name="refreshPeriod">
        /// Default Value: monthly
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether BYOK usage counts toward this budget.
        /// </param>
        /// <param name="alertThresholds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertAiGatewayBudgetRequest(
            global::Vercel.UpsertAiGatewayBudgetRequestScopeType scopeType,
            double limitAmount,
            string? projectId,
            string? userId,
            global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod? refreshPeriod,
            bool? includeByokInQuota,
            global::System.Collections.Generic.IList<double>? alertThresholds)
        {
            this.ScopeType = scopeType;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.LimitAmount = limitAmount;
            this.RefreshPeriod = refreshPeriod;
            this.IncludeByokInQuota = includeByokInQuota;
            this.AlertThresholds = alertThresholds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertAiGatewayBudgetRequest" /> class.
        /// </summary>
        public UpsertAiGatewayBudgetRequest()
        {
        }

    }
}