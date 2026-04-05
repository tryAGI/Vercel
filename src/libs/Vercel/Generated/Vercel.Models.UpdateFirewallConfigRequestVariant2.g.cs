
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Add a custom rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant2ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant2Action Action { get; set; }

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
        public required global::Vercel.UpdateFirewallConfigRequestVariant2Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="action"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant2(
            global::Vercel.UpdateFirewallConfigRequestVariant2Value value,
            global::Vercel.UpdateFirewallConfigRequestVariant2Action action,
            object? id)
        {
            this.Action = action;
            this.Id = id;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant2" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant2()
        {
        }
    }
}