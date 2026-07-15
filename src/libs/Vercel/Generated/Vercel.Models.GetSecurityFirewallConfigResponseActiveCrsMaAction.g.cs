
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveCrsMaAction
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
    public static class GetSecurityFirewallConfigResponseActiveCrsMaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveCrsMaAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveCrsMaAction.Deny => "deny",
                GetSecurityFirewallConfigResponseActiveCrsMaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveCrsMaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetSecurityFirewallConfigResponseActiveCrsMaAction.Deny,
                "log" => GetSecurityFirewallConfigResponseActiveCrsMaAction.Log,
                _ => null,
            };
        }
    }
}