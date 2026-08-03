
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveRepositoryPermissionRequest
    {
        /// <summary>
        /// ID of a team that is granted access to a repository.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </summary>
        /// <example>team_LLHUOMOoDlqOp8wPE4kFo9pE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Slug of a team that is granted access to a repository.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamSlug")]
        public string? TeamSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveRepositoryPermissionRequest" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of a team that is granted access to a repository.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </param>
        /// <param name="teamSlug">
        /// Slug of a team that is granted access to a repository.<br/>
        /// Example: my-team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveRepositoryPermissionRequest(
            string? teamId,
            string? teamSlug)
        {
            this.TeamId = teamId;
            this.TeamSlug = teamSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveRepositoryPermissionRequest" /> class.
        /// </summary>
        public RemoveRepositoryPermissionRequest()
        {
        }

    }
}