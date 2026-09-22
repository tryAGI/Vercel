
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo
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
    public static class AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}