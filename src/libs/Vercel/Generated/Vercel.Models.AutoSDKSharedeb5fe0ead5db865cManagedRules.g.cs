
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedeb5fe0ead5db865cManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedeb5fe0ead5db865cManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botProtection"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedeb5fe0ead5db865cManagedRules(
            global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesAiBots? aiBots,
            global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesBotProtection? botProtection,
            global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesOwasp? owasp,
            global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesTrafficSources? trafficSources,
            global::Vercel.AutoSDKSharedeb5fe0ead5db865cManagedRulesVercelRuleset? vercelRuleset)
        {
            this.AiBots = aiBots;
            this.BotProtection = botProtection;
            this.Owasp = owasp;
            this.TrafficSources = trafficSources;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedeb5fe0ead5db865cManagedRules" /> class.
        /// </summary>
        public AutoSDKSharedeb5fe0ead5db865cManagedRules()
        {
        }

    }
}