
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared1ed2975831fbb888ManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1ed2975831fbb888ManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botProtection"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared1ed2975831fbb888ManagedRules(
            global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesAiBots? aiBots,
            global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesBotProtection? botProtection,
            global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesOwasp? owasp,
            global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesTrafficSources? trafficSources,
            global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRulesVercelRuleset? vercelRuleset)
        {
            this.AiBots = aiBots;
            this.BotProtection = botProtection;
            this.Owasp = owasp;
            this.TrafficSources = trafficSources;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1ed2975831fbb888ManagedRules" /> class.
        /// </summary>
        public AutoSDKShared1ed2975831fbb888ManagedRules()
        {
        }

    }
}