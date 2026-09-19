
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestAccessToTeamResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessRequestedAt")]
        public double? AccessRequestedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucket")]
        public global::Vercel.RequestAccessToTeamResponseBitbucket? Bitbucket { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Confirmed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        public global::Vercel.RequestAccessToTeamResponseGithub? Github { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlab")]
        public global::Vercel.RequestAccessToTeamResponseGitlab? Gitlab { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinedFrom")]
        public global::Vercel.RequestAccessToTeamResponseJoinedFrom? JoinedFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccessToTeamResponse" /> class.
        /// </summary>
        /// <param name="confirmed"></param>
        /// <param name="teamName"></param>
        /// <param name="teamSlug"></param>
        /// <param name="accessRequestedAt"></param>
        /// <param name="bitbucket"></param>
        /// <param name="github"></param>
        /// <param name="gitlab"></param>
        /// <param name="joinedFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAccessToTeamResponse(
            bool confirmed,
            string teamName,
            string teamSlug,
            double? accessRequestedAt,
            global::Vercel.RequestAccessToTeamResponseBitbucket? bitbucket,
            global::Vercel.RequestAccessToTeamResponseGithub? github,
            global::Vercel.RequestAccessToTeamResponseGitlab? gitlab,
            global::Vercel.RequestAccessToTeamResponseJoinedFrom? joinedFrom)
        {
            this.AccessRequestedAt = accessRequestedAt;
            this.Bitbucket = bitbucket;
            this.Confirmed = confirmed;
            this.Github = github;
            this.Gitlab = gitlab;
            this.JoinedFrom = joinedFrom;
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.TeamSlug = teamSlug ?? throw new global::System.ArgumentNullException(nameof(teamSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccessToTeamResponse" /> class.
        /// </summary>
        public RequestAccessToTeamResponse()
        {
        }

    }
}