
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant12Id
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
    public static class UpdateFirewallConfigRequestVariant12IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant12Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant12Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant12Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant12Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant12Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant12Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant12Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant12Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant12Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant12Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant12Id.Owasp,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant12Id.VercelRuleset,
                _ => null,
            };
        }
    }
}