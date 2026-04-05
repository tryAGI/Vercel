
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Reorder a custom rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant5ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant5Action Action { get; set; }

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
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant5" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant5(
            string id,
            double value,
            global::Vercel.UpdateFirewallConfigRequestVariant5Action action)
        {
            this.Action = action;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant5" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant5()
        {
        }
    }
}