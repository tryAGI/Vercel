
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionCrsJavaAction
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
    public static class GetSecurityFirewallConfigResponseVersionCrsJavaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionCrsJavaAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionCrsJavaAction.Deny => "deny",
                GetSecurityFirewallConfigResponseVersionCrsJavaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionCrsJavaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetSecurityFirewallConfigResponseVersionCrsJavaAction.Deny,
                "log" => GetSecurityFirewallConfigResponseVersionCrsJavaAction.Log,
                _ => null,
            };
        }
    }
}