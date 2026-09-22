
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of projects and spaces across teams that a user has marked as a favorite.
    /// </summary>
    public sealed partial class AuthUserFavoriteProjectsAndSpace
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFavoriteProjectsAndSpace" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserFavoriteProjectsAndSpace(
            string projectId,
            string teamId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserFavoriteProjectsAndSpace" /> class.
        /// </summary>
        public AuthUserFavoriteProjectsAndSpace()
        {
        }

    }
}