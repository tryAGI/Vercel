
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The principal that last edited this env var, when the editor id resolves to a known user or app. Lets clients render the right avatar instead of assuming every editor is a user.
    /// </summary>
    public sealed partial class AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="avatar"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2(
            string id,
            string name,
            string? avatar,
            global::Vercel.AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2Type type)
        {
            this.Avatar = avatar;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2" /> class.
        /// </summary>
        public AutoSDKShared2e531c6dd7d2b280LastEditedByPrincipalVariant2()
        {
        }

    }
}