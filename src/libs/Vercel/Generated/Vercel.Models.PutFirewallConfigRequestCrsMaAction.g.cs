
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestCrsMaAction
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
    public static class PutFirewallConfigRequestCrsMaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestCrsMaAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestCrsMaAction.Deny => "deny",
                PutFirewallConfigRequestCrsMaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestCrsMaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigRequestCrsMaAction.Deny,
                "log" => PutFirewallConfigRequestCrsMaAction.Log,
                _ => null,
            };
        }
    }
}