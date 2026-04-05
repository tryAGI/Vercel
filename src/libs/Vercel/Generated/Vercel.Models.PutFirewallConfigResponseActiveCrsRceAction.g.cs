
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveCrsRceAction
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
    public static class PutFirewallConfigResponseActiveCrsRceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveCrsRceAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveCrsRceAction.Deny => "deny",
                PutFirewallConfigResponseActiveCrsRceAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveCrsRceAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigResponseActiveCrsRceAction.Deny,
                "log" => PutFirewallConfigResponseActiveCrsRceAction.Log,
                _ => null,
            };
        }
    }
}