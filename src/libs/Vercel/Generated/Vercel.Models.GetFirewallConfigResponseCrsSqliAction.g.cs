
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseCrsSqliAction
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
    public static class GetFirewallConfigResponseCrsSqliActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseCrsSqliAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseCrsSqliAction.Deny => "deny",
                GetFirewallConfigResponseCrsSqliAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseCrsSqliAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetFirewallConfigResponseCrsSqliAction.Deny,
                "log" => GetFirewallConfigResponseCrsSqliAction.Log,
                _ => null,
            };
        }
    }
}