
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant17Id
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
    public static class UpdateFirewallConfigRequestVariant17IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant17Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant17Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant17Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant17Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant17Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant17Id.TrafficSources => "traffic_sources",
                UpdateFirewallConfigRequestVariant17Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant17Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant17Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant17Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant17Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant17Id.Owasp,
                "traffic_sources" => UpdateFirewallConfigRequestVariant17Id.TrafficSources,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant17Id.VercelRuleset,
                _ => null,
            };
        }
    }
}