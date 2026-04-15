
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant260
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedTeamName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestedTeamName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedUserName")]
        public string? RequestedUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUsername")]
        public string? GitUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubUsername")]
        public string? GithubUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabUsername")]
        public string? GitlabUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitbucketUsername")]
        public string? BitbucketUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant260" /> class.
        /// </summary>
        /// <param name="requestedTeamName"></param>
        /// <param name="requestedUserName"></param>
        /// <param name="gitUsername"></param>
        /// <param name="githubUsername"></param>
        /// <param name="gitlabUsername"></param>
        /// <param name="bitbucketUsername"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant260(
            string requestedTeamName,
            string? requestedUserName,
            string? gitUsername,
            string? githubUsername,
            string? gitlabUsername,
            string? bitbucketUsername)
        {
            this.RequestedTeamName = requestedTeamName ?? throw new global::System.ArgumentNullException(nameof(requestedTeamName));
            this.RequestedUserName = requestedUserName;
            this.GitUsername = gitUsername;
            this.GithubUsername = githubUsername;
            this.GitlabUsername = gitlabUsername;
            this.BitbucketUsername = bitbucketUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant260" /> class.
        /// </summary>
        public UserEventPayloadVariant260()
        {
        }
    }
}