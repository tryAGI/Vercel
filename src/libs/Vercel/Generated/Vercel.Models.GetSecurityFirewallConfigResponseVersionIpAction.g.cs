
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionIpAction
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseVersionIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionIpAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionIpAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseVersionIpAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseVersionIpAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetSecurityFirewallConfigResponseVersionIpAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseVersionIpAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseVersionIpAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionIpAction.Log,
                _ => null,
            };
        }
    }
}