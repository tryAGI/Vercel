
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction
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
    public static class AutoSDKShared44c5e53073934a2bActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.Log => "log",
                AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKShared44c5e53073934a2bActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}