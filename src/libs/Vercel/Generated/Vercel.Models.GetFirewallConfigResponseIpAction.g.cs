
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseIpAction
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
    public static class GetFirewallConfigResponseIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseIpAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseIpAction.Bypass => "bypass",
                GetFirewallConfigResponseIpAction.Challenge => "challenge",
                GetFirewallConfigResponseIpAction.Deny => "deny",
                GetFirewallConfigResponseIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetFirewallConfigResponseIpAction.Bypass,
                "challenge" => GetFirewallConfigResponseIpAction.Challenge,
                "deny" => GetFirewallConfigResponseIpAction.Deny,
                "log" => GetFirewallConfigResponseIpAction.Log,
                _ => null,
            };
        }
    }
}