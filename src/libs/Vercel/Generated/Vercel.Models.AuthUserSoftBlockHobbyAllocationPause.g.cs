
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Present only when `reason` is `HOBBY_ALLOCATION_PAUSED`. Makes the pause self-describing for support without a separate lookup.
    /// </summary>
    public sealed partial class AuthUserSoftBlockHobbyAllocationPause
    {
        /// <summary>
        /// Unix ms timestamp at which the pause is eligible to end. This is the single source of truth for when the pause ends. Never re-derive it by re-checking usage — usage keeps moving while a team is paused, and the pause duration is a fixed experiment parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedUntil")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PausedUntil { get; set; }

        /// <summary>
        /// Unix ms timestamp of when the pause was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PausedAt { get; set; }

        /// <summary>
        /// Allocations that were at or over 100% when the pause was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AuthUserSoftBlockHobbyAllocationPauseTrigger> Triggers { get; set; }

        /// <summary>
        /// Experiment cohort the owner was assigned to when the pause fired. Free-form so cohort naming stays owned by the assignment path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cohort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserSoftBlockHobbyAllocationPause" /> class.
        /// </summary>
        /// <param name="pausedUntil">
        /// Unix ms timestamp at which the pause is eligible to end. This is the single source of truth for when the pause ends. Never re-derive it by re-checking usage — usage keeps moving while a team is paused, and the pause duration is a fixed experiment parameter.
        /// </param>
        /// <param name="pausedAt">
        /// Unix ms timestamp of when the pause was applied.
        /// </param>
        /// <param name="triggers">
        /// Allocations that were at or over 100% when the pause was applied.
        /// </param>
        /// <param name="cohort">
        /// Experiment cohort the owner was assigned to when the pause fired. Free-form so cohort naming stays owned by the assignment path.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserSoftBlockHobbyAllocationPause(
            double pausedUntil,
            double pausedAt,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserSoftBlockHobbyAllocationPauseTrigger> triggers,
            string cohort)
        {
            this.PausedUntil = pausedUntil;
            this.PausedAt = pausedAt;
            this.Triggers = triggers ?? throw new global::System.ArgumentNullException(nameof(triggers));
            this.Cohort = cohort ?? throw new global::System.ArgumentNullException(nameof(cohort));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserSoftBlockHobbyAllocationPause" /> class.
        /// </summary>
        public AuthUserSoftBlockHobbyAllocationPause()
        {
        }

    }
}