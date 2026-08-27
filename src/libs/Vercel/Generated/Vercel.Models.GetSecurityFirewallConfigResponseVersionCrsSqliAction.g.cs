
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionCrsSqliAction
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
    public static class GetSecurityFirewallConfigResponseVersionCrsSqliActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionCrsSqliAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionCrsSqliAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionCrsSqliAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionCrsSqliAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetSecurityFirewallConfigResponseVersionCrsSqliAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionCrsSqliAction.Log,
                _ => null,
            };
        }
    }
}