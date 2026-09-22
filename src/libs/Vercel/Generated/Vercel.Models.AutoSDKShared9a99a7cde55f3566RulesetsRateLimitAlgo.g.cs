
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo
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
    public static class AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared9a99a7cde55f3566RulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}