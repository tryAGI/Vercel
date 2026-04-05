
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunRequestConclusion
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
    public static class UpdateDeploymentCheckRunRequestConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunRequestConclusion value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunRequestConclusion.Canceled => "canceled",
                UpdateDeploymentCheckRunRequestConclusion.Failed => "failed",
                UpdateDeploymentCheckRunRequestConclusion.Neutral => "neutral",
                UpdateDeploymentCheckRunRequestConclusion.Skipped => "skipped",
                UpdateDeploymentCheckRunRequestConclusion.Succeeded => "succeeded",
                UpdateDeploymentCheckRunRequestConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunRequestConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateDeploymentCheckRunRequestConclusion.Canceled,
                "failed" => UpdateDeploymentCheckRunRequestConclusion.Failed,
                "neutral" => UpdateDeploymentCheckRunRequestConclusion.Neutral,
                "skipped" => UpdateDeploymentCheckRunRequestConclusion.Skipped,
                "succeeded" => UpdateDeploymentCheckRunRequestConclusion.Succeeded,
                "timeout" => UpdateDeploymentCheckRunRequestConclusion.Timeout,
                _ => null,
            };
        }
    }
}