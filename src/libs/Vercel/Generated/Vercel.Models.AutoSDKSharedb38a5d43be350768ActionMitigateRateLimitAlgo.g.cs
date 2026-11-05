
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo
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
    public static class AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedb38a5d43be350768ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}