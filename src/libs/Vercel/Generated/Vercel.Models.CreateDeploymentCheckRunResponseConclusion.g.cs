
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseConclusion
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
    public static class CreateDeploymentCheckRunResponseConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseConclusion value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseConclusion.Canceled => "canceled",
                CreateDeploymentCheckRunResponseConclusion.Failed => "failed",
                CreateDeploymentCheckRunResponseConclusion.Neutral => "neutral",
                CreateDeploymentCheckRunResponseConclusion.Skipped => "skipped",
                CreateDeploymentCheckRunResponseConclusion.Succeeded => "succeeded",
                CreateDeploymentCheckRunResponseConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateDeploymentCheckRunResponseConclusion.Canceled,
                "failed" => CreateDeploymentCheckRunResponseConclusion.Failed,
                "neutral" => CreateDeploymentCheckRunResponseConclusion.Neutral,
                "skipped" => CreateDeploymentCheckRunResponseConclusion.Skipped,
                "succeeded" => CreateDeploymentCheckRunResponseConclusion.Succeeded,
                "timeout" => CreateDeploymentCheckRunResponseConclusion.Timeout,
                _ => null,
            };
        }
    }
}