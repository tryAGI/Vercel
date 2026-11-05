
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo
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
    public static class AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}