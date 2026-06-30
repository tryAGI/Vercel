
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTargetsChecksConclusion
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
    public static class UpdateMicrofrontendsResponseTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTargetsChecksConclusion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTargetsChecksConclusion.Canceled => "canceled",
                UpdateMicrofrontendsResponseTargetsChecksConclusion.Failed => "failed",
                UpdateMicrofrontendsResponseTargetsChecksConclusion.Skipped => "skipped",
                UpdateMicrofrontendsResponseTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateMicrofrontendsResponseTargetsChecksConclusion.Canceled,
                "failed" => UpdateMicrofrontendsResponseTargetsChecksConclusion.Failed,
                "skipped" => UpdateMicrofrontendsResponseTargetsChecksConclusion.Skipped,
                "succeeded" => UpdateMicrofrontendsResponseTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}