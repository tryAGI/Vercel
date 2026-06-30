
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTargetsChecksConclusion
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
    public static class UpdateProjectResponseTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTargetsChecksConclusion value)
        {
            return value switch
            {
                UpdateProjectResponseTargetsChecksConclusion.Canceled => "canceled",
                UpdateProjectResponseTargetsChecksConclusion.Failed => "failed",
                UpdateProjectResponseTargetsChecksConclusion.Skipped => "skipped",
                UpdateProjectResponseTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateProjectResponseTargetsChecksConclusion.Canceled,
                "failed" => UpdateProjectResponseTargetsChecksConclusion.Failed,
                "skipped" => UpdateProjectResponseTargetsChecksConclusion.Skipped,
                "succeeded" => UpdateProjectResponseTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}