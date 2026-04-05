
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecurity
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
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRoute>? FirewallRoutes { get; set; }

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
        public global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRules? ManagedRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestLogsKey")]
        public global::System.Collections.Generic.IList<string>? RequestLogsKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant1ItemSecurityLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant1ItemSecurityLogHeaders?>? LogHeaders { get; set; }

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
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurity" /> class.
        /// </summary>
        /// <param name="attackModeEnabled"></param>
        /// <param name="attackModeUpdatedAt"></param>
        /// <param name="firewallEnabled"></param>
        /// <param name="firewallUpdatedAt"></param>
        /// <param name="attackModeActiveUntil"></param>
        /// <param name="firewallConfigVersion"></param>
        /// <param name="firewallRoutes"></param>
        /// <param name="firewallSeawallEnabled"></param>
        /// <param name="ja3Enabled"></param>
        /// <param name="ja4Enabled"></param>
        /// <param name="firewallBypassIps"></param>
        /// <param name="managedRules"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="requestLogsKey"></param>
        /// <param name="logHeaders"></param>
        /// <param name="securityPlus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecurity(
            bool? attackModeEnabled,
            double? attackModeUpdatedAt,
            bool? firewallEnabled,
            double? firewallUpdatedAt,
            double? attackModeActiveUntil,
            double? firewallConfigVersion,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRoute>? firewallRoutes,
            bool? firewallSeawallEnabled,
            bool? ja3Enabled,
            bool? ja4Enabled,
            global::System.Collections.Generic.IList<string>? firewallBypassIps,
            global::Vercel.GetProjectsResponseVariant1ItemSecurityManagedRules? managedRules,
            bool? botIdEnabled,
            global::System.Collections.Generic.IList<string>? requestLogsKey,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.GetProjectsResponseVariant1ItemSecurityLogHeaders?>? logHeaders,
            bool? securityPlus)
        {
            this.AttackModeEnabled = attackModeEnabled;
            this.AttackModeUpdatedAt = attackModeUpdatedAt;
            this.FirewallEnabled = firewallEnabled;
            this.FirewallUpdatedAt = firewallUpdatedAt;
            this.AttackModeActiveUntil = attackModeActiveUntil;
            this.FirewallConfigVersion = firewallConfigVersion;
            this.FirewallRoutes = firewallRoutes;
            this.FirewallSeawallEnabled = firewallSeawallEnabled;
            this.Ja3Enabled = ja3Enabled;
            this.Ja4Enabled = ja4Enabled;
            this.FirewallBypassIps = firewallBypassIps;
            this.ManagedRules = managedRules;
            this.BotIdEnabled = botIdEnabled;
            this.RequestLogsKey = requestLogsKey;
            this.LogHeaders = logHeaders;
            this.SecurityPlus = securityPlus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurity" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecurity()
        {
        }
    }
}