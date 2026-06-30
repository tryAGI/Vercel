
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion
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
    public static class GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}