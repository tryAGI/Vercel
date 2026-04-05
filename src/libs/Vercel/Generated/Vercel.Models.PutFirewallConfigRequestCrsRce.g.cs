
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
    /// </summary>
    public sealed partial class PutFirewallConfigRequestCrsRce
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigRequestCrsRceActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigRequestCrsRceAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestCrsRce" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigRequestCrsRce(
            bool active,
            global::Vercel.PutFirewallConfigRequestCrsRceAction action)
        {
            this.Active = active;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigRequestCrsRce" /> class.
        /// </summary>
        public PutFirewallConfigRequestCrsRce()
        {
        }
    }
}