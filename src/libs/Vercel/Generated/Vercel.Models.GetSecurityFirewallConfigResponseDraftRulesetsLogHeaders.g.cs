
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetsLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseDraftRulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetsLogHeaders value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetSecurityFirewallConfigResponseDraftRulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}