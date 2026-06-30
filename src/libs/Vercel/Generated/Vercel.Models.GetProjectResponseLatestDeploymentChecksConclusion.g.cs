
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLatestDeploymentChecksConclusion
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
    public static class GetProjectResponseLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectResponseLatestDeploymentChecksConclusion.Failed => "failed",
                GetProjectResponseLatestDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectResponseLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectResponseLatestDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectResponseLatestDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectResponseLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectResponseLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}