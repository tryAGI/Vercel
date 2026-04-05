
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckResponseConclusion
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
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckResponseConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckResponseConclusion value)
        {
            return value switch
            {
                UpdateCheckResponseConclusion.Canceled => "canceled",
                UpdateCheckResponseConclusion.Failed => "failed",
                UpdateCheckResponseConclusion.Neutral => "neutral",
                UpdateCheckResponseConclusion.Skipped => "skipped",
                UpdateCheckResponseConclusion.Stale => "stale",
                UpdateCheckResponseConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckResponseConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateCheckResponseConclusion.Canceled,
                "failed" => UpdateCheckResponseConclusion.Failed,
                "neutral" => UpdateCheckResponseConclusion.Neutral,
                "skipped" => UpdateCheckResponseConclusion.Skipped,
                "stale" => UpdateCheckResponseConclusion.Stale,
                "succeeded" => UpdateCheckResponseConclusion.Succeeded,
                _ => null,
            };
        }
    }
}