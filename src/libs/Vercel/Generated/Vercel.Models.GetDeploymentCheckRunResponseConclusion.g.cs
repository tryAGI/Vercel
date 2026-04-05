
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseConclusion
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
    public static class GetDeploymentCheckRunResponseConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseConclusion value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseConclusion.Canceled => "canceled",
                GetDeploymentCheckRunResponseConclusion.Failed => "failed",
                GetDeploymentCheckRunResponseConclusion.Neutral => "neutral",
                GetDeploymentCheckRunResponseConclusion.Skipped => "skipped",
                GetDeploymentCheckRunResponseConclusion.Succeeded => "succeeded",
                GetDeploymentCheckRunResponseConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDeploymentCheckRunResponseConclusion.Canceled,
                "failed" => GetDeploymentCheckRunResponseConclusion.Failed,
                "neutral" => GetDeploymentCheckRunResponseConclusion.Neutral,
                "skipped" => GetDeploymentCheckRunResponseConclusion.Skipped,
                "succeeded" => GetDeploymentCheckRunResponseConclusion.Succeeded,
                "timeout" => GetDeploymentCheckRunResponseConclusion.Timeout,
                _ => null,
            };
        }
    }
}