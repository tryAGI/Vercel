
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseCrsLfiAction
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
    public static class GetFirewallConfigResponseCrsLfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseCrsLfiAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseCrsLfiAction.Deny => "deny",
                GetFirewallConfigResponseCrsLfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseCrsLfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetFirewallConfigResponseCrsLfiAction.Deny,
                "log" => GetFirewallConfigResponseCrsLfiAction.Log,
                _ => null,
            };
        }
    }
}