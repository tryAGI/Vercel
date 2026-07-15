
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityRulesetsAction
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
    public static class GetProjectsResponseVariant1ItemSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityRulesetsAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.Allow => "allow",
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.Bypass => "bypass",
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.Log => "log",
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.RateLimit => "rate_limit",
                GetProjectsResponseVariant1ItemSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.Allow,
                "bypass" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.Bypass,
                "challenge" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.Log,
                "rate_limit" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.RateLimit,
                "redirect" => GetProjectsResponseVariant1ItemSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}