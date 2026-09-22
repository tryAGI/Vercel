
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared1629dac811485089ManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        public global::Vercel.AutoSDKShared1629dac811485089ManagedRulesAiBots? AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public global::Vercel.AutoSDKShared1629dac811485089ManagedRulesBotProtection? BotProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        public global::Vercel.AutoSDKShared1629dac811485089ManagedRulesOwasp? Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::Vercel.AutoSDKShared1629dac811485089ManagedRulesTrafficSources? TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        public global::Vercel.AutoSDKShared1629dac811485089ManagedRulesVercelRuleset? VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1629dac811485089ManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botProtection"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared1629dac811485089ManagedRules(
            global::Vercel.AutoSDKShared1629dac811485089ManagedRulesAiBots? aiBots,
            global::Vercel.AutoSDKShared1629dac811485089ManagedRulesBotProtection? botProtection,
            global::Vercel.AutoSDKShared1629dac811485089ManagedRulesOwasp? owasp,
            global::Vercel.AutoSDKShared1629dac811485089ManagedRulesTrafficSources? trafficSources,
            global::Vercel.AutoSDKShared1629dac811485089ManagedRulesVercelRuleset? vercelRuleset)
        {
            this.AiBots = aiBots;
            this.BotProtection = botProtection;
            this.Owasp = owasp;
            this.TrafficSources = trafficSources;
            this.VercelRuleset = vercelRuleset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1629dac811485089ManagedRules" /> class.
        /// </summary>
        public AutoSDKShared1629dac811485089ManagedRules()
        {
        }

    }
}