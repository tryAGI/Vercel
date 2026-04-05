
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetFirewallConfigResponseRuleVariant1ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}