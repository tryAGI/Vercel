
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
        /// <summary>
        ///
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared037328971b8d11dbActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.Log => "log",
                AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKShared037328971b8d11dbActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}