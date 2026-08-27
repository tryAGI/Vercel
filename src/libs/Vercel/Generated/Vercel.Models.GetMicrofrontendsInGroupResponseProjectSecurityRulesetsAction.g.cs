
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Allow => "allow",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Bypass => "bypass",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Log => "log",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.RateLimit => "rate_limit",
                GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Allow,
                "bypass" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Bypass,
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Log,
                "rate_limit" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.RateLimit,
                "redirect" => GetMicrofrontendsInGroupResponseProjectSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}