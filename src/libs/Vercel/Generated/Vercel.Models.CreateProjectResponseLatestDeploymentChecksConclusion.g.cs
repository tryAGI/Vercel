
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseLatestDeploymentChecksConclusion
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
    public static class CreateProjectResponseLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                CreateProjectResponseLatestDeploymentChecksConclusion.Canceled => "canceled",
                CreateProjectResponseLatestDeploymentChecksConclusion.Failed => "failed",
                CreateProjectResponseLatestDeploymentChecksConclusion.Skipped => "skipped",
                CreateProjectResponseLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateProjectResponseLatestDeploymentChecksConclusion.Canceled,
                "failed" => CreateProjectResponseLatestDeploymentChecksConclusion.Failed,
                "skipped" => CreateProjectResponseLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => CreateProjectResponseLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}