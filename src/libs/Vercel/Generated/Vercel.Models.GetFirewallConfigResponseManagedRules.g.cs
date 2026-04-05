
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFirewallConfigResponseManagedRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.GetFirewallConfigResponseManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.GetFirewallConfigResponseManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.GetFirewallConfigResponseManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.GetFirewallConfigResponseManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseManagedRules" /> class.
        /// </summary>
        /// <param name="botProtection"></param>
        /// <param name="aiBots"></param>
        /// <param name="owasp"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFirewallConfigResponseManagedRules(
            global::Vercel.GetFirewallConfigResponseManagedRulesBotProtection? botProtection,
            global::Vercel.GetFirewallConfigResponseManagedRulesAiBots? aiBots,
            global::Vercel.GetFirewallConfigResponseManagedRulesOwasp? owasp,
            global::Vercel.GetFirewallConfigResponseManagedRulesVercelRuleset? vercelRuleset)
        {
            this.BotProtection = botProtection;
            this.AiBots = aiBots;
            this.Owasp = owasp;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseManagedRules" /> class.
        /// </summary>
        public GetFirewallConfigResponseManagedRules()
        {
        }
    }
}