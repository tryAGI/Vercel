
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveCrsXssAction
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
    public static class GetSecurityFirewallConfigResponseActiveCrsXssActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveCrsXssAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveCrsXssAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveCrsXssAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveCrsXssAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetSecurityFirewallConfigResponseActiveCrsXssAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveCrsXssAction.Log,
                _ => null,
            };
        }
    }
}