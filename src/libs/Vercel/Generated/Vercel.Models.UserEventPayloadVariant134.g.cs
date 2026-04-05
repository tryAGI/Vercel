
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant134
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedUsers")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant134RemovedUsers2>? RemovedUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevPlan")]
        public string? PrevPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priorPlan")]
        public string? PriorPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDowngrade")]
        public bool? IsDowngrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isReactivate")]
        public bool? IsReactivate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTrialUpgrade")]
        public bool? IsTrialUpgrade { get; set; }

        /// <summary>
        /// Whether the plan change was system-initiated rather than human-initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automated")]
        public bool? Automated { get; set; }

        /// <summary>
        /// Why the plan changed. For downgrades, this is a {@link DowngradeReason} from `@api/pubsub-types` (e.g. `user_downgrade`, `trial_expired`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedMemberCount")]
        public double? RemovedMemberCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant134" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="removedUsers"></param>
        /// <param name="prevPlan"></param>
        /// <param name="priorPlan"></param>
        /// <param name="isDowngrade"></param>
        /// <param name="userAgent"></param>
        /// <param name="isReactivate"></param>
        /// <param name="isTrialUpgrade"></param>
        /// <param name="automated">
        /// Whether the plan change was system-initiated rather than human-initiated.
        /// </param>
        /// <param name="reason">
        /// Why the plan changed. For downgrades, this is a {@link DowngradeReason} from `@api/pubsub-types` (e.g. `user_downgrade`, `trial_expired`).
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="removedMemberCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant134(
            string plan,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant134RemovedUsers2>? removedUsers,
            string? prevPlan,
            string? priorPlan,
            bool? isDowngrade,
            string? userAgent,
            bool? isReactivate,
            bool? isTrialUpgrade,
            bool? automated,
            string? reason,
            double? timestamp,
            double? removedMemberCount)
        {
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.RemovedUsers = removedUsers;
            this.PrevPlan = prevPlan;
            this.PriorPlan = priorPlan;
            this.IsDowngrade = isDowngrade;
            this.UserAgent = userAgent;
            this.IsReactivate = isReactivate;
            this.IsTrialUpgrade = isTrialUpgrade;
            this.Automated = automated;
            this.Reason = reason;
            this.Timestamp = timestamp;
            this.RemovedMemberCount = removedMemberCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant134" /> class.
        /// </summary>
        public UserEventPayloadVariant134()
        {
        }
    }
}