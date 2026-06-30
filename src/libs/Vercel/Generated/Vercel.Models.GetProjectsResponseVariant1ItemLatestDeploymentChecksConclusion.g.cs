
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion
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
    public static class GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant1ItemLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}