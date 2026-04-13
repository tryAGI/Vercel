
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant28BeforeResourcesProjectIdsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant28BeforeResourcesProjectIdsItemsTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant28BeforeResourcesProjectIdsItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant28BeforeResourcesProjectIdsItems" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant28BeforeResourcesProjectIdsItems(
            global::Vercel.UserEventPayloadVariant28BeforeResourcesProjectIdsItemsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant28BeforeResourcesProjectIdsItems" /> class.
        /// </summary>
        public UserEventPayloadVariant28BeforeResourcesProjectIdsItems()
        {
        }
    }
}