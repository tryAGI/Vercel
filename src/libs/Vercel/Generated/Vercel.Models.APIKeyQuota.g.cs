
#nullable enable

namespace Vercel
{
    /// <summary>
    /// AI Gateway quota associated with an API key.
    /// </summary>
    public sealed partial class APIKeyQuota
    {
        /// <summary>
        /// The unique identifier for the quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quotaEntityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuotaEntityId { get; set; }

        /// <summary>
        /// The quota limit amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitAmount { get; set; }

        /// <summary>
        /// The current amount spent against the quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentSpend { get; set; }

        /// <summary>
        /// The current BYOK spend (tracked separately).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentByokSpend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentByokSpend { get; set; }

        /// <summary>
        /// Whether BYOK (Bring Your Own Key) spend counts against the quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeByokInQuota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInQuota { get; set; }

        /// <summary>
        /// How often the quota refreshes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshPeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshPeriod { get; set; }

        /// <summary>
        /// Whether the quota is currently active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Whether the quota has been archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert. Empty or undefined disables alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertThresholds")]
        public global::System.Collections.Generic.IList<double>? AlertThresholds { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the quota was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the quota was last updated.
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
        /// Initializes a new instance of the <see cref="APIKeyQuota" /> class.
        /// </summary>
        /// <param name="quotaEntityId">
        /// The unique identifier for the quota.
        /// </param>
        /// <param name="limitAmount">
        /// The quota limit amount.
        /// </param>
        /// <param name="currentSpend">
        /// The current amount spent against the quota.
        /// </param>
        /// <param name="currentByokSpend">
        /// The current BYOK spend (tracked separately).
        /// </param>
        /// <param name="includeByokInQuota">
        /// Whether BYOK (Bring Your Own Key) spend counts against the quota.
        /// </param>
        /// <param name="refreshPeriod">
        /// How often the quota refreshes.
        /// </param>
        /// <param name="active">
        /// Whether the quota is currently active.
        /// </param>
        /// <param name="archived">
        /// Whether the quota has been archived.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp (in milliseconds) of when the quota was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp (in milliseconds) of when the quota was last updated.
        /// </param>
        /// <param name="alertThresholds">
        /// Spend percentages (a subset of [50, 75, 100]) at which to send a spend alert. Empty or undefined disables alerts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyQuota(
            string quotaEntityId,
            double limitAmount,
            double currentSpend,
            double currentByokSpend,
            bool includeByokInQuota,
            string refreshPeriod,
            bool active,
            bool archived,
            double createdAt,
            double updatedAt,
            global::System.Collections.Generic.IList<double>? alertThresholds)
        {
            this.QuotaEntityId = quotaEntityId ?? throw new global::System.ArgumentNullException(nameof(quotaEntityId));
            this.LimitAmount = limitAmount;
            this.CurrentSpend = currentSpend;
            this.CurrentByokSpend = currentByokSpend;
            this.IncludeByokInQuota = includeByokInQuota;
            this.RefreshPeriod = refreshPeriod;
            this.Active = active;
            this.Archived = archived;
            this.AlertThresholds = alertThresholds;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyQuota" /> class.
        /// </summary>
        public APIKeyQuota()
        {
        }

    }
}