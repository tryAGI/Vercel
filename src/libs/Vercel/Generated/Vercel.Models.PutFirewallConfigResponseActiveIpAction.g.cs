
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveIpAction
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
    public static class PutFirewallConfigResponseActiveIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveIpAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveIpAction.Bypass => "bypass",
                PutFirewallConfigResponseActiveIpAction.Challenge => "challenge",
                PutFirewallConfigResponseActiveIpAction.Deny => "deny",
                PutFirewallConfigResponseActiveIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigResponseActiveIpAction.Bypass,
                "challenge" => PutFirewallConfigResponseActiveIpAction.Challenge,
                "deny" => PutFirewallConfigResponseActiveIpAction.Deny,
                "log" => PutFirewallConfigResponseActiveIpAction.Log,
                _ => null,
            };
        }
    }
}