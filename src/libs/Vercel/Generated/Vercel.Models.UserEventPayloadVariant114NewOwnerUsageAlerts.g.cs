
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Contains the timestamps when a user was notified about their usage
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerUsageAlerts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warningAt")]
        public double? WarningAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockingAt")]
        public double? BlockingAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerUsageAlerts" /> class.
        /// </summary>
        /// <param name="warningAt"></param>
        /// <param name="blockingAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerUsageAlerts(
            double? warningAt,
            double? blockingAt)
        {
            this.WarningAt = warningAt;
            this.BlockingAt = blockingAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerUsageAlerts" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerUsageAlerts()
        {
        }
    }
}