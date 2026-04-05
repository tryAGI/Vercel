
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddProjectMemberRequest
    {
        /// <summary>
        /// The ID of the team member that should be added to this project.<br/>
        /// Example: ndlgr43fadlPyCtREAqxxdyFK
        /// </summary>
        /// <example>ndlgr43fadlPyCtREAqxxdyFK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The username of the team member that should be added to this project.<br/>
        /// Example: example
        /// </summary>
        /// <example>example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The email of the team member that should be added to this project.<br/>
        /// Example: entity@example.com
        /// </summary>
        /// <example>entity@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The project role of the member that will be added.<br/>
        /// Example: ADMIN
        /// </summary>
        /// <example>ADMIN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AddProjectMemberRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AddProjectMemberRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectMemberRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// The project role of the member that will be added.<br/>
        /// Example: ADMIN
        /// </param>
        /// <param name="uid">
        /// The ID of the team member that should be added to this project.<br/>
        /// Example: ndlgr43fadlPyCtREAqxxdyFK
        /// </param>
        /// <param name="username">
        /// The username of the team member that should be added to this project.<br/>
        /// Example: example
        /// </param>
        /// <param name="email">
        /// The email of the team member that should be added to this project.<br/>
        /// Example: entity@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectMemberRequest(
            global::Vercel.AddProjectMemberRequestRole role,
            string? uid,
            string? username,
            string? email)
        {
            this.Uid = uid;
            this.Username = username;
            this.Email = email;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectMemberRequest" /> class.
        /// </summary>
        public AddProjectMemberRequest()
        {
        }
    }
}