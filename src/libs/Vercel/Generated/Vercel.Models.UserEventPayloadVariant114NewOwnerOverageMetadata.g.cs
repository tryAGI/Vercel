
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Contains the timestamps for usage summary emails.
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerOverageMetadata
    {
        /// <summary>
        /// Tracks if the first time on-demand overage email has been sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstTimeOnDemandNotificationSentAt")]
        public double? FirstTimeOnDemandNotificationSentAt { get; set; }

        /// <summary>
        /// Tracks the last time we sent a daily summary email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyOverageSummaryEmailSentAt")]
        public double? DailyOverageSummaryEmailSentAt { get; set; }

        /// <summary>
        /// Tracks the last time we sent a weekly summary email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weeklyOverageSummaryEmailSentAt")]
        public double? WeeklyOverageSummaryEmailSentAt { get; set; }

        /// <summary>
        /// Tracks when the overage summary email will stop auto-sending. We currently lock the user into email for a month after the last on-demand usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overageSummaryExpiresAt")]
        public double? OverageSummaryExpiresAt { get; set; }

        /// <summary>
        /// Tracks the last time we sent a increased on-demand email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("increasedOnDemandEmailSentAt")]
        public double? IncreasedOnDemandEmailSentAt { get; set; }

        /// <summary>
        /// Tracks the last time we attempted to send an increased on-demand email. This check is to limit the number of attempts per day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("increasedOnDemandEmailAttemptedAt")]
        public double? IncreasedOnDemandEmailAttemptedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerOverageMetadata" /> class.
        /// </summary>
        /// <param name="firstTimeOnDemandNotificationSentAt">
        /// Tracks if the first time on-demand overage email has been sent.
        /// </param>
        /// <param name="dailyOverageSummaryEmailSentAt">
        /// Tracks the last time we sent a daily summary email.
        /// </param>
        /// <param name="weeklyOverageSummaryEmailSentAt">
        /// Tracks the last time we sent a weekly summary email.
        /// </param>
        /// <param name="overageSummaryExpiresAt">
        /// Tracks when the overage summary email will stop auto-sending. We currently lock the user into email for a month after the last on-demand usage.
        /// </param>
        /// <param name="increasedOnDemandEmailSentAt">
        /// Tracks the last time we sent a increased on-demand email.
        /// </param>
        /// <param name="increasedOnDemandEmailAttemptedAt">
        /// Tracks the last time we attempted to send an increased on-demand email. This check is to limit the number of attempts per day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerOverageMetadata(
            double? firstTimeOnDemandNotificationSentAt,
            double? dailyOverageSummaryEmailSentAt,
            double? weeklyOverageSummaryEmailSentAt,
            double? overageSummaryExpiresAt,
            double? increasedOnDemandEmailSentAt,
            double? increasedOnDemandEmailAttemptedAt)
        {
            this.FirstTimeOnDemandNotificationSentAt = firstTimeOnDemandNotificationSentAt;
            this.DailyOverageSummaryEmailSentAt = dailyOverageSummaryEmailSentAt;
            this.WeeklyOverageSummaryEmailSentAt = weeklyOverageSummaryEmailSentAt;
            this.OverageSummaryExpiresAt = overageSummaryExpiresAt;
            this.IncreasedOnDemandEmailSentAt = increasedOnDemandEmailSentAt;
            this.IncreasedOnDemandEmailAttemptedAt = increasedOnDemandEmailAttemptedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerOverageMetadata" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerOverageMetadata()
        {
        }
    }
}