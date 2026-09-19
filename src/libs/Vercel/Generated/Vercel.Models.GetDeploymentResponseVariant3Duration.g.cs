
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build timestamps, elapsed durations, and billing measurements. The object is always present, but fields are omitted when their source timestamps are unavailable, such as for running or legacy deployments.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant3Duration
    {
        /// <summary>
        /// Unix timestamp in milliseconds when the build container exited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public double? EndTime { get; set; }

        /// <summary>
        /// Build-container exit Unix timestamp in milliseconds, capped at 45 minutes after `startTime`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeCapped")]
        public double? EndTimeCapped { get; set; }

        /// <summary>
        /// Unix timestamp in milliseconds when the deployment entered BUILDING.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public double? StartTime { get; set; }

        /// <summary>
        /// Billable build-container duration in milliseconds, capped at 45 minutes, rounded up to a whole minute, with a one-minute minimum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeForBilling")]
        public double? TimeForBilling { get; set; }

        /// <summary>
        /// Milliseconds from entering BUILDING until the build container exited, without the billing cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToContainerExit")]
        public double? TimeToContainerExit { get; set; }

        /// <summary>
        /// Build-container duration in milliseconds, capped at 45 minutes and without billing rounding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToContainerExitCapped")]
        public double? TimeToContainerExitCapped { get; set; }

        /// <summary>
        /// Milliseconds from entering BUILDING until the deployment reached its current ready state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToReady")]
        public double? TimeToReady { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant3Duration" /> class.
        /// </summary>
        /// <param name="endTime">
        /// Unix timestamp in milliseconds when the build container exited.
        /// </param>
        /// <param name="endTimeCapped">
        /// Build-container exit Unix timestamp in milliseconds, capped at 45 minutes after `startTime`.
        /// </param>
        /// <param name="startTime">
        /// Unix timestamp in milliseconds when the deployment entered BUILDING.
        /// </param>
        /// <param name="timeForBilling">
        /// Billable build-container duration in milliseconds, capped at 45 minutes, rounded up to a whole minute, with a one-minute minimum.
        /// </param>
        /// <param name="timeToContainerExit">
        /// Milliseconds from entering BUILDING until the build container exited, without the billing cap.
        /// </param>
        /// <param name="timeToContainerExitCapped">
        /// Build-container duration in milliseconds, capped at 45 minutes and without billing rounding.
        /// </param>
        /// <param name="timeToReady">
        /// Milliseconds from entering BUILDING until the deployment reached its current ready state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant3Duration(
            double? endTime,
            double? endTimeCapped,
            double? startTime,
            double? timeForBilling,
            double? timeToContainerExit,
            double? timeToContainerExitCapped,
            double? timeToReady)
        {
            this.EndTime = endTime;
            this.EndTimeCapped = endTimeCapped;
            this.StartTime = startTime;
            this.TimeForBilling = timeForBilling;
            this.TimeToContainerExit = timeToContainerExit;
            this.TimeToContainerExitCapped = timeToContainerExitCapped;
            this.TimeToReady = timeToReady;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant3Duration" /> class.
        /// </summary>
        public GetDeploymentResponseVariant3Duration()
        {
        }

    }
}