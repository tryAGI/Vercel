
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseSecurityManagedRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesVercelRuleset VercelRuleset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesBotFilter BotFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesAiBots AiBots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesOwasp Owasp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseSecurityManagedRules" /> class.
        /// </summary>
        /// <param name="vercelRuleset"></param>
        /// <param name="botFilter"></param>
        /// <param name="aiBots"></param>
        /// <param name="owasp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseSecurityManagedRules(
            global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesVercelRuleset vercelRuleset,
            global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesBotFilter botFilter,
            global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesAiBots aiBots,
            global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRulesOwasp owasp)
        {
            this.VercelRuleset = vercelRuleset ?? throw new global::System.ArgumentNullException(nameof(vercelRuleset));
            this.BotFilter = botFilter ?? throw new global::System.ArgumentNullException(nameof(botFilter));
            this.AiBots = aiBots ?? throw new global::System.ArgumentNullException(nameof(aiBots));
            this.Owasp = owasp ?? throw new global::System.ArgumentNullException(nameof(owasp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseSecurityManagedRules" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseSecurityManagedRules()
        {
        }
    }
}