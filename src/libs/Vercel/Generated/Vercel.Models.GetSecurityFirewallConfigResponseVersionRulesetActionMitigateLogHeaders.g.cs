
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseVersionRulesetActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetActionMitigateLogHeaders value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetSecurityFirewallConfigResponseVersionRulesetActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}