
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enable a managed rule
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant6ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant6Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant6IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant6Id Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant6Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant6" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant6(
            global::Vercel.UpdateFirewallConfigRequestVariant6Id id,
            global::Vercel.UpdateFirewallConfigRequestVariant6Value value,
            global::Vercel.UpdateFirewallConfigRequestVariant6Action action)
        {
            this.Action = action;
            this.Id = id;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant6" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant6()
        {
        }
    }
}