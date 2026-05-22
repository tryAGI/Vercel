
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1Conclusion
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
    public static class CreateDeploymentCheckRunResponseVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1Conclusion value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1Conclusion.Canceled => "canceled",
                CreateDeploymentCheckRunResponseVariant1Conclusion.Failed => "failed",
                CreateDeploymentCheckRunResponseVariant1Conclusion.Neutral => "neutral",
                CreateDeploymentCheckRunResponseVariant1Conclusion.Skipped => "skipped",
                CreateDeploymentCheckRunResponseVariant1Conclusion.Succeeded => "succeeded",
                CreateDeploymentCheckRunResponseVariant1Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateDeploymentCheckRunResponseVariant1Conclusion.Canceled,
                "failed" => CreateDeploymentCheckRunResponseVariant1Conclusion.Failed,
                "neutral" => CreateDeploymentCheckRunResponseVariant1Conclusion.Neutral,
                "skipped" => CreateDeploymentCheckRunResponseVariant1Conclusion.Skipped,
                "succeeded" => CreateDeploymentCheckRunResponseVariant1Conclusion.Succeeded,
                "timeout" => CreateDeploymentCheckRunResponseVariant1Conclusion.Timeout,
                _ => null,
            };
        }
    }
}