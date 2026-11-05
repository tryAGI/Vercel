
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo
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
    public static class AutoSDKShared5461df8584cbc999Variant2RateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared5461df8584cbc999Variant2RateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}