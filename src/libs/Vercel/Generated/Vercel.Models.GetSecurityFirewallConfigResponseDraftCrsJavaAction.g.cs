
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftCrsJavaAction
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
    public static class GetSecurityFirewallConfigResponseDraftCrsJavaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftCrsJavaAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftCrsJavaAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftCrsJavaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftCrsJavaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetSecurityFirewallConfigResponseDraftCrsJavaAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftCrsJavaAction.Log,
                _ => null,
            };
        }
    }
}