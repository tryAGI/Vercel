
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.Log => "log",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.Log,
                "rate_limit" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}