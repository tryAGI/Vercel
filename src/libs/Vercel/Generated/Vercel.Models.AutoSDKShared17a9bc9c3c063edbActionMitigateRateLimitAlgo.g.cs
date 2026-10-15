
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo
    {
        /// <summary>
        ///
        /// </summary>
        FixedWindow,
        /// <summary>
        ///
        /// </summary>
        TokenBucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared17a9bc9c3c063edbActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}