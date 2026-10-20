
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beConclusion
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
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede3c00aaf9d3a15beConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beConclusion value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beConclusion.Canceled => "canceled",
                AutoSDKSharede3c00aaf9d3a15beConclusion.Failed => "failed",
                AutoSDKSharede3c00aaf9d3a15beConclusion.Neutral => "neutral",
                AutoSDKSharede3c00aaf9d3a15beConclusion.Skipped => "skipped",
                AutoSDKSharede3c00aaf9d3a15beConclusion.Succeeded => "succeeded",
                AutoSDKSharede3c00aaf9d3a15beConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKSharede3c00aaf9d3a15beConclusion.Canceled,
                "failed" => AutoSDKSharede3c00aaf9d3a15beConclusion.Failed,
                "neutral" => AutoSDKSharede3c00aaf9d3a15beConclusion.Neutral,
                "skipped" => AutoSDKSharede3c00aaf9d3a15beConclusion.Skipped,
                "succeeded" => AutoSDKSharede3c00aaf9d3a15beConclusion.Succeeded,
                "timeout" => AutoSDKSharede3c00aaf9d3a15beConclusion.Timeout,
                _ => null,
            };
        }
    }
}