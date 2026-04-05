
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Update log headers configuration
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant14
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
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>, string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant14" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="value"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant14(
            string action,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>, string> value,
            string? id)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Id = id;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant14" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant14()
        {
        }
    }
}