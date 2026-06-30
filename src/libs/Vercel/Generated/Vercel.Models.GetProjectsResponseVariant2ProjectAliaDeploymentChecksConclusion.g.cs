
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion
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
    public static class GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}