
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Disable a managed rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant7ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant7Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public object? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant7" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant7(
            global::Vercel.UpdateFirewallConfigRequestVariant7Action action,
            object? id,
            object? value)
        {
            this.Action = action;
            this.Id = id;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant7" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant7()
        {
        }
    }
}