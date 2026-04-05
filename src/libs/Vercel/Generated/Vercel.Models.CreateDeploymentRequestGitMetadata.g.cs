
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Populates initial git metadata for different git providers.
    /// </summary>
    public sealed partial class CreateDeploymentRequestGitMetadata
    {
        /// <summary>
        /// The git repository's remote origin url<br/>
        /// Example: https://github.com/vercel/next.js
        /// </summary>
        /// <example>https://github.com/vercel/next.js</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteUrl")]
        public string? RemoteUrl { get; set; }

        /// <summary>
        /// The name of the author of the commit<br/>
        /// Example: kyliau
        /// </summary>
        /// <example>kyliau</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitAuthorName")]
        public string? CommitAuthorName { get; set; }

        /// <summary>
        /// The email of the author of the commit<br/>
        /// Example: kyliau@example.com
        /// </summary>
        /// <example>kyliau@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitAuthorEmail")]
        public string? CommitAuthorEmail { get; set; }

        /// <summary>
        /// The commit message<br/>
        /// Example: add method to measure Interaction to Next Paint (INP) (#36490)
        /// </summary>
        /// <example>add method to measure Interaction to Next Paint (INP) (#36490)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMessage")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// The branch on which the commit was made<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitRef")]
        public string? CommitRef { get; set; }

        /// <summary>
        /// The hash of the commit<br/>
        /// Example: dc36199b2234c6586ebe05ec94078a895c707e29
        /// </summary>
        /// <example>dc36199b2234c6586ebe05ec94078a895c707e29</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitSha")]
        public string? CommitSha { get; set; }

        /// <summary>
        /// Whether or not there have been modifications to the working tree since the latest commit<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dirty")]
        public bool? Dirty { get; set; }

        /// <summary>
        /// True if process.env.CI was set when deploying<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ci")]
        public bool? Ci { get; set; }

        /// <summary>
        /// The type of CI system used<br/>
        /// Example: github-actions
        /// </summary>
        /// <example>github-actions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciType")]
        public string? CiType { get; set; }

        /// <summary>
        /// The username used for the Git Provider (e.g. GitHub) if their CI (e.g. GitHub Actions) was used, if available<br/>
        /// Example: rauchg
        /// </summary>
        /// <example>rauchg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciGitProviderUsername")]
        public string? CiGitProviderUsername { get; set; }

        /// <summary>
        /// The visibility of the Git repository if their CI (e.g. GitHub Actions) was used, if available<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciGitRepoVisibility")]
        public string? CiGitRepoVisibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitMetadata" /> class.
        /// </summary>
        /// <param name="remoteUrl">
        /// The git repository's remote origin url<br/>
        /// Example: https://github.com/vercel/next.js
        /// </param>
        /// <param name="commitAuthorName">
        /// The name of the author of the commit<br/>
        /// Example: kyliau
        /// </param>
        /// <param name="commitAuthorEmail">
        /// The email of the author of the commit<br/>
        /// Example: kyliau@example.com
        /// </param>
        /// <param name="commitMessage">
        /// The commit message<br/>
        /// Example: add method to measure Interaction to Next Paint (INP) (#36490)
        /// </param>
        /// <param name="commitRef">
        /// The branch on which the commit was made<br/>
        /// Example: main
        /// </param>
        /// <param name="commitSha">
        /// The hash of the commit<br/>
        /// Example: dc36199b2234c6586ebe05ec94078a895c707e29
        /// </param>
        /// <param name="dirty">
        /// Whether or not there have been modifications to the working tree since the latest commit<br/>
        /// Example: true
        /// </param>
        /// <param name="ci">
        /// True if process.env.CI was set when deploying<br/>
        /// Example: true
        /// </param>
        /// <param name="ciType">
        /// The type of CI system used<br/>
        /// Example: github-actions
        /// </param>
        /// <param name="ciGitProviderUsername">
        /// The username used for the Git Provider (e.g. GitHub) if their CI (e.g. GitHub Actions) was used, if available<br/>
        /// Example: rauchg
        /// </param>
        /// <param name="ciGitRepoVisibility">
        /// The visibility of the Git repository if their CI (e.g. GitHub Actions) was used, if available<br/>
        /// Example: private
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestGitMetadata(
            string? remoteUrl,
            string? commitAuthorName,
            string? commitAuthorEmail,
            string? commitMessage,
            string? commitRef,
            string? commitSha,
            bool? dirty,
            bool? ci,
            string? ciType,
            string? ciGitProviderUsername,
            string? ciGitRepoVisibility)
        {
            this.RemoteUrl = remoteUrl;
            this.CommitAuthorName = commitAuthorName;
            this.CommitAuthorEmail = commitAuthorEmail;
            this.CommitMessage = commitMessage;
            this.CommitRef = commitRef;
            this.CommitSha = commitSha;
            this.Dirty = dirty;
            this.Ci = ci;
            this.CiType = ciType;
            this.CiGitProviderUsername = ciGitProviderUsername;
            this.CiGitRepoVisibility = ciGitRepoVisibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitMetadata" /> class.
        /// </summary>
        public CreateDeploymentRequestGitMetadata()
        {
        }
    }
}