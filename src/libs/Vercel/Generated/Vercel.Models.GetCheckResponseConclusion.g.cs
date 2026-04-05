
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseConclusion
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
    public static class GetCheckResponseConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseConclusion value)
        {
            return value switch
            {
                GetCheckResponseConclusion.Canceled => "canceled",
                GetCheckResponseConclusion.Failed => "failed",
                GetCheckResponseConclusion.Neutral => "neutral",
                GetCheckResponseConclusion.Skipped => "skipped",
                GetCheckResponseConclusion.Stale => "stale",
                GetCheckResponseConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetCheckResponseConclusion.Canceled,
                "failed" => GetCheckResponseConclusion.Failed,
                "neutral" => GetCheckResponseConclusion.Neutral,
                "skipped" => GetCheckResponseConclusion.Skipped,
                "stale" => GetCheckResponseConclusion.Stale,
                "succeeded" => GetCheckResponseConclusion.Succeeded,
                _ => null,
            };
        }
    }
}