
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Scanner Detection - Detect and prevent reconnaissance activities from network scanning tools.
    /// </summary>
    public sealed partial class GetFirewallConfigResponseCrsSd
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetFirewallConfigResponseCrsSdActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetFirewallConfigResponseCrsSdAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseCrsSd" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFirewallConfigResponseCrsSd(
            global::Vercel.GetFirewallConfigResponseCrsSdAction action,
            bool active)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFirewallConfigResponseCrsSd" /> class.
        /// </summary>
        public GetFirewallConfigResponseCrsSd()
        {
        }

    }
}