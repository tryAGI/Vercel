
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction
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
    public static class AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.Log => "log",
                AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKSharede10df3c22a339c10ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}