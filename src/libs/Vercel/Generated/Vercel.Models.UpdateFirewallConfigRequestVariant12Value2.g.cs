
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFirewallConfigRequestVariant12Value2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFirewallConfigRequestVariant12ValueActionJsonConverter))]
        public global::Vercel.UpdateFirewallConfigRequestVariant12ValueAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant12Value2" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFirewallConfigRequestVariant12Value2(
            bool active,
            global::Vercel.UpdateFirewallConfigRequestVariant12ValueAction? action)
        {
            this.Active = active;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirewallConfigRequestVariant12Value2" /> class.
        /// </summary>
        public UpdateFirewallConfigRequestVariant12Value2()
        {
        }
    }
}