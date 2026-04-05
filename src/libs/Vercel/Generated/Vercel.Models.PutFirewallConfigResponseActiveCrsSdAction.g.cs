
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveCrsSdAction
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
    public static class PutFirewallConfigResponseActiveCrsSdActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveCrsSdAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveCrsSdAction.Deny => "deny",
                PutFirewallConfigResponseActiveCrsSdAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveCrsSdAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigResponseActiveCrsSdAction.Deny,
                "log" => PutFirewallConfigResponseActiveCrsSdAction.Log,
                _ => null,
            };
        }
    }
}