
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveCrsXssAction
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
    public static class PutFirewallConfigResponseActiveCrsXssActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveCrsXssAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveCrsXssAction.Deny => "deny",
                PutFirewallConfigResponseActiveCrsXssAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveCrsXssAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigResponseActiveCrsXssAction.Deny,
                "log" => PutFirewallConfigResponseActiveCrsXssAction.Log,
                _ => null,
            };
        }
    }
}