
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChecksResponseCheckConclusion
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
    public static class GetAllChecksResponseCheckConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChecksResponseCheckConclusion value)
        {
            return value switch
            {
                GetAllChecksResponseCheckConclusion.Canceled => "canceled",
                GetAllChecksResponseCheckConclusion.Failed => "failed",
                GetAllChecksResponseCheckConclusion.Neutral => "neutral",
                GetAllChecksResponseCheckConclusion.Skipped => "skipped",
                GetAllChecksResponseCheckConclusion.Stale => "stale",
                GetAllChecksResponseCheckConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChecksResponseCheckConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetAllChecksResponseCheckConclusion.Canceled,
                "failed" => GetAllChecksResponseCheckConclusion.Failed,
                "neutral" => GetAllChecksResponseCheckConclusion.Neutral,
                "skipped" => GetAllChecksResponseCheckConclusion.Skipped,
                "stale" => GetAllChecksResponseCheckConclusion.Stale,
                "succeeded" => GetAllChecksResponseCheckConclusion.Succeeded,
                _ => null,
            };
        }
    }
}