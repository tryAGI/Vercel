
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant135Project
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant3>))]
        public global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant3>? Microfrontends { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant135Project" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="microfrontends"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant135Project(
            string id,
            string name,
            global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant1, global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant2, global::Vercel.UserEventPayloadVariant135ProjectMicrofrontendsVariant3>? microfrontends)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Microfrontends = microfrontends;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant135Project" /> class.
        /// </summary>
        public UserEventPayloadVariant135Project()
        {
        }
    }
}