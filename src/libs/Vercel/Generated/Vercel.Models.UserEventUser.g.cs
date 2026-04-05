
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link userId}.
    /// </summary>
    public sealed partial class UserEventUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventUser" /> class.
        /// </summary>
        /// <param name="avatar"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="uid"></param>
        /// <param name="slug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventUser(
            string avatar,
            string email,
            string username,
            string uid,
            string? slug)
        {
            this.Slug = slug;
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventUser" /> class.
        /// </summary>
        public UserEventUser()
        {
        }
    }
}