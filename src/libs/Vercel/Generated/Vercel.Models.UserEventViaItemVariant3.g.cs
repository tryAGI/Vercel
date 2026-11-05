
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link viaIds}.
    /// </summary>
    public sealed partial class UserEventViaItemVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The OAuth2 integration ID.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventViaItemVariant3TypeJsonConverter))]
        public global::Vercel.UserEventViaItemVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant3" /> class.
        /// </summary>
        /// <param name="id">
        /// The OAuth2 integration ID.
        /// </param>
        /// <param name="name"></param>
        /// <param name="avatar"></param>
        /// <param name="slug"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventViaItemVariant3(
            string id,
            string name,
            string? avatar,
            string? slug,
            global::Vercel.UserEventViaItemVariant3Type type)
        {
            this.Avatar = avatar;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventViaItemVariant3" /> class.
        /// </summary>
        public UserEventViaItemVariant3()
        {
        }

    }
}