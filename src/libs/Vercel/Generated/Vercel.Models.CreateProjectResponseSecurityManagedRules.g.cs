
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseSecurityManagedRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercel_ruleset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectResponseSecurityManagedRulesVercelRuleset VercelRuleset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectResponseSecurityManagedRulesBotFilter BotFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_bots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectResponseSecurityManagedRulesAiBots AiBots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owasp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectResponseSecurityManagedRulesOwasp Owasp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseSecurityManagedRules" /> class.
        /// </summary>
        /// <param name="vercelRuleset"></param>
        /// <param name="botFilter"></param>
        /// <param name="aiBots"></param>
        /// <param name="owasp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseSecurityManagedRules(
            global::Vercel.CreateProjectResponseSecurityManagedRulesVercelRuleset vercelRuleset,
            global::Vercel.CreateProjectResponseSecurityManagedRulesBotFilter botFilter,
            global::Vercel.CreateProjectResponseSecurityManagedRulesAiBots aiBots,
            global::Vercel.CreateProjectResponseSecurityManagedRulesOwasp owasp)
        {
            this.VercelRuleset = vercelRuleset ?? throw new global::System.ArgumentNullException(nameof(vercelRuleset));
            this.BotFilter = botFilter ?? throw new global::System.ArgumentNullException(nameof(botFilter));
            this.AiBots = aiBots ?? throw new global::System.ArgumentNullException(nameof(aiBots));
            this.Owasp = owasp ?? throw new global::System.ArgumentNullException(nameof(owasp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseSecurityManagedRules" /> class.
        /// </summary>
        public CreateProjectResponseSecurityManagedRules()
        {
        }
    }
}