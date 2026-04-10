
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant27AfterResourcesProjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant27AfterResourcesProjectIdsTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant27AfterResourcesProjectIdsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant27AfterResourcesProjectIdsItems Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27AfterResourcesProjectIds" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="items"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant27AfterResourcesProjectIds(
            bool required,
            global::Vercel.UserEventPayloadVariant27AfterResourcesProjectIdsItems items,
            global::Vercel.UserEventPayloadVariant27AfterResourcesProjectIdsType type)
        {
            this.Type = type;
            this.Required = required;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant27AfterResourcesProjectIds" /> class.
        /// </summary>
        public UserEventPayloadVariant27AfterResourcesProjectIds()
        {
        }
    }
}