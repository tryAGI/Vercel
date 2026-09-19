
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectResponseUsageStatus
    {
        /// <summary>
        /// Timestamp until which throttling is bypassed (project pays list rates for overage).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypassThrottleUntil")]
        public double? BypassThrottleUntil { get; set; }

        /// <summary>
        /// Timestamp until which the project has exceeded its CDN allowance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceededAllowanceUntil")]
        public double? ExceededAllowanceUntil { get; set; }

        /// <summary>
        /// Billing mode. Always 'flat' for flat-rate projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseUsageStatusKindJsonConverter))]
        public global::Vercel.GetProjectResponseUsageStatusKind Kind { get; set; }

        /// <summary>
        /// Synced from `team.billing.usageStatus.throttled`. When `true`, the team has throttled all of its projects regardless of `throttled`. The effective throttle the CDN enforces is `throttled || teamThrottled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamThrottled")]
        public bool? TeamThrottled { get; set; }

        /// <summary>
        /// Per-project throttle, set explicitly for this project (e.g. via the per-project Flat Rate CDN endpoint).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttled")]
        public bool? Throttled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseUsageStatus" /> class.
        /// </summary>
        /// <param name="bypassThrottleUntil">
        /// Timestamp until which throttling is bypassed (project pays list rates for overage).
        /// </param>
        /// <param name="exceededAllowanceUntil">
        /// Timestamp until which the project has exceeded its CDN allowance.
        /// </param>
        /// <param name="kind">
        /// Billing mode. Always 'flat' for flat-rate projects.
        /// </param>
        /// <param name="teamThrottled">
        /// Synced from `team.billing.usageStatus.throttled`. When `true`, the team has throttled all of its projects regardless of `throttled`. The effective throttle the CDN enforces is `throttled || teamThrottled`.
        /// </param>
        /// <param name="throttled">
        /// Per-project throttle, set explicitly for this project (e.g. via the per-project Flat Rate CDN endpoint).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseUsageStatus(
            double? bypassThrottleUntil,
            double? exceededAllowanceUntil,
            global::Vercel.GetProjectResponseUsageStatusKind kind,
            bool? teamThrottled,
            bool? throttled)
        {
            this.BypassThrottleUntil = bypassThrottleUntil;
            this.ExceededAllowanceUntil = exceededAllowanceUntil;
            this.Kind = kind;
            this.TeamThrottled = teamThrottled;
            this.Throttled = throttled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseUsageStatus" /> class.
        /// </summary>
        public GetProjectResponseUsageStatus()
        {
        }

    }
}