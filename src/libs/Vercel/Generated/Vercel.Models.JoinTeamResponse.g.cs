
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Successfully joined a team.
    /// </summary>
    public sealed partial class JoinTeamResponse
    {
        /// <summary>
        /// The ID of the team the user joined.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </summary>
        /// <example>team_LLHUOMOoDlqOp8wPE4kFo9pE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The slug of the team the user joined.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The name of the team the user joined.<br/>
        /// Example: My Team
        /// </summary>
        /// <example>My Team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The origin of how the user joined.<br/>
        /// Example: email
        /// </summary>
        /// <example>email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinTeamResponse" /> class.
        /// </summary>
        /// <param name="teamId">
        /// The ID of the team the user joined.<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </param>
        /// <param name="slug">
        /// The slug of the team the user joined.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="name">
        /// The name of the team the user joined.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="from">
        /// The origin of how the user joined.<br/>
        /// Example: email
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JoinTeamResponse(
            string teamId,
            string slug,
            string name,
            string from)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinTeamResponse" /> class.
        /// </summary>
        public JoinTeamResponse()
        {
        }
    }
}