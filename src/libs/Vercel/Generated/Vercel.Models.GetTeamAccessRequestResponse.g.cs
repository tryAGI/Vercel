
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTeamAccessRequestResponse
    {
        /// <summary>
        /// The slug of the team.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamSlug { get; set; }

        /// <summary>
        /// The name of the team.<br/>
        /// Example: My Team
        /// </summary>
        /// <example>My Team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// Current status of the membership. Will be `true` if confirmed, if pending it'll be `false`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        /// A map that describes the origin from where the user joined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetTeamAccessRequestResponseJoinedFrom JoinedFrom { get; set; }

        /// <summary>
        /// Timestamp in milliseconds when the user requested access to the team.<br/>
        /// Example: 1588720733602L
        /// </summary>
        /// <example>1588720733602L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessRequestedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AccessRequestedAt { get; set; }

        /// <summary>
        /// Map of the connected GitHub account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        public global::Vercel.GetTeamAccessRequestResponseGithub? Github { get; set; }

        /// <summary>
        /// Map of the connected GitLab account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlab")]
        public global::Vercel.GetTeamAccessRequestResponseGitlab? Gitlab { get; set; }

        /// <summary>
        /// Map of the connected Bitbucket account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucket")]
        public global::Vercel.GetTeamAccessRequestResponseBitbucket? Bitbucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamAccessRequestResponse" /> class.
        /// </summary>
        /// <param name="teamSlug">
        /// The slug of the team.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="teamName">
        /// The name of the team.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="confirmed">
        /// Current status of the membership. Will be `true` if confirmed, if pending it'll be `false`.<br/>
        /// Example: false
        /// </param>
        /// <param name="joinedFrom">
        /// A map that describes the origin from where the user joined.
        /// </param>
        /// <param name="accessRequestedAt">
        /// Timestamp in milliseconds when the user requested access to the team.<br/>
        /// Example: 1588720733602L
        /// </param>
        /// <param name="github">
        /// Map of the connected GitHub account.
        /// </param>
        /// <param name="gitlab">
        /// Map of the connected GitLab account.
        /// </param>
        /// <param name="bitbucket">
        /// Map of the connected Bitbucket account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamAccessRequestResponse(
            string teamSlug,
            string teamName,
            bool confirmed,
            global::Vercel.GetTeamAccessRequestResponseJoinedFrom joinedFrom,
            double accessRequestedAt,
            global::Vercel.GetTeamAccessRequestResponseGithub? github,
            global::Vercel.GetTeamAccessRequestResponseGitlab? gitlab,
            global::Vercel.GetTeamAccessRequestResponseBitbucket? bitbucket)
        {
            this.TeamSlug = teamSlug ?? throw new global::System.ArgumentNullException(nameof(teamSlug));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.Confirmed = confirmed;
            this.JoinedFrom = joinedFrom ?? throw new global::System.ArgumentNullException(nameof(joinedFrom));
            this.AccessRequestedAt = accessRequestedAt;
            this.Github = github;
            this.Gitlab = gitlab;
            this.Bitbucket = bitbucket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamAccessRequestResponse" /> class.
        /// </summary>
        public GetTeamAccessRequestResponse()
        {
        }
    }
}