
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Add an IP Blocking rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant8ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant8Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public object? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant8Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant8" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="action"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant8(
            global::Vercel.UpdateFirewallConfigRequestVariant8Value value,
            global::Vercel.UpdateFirewallConfigRequestVariant8Action action,
            object? id)
        {
            this.Action = action;
            this.Id = id;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant8" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant8()
        {
        }
    }
}