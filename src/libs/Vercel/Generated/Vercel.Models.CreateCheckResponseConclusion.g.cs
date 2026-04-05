
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Example: succeeded
    /// </summary>
    public enum CreateCheckResponseConclusion
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
    public static class CreateCheckResponseConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCheckResponseConclusion value)
        {
            return value switch
            {
                CreateCheckResponseConclusion.Canceled => "canceled",
                CreateCheckResponseConclusion.Failed => "failed",
                CreateCheckResponseConclusion.Neutral => "neutral",
                CreateCheckResponseConclusion.Skipped => "skipped",
                CreateCheckResponseConclusion.Stale => "stale",
                CreateCheckResponseConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCheckResponseConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateCheckResponseConclusion.Canceled,
                "failed" => CreateCheckResponseConclusion.Failed,
                "neutral" => CreateCheckResponseConclusion.Neutral,
                "skipped" => CreateCheckResponseConclusion.Skipped,
                "stale" => CreateCheckResponseConclusion.Stale,
                "succeeded" => CreateCheckResponseConclusion.Succeeded,
                _ => null,
            };
        }
    }
}