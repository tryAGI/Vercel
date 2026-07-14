
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional AI Gateway quota configuration for the API key.
    /// </summary>
    public sealed partial class CreateApiKeysRequestAiGatewayQuota
    {
        /// <summary>
        /// The quota limit amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitAmount { get; set; }

        /// <summary>
        /// Whether to include BYOK (Bring Your Own Key) usage in the quota.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeByokInQuota")]
        public bool? IncludeByokInQuota { get; set; }

        /// <summary>
        /// How often the quota refreshes.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateApiKeysRequestAiGatewayQuotaRefreshPeriodJsonConverter))]
        public global::Vercel.CreateApiKeysRequestAiGatewayQuotaRefreshPeriod? RefreshPeriod { get; set; }

        /// <summary>
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertThresholds")]
        public global::System.Collections.Generic.IList<double>? AlertThresholds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeysRequestAiGatewayQuota" /> class.
        /// </summary>
        /// <param name="limitAmount">
        /// The quota limit amount.
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether to include BYOK (Bring Your Own Key) usage in the quota.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="refreshPeriod">
        /// How often the quota refreshes.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="alertThresholds">
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeysRequestAiGatewayQuota(
            double limitAmount,
            bool? includeByokInQuota,
            global::Vercel.CreateApiKeysRequestAiGatewayQuotaRefreshPeriod? refreshPeriod,
            global::System.Collections.Generic.IList<double>? alertThresholds)
        {
            this.LimitAmount = limitAmount;
            this.IncludeByokInQuota = includeByokInQuota;
            this.RefreshPeriod = refreshPeriod;
            this.AlertThresholds = alertThresholds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeysRequestAiGatewayQuota" /> class.
        /// </summary>
        public CreateApiKeysRequestAiGatewayQuota()
        {
        }

    }
}