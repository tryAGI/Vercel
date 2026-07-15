
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityRulesetsAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityRulesetsAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Allow => "allow",
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Bypass => "bypass",
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Log => "log",
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.RateLimit => "rate_limit",
                GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Allow,
                "bypass" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Bypass,
                "challenge" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Log,
                "rate_limit" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.RateLimit,
                "redirect" => GetProjectsResponseVariant2ProjectSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}