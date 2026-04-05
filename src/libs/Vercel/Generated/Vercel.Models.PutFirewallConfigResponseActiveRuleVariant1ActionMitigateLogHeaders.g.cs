
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => PutFirewallConfigResponseActiveRuleVariant1ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}