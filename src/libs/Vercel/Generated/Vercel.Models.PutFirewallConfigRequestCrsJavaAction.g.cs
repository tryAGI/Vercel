
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestCrsJavaAction
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
    public static class PutFirewallConfigRequestCrsJavaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestCrsJavaAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestCrsJavaAction.Deny => "deny",
                PutFirewallConfigRequestCrsJavaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestCrsJavaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigRequestCrsJavaAction.Deny,
                "log" => PutFirewallConfigRequestCrsJavaAction.Log,
                _ => null,
            };
        }
    }
}