
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerOverageUsageAlertsFluidDuration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentThreshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warningAt")]
        public double? WarningAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedAt")]
        public double? BlockedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerOverageUsageAlertsFluidDuration" /> class.
        /// </summary>
        /// <param name="currentThreshold"></param>
        /// <param name="warningAt"></param>
        /// <param name="blockedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerOverageUsageAlertsFluidDuration(
            double currentThreshold,
            double? warningAt,
            double? blockedAt)
        {
            this.CurrentThreshold = currentThreshold;
            this.WarningAt = warningAt;
            this.BlockedAt = blockedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerOverageUsageAlertsFluidDuration" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerOverageUsageAlertsFluidDuration()
        {
        }
    }
}