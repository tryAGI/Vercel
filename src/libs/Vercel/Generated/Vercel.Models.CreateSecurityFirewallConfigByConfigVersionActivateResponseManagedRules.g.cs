
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
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules" /> class.
        /// </summary>
        /// <param name="botProtection"></param>
        /// <param name="aiBots"></param>
        /// <param name="owasp"></param>
        /// <param name="vercelRuleset"></param>
        /// <param name="trafficSources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules(
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesBotProtection? botProtection,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesAiBots? aiBots,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesOwasp? owasp,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesVercelRuleset? vercelRuleset,
            global::Vercel.CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRulesTrafficSources? trafficSources)
        {
            this.BotProtection = botProtection;
            this.AiBots = aiBots;
            this.Owasp = owasp;
            this.VercelRuleset = vercelRuleset;
            this.TrafficSources = trafficSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules" /> class.
        /// </summary>
        public CreateSecurityFirewallConfigByConfigVersionActivateResponseManagedRules()
        {
        }

    }
}