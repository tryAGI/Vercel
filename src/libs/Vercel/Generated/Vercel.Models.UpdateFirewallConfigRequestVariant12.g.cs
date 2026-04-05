
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Update a managed rule group
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant12IdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFirewallConfigRequestVariant12Id Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateFirewallConfigRequestVariant12Value2> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant12" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant12(
            string action,
            global::Vercel.UpdateFirewallConfigRequestVariant12Id id,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateFirewallConfigRequestVariant12Value2> value)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Id = id;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant12" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant12()
        {
        }
    }
}