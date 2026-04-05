
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestCrsGenAction
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
    public static class PutFirewallConfigRequestCrsGenActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestCrsGenAction value)
        {
            return value switch
            {
                PutFirewallConfigRequestCrsGenAction.Deny => "deny",
                PutFirewallConfigRequestCrsGenAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestCrsGenAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => PutFirewallConfigRequestCrsGenAction.Deny,
                "log" => PutFirewallConfigRequestCrsGenAction.Log,
                _ => null,
            };
        }
    }
}