
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction
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
    public static class AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.Log => "log",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}