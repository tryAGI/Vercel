
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseSecurity
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallEnabled")]
        public bool? FirewallEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallUpdatedAt")]
        public double? FirewallUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attackModeActiveUntil")]
        public double? AttackModeActiveUntil { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallConfigVersion")]
        public double? FirewallConfigVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallSeawallEnabled")]
        public bool? FirewallSeawallEnabled { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallBypassIps")]
        public global::System.Collections.Generic.IList<string>? FirewallBypassIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRules")]
        public global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRules? ManagedRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.UpdateMicrofrontendsResponseSecurityLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UpdateMicrofrontendsResponseSecurityLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityPlus")]
        public bool? SecurityPlus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseSecurity" /> class.
        /// </summary>
        /// <param name="attackModeEnabled"></param>
        /// <param name="attackModeUpdatedAt"></param>
        /// <param name="firewallEnabled"></param>
        /// <param name="firewallUpdatedAt"></param>
        /// <param name="attackModeActiveUntil"></param>
        /// <param name="firewallConfigVersion"></param>
        /// <param name="firewallSeawallEnabled"></param>
        /// <param name="ja3Enabled"></param>
        /// <param name="ja4Enabled"></param>
        /// <param name="firewallBypassIps"></param>
        /// <param name="managedRules"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="logHeaders"></param>
        /// <param name="securityPlus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseSecurity(
            bool? attackModeEnabled,
            double? attackModeUpdatedAt,
            bool? firewallEnabled,
            double? firewallUpdatedAt,
            double? attackModeActiveUntil,
            double? firewallConfigVersion,
            bool? firewallSeawallEnabled,
            bool? ja3Enabled,
            bool? ja4Enabled,
            global::System.Collections.Generic.IList<string>? firewallBypassIps,
            global::Vercel.UpdateMicrofrontendsResponseSecurityManagedRules? managedRules,
            bool? botIdEnabled,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UpdateMicrofrontendsResponseSecurityLogHeaders?>? logHeaders,
            bool? securityPlus)
        {
            this.AttackModeEnabled = attackModeEnabled;
            this.AttackModeUpdatedAt = attackModeUpdatedAt;
            this.FirewallEnabled = firewallEnabled;
            this.FirewallUpdatedAt = firewallUpdatedAt;
            this.AttackModeActiveUntil = attackModeActiveUntil;
            this.FirewallConfigVersion = firewallConfigVersion;
            this.FirewallSeawallEnabled = firewallSeawallEnabled;
            this.Ja3Enabled = ja3Enabled;
            this.Ja4Enabled = ja4Enabled;
            this.FirewallBypassIps = firewallBypassIps;
            this.ManagedRules = managedRules;
            this.BotIdEnabled = botIdEnabled;
            this.LogHeaders = logHeaders;
            this.SecurityPlus = securityPlus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseSecurity" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseSecurity()
        {
        }
    }
}