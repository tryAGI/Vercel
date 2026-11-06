
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo
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
    public static class AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared25e1e81cf9eecd30RulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}