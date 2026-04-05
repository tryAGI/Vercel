
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Update a managed ruleset
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant11ActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant11Action Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant11IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant11Id Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant11Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant11" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant11(
            global::Vercel.UpdateFirewallConfigRequestVariant11Id id,
            global::Vercel.UpdateFirewallConfigRequestVariant11Value value,
            global::Vercel.UpdateFirewallConfigRequestVariant11Action action)
        {
            this.Action = action;
            this.Id = id;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant11" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant11()
        {
        }
    }
}