
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestCrsSfAction
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
    public static class PutFirewallConfigRequestCrsSfActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestCrsSfAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestCrsSfAction.Deny => "deny",
                PutFirewallConfigRequestCrsSfAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestCrsSfAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigRequestCrsSfAction.Deny,
                "log" => PutFirewallConfigRequestCrsSfAction.Log,
                _ => null,
            };
        }
    }
}