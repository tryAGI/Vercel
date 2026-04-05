
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseConclusion
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
    public static class UpdateDeploymentCheckRunResponseConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseConclusion value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseConclusion.Canceled => "canceled",
                UpdateDeploymentCheckRunResponseConclusion.Failed => "failed",
                UpdateDeploymentCheckRunResponseConclusion.Neutral => "neutral",
                UpdateDeploymentCheckRunResponseConclusion.Skipped => "skipped",
                UpdateDeploymentCheckRunResponseConclusion.Succeeded => "succeeded",
                UpdateDeploymentCheckRunResponseConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateDeploymentCheckRunResponseConclusion.Canceled,
                "failed" => UpdateDeploymentCheckRunResponseConclusion.Failed,
                "neutral" => UpdateDeploymentCheckRunResponseConclusion.Neutral,
                "skipped" => UpdateDeploymentCheckRunResponseConclusion.Skipped,
                "succeeded" => UpdateDeploymentCheckRunResponseConclusion.Succeeded,
                "timeout" => UpdateDeploymentCheckRunResponseConclusion.Timeout,
                _ => null,
            };
        }
    }
}