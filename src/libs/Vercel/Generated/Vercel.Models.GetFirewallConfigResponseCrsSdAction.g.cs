
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseCrsSdAction
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
    public static class GetFirewallConfigResponseCrsSdActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseCrsSdAction value)
        {
            return value switch
            {
                GetFirewallConfigResponseCrsSdAction.Deny => "deny",
                GetFirewallConfigResponseCrsSdAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseCrsSdAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => GetFirewallConfigResponseCrsSdAction.Deny,
                "log" => GetFirewallConfigResponseCrsSdAction.Log,
                _ => null,
            };
        }
    }
}