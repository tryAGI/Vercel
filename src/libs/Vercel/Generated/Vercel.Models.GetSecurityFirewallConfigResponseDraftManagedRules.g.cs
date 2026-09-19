
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallConfigResponseDraftManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseDraftManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botProtection"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallConfigResponseDraftManagedRules(
            global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesAiBots? aiBots,
            global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesBotProtection? botProtection,
            global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesOwasp? owasp,
            global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesTrafficSources? trafficSources,
            global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRulesVercelRuleset? vercelRuleset)
        {
            this.AiBots = aiBots;
            this.BotProtection = botProtection;
            this.Owasp = owasp;
            this.TrafficSources = trafficSources;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseDraftManagedRules" /> class.
        /// </summary>
        public GetSecurityFirewallConfigResponseDraftManagedRules()
        {
        }

    }
}