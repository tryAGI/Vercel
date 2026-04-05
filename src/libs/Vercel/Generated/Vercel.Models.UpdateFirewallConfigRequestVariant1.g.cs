
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enable Firewall
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant1ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant1Action Action { get; set; }

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
        public required bool Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="action"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant1(
            bool value,
            global::Vercel.UpdateFirewallConfigRequestVariant1Action action,
            object? id)
        {
            this.Action = action;
            this.Id = id;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant1" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant1()
        {
        }
    }
}