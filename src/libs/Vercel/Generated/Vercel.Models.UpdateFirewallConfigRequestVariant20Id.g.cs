
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant20Id
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
    public static class UpdateFirewallConfigRequestVariant20IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant20Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant20Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant20Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant20Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant20Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant20Id.TrafficSources => "traffic_sources",
                UpdateFirewallConfigRequestVariant20Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant20Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant20Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant20Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant20Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant20Id.Owasp,
                "traffic_sources" => UpdateFirewallConfigRequestVariant20Id.TrafficSources,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant20Id.VercelRuleset,
                _ => null,
            };
        }
    }
}