
#nullable enable

namespace Vercel
{
    /// <summary>
    /// XSS Attack - Prevent injection of malicious scripts into trusted webpages.
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveCrsXss
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveCrsXssActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsXssAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveCrsXss" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveCrsXss(
            bool active,
            global::Vercel.PutFirewallConfigResponseActiveCrsXssAction action)
        {
            this.Active = active;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveCrsXss" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveCrsXss()
        {
        }
    }
}