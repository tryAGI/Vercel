
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1Conclusion
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
    public static class GetDeploymentCheckRunResponseVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1Conclusion value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1Conclusion.Canceled => "canceled",
                GetDeploymentCheckRunResponseVariant1Conclusion.Failed => "failed",
                GetDeploymentCheckRunResponseVariant1Conclusion.Neutral => "neutral",
                GetDeploymentCheckRunResponseVariant1Conclusion.Skipped => "skipped",
                GetDeploymentCheckRunResponseVariant1Conclusion.Succeeded => "succeeded",
                GetDeploymentCheckRunResponseVariant1Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentCheckRunResponseVariant1Conclusion.Canceled,
                "failed" => GetDeploymentCheckRunResponseVariant1Conclusion.Failed,
                "neutral" => GetDeploymentCheckRunResponseVariant1Conclusion.Neutral,
                "skipped" => GetDeploymentCheckRunResponseVariant1Conclusion.Skipped,
                "succeeded" => GetDeploymentCheckRunResponseVariant1Conclusion.Succeeded,
                "timeout" => GetDeploymentCheckRunResponseVariant1Conclusion.Timeout,
                _ => null,
            };
        }
    }
}