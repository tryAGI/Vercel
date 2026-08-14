
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSecurityFirewallConfigResponseVersion
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FirewallEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crs")]
        public global::Vercel.GetSecurityFirewallConfigResponseVersionCrs? Crs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetSecurityFirewallConfigResponseVersionRuleVariant1, global::Vercel.GetSecurityFirewallConfigResponseVersionRuleVariant2>> Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionIp> Ips { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionRuleset>, global::System.Collections.Generic.Dictionary<string, global::Vercel.GetSecurityFirewallConfigResponseVersionRulesets2>>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionRuleset>, global::System.Collections.Generic.Dictionary<string, global::Vercel.GetSecurityFirewallConfigResponseVersionRulesets2>>? Rulesets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionCondition>? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Changes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRules")]
        public global::Vercel.GetSecurityFirewallConfigResponseVersionManagedRules? ManagedRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.GetSecurityFirewallConfigResponseVersionLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetSecurityFirewallConfigResponseVersionLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseVersion" /> class.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="projectKey"></param>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="updatedAt"></param>
        /// <param name="firewallEnabled"></param>
        /// <param name="rules"></param>
        /// <param name="ips"></param>
        /// <param name="changes"></param>
        /// <param name="crs"></param>
        /// <param name="rulesets"></param>
        /// <param name="conditions"></param>
        /// <param name="managedRules"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="logHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityFirewallConfigResponseVersion(
            string ownerId,
            string projectKey,
            string id,
            double version,
            string updatedAt,
            bool firewallEnabled,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetSecurityFirewallConfigResponseVersionRuleVariant1, global::Vercel.GetSecurityFirewallConfigResponseVersionRuleVariant2>> rules,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionIp> ips,
            global::System.Collections.Generic.IList<object> changes,
            global::Vercel.GetSecurityFirewallConfigResponseVersionCrs? crs,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionRuleset>, global::System.Collections.Generic.Dictionary<string, global::Vercel.GetSecurityFirewallConfigResponseVersionRulesets2>>? rulesets,
            global::System.Collections.Generic.IList<global::Vercel.GetSecurityFirewallConfigResponseVersionCondition>? conditions,
            global::Vercel.GetSecurityFirewallConfigResponseVersionManagedRules? managedRules,
            bool? botIdEnabled,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetSecurityFirewallConfigResponseVersionLogHeaders?>? logHeaders)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectKey = projectKey ?? throw new global::System.ArgumentNullException(nameof(projectKey));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.FirewallEnabled = firewallEnabled;
            this.Crs = crs;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Ips = ips ?? throw new global::System.ArgumentNullException(nameof(ips));
            this.Rulesets = rulesets;
            this.Conditions = conditions;
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
            this.ManagedRules = managedRules;
            this.BotIdEnabled = botIdEnabled;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityFirewallConfigResponseVersion" /> class.
        /// </summary>
        public GetSecurityFirewallConfigResponseVersion()
        {
        }

    }
}