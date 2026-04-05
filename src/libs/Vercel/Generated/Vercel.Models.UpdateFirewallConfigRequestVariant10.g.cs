
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Remove an IP Blocking rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant10ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant10Action Action { get; set; }

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
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant10" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="action"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant10(
            string id,
            global::Vercel.UpdateFirewallConfigRequestVariant10Action action,
            object? value)
        {
            this.Action = action;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant10" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant10()
        {
        }
    }
}