
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botProtection"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules(
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBots? aiBots,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtection? botProtection,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwasp? owasp,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSources? trafficSources,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRuleset? vercelRuleset)
        {
            this.AiBots = aiBots;
            this.BotProtection = botProtection;
            this.Owasp = owasp;
            this.TrafficSources = trafficSources;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules" /> class.
        /// </summary>
        public CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules()
        {
        }

    }
}