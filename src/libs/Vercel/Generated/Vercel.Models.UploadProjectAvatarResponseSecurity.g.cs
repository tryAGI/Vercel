
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseSecurity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeActiveUntil")]
        public double? AttackModeActiveUntil { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeEnabled")]
        public bool? AttackModeEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeUpdatedAt")]
        public double? AttackModeUpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallBypassIps")]
        public global::System.Collections.Generic.IList<string>? FirewallBypassIps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallConfigVersion")]
        public double? FirewallConfigVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallEnabled")]
        public bool? FirewallEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallSeawallEnabled")]
        public bool? FirewallSeawallEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallUpdatedAt")]
        public double? FirewallUpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ja3Enabled")]
        public bool? Ja3Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ja4Enabled")]
        public bool? Ja4Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.UploadProjectAvatarResponseSecurityLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UploadProjectAvatarResponseSecurityLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRules")]
        public global::Vercel.UploadProjectAvatarResponseSecurityManagedRules? ManagedRules { get; set; }

        /// <summary>
        /// Whether Page Integrity is enabled for this project. Used by the metadata service to gate DynamoDB lookups against the page-integrity-inventory table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageIntegrityEnabled")]
        public bool? PageIntegrityEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UploadProjectAvatarResponseSecurityRulesets2>? Rulesets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseSecurity" /> class.
        /// </summary>
        /// <param name="attackModeActiveUntil"></param>
        /// <param name="attackModeEnabled"></param>
        /// <param name="attackModeUpdatedAt"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="firewallBypassIps"></param>
        /// <param name="firewallConfigVersion"></param>
        /// <param name="firewallEnabled"></param>
        /// <param name="firewallSeawallEnabled"></param>
        /// <param name="firewallUpdatedAt"></param>
        /// <param name="ja3Enabled"></param>
        /// <param name="ja4Enabled"></param>
        /// <param name="logHeaders"></param>
        /// <param name="managedRules"></param>
        /// <param name="pageIntegrityEnabled">
        /// Whether Page Integrity is enabled for this project. Used by the metadata service to gate DynamoDB lookups against the page-integrity-inventory table.
        /// </param>
        /// <param name="rulesets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseSecurity(
            double? attackModeActiveUntil,
            bool? attackModeEnabled,
            double? attackModeUpdatedAt,
            bool? botIdEnabled,
            global::System.Collections.Generic.IList<string>? firewallBypassIps,
            double? firewallConfigVersion,
            bool? firewallEnabled,
            bool? firewallSeawallEnabled,
            double? firewallUpdatedAt,
            bool? ja3Enabled,
            bool? ja4Enabled,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UploadProjectAvatarResponseSecurityLogHeaders?>? logHeaders,
            global::Vercel.UploadProjectAvatarResponseSecurityManagedRules? managedRules,
            bool? pageIntegrityEnabled,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UploadProjectAvatarResponseSecurityRulesets2>? rulesets)
        {
            this.AttackModeActiveUntil = attackModeActiveUntil;
            this.AttackModeEnabled = attackModeEnabled;
            this.AttackModeUpdatedAt = attackModeUpdatedAt;
            this.BotIdEnabled = botIdEnabled;
            this.FirewallBypassIps = firewallBypassIps;
            this.FirewallConfigVersion = firewallConfigVersion;
            this.FirewallEnabled = firewallEnabled;
            this.FirewallSeawallEnabled = firewallSeawallEnabled;
            this.FirewallUpdatedAt = firewallUpdatedAt;
            this.Ja3Enabled = ja3Enabled;
            this.Ja4Enabled = ja4Enabled;
            this.LogHeaders = logHeaders;
            this.ManagedRules = managedRules;
            this.PageIntegrityEnabled = pageIntegrityEnabled;
            this.Rulesets = rulesets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseSecurity" /> class.
        /// </summary>
        public UploadProjectAvatarResponseSecurity()
        {
        }

    }
}