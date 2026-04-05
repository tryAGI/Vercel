
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActive
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
        /// Custom Ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrs Crs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.PutFirewallConfigResponseActiveRuleVariant1, global::Vercel.PutFirewallConfigResponseActiveRuleVariant2>> Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigResponseActiveIp> Ips { get; set; }

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
        public global::Vercel.PutFirewallConfigResponseActiveManagedRules? ManagedRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActive" /> class.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="projectKey"></param>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="updatedAt"></param>
        /// <param name="firewallEnabled"></param>
        /// <param name="crs">
        /// Custom Ruleset
        /// </param>
        /// <param name="rules"></param>
        /// <param name="ips"></param>
        /// <param name="changes"></param>
        /// <param name="managedRules"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="logHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActive(
            string ownerId,
            string projectKey,
            string id,
            double version,
            string updatedAt,
            bool firewallEnabled,
            global::Vercel.PutFirewallConfigResponseActiveCrs crs,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.PutFirewallConfigResponseActiveRuleVariant1, global::Vercel.PutFirewallConfigResponseActiveRuleVariant2>> rules,
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigResponseActiveIp> ips,
            global::System.Collections.Generic.IList<object> changes,
            global::Vercel.PutFirewallConfigResponseActiveManagedRules? managedRules,
            bool? botIdEnabled,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.PutFirewallConfigResponseActiveLogHeaders?>? logHeaders)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectKey = projectKey ?? throw new global::System.ArgumentNullException(nameof(projectKey));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.FirewallEnabled = firewallEnabled;
            this.Crs = crs ?? throw new global::System.ArgumentNullException(nameof(crs));
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Ips = ips ?? throw new global::System.ArgumentNullException(nameof(ips));
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
            this.ManagedRules = managedRules;
            this.BotIdEnabled = botIdEnabled;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActive" /> class.
        /// </summary>
        public PutFirewallConfigResponseActive()
        {
        }
    }
}