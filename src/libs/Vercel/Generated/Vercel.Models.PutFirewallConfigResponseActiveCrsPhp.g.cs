
#nullable enable

namespace Vercel
{
    /// <summary>
    /// PHP Attack - Safeguard against vulnerability exploits in PHP-based applications.
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveCrsPhp
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PutFirewallConfigResponseActiveCrsPhpActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutFirewallConfigResponseActiveCrsPhpAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveCrsPhp" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveCrsPhp(
            bool active,
            global::Vercel.PutFirewallConfigResponseActiveCrsPhpAction action)
        {
            this.Active = active;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveCrsPhp" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveCrsPhp()
        {
        }
    }
}