
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Deploys from the Cursor Origin repository linked to the target project. The repository ID must match the linked repository; Vercel resolves the owner and repository name from the project link.
    /// </summary>
    public sealed partial class CreateDeploymentRequestGitSourceVariant9
    {
        /// <summary>
        /// The Origin workspace slug. Optional because Vercel resolves it from the linked project.<br/>
        /// Example: bitbucket_user
        /// </summary>
        /// <example>bitbucket_user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// The branch or Git reference to deploy.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// The Origin repository name. Optional because Vercel resolves it from the linked project.<br/>
        /// Example: next.js
        /// </summary>
        /// <example>next.js</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// The stable Origin repository ID. Read it from the `link.repoId` field returned by the project API.<br/>
        /// Example: 123456789
        /// </summary>
        /// <example>123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        /// The commit SHA to deploy. When omitted, Vercel resolves the latest commit on `ref`.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </summary>
        /// <example>a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestGitSourceVariant9TypeJsonConverter))]
        public global::Vercel.CreateDeploymentRequestGitSourceVariant9Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant9" /> class.
        /// </summary>
        /// <param name="ref">
        /// The branch or Git reference to deploy.<br/>
        /// Example: main
        /// </param>
        /// <param name="repoId">
        /// The stable Origin repository ID. Read it from the `link.repoId` field returned by the project API.<br/>
        /// Example: 123456789
        /// </param>
        /// <param name="owner">
        /// The Origin workspace slug. Optional because Vercel resolves it from the linked project.<br/>
        /// Example: bitbucket_user
        /// </param>
        /// <param name="repo">
        /// The Origin repository name. Optional because Vercel resolves it from the linked project.<br/>
        /// Example: next.js
        /// </param>
        /// <param name="sha">
        /// The commit SHA to deploy. When omitted, Vercel resolves the latest commit on `ref`.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestGitSourceVariant9(
            string @ref,
            string repoId,
            string? owner,
            string? repo,
            string? sha,
            global::Vercel.CreateDeploymentRequestGitSourceVariant9Type type)
        {
            this.Owner = owner;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo;
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Sha = sha;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant9" /> class.
        /// </summary>
        public CreateDeploymentRequestGitSourceVariant9()
        {
        }

    }
}