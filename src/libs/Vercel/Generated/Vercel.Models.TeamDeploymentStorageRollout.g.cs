
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Phase 2 Pro deployment-storage pricing rollout cohort and milestones. Absent when the team is not in a Phase 2 Pro cohort.
    /// </summary>
    public sealed partial class TeamDeploymentStorageRollout
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamDeploymentStorageRolloutCohortJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TeamDeploymentStorageRolloutCohort Cohort { get; set; }

        /// <summary>
        /// When team-wide metering was recorded for this rollout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meteredAt")]
        public double? MeteredAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meterReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamDeploymentStorageRolloutMeterReasonJsonConverter))]
        public global::Vercel.TeamDeploymentStorageRolloutMeterReason? MeterReason { get; set; }

        /// <summary>
        /// When the calendar retention-reduce migration applied 30d retention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionAppliedAt")]
        public double? RetentionAppliedAt { get; set; }

        /// <summary>
        /// When the customer chose "keep my retention" before reduce day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retentionOptOutAt")]
        public double? RetentionOptOutAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentStorageRollout" /> class.
        /// </summary>
        /// <param name="cohort"></param>
        /// <param name="meteredAt">
        /// When team-wide metering was recorded for this rollout.
        /// </param>
        /// <param name="meterReason"></param>
        /// <param name="retentionAppliedAt">
        /// When the calendar retention-reduce migration applied 30d retention.
        /// </param>
        /// <param name="retentionOptOutAt">
        /// When the customer chose "keep my retention" before reduce day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDeploymentStorageRollout(
            global::Vercel.TeamDeploymentStorageRolloutCohort cohort,
            double? meteredAt,
            global::Vercel.TeamDeploymentStorageRolloutMeterReason? meterReason,
            double? retentionAppliedAt,
            double? retentionOptOutAt)
        {
            this.Cohort = cohort;
            this.MeteredAt = meteredAt;
            this.MeterReason = meterReason;
            this.RetentionAppliedAt = retentionAppliedAt;
            this.RetentionOptOutAt = retentionOptOutAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentStorageRollout" /> class.
        /// </summary>
        public TeamDeploymentStorageRollout()
        {
        }

    }
}