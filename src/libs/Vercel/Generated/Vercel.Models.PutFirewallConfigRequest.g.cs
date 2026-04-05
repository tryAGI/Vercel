
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewallEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FirewallEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRules")]
        public object? ManagedRules { get; set; }

        /// <summary>
        /// Custom Ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crs")]
        public global::Vercel.PutFirewallConfigRequestCrs? Crs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRule>? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ips")]
        public global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestIp>? Ips { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botIdEnabled")]
        public bool? BotIdEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? LogHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequest" /> class.
        /// </summary>
        /// <param name="firewallEnabled"></param>
        /// <param name="managedRules"></param>
        /// <param name="crs">
        /// Custom Ruleset
        /// </param>
        /// <param name="rules"></param>
        /// <param name="ips"></param>
        /// <param name="botIdEnabled"></param>
        /// <param name="logHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigRequest(
            bool firewallEnabled,
            object? managedRules,
            global::Vercel.PutFirewallConfigRequestCrs? crs,
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestRule>? rules,
            global::System.Collections.Generic.IList<global::Vercel.PutFirewallConfigRequestIp>? ips,
            bool? botIdEnabled,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? logHeaders)
        {
            this.FirewallEnabled = firewallEnabled;
            this.ManagedRules = managedRules;
            this.Crs = crs;
            this.Rules = rules;
            this.Ips = ips;
            this.BotIdEnabled = botIdEnabled;
            this.LogHeaders = logHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequest" /> class.
        /// </summary>
        public PutFirewallConfigRequest()
        {
        }
    }
}