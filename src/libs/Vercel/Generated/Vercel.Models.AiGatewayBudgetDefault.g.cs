
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayBudgetDefault
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayBudgetDefaultRefreshPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayBudgetDefaultRefreshPeriod RefreshPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayBudgetDefaultScopeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayBudgetDefaultScopeType ScopeType { get; set; }

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
        /// Initializes a new instance of the <see cref="AiGatewayBudgetDefault" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="createdAt"></param>
        /// <param name="limitAmount"></param>
        /// <param name="refreshPeriod"></param>
        /// <param name="scopeType"></param>
        /// <param name="updatedAt"></param>
        /// <param name="alertThresholds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayBudgetDefault(
            bool active,
            double createdAt,
            double limitAmount,
            global::Vercel.AiGatewayBudgetDefaultRefreshPeriod refreshPeriod,
            global::Vercel.AiGatewayBudgetDefaultScopeType scopeType,
            double updatedAt,
            global::System.Collections.Generic.IList<double>? alertThresholds)
        {
            this.Active = active;
            this.AlertThresholds = alertThresholds;
            this.CreatedAt = createdAt;
            this.LimitAmount = limitAmount;
            this.RefreshPeriod = refreshPeriod;
            this.ScopeType = scopeType;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetDefault" /> class.
        /// </summary>
        public AiGatewayBudgetDefault()
        {
        }

    }
}