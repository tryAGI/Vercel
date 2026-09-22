
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo
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
    public static class AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}