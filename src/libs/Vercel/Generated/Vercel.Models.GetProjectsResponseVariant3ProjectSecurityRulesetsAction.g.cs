
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityRulesetsAction
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
    public static class GetProjectsResponseVariant3ProjectSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityRulesetsAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Allow => "allow",
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Bypass => "bypass",
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Challenge => "challenge",
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Deny => "deny",
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Log => "log",
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.RateLimit => "rate_limit",
                GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Allow,
                "bypass" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Bypass,
                "challenge" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Challenge,
                "deny" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Deny,
                "log" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Log,
                "rate_limit" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.RateLimit,
                "redirect" => GetProjectsResponseVariant3ProjectSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}