
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo
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
    public static class AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}