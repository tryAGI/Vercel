
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo
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
    public static class AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}