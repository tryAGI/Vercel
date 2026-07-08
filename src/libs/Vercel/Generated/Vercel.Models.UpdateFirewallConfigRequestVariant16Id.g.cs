
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant16Id
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
    public static class UpdateFirewallConfigRequestVariant16IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant16Id value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant16Id.AiBots => "ai_bots",
                UpdateFirewallConfigRequestVariant16Id.BotFilter => "bot_filter",
                UpdateFirewallConfigRequestVariant16Id.BotProtection => "bot_protection",
                UpdateFirewallConfigRequestVariant16Id.Owasp => "owasp",
                UpdateFirewallConfigRequestVariant16Id.TrafficSources => "traffic_sources",
                UpdateFirewallConfigRequestVariant16Id.VercelRuleset => "vercel_ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant16Id? ToEnum(string value)
        {
            return value switch
            {
                "ai_bots" => UpdateFirewallConfigRequestVariant16Id.AiBots,
                "bot_filter" => UpdateFirewallConfigRequestVariant16Id.BotFilter,
                "bot_protection" => UpdateFirewallConfigRequestVariant16Id.BotProtection,
                "owasp" => UpdateFirewallConfigRequestVariant16Id.Owasp,
                "traffic_sources" => UpdateFirewallConfigRequestVariant16Id.TrafficSources,
                "vercel_ruleset" => UpdateFirewallConfigRequestVariant16Id.VercelRuleset,
                _ => null,
            };
        }
    }
}