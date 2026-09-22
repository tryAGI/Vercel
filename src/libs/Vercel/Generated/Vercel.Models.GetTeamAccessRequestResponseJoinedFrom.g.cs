
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A map that describes the origin from where the user joined.
    /// </summary>
    public sealed partial class GetTeamAccessRequestResponseJoinedFrom
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitId")]
        public string? CommitId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsyncConnectedAt")]
        public double? DsyncConnectedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsyncUserId")]
        public string? DsyncUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? GitUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserLogin")]
        public string? GitUserLogin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idpUserId")]
        public string? IdpUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetTeamAccessRequestResponseJoinedFromOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        public string? RepoId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPath")]
        public string? RepoPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoConnectedAt")]
        public double? SsoConnectedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoUserId")]
        public string? SsoUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamAccessRequestResponseJoinedFrom" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="commitId"></param>
        /// <param name="dsyncConnectedAt"></param>
        /// <param name="dsyncUserId"></param>
        /// <param name="gitUserId"></param>
        /// <param name="gitUserLogin"></param>
        /// <param name="idpUserId"></param>
        /// <param name="repoId"></param>
        /// <param name="repoPath"></param>
        /// <param name="ssoConnectedAt"></param>
        /// <param name="ssoUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamAccessRequestResponseJoinedFrom(
            global::Vercel.GetTeamAccessRequestResponseJoinedFromOrigin origin,
            string? commitId,
            double? dsyncConnectedAt,
            string? dsyncUserId,
            global::Vercel.OneOf<string, double?>? gitUserId,
            string? gitUserLogin,
            string? idpUserId,
            string? repoId,
            string? repoPath,
            double? ssoConnectedAt,
            string? ssoUserId)
        {
            this.CommitId = commitId;
            this.DsyncConnectedAt = dsyncConnectedAt;
            this.DsyncUserId = dsyncUserId;
            this.GitUserId = gitUserId;
            this.GitUserLogin = gitUserLogin;
            this.IdpUserId = idpUserId;
            this.Origin = origin;
            this.RepoId = repoId;
            this.RepoPath = repoPath;
            this.SsoConnectedAt = ssoConnectedAt;
            this.SsoUserId = ssoUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamAccessRequestResponseJoinedFrom" /> class.
        /// </summary>
        public GetTeamAccessRequestResponseJoinedFrom()
        {
        }

    }
}