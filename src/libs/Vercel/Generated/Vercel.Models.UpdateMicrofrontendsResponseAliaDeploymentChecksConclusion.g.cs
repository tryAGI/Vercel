
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion
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
    public static class UpdateMicrofrontendsResponseAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Canceled => "canceled",
                UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Failed => "failed",
                UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Skipped => "skipped",
                UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Canceled,
                "failed" => UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Failed,
                "skipped" => UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => UpdateMicrofrontendsResponseAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}