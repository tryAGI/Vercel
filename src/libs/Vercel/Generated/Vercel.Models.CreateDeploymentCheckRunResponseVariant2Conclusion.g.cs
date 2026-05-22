
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant2Conclusion
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
    public static class CreateDeploymentCheckRunResponseVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant2Conclusion value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant2Conclusion.Canceled => "canceled",
                CreateDeploymentCheckRunResponseVariant2Conclusion.Failed => "failed",
                CreateDeploymentCheckRunResponseVariant2Conclusion.Neutral => "neutral",
                CreateDeploymentCheckRunResponseVariant2Conclusion.Skipped => "skipped",
                CreateDeploymentCheckRunResponseVariant2Conclusion.Succeeded => "succeeded",
                CreateDeploymentCheckRunResponseVariant2Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateDeploymentCheckRunResponseVariant2Conclusion.Canceled,
                "failed" => CreateDeploymentCheckRunResponseVariant2Conclusion.Failed,
                "neutral" => CreateDeploymentCheckRunResponseVariant2Conclusion.Neutral,
                "skipped" => CreateDeploymentCheckRunResponseVariant2Conclusion.Skipped,
                "succeeded" => CreateDeploymentCheckRunResponseVariant2Conclusion.Succeeded,
                "timeout" => CreateDeploymentCheckRunResponseVariant2Conclusion.Timeout,
                _ => null,
            };
        }
    }
}