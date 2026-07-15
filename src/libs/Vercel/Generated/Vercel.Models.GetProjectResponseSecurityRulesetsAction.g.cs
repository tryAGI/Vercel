
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityRulesetsAction
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
    public static class GetProjectResponseSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityRulesetsAction value)
        {
            return value switch
            {
                GetProjectResponseSecurityRulesetsAction.Allow => "allow",
                GetProjectResponseSecurityRulesetsAction.Bypass => "bypass",
                GetProjectResponseSecurityRulesetsAction.Challenge => "challenge",
                GetProjectResponseSecurityRulesetsAction.Deny => "deny",
                GetProjectResponseSecurityRulesetsAction.Log => "log",
                GetProjectResponseSecurityRulesetsAction.RateLimit => "rate_limit",
                GetProjectResponseSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetProjectResponseSecurityRulesetsAction.Allow,
                "bypass" => GetProjectResponseSecurityRulesetsAction.Bypass,
                "challenge" => GetProjectResponseSecurityRulesetsAction.Challenge,
                "deny" => GetProjectResponseSecurityRulesetsAction.Deny,
                "log" => GetProjectResponseSecurityRulesetsAction.Log,
                "rate_limit" => GetProjectResponseSecurityRulesetsAction.RateLimit,
                "redirect" => GetProjectResponseSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}