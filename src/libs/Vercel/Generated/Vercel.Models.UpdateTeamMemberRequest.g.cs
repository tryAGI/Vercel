
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTeamMemberRequest
    {
        /// <summary>
        /// Accept a user who requested access to the team.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        public bool? Confirmed { get; set; }

        /// <summary>
        /// The role in the team of the member.<br/>
        /// Default Value: MEMBER<br/>
        /// Example: VIEWER
        /// </summary>
        /// <example>VIEWER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The team permissions to set for the member. Permissions must be compatible with the team roles assigned to the member.<br/>
        /// Example: [CreateProject, FullProductionDeployment]
        /// </summary>
        /// <example>[CreateProject, FullProductionDeployment]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestTeamPermission>? TeamPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestProject>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedFrom")]
        public global::Vercel.UpdateTeamMemberRequestJoinedFrom? JoinedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamMemberRequest" /> class.
        /// </summary>
        /// <param name="confirmed">
        /// Accept a user who requested access to the team.<br/>
        /// Example: true
        /// </param>
        /// <param name="role">
        /// The role in the team of the member.<br/>
        /// Default Value: MEMBER<br/>
        /// Example: VIEWER
        /// </param>
        /// <param name="teamPermissions">
        /// The team permissions to set for the member. Permissions must be compatible with the team roles assigned to the member.<br/>
        /// Example: [CreateProject, FullProductionDeployment]
        /// </param>
        /// <param name="projects"></param>
        /// <param name="joinedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTeamMemberRequest(
            bool? confirmed,
            string? role,
            global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestTeamPermission>? teamPermissions,
            global::System.Collections.Generic.IList<global::Vercel.UpdateTeamMemberRequestProject>? projects,
            global::Vercel.UpdateTeamMemberRequestJoinedFrom? joinedFrom)
        {
            this.Confirmed = confirmed;
            this.Role = role;
            this.TeamPermissions = teamPermissions;
            this.Projects = projects;
            this.JoinedFrom = joinedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamMemberRequest" /> class.
        /// </summary>
        public UpdateTeamMemberRequest()
        {
        }
    }
}