
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateApiKeyQuotaRequest
    {
        /// <summary>
        /// The quota limit amount. Required if the quota does not yet exist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        public double? LimitAmount { get; set; }

        /// <summary>
        /// Whether BYOK (Bring Your Own Key) usage counts against the quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeByokInQuota")]
        public bool? IncludeByokInQuota { get; set; }

        /// <summary>
        /// How often the quota refreshes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateApiKeyQuotaRequestRefreshPeriodJsonConverter))]
        public global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod? RefreshPeriod { get; set; }

        /// <summary>
        /// Whether the quota is currently active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Set to true to archive (soft-delete) the quota. The api key itself is unaffected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert. Pass an empty array to disable alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertThresholds")]
        public global::System.Collections.Generic.IList<double>? AlertThresholds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyQuotaRequest" /> class.
        /// </summary>
        /// <param name="limitAmount">
        /// The quota limit amount. Required if the quota does not yet exist.
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether BYOK (Bring Your Own Key) usage counts against the quota.
        /// </param>
        /// <param name="refreshPeriod">
        /// How often the quota refreshes.
        /// </param>
        /// <param name="active">
        /// Whether the quota is currently active.
        /// </param>
        /// <param name="archived">
        /// Set to true to archive (soft-delete) the quota. The api key itself is unaffected.
        /// </param>
        /// <param name="alertThresholds">
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert. Pass an empty array to disable alerts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyQuotaRequest(
            double? limitAmount,
            bool? includeByokInQuota,
            global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod? refreshPeriod,
            bool? active,
            bool? archived,
            global::System.Collections.Generic.IList<double>? alertThresholds)
        {
            this.LimitAmount = limitAmount;
            this.IncludeByokInQuota = includeByokInQuota;
            this.RefreshPeriod = refreshPeriod;
            this.Active = active;
            this.Archived = archived;
            this.AlertThresholds = alertThresholds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyQuotaRequest" /> class.
        /// </summary>
        public UpdateApiKeyQuotaRequest()
        {
        }

    }
}