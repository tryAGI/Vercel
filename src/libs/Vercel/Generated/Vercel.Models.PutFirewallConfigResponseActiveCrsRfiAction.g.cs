
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveCrsRfiAction
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
    public static class PutFirewallConfigResponseActiveCrsRfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveCrsRfiAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveCrsRfiAction.Deny => "deny",
                PutFirewallConfigResponseActiveCrsRfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveCrsRfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigResponseActiveCrsRfiAction.Deny,
                "log" => PutFirewallConfigResponseActiveCrsRfiAction.Log,
                _ => null,
            };
        }
    }
}