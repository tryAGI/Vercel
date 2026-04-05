
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaValue>))]
        public global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa(
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaType type,
            string? key,
            global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHaValue>? value)
        {
            this.Type = type;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa()
        {
        }
    }
}