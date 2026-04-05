
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemValue>))]
        public global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem(
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemType type,
            string? key,
            global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItemValue>? value)
        {
            this.Type = type;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem()
        {
        }
    }
}