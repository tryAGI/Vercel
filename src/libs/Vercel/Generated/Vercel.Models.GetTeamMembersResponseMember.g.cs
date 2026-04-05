
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTeamMembersResponseMember
    {
        /// <summary>
        /// ID of the file for the Avatar of this member.<br/>
        /// Example: 123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Boolean that indicates if this member was confirmed by an owner.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        /// The email of this member.<br/>
        /// Example: jane.doe@example.com
        /// </summary>
        /// <example>jane.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Information about the GitHub account for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        public global::Vercel.GetTeamMembersResponseMemberGithub? Github { get; set; }

        /// <summary>
        /// Information about the GitLab account of this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlab")]
        public global::Vercel.GetTeamMembersResponseMemberGitlab? Gitlab { get; set; }

        /// <summary>
        /// Information about the Bitbucket account of this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucket")]
        public global::Vercel.GetTeamMembersResponseMemberBitbucket? Bitbucket { get; set; }

        /// <summary>
        /// Role of this user in the team.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetTeamMembersResponseMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetTeamMembersResponseMemberRole Role { get; set; }

        /// <summary>
        /// The ID of this user.<br/>
        /// Example: zTuNVUXEAvvnNN3IaqinkyMw
        /// </summary>
        /// <example>zTuNVUXEAvvnNN3IaqinkyMw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The unique username of this user.<br/>
        /// Example: jane-doe
        /// </summary>
        /// <example>jane-doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// The name of this user.<br/>
        /// Example: Jane Doe
        /// </summary>
        /// <example>Jane Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Timestamp in milliseconds when this member was added.<br/>
        /// Example: 1588720733602L
        /// </summary>
        /// <example>1588720733602L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Timestamp in milliseconds for when this team member was accepted by an owner.<br/>
        /// Example: 1588820733602L
        /// </summary>
        /// <example>1588820733602L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessRequestedAt")]
        public double? AccessRequestedAt { get; set; }

        /// <summary>
        /// Map with information about the members origin if they joined by requesting access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedFrom")]
        public global::Vercel.GetTeamMembersResponseMemberJoinedFrom? JoinedFrom { get; set; }

        /// <summary>
        /// Array of project memberships
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseMemberProject>? Projects { get; set; }

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
        /// Initializes a new instance of the <see cref="GetTeamMembersResponseMember" /> class.
        /// </summary>
        /// <param name="confirmed">
        /// Boolean that indicates if this member was confirmed by an owner.<br/>
        /// Example: true
        /// </param>
        /// <param name="email">
        /// The email of this member.<br/>
        /// Example: jane.doe@example.com
        /// </param>
        /// <param name="role">
        /// Role of this user in the team.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="uid">
        /// The ID of this user.<br/>
        /// Example: zTuNVUXEAvvnNN3IaqinkyMw
        /// </param>
        /// <param name="username">
        /// The unique username of this user.<br/>
        /// Example: jane-doe
        /// </param>
        /// <param name="createdAt">
        /// Timestamp in milliseconds when this member was added.<br/>
        /// Example: 1588720733602L
        /// </param>
        /// <param name="avatar">
        /// ID of the file for the Avatar of this member.<br/>
        /// Example: 123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="github">
        /// Information about the GitHub account for this user.
        /// </param>
        /// <param name="gitlab">
        /// Information about the GitLab account of this user.
        /// </param>
        /// <param name="bitbucket">
        /// Information about the Bitbucket account of this user.
        /// </param>
        /// <param name="name">
        /// The name of this user.<br/>
        /// Example: Jane Doe
        /// </param>
        /// <param name="accessRequestedAt">
        /// Timestamp in milliseconds for when this team member was accepted by an owner.<br/>
        /// Example: 1588820733602L
        /// </param>
        /// <param name="joinedFrom">
        /// Map with information about the members origin if they joined by requesting access.
        /// </param>
        /// <param name="projects">
        /// Array of project memberships
        /// </param>
        /// <param name="isEnterpriseManaged">
        /// Indicates whether the user is managed by an enterprise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamMembersResponseMember(
            bool confirmed,
            string email,
            global::Vercel.GetTeamMembersResponseMemberRole role,
            string uid,
            string username,
            double createdAt,
            string? avatar,
            global::Vercel.GetTeamMembersResponseMemberGithub? github,
            global::Vercel.GetTeamMembersResponseMemberGitlab? gitlab,
            global::Vercel.GetTeamMembersResponseMemberBitbucket? bitbucket,
            string? name,
            double? accessRequestedAt,
            global::Vercel.GetTeamMembersResponseMemberJoinedFrom? joinedFrom,
            global::System.Collections.Generic.IList<global::Vercel.GetTeamMembersResponseMemberProject>? projects,
            bool? isEnterpriseManaged)
        {
            this.Avatar = avatar;
            this.Confirmed = confirmed;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Github = github;
            this.Gitlab = gitlab;
            this.Bitbucket = bitbucket;
            this.Role = role;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Name = name;
            this.CreatedAt = createdAt;
            this.AccessRequestedAt = accessRequestedAt;
            this.JoinedFrom = joinedFrom;
            this.Projects = projects;
            this.IsEnterpriseManaged = isEnterpriseManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMembersResponseMember" /> class.
        /// </summary>
        public GetTeamMembersResponseMember()
        {
        }
    }
}