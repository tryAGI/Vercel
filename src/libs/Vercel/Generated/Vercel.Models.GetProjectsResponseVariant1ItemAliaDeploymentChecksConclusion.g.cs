
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion
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
    public static class GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Failed => "failed",
                GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectsResponseVariant1ItemAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}