
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => PutFirewallConfigResponseActiveRuleVariant2ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}