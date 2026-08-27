
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftIpAction
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
    public static class GetSecurityFirewallConfigResponseDraftIpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftIpAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftIpAction.Bypass => "bypass",
                GetSecurityFirewallConfigResponseDraftIpAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftIpAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftIpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftIpAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetSecurityFirewallConfigResponseDraftIpAction.Bypass,
                "challenge" => GetSecurityFirewallConfigResponseDraftIpAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftIpAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftIpAction.Log,
                _ => null,
            };
        }
    }
}