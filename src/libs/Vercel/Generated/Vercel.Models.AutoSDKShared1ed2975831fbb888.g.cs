
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared1ed2975831fbb888
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
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared1ed2975831fbb888Condition>? Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crs")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888Crs? Crs { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared1ed2975831fbb888Ip> Ips { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared1ed2975831fbb888LogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared1ed2975831fbb888LogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRules")]
        public global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRules? ManagedRules { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6dc2506c74cb750c> Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared3cefeabeb1d55c64JsonConverter))]
        public global::Vercel.AutoSDKShared3cefeabeb1d55c64? Rulesets { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared1ed2975831fbb888" /> class.
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
        public AutoSDKShared1ed2975831fbb888(
            global::System.Collections.Generic.IList<object> changes,
            bool firewallEnabled,
            string id,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared1ed2975831fbb888Ip> ips,
            string ownerId,
            string projectKey,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6dc2506c74cb750c> rules,
            string updatedAt,
            double version,
            bool? botIdEnabled,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared1ed2975831fbb888Condition>? conditions,
            global::Vercel.AutoSDKShared1ed2975831fbb888Crs? crs,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared1ed2975831fbb888LogHeaders?>? logHeaders,
            global::Vercel.AutoSDKShared1ed2975831fbb888ManagedRules? managedRules,
            global::Vercel.AutoSDKShared3cefeabeb1d55c64? rulesets)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared1ed2975831fbb888" /> class.
        /// </summary>
        public AutoSDKShared1ed2975831fbb888()
        {
        }

    }
}