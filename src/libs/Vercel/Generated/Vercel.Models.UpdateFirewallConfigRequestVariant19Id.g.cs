
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant19Id
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
    public static class UpdateFirewallConfigRequestVariant19IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant19Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant19Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant19Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant19Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant19Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant19Id.TrafficSources => "traffic_sources",
                UpdateFirewallConfigRequestVariant19Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant19Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant19Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant19Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant19Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant19Id.Owasp,
                "traffic_sources" => UpdateFirewallConfigRequestVariant19Id.TrafficSources,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant19Id.VercelRuleset,
                _ => null,
            };
        }
    }
}