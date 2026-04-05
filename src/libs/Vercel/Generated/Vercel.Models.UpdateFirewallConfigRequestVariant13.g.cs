
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Toggle bot ID
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant13
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant13" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="value"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant13(
            string action,
            bool value,
            string? id)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Id = id;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant13" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant13()
        {
        }
    }
}