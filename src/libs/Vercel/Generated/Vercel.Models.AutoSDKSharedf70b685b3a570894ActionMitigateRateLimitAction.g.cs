
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction
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
    public static class AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.Log => "log",
                AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKSharedf70b685b3a570894ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}