
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteUserToTeamRequestItem
    {
        /// <summary>
        /// The email address of the user to invite<br/>
        /// Example: john@example.com
        /// </summary>
        /// <example>john@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The role of the user to invite<br/>
        /// Default Value: VIEWER<br/>
        /// Example: VIEWER
        /// </summary>
        /// <example>VIEWER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.InviteUserToTeamRequestItemRoleJsonConverter))]
        public global::Vercel.InviteUserToTeamRequestItemRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Vercel.InviteUserToTeamRequestItemProject>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserToTeamRequestItem" /> class.
        /// </summary>
        /// <param name="email">
        /// The email address of the user to invite<br/>
        /// Example: john@example.com
        /// </param>
        /// <param name="role">
        /// The role of the user to invite<br/>
        /// Default Value: VIEWER<br/>
        /// Example: VIEWER
        /// </param>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteUserToTeamRequestItem(
            string email,
            global::Vercel.InviteUserToTeamRequestItemRole? role,
            global::System.Collections.Generic.IList<global::Vercel.InviteUserToTeamRequestItemProject>? projects)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserToTeamRequestItem" /> class.
        /// </summary>
        public InviteUserToTeamRequestItem()
        {
        }
    }
}