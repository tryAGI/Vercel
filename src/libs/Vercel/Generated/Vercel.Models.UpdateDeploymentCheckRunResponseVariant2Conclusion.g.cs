
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant2Conclusion
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Neutral,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant2Conclusion value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant2Conclusion.Canceled => "canceled",
                UpdateDeploymentCheckRunResponseVariant2Conclusion.Failed => "failed",
                UpdateDeploymentCheckRunResponseVariant2Conclusion.Neutral => "neutral",
                UpdateDeploymentCheckRunResponseVariant2Conclusion.Skipped => "skipped",
                UpdateDeploymentCheckRunResponseVariant2Conclusion.Succeeded => "succeeded",
                UpdateDeploymentCheckRunResponseVariant2Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateDeploymentCheckRunResponseVariant2Conclusion.Canceled,
                "failed" => UpdateDeploymentCheckRunResponseVariant2Conclusion.Failed,
                "neutral" => UpdateDeploymentCheckRunResponseVariant2Conclusion.Neutral,
                "skipped" => UpdateDeploymentCheckRunResponseVariant2Conclusion.Skipped,
                "succeeded" => UpdateDeploymentCheckRunResponseVariant2Conclusion.Succeeded,
                "timeout" => UpdateDeploymentCheckRunResponseVariant2Conclusion.Timeout,
                _ => null,
            };
        }
    }
}