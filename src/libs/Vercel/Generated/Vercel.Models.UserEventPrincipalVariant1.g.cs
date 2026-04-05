
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata for {@link principalId}.
    /// </summary>
    public sealed partial class UserEventPrincipalVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPrincipalVariant1TypeJsonConverter))]
        public global::Vercel.UserEventPrincipalVariant1Type? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPrincipalVariant1" /> class.
        /// </summary>
        /// <param name="avatar"></param>
        /// <param name="email"></param>
        /// <param name="uid"></param>
        /// <param name="username"></param>
        /// <param name="type"></param>
        /// <param name="slug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPrincipalVariant1(
            string avatar,
            string email,
            string uid,
            string username,
            global::Vercel.UserEventPrincipalVariant1Type? type,
            string? slug)
        {
            this.Type = type;
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Slug = slug;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPrincipalVariant1" /> class.
        /// </summary>
        public UserEventPrincipalVariant1()
        {
        }
    }
}