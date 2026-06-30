
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion
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
    public static class UpdateMicrofrontendsResponseLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Canceled => "canceled",
                UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Failed => "failed",
                UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Skipped => "skipped",
                UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Canceled,
                "failed" => UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Failed,
                "skipped" => UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => UpdateMicrofrontendsResponseLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}