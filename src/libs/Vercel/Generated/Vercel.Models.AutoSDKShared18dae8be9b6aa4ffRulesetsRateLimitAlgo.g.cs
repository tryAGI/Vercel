
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo
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
    public static class AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared18dae8be9b6aa4ffRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}