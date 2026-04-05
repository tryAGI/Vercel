
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion
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
    public static class GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Canceled => "canceled",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Failed => "failed",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Skipped => "skipped",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Canceled,
                "failed" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Failed,
                "skipped" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}