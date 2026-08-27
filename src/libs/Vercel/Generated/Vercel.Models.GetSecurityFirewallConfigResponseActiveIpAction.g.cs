
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveIpAction
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
    public static class GetSecurityFirewallConfigResponseActiveIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveIpAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveIpAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseActiveIpAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseActiveIpAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetSecurityFirewallConfigResponseActiveIpAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseActiveIpAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseActiveIpAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveIpAction.Log,
                _ => null,
            };
        }
    }
}