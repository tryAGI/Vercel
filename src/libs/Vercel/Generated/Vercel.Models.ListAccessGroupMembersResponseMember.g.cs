
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAccessGroupMembersResponseMember
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListAccessGroupMembersResponseMemberTeamRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListAccessGroupMembersResponseMemberTeamRole TeamRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccessGroupMembersResponseMember" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="uid"></param>
        /// <param name="username"></param>
        /// <param name="teamRole"></param>
        /// <param name="avatar"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccessGroupMembersResponseMember(
            string email,
            string uid,
            string username,
            global::Vercel.ListAccessGroupMembersResponseMemberTeamRole teamRole,
            string? avatar,
            string? name,
            string? createdAt)
        {
            this.Avatar = avatar;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Name = name;
            this.CreatedAt = createdAt;
            this.TeamRole = teamRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccessGroupMembersResponseMember" /> class.
        /// </summary>
        public ListAccessGroupMembersResponseMember()
        {
        }
    }
}