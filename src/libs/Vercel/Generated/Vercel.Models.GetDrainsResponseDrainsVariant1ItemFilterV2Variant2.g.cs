
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant1ItemFilterV2Variant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2VersionJsonConverter))]
        public global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1, global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1, global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant2> Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant1ItemFilterV2Variant2" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant1ItemFilterV2Variant2(
            global::Vercel.OneOf<global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1, global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant2> filter,
            global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version version)
        {
            this.Version = version;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant1ItemFilterV2Variant2" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant1ItemFilterV2Variant2()
        {
        }
    }
}