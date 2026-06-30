
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAliaDeploymentChecksConclusion
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
    public static class GetProjectResponseAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentChecksConclusion.Canceled => "canceled",
                GetProjectResponseAliaDeploymentChecksConclusion.Failed => "failed",
                GetProjectResponseAliaDeploymentChecksConclusion.Skipped => "skipped",
                GetProjectResponseAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetProjectResponseAliaDeploymentChecksConclusion.Canceled,
                "failed" => GetProjectResponseAliaDeploymentChecksConclusion.Failed,
                "skipped" => GetProjectResponseAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => GetProjectResponseAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}