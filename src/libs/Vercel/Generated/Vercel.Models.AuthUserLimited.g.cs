
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A limited form of data for the currently authenticated User, due to the authentication token missing privileges to read the full User data.
    /// </summary>
    public sealed partial class AuthUserLimited
    {
        /// <summary>
        /// Property indicating that this User data contains only limited information, due to the authentication token missing privileges to read the full User data. Re-login with email, GitHub, GitLab or Bitbucket in order to upgrade the authentication token with the necessary privileges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Limited { get; set; }

        /// <summary>
        /// The User's unique identifier.<br/>
        /// Example: AEIIDYVk59zbFF2Sxfyxxmua
        /// </summary>
        /// <example>AEIIDYVk59zbFF2Sxfyxxmua</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address associated with the User account.<br/>
        /// Example: me@example.com
        /// </summary>
        /// <example>me@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Name associated with the User account, or `null` if none has been provided.<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique username associated with the User account.<br/>
        /// Example: jdoe
        /// </summary>
        /// <example>jdoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// SHA1 hash of the avatar for the User account. Can be used in conjuction with the ... endpoint to retrieve the avatar image.<br/>
        /// Example: 22cb30c85ff45ac4c72de8981500006b28114aa1
        /// </summary>
        /// <example>22cb30c85ff45ac4c72de8981500006b28114aa1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The user's default team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultTeamId")]
        public string? DefaultTeamId { get; set; }

        /// <summary>
        /// Indicates whether the user is managed by an enterprise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnterpriseManaged")]
        public bool? IsEnterpriseManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserLimited" /> class.
        /// </summary>
        /// <param name="limited">
        /// Property indicating that this User data contains only limited information, due to the authentication token missing privileges to read the full User data. Re-login with email, GitHub, GitLab or Bitbucket in order to upgrade the authentication token with the necessary privileges.
        /// </param>
        /// <param name="id">
        /// The User's unique identifier.<br/>
        /// Example: AEIIDYVk59zbFF2Sxfyxxmua
        /// </param>
        /// <param name="email">
        /// Email address associated with the User account.<br/>
        /// Example: me@example.com
        /// </param>
        /// <param name="username">
        /// Unique username associated with the User account.<br/>
        /// Example: jdoe
        /// </param>
        /// <param name="name">
        /// Name associated with the User account, or `null` if none has been provided.<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="avatar">
        /// SHA1 hash of the avatar for the User account. Can be used in conjuction with the ... endpoint to retrieve the avatar image.<br/>
        /// Example: 22cb30c85ff45ac4c72de8981500006b28114aa1
        /// </param>
        /// <param name="defaultTeamId">
        /// The user's default team.
        /// </param>
        /// <param name="isEnterpriseManaged">
        /// Indicates whether the user is managed by an enterprise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserLimited(
            bool limited,
            string id,
            string email,
            string username,
            string? name,
            string? avatar,
            string? defaultTeamId,
            bool? isEnterpriseManaged)
        {
            this.Limited = limited;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Avatar = avatar;
            this.DefaultTeamId = defaultTeamId;
            this.IsEnterpriseManaged = isEnterpriseManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserLimited" /> class.
        /// </summary>
        public AuthUserLimited()
        {
        }
    }
}