
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion
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
    public static class GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Canceled => "canceled",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Failed => "failed",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Skipped => "skipped",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Canceled,
                "failed" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Failed,
                "skipped" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}