
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayBudget
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertThresholds")]
        public global::System.Collections.Generic.IList<double>? AlertThresholds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentByokSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentByokSpend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentSpend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeByokInQuota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInQuota { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quotaEntityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuotaEntityId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayBudgetRefreshPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayBudgetRefreshPeriod RefreshPeriod { get; set; }

        /// <summary>
        /// The native Vercel id of the scoped entity. Team/project ids already carry their prefix, so this equals `quotaEntityId` (`team_…` / `prj_…`); for the api-key scope it is the api key id (the `api_key_id_` prefix stripped).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayBudgetScopeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayBudgetScopeType ScopeType { get; set; }

        /// <summary>
        /// Set when the row is inherited from the team's budget default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayBudgetSourceJsonConverter))]
        public global::Vercel.AiGatewayBudgetSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudget" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="archived"></param>
        /// <param name="createdAt"></param>
        /// <param name="currentByokSpend"></param>
        /// <param name="currentSpend"></param>
        /// <param name="includeByokInQuota"></param>
        /// <param name="limitAmount"></param>
        /// <param name="quotaEntityId"></param>
        /// <param name="refreshPeriod"></param>
        /// <param name="scopeId">
        /// The native Vercel id of the scoped entity. Team/project ids already carry their prefix, so this equals `quotaEntityId` (`team_…` / `prj_…`); for the api-key scope it is the api key id (the `api_key_id_` prefix stripped).
        /// </param>
        /// <param name="scopeType"></param>
        /// <param name="updatedAt"></param>
        /// <param name="alertThresholds"></param>
        /// <param name="name"></param>
        /// <param name="source">
        /// Set when the row is inherited from the team's budget default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayBudget(
            bool active,
            bool archived,
            double createdAt,
            double currentByokSpend,
            double currentSpend,
            bool includeByokInQuota,
            double limitAmount,
            string quotaEntityId,
            global::Vercel.AiGatewayBudgetRefreshPeriod refreshPeriod,
            string scopeId,
            global::Vercel.AiGatewayBudgetScopeType scopeType,
            double updatedAt,
            global::System.Collections.Generic.IList<double>? alertThresholds,
            string? name,
            global::Vercel.AiGatewayBudgetSource? source)
        {
            this.Active = active;
            this.AlertThresholds = alertThresholds;
            this.Archived = archived;
            this.CreatedAt = createdAt;
            this.CurrentByokSpend = currentByokSpend;
            this.CurrentSpend = currentSpend;
            this.IncludeByokInQuota = includeByokInQuota;
            this.LimitAmount = limitAmount;
            this.Name = name;
            this.QuotaEntityId = quotaEntityId ?? throw new global::System.ArgumentNullException(nameof(quotaEntityId));
            this.RefreshPeriod = refreshPeriod;
            this.ScopeId = scopeId ?? throw new global::System.ArgumentNullException(nameof(scopeId));
            this.ScopeType = scopeType;
            this.Source = source;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudget" /> class.
        /// </summary>
        public AiGatewayBudget()
        {
        }

    }
}