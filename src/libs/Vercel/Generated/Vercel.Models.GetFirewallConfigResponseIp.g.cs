
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFirewallConfigResponseIp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetFirewallConfigResponseIpActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseIpAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseIp" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hostname"></param>
        /// <param name="ip"></param>
        /// <param name="action"></param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFirewallConfigResponseIp(
            string id,
            string hostname,
            string ip,
            global::Vercel.GetFirewallConfigResponseIpAction action,
            string? notes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.Notes = notes;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseIp" /> class.
        /// </summary>
        public GetFirewallConfigResponseIp()
        {
        }
    }
}