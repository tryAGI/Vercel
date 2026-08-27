
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant21Id
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
        TrafficSources,
        /// <summary>
        ///
        /// </summary>
        VercelRuleset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFirewallConfigRequestVariant21IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant21Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant21Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant21Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant21Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant21Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant21Id.TrafficSources => "traffic_sources",
                UpdateFirewallConfigRequestVariant21Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant21Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant21Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant21Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant21Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant21Id.Owasp,
                "traffic_sources" => UpdateFirewallConfigRequestVariant21Id.TrafficSources,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant21Id.VercelRuleset,
                _ => null,
            };
        }
    }
}