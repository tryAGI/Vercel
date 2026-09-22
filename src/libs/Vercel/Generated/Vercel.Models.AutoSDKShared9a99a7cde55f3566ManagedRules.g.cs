
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9a99a7cde55f3566ManagedRules
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesAiBots AiBots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilter BotFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesOwasp Owasp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesTrafficSources TrafficSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRuleset VercelRuleset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566ManagedRules" /> class.
        /// </summary>
        /// <param name="aiBots"></param>
        /// <param name="botFilter"></param>
        /// <param name="owasp"></param>
        /// <param name="trafficSources"></param>
        /// <param name="vercelRuleset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9a99a7cde55f3566ManagedRules(
            global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesAiBots aiBots,
            global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesBotFilter botFilter,
            global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesOwasp owasp,
            global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesTrafficSources trafficSources,
            global::Vercel.AutoSDKShared9a99a7cde55f3566ManagedRulesVercelRuleset vercelRuleset)
        {
            this.AiBots = aiBots ?? throw new global::System.ArgumentNullException(nameof(aiBots));
            this.BotFilter = botFilter ?? throw new global::System.ArgumentNullException(nameof(botFilter));
            this.Owasp = owasp ?? throw new global::System.ArgumentNullException(nameof(owasp));
            this.TrafficSources = trafficSources ?? throw new global::System.ArgumentNullException(nameof(trafficSources));
            this.VercelRuleset = vercelRuleset ?? throw new global::System.ArgumentNullException(nameof(vercelRuleset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566ManagedRules" /> class.
        /// </summary>
        public AutoSDKShared9a99a7cde55f3566ManagedRules()
        {
        }

    }
}