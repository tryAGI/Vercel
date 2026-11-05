
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb4cb9cbf2561e851ManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4cb9cbf2561e851ManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botProtection"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb4cb9cbf2561e851ManagedRules(
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesAiBots? aiBots,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesBotProtection? botProtection,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesOwasp? owasp,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesTrafficSources? trafficSources,
            global::Vercel.AutoSDKSharedb4cb9cbf2561e851ManagedRulesVercelRuleset? vercelRuleset)
        {
            this.AiBots = aiBots;
            this.BotProtection = botProtection;
            this.Owasp = owasp;
            this.TrafficSources = trafficSources;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4cb9cbf2561e851ManagedRules" /> class.
        /// </summary>
        public AutoSDKSharedb4cb9cbf2561e851ManagedRules()
        {
        }

    }
}