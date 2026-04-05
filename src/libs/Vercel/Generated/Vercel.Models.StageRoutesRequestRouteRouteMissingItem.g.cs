
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StageRoutesRequestRouteRouteMissingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.StageRoutesRequestRouteRouteMissingItemTypeJsonConverter))]
        public global::Vercel.StageRoutesRequestRouteRouteMissingItemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesRequestRouteRouteMissingItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StageRoutesRequestRouteRouteMissingItem(
            global::Vercel.StageRoutesRequestRouteRouteMissingItemType? type,
            string? key,
            string? value)
        {
            this.Type = type;
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesRequestRouteRouteMissingItem" /> class.
        /// </summary>
        public StageRoutesRequestRouteRouteMissingItem()
        {
        }
    }
}