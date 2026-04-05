
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The result of the check being run
    /// </summary>
    public enum UpdateCheckRequestConclusion
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
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestConclusion value)
        {
            return value switch
            {
                UpdateCheckRequestConclusion.Canceled => "canceled",
                UpdateCheckRequestConclusion.Failed => "failed",
                UpdateCheckRequestConclusion.Neutral => "neutral",
                UpdateCheckRequestConclusion.Skipped => "skipped",
                UpdateCheckRequestConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UpdateCheckRequestConclusion.Canceled,
                "failed" => UpdateCheckRequestConclusion.Failed,
                "neutral" => UpdateCheckRequestConclusion.Neutral,
                "skipped" => UpdateCheckRequestConclusion.Skipped,
                "succeeded" => UpdateCheckRequestConclusion.Succeeded,
                _ => null,
            };
        }
    }
}