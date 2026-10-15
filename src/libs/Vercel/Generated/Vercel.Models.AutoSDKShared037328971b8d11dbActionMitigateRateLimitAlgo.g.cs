
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo
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
    public static class AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared037328971b8d11dbActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}