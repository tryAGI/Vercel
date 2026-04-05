
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11Id
    {
        /// <summary>
        /// 
        /// </summary>
        AiBots,
        /// <summary>
        /// 
        /// </summary>
        BotFilter,
        /// <summary>
        /// 
        /// </summary>
        BotProtection,
        /// <summary>
        /// 
        /// </summary>
        Owasp,
        /// <summary>
        /// 
        /// </summary>
        VercelRuleset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant11IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant11Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant11Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant11Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant11Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant11Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant11Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant11Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant11Id.Owasp,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant11Id.VercelRuleset,
                _ => null,
            };
        }
    }
}