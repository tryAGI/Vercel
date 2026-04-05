
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveCrsMaAction
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
    public static class PutFirewallConfigResponseActiveCrsMaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveCrsMaAction value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveCrsMaAction.Deny => "deny",
                PutFirewallConfigResponseActiveCrsMaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveCrsMaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigResponseActiveCrsMaAction.Deny,
                "log" => PutFirewallConfigResponseActiveCrsMaAction.Log,
                _ => null,
            };
        }
    }
}