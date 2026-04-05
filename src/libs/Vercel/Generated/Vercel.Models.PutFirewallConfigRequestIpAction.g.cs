
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestIpAction
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
    public static class PutFirewallConfigRequestIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestIpAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestIpAction.Bypass => "bypass",
                PutFirewallConfigRequestIpAction.Challenge => "challenge",
                PutFirewallConfigRequestIpAction.Deny => "deny",
                PutFirewallConfigRequestIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => PutFirewallConfigRequestIpAction.Bypass,
                "challenge" => PutFirewallConfigRequestIpAction.Challenge,
                "deny" => PutFirewallConfigRequestIpAction.Deny,
                "log" => PutFirewallConfigRequestIpAction.Log,
                _ => null,
            };
        }
    }
}