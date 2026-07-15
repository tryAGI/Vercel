
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionCrsPhpAction
    {
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
    public static class GetSecurityFirewallConfigResponseVersionCrsPhpActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionCrsPhpAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionCrsPhpAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionCrsPhpAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionCrsPhpAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetSecurityFirewallConfigResponseVersionCrsPhpAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionCrsPhpAction.Log,
                _ => null,
            };
        }
    }
}