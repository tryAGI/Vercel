
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveManagedRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.PutFirewallConfigResponseActiveManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.PutFirewallConfigResponseActiveManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.PutFirewallConfigResponseActiveManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.PutFirewallConfigResponseActiveManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveManagedRules" /> class.
        /// </summary>
        /// <param name="botProtection"></param>
        /// <param name="aiBots"></param>
        /// <param name="owasp"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveManagedRules(
            global::Vercel.PutFirewallConfigResponseActiveManagedRulesBotProtection? botProtection,
            global::Vercel.PutFirewallConfigResponseActiveManagedRulesAiBots? aiBots,
            global::Vercel.PutFirewallConfigResponseActiveManagedRulesOwasp? owasp,
            global::Vercel.PutFirewallConfigResponseActiveManagedRulesVercelRuleset? vercelRuleset)
        {
            this.BotProtection = botProtection;
            this.AiBots = aiBots;
            this.Owasp = owasp;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveManagedRules" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveManagedRules()
        {
        }
    }
}