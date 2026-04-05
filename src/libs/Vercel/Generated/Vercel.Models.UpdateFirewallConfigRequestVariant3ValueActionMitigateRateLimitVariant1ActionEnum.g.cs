
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum
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
    public static class UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.Deny => "deny",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.Log => "log",
                UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.Deny,
                "log" => UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.Log,
                "rate_limit" => UpdateFirewallConfigRequestVariant3ValueActionMitigateRateLimitVariant1ActionEnum.RateLimit,
                _ => null,
            };
        }
    }
}