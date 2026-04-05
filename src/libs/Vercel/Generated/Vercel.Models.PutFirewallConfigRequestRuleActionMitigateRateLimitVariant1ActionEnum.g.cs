
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Challenge,
        /// <summary>
        /// 
        /// </summary>
        Deny,
        /// <summary>
        /// 
        /// </summary>
        Log,
        /// <summary>
        /// 
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum value)
        {
            return value switch
            {
                PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.Challenge => "challenge",
                PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.Deny => "deny",
                PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.Log => "log",
                PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.Challenge,
                "deny" => PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.Deny,
                "log" => PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.Log,
                "rate_limit" => PutFirewallConfigRequestRuleActionMitigateRateLimitVariant1ActionEnum.RateLimit,
                _ => null,
            };
        }
    }
}