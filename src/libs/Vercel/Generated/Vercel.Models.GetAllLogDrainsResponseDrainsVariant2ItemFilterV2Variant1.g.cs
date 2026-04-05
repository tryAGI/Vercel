
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1VersionJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1" /> class.
        /// </summary>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1(
            global::Vercel.GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1Version version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant1()
        {
        }
    }
}