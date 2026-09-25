
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The principal that last edited this env var, when the editor id resolves to a known user or app. Lets clients render the right avatar instead of assuming every editor is a user.
    /// </summary>
    public sealed partial class ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1
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
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1TypeJsonConverter))]
        public global::Vercel.ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="avatar"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1(
            string id,
            string username,
            string? avatar,
            string? name,
            global::Vercel.ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1Type type)
        {
            this.Avatar = avatar;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Type = type;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1" /> class.
        /// </summary>
        public ListSharedEnvVariableResponseDataItemLastEditedByPrincipalVariant1()
        {
        }

    }
}