
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo
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
    public static class AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedf0cc1038a078908fRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}