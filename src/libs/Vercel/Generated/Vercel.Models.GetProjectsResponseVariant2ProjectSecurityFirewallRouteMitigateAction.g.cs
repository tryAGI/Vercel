
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Bypass => "bypass",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Log => "log",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.RateLimit => "rate_limit",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Bypass,
                "challenge" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Log,
                "rate_limit" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.RateLimit,
                "redirect" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}