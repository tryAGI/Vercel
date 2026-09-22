
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSecurityFirewallConfigResponseDraft
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Changes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftCondition>? Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crs")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftCrs? Crs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FirewallEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftIp> Ips { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.GetSecurityFirewallConfigResponseDraftLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetSecurityFirewallConfigResponseDraftLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRules")]
        public global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRules? ManagedRules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetSecurityFirewallConfigResponseDraftRuleVariant1, global::Vercel.GetSecurityFirewallConfigResponseDraftRuleVariant2>> Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftRuleset>, global::System.Collections.Generic.Dictionary<string, global::Vercel.GetSecurityFirewallConfigResponseDraftRulesets2>>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftRuleset>, global::System.Collections.Generic.Dictionary<string, global::Vercel.GetSecurityFirewallConfigResponseDraftRulesets2>>? Rulesets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseDraft" /> class.
        /// </summary>
        /// <param name="changes"></param>
        /// <param name="firewallEnabled"></param>
        /// <param name="id"></param>
        /// <param name="ips"></param>
        /// <param name="ownerId"></param>
        /// <param name="projectKey"></param>
        /// <param name="rules"></param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="conditions"></param>
        /// <param name="crs"></param>
        /// <param name="logHeaders"></param>
        /// <param name="managedRules"></param>
        /// <param name="rulesets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallConfigResponseDraft(
            global::System.Collections.Generic.IList<object> changes,
            bool firewallEnabled,
            string id,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftIp> ips,
            string ownerId,
            string projectKey,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetSecurityFirewallConfigResponseDraftRuleVariant1, global::Vercel.GetSecurityFirewallConfigResponseDraftRuleVariant2>> rules,
            string updatedAt,
            double version,
            bool? botIdEnabled,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftCondition>? conditions,
            global::Vercel.GetSecurityFirewallConfigResponseDraftCrs? crs,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetSecurityFirewallConfigResponseDraftLogHeaders?>? logHeaders,
            global::Vercel.GetSecurityFirewallConfigResponseDraftManagedRules? managedRules,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseDraftRuleset>, global::System.Collections.Generic.Dictionary<string, global::Vercel.GetSecurityFirewallConfigResponseDraftRulesets2>>? rulesets)
        {
            this.BotIdEnabled = botIdEnabled;
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
            this.Conditions = conditions;
            this.Crs = crs;
            this.FirewallEnabled = firewallEnabled;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Ips = ips ?? throw new global::System.ArgumentNullException(nameof(ips));
            this.LogHeaders = logHeaders;
            this.ManagedRules = managedRules;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectKey = projectKey ?? throw new global::System.ArgumentNullException(nameof(projectKey));
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Rulesets = rulesets;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseDraft" /> class.
        /// </summary>
        public GetSecurityFirewallConfigResponseDraft()
        {
        }

    }
}