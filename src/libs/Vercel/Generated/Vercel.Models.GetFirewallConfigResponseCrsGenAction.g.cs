
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseCrsGenAction
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
    public static class GetFirewallConfigResponseCrsGenActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseCrsGenAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseCrsGenAction.Deny => "deny",
                GetFirewallConfigResponseCrsGenAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseCrsGenAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetFirewallConfigResponseCrsGenAction.Deny,
                "log" => GetFirewallConfigResponseCrsGenAction.Log,
                _ => null,
            };
        }
    }
}