
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction
    {
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
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Bypass => "bypass",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Log => "log",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.RateLimit => "rate_limit",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Bypass,
                "challenge" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Log,
                "rate_limit" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.RateLimit,
                "redirect" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}