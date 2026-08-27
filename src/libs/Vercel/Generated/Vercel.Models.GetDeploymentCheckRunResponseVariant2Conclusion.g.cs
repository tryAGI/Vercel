
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant2Conclusion
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
    public static class GetDeploymentCheckRunResponseVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant2Conclusion value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant2Conclusion.Canceled => "canceled",
                GetDeploymentCheckRunResponseVariant2Conclusion.Failed => "failed",
                GetDeploymentCheckRunResponseVariant2Conclusion.Neutral => "neutral",
                GetDeploymentCheckRunResponseVariant2Conclusion.Skipped => "skipped",
                GetDeploymentCheckRunResponseVariant2Conclusion.Succeeded => "succeeded",
                GetDeploymentCheckRunResponseVariant2Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentCheckRunResponseVariant2Conclusion.Canceled,
                "failed" => GetDeploymentCheckRunResponseVariant2Conclusion.Failed,
                "neutral" => GetDeploymentCheckRunResponseVariant2Conclusion.Neutral,
                "skipped" => GetDeploymentCheckRunResponseVariant2Conclusion.Skipped,
                "succeeded" => GetDeploymentCheckRunResponseVariant2Conclusion.Succeeded,
                "timeout" => GetDeploymentCheckRunResponseVariant2Conclusion.Timeout,
                _ => null,
            };
        }
    }
}