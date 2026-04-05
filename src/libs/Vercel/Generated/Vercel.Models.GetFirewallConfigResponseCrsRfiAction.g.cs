
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseCrsRfiAction
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
    public static class GetFirewallConfigResponseCrsRfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseCrsRfiAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseCrsRfiAction.Deny => "deny",
                GetFirewallConfigResponseCrsRfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseCrsRfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetFirewallConfigResponseCrsRfiAction.Deny,
                "log" => GetFirewallConfigResponseCrsRfiAction.Log,
                _ => null,
            };
        }
    }
}