
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information of the user who created the alias
    /// </summary>
    public sealed partial class GetAliasResponseCreator
    {
        /// <summary>
        /// ID of the user who created the alias<br/>
        /// Example: 96SnxkFiMyVKsK3pnoHfx3Hz
        /// </summary>
        /// <example>96SnxkFiMyVKsK3pnoHfx3Hz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Email of the user who created the alias<br/>
        /// Example: john-doe@gmail.com
        /// </summary>
        /// <example>john-doe@gmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Username of the user who created the alias<br/>
        /// Example: john-doe
        /// </summary>
        /// <example>john-doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseCreator" /> class.
        /// </summary>
        /// <param name="uid">
        /// ID of the user who created the alias<br/>
        /// Example: 96SnxkFiMyVKsK3pnoHfx3Hz
        /// </param>
        /// <param name="email">
        /// Email of the user who created the alias<br/>
        /// Example: john-doe@gmail.com
        /// </param>
        /// <param name="username">
        /// Username of the user who created the alias<br/>
        /// Example: john-doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAliasResponseCreator(
            string uid,
            string email,
            string username)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponseCreator" /> class.
        /// </summary>
        public GetAliasResponseCreator()
        {
        }
    }
}