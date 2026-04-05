
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant8Value
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant8ValueActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant8ValueAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant8Value" /> class.
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="ip"></param>
        /// <param name="action"></param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant8Value(
            string hostname,
            string ip,
            global::Vercel.UpdateFirewallConfigRequestVariant8ValueAction action,
            string? notes)
        {
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.Notes = notes;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant8Value" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant8Value()
        {
        }
    }
}