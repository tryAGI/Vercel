
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertAiGatewayBudgetDefaultRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpsertAiGatewayBudgetDefaultRequestScopeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType ScopeType { get; set; }

        /// <summary>
        /// Default budget limit in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpsertAiGatewayBudgetDefaultRequestRefreshPeriodJsonConverter))]
        public global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod? RefreshPeriod { get; set; }

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
        /// Initializes a new instance of the <see cref="UpsertAiGatewayBudgetDefaultRequest" /> class.
        /// </summary>
        /// <param name="scopeType"></param>
        /// <param name="limitAmount">
        /// Default budget limit in dollars.
        /// </param>
        /// <param name="refreshPeriod"></param>
        /// <param name="alertThresholds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertAiGatewayBudgetDefaultRequest(
            global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType scopeType,
            double limitAmount,
            global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod? refreshPeriod,
            global::System.Collections.Generic.IList<double>? alertThresholds)
        {
            this.ScopeType = scopeType;
            this.LimitAmount = limitAmount;
            this.RefreshPeriod = refreshPeriod;
            this.AlertThresholds = alertThresholds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertAiGatewayBudgetDefaultRequest" /> class.
        /// </summary>
        public UpsertAiGatewayBudgetDefaultRequest()
        {
        }

    }
}