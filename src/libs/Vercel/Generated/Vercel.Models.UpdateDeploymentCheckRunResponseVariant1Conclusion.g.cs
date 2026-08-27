
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant1Conclusion
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
    public static class UpdateDeploymentCheckRunResponseVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant1Conclusion value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant1Conclusion.Canceled => "canceled",
                UpdateDeploymentCheckRunResponseVariant1Conclusion.Failed => "failed",
                UpdateDeploymentCheckRunResponseVariant1Conclusion.Neutral => "neutral",
                UpdateDeploymentCheckRunResponseVariant1Conclusion.Skipped => "skipped",
                UpdateDeploymentCheckRunResponseVariant1Conclusion.Succeeded => "succeeded",
                UpdateDeploymentCheckRunResponseVariant1Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateDeploymentCheckRunResponseVariant1Conclusion.Canceled,
                "failed" => UpdateDeploymentCheckRunResponseVariant1Conclusion.Failed,
                "neutral" => UpdateDeploymentCheckRunResponseVariant1Conclusion.Neutral,
                "skipped" => UpdateDeploymentCheckRunResponseVariant1Conclusion.Skipped,
                "succeeded" => UpdateDeploymentCheckRunResponseVariant1Conclusion.Succeeded,
                "timeout" => UpdateDeploymentCheckRunResponseVariant1Conclusion.Timeout,
                _ => null,
            };
        }
    }
}