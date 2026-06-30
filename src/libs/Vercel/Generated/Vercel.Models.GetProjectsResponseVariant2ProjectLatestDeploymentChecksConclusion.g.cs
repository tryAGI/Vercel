
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion
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
    public static class GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}