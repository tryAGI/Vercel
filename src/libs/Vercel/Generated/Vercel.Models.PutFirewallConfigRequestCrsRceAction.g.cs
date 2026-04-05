
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestCrsRceAction
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
    public static class PutFirewallConfigRequestCrsRceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestCrsRceAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestCrsRceAction.Deny => "deny",
                PutFirewallConfigRequestCrsRceAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestCrsRceAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigRequestCrsRceAction.Deny,
                "log" => PutFirewallConfigRequestCrsRceAction.Log,
                _ => null,
            };
        }
    }
}