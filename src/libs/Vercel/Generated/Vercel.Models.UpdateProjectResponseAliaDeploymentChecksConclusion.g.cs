
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAliaDeploymentChecksConclusion
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
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                UpdateProjectResponseAliaDeploymentChecksConclusion.Canceled => "canceled",
                UpdateProjectResponseAliaDeploymentChecksConclusion.Failed => "failed",
                UpdateProjectResponseAliaDeploymentChecksConclusion.Skipped => "skipped",
                UpdateProjectResponseAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateProjectResponseAliaDeploymentChecksConclusion.Canceled,
                "failed" => UpdateProjectResponseAliaDeploymentChecksConclusion.Failed,
                "skipped" => UpdateProjectResponseAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => UpdateProjectResponseAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}