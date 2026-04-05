
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum
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
    public static class UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.Deny => "deny",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.Log => "log",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.Deny,
                "log" => UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant2ValueActionMitigateRateLimitVariant1ActionEnum.RateLimit,
                _ => null,
            };
        }
    }
}