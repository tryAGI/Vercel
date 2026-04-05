
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAccessGroupProjectRequest
    {
        /// <summary>
        /// The ID of the project.<br/>
        /// Example: prj_ndlgr43fadlPyCtREAqxxdyFK
        /// </summary>
        /// <example>prj_ndlgr43fadlPyCtREAqxxdyFK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The project role that will be added to this Access Group.<br/>
        /// Example: ADMIN
        /// </summary>
        /// <example>ADMIN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateAccessGroupProjectRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateAccessGroupProjectRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessGroupProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project.<br/>
        /// Example: prj_ndlgr43fadlPyCtREAqxxdyFK
        /// </param>
        /// <param name="role">
        /// The project role that will be added to this Access Group.<br/>
        /// Example: ADMIN
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessGroupProjectRequest(
            string projectId,
            global::Vercel.CreateAccessGroupProjectRequestRole role)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessGroupProjectRequest" /> class.
        /// </summary>
        public CreateAccessGroupProjectRequest()
        {
        }
    }
}