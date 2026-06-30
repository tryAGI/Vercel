
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentChecksConclusion
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
    public static class UpdateProjectResponseLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentChecksConclusion.Canceled => "canceled",
                UpdateProjectResponseLatestDeploymentChecksConclusion.Failed => "failed",
                UpdateProjectResponseLatestDeploymentChecksConclusion.Skipped => "skipped",
                UpdateProjectResponseLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateProjectResponseLatestDeploymentChecksConclusion.Canceled,
                "failed" => UpdateProjectResponseLatestDeploymentChecksConclusion.Failed,
                "skipped" => UpdateProjectResponseLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => UpdateProjectResponseLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}