
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Update an IP Blocking rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant9ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant9Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant9Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant9" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant9(
            string id,
            global::Vercel.UpdateFirewallConfigRequestVariant9Value value,
            global::Vercel.UpdateFirewallConfigRequestVariant9Action action)
        {
            this.Action = action;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant9" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant9()
        {
        }
    }
}