
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo
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
    public static class AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedc60721415ef8a2a0Variant2RateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}