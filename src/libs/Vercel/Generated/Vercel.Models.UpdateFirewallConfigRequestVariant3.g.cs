
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Update a custom rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant3ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant3Action Action { get; set; }

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
        public required global::Vercel.UpdateFirewallConfigRequestVariant3Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant3" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant3(
            string id,
            global::Vercel.UpdateFirewallConfigRequestVariant3Value value,
            global::Vercel.UpdateFirewallConfigRequestVariant3Action action)
        {
            this.Action = action;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant3" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant3()
        {
        }
    }
}