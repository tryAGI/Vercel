
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo
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
    public static class AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared4c958b4a81a75558RulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}