
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion
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
    public static class GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}