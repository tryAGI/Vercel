
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestAccessToTeamRequestJoinedFrom
    {
        /// <summary>
        /// The origin of the request.<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RequestAccessToTeamRequestJoinedFromOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin Origin { get; set; }

        /// <summary>
        /// The commit sha if the origin is a git provider.<br/>
        /// Example: f498d25d8bd654b578716203be73084b31130cd7
        /// </summary>
        /// <example>f498d25d8bd654b578716203be73084b31130cd7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitId")]
        public string? CommitId { get; set; }

        /// <summary>
        /// The ID of the repository for the given Git provider.<br/>
        /// Example: 67753070
        /// </summary>
        /// <example>67753070</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        public string? RepoId { get; set; }

        /// <summary>
        /// The path to the repository for the given Git provider.<br/>
        /// Example: jane-doe/example
        /// </summary>
        /// <example>jane-doe/example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPath")]
        public string? RepoPath { get; set; }

        /// <summary>
        /// The ID of the Git account of the user who requests access.<br/>
        /// Example: 103053343
        /// </summary>
        /// <example>103053343</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? GitUserId { get; set; }

        /// <summary>
        /// The login name for the Git account of the user who requests access.<br/>
        /// Example: jane-doe
        /// </summary>
        /// <example>jane-doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserLogin")]
        public string? GitUserLogin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccessToTeamRequestJoinedFrom" /> class.
        /// </summary>
        /// <param name="origin">
        /// The origin of the request.<br/>
        /// Example: github
        /// </param>
        /// <param name="commitId">
        /// The commit sha if the origin is a git provider.<br/>
        /// Example: f498d25d8bd654b578716203be73084b31130cd7
        /// </param>
        /// <param name="repoId">
        /// The ID of the repository for the given Git provider.<br/>
        /// Example: 67753070
        /// </param>
        /// <param name="repoPath">
        /// The path to the repository for the given Git provider.<br/>
        /// Example: jane-doe/example
        /// </param>
        /// <param name="gitUserId">
        /// The ID of the Git account of the user who requests access.<br/>
        /// Example: 103053343
        /// </param>
        /// <param name="gitUserLogin">
        /// The login name for the Git account of the user who requests access.<br/>
        /// Example: jane-doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAccessToTeamRequestJoinedFrom(
            global::Vercel.RequestAccessToTeamRequestJoinedFromOrigin origin,
            string? commitId,
            string? repoId,
            string? repoPath,
            global::Vercel.OneOf<string, double?>? gitUserId,
            string? gitUserLogin)
        {
            this.Origin = origin;
            this.CommitId = commitId;
            this.RepoId = repoId;
            this.RepoPath = repoPath;
            this.GitUserId = gitUserId;
            this.GitUserLogin = gitUserLogin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAccessToTeamRequestJoinedFrom" /> class.
        /// </summary>
        public RequestAccessToTeamRequestJoinedFrom()
        {
        }
    }
}