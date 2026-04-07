
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseGitProviderOptions
    {
        /// <summary>
        /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createDeployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseGitProviderOptionsCreateDeploymentsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectResponseGitProviderOptionsCreateDeployments CreateDeployments { get; set; }

        /// <summary>
        /// Whether the Vercel bot should not automatically create GitHub repository-dispatch events on deployment events. https://vercel.com/docs/git/vercel-for-github#repository-dispatch-events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableRepositoryDispatchEvents")]
        public bool? DisableRepositoryDispatchEvents { get; set; }

        /// <summary>
        /// Whether the project requires commits to be signed before deployments will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireVerifiedCommits")]
        public bool? RequireVerifiedCommits { get; set; }

        /// <summary>
        /// Whether Vercel should post commit statuses for this project. When omitted, commit statuses remain enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitCommitStatus")]
        public bool? GitCommitStatus { get; set; }

        /// <summary>
        /// Configuration for consolidated git commit status reporting. When enabled, Vercel will post a single consolidated commit status instead of individual statuses for each deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consolidatedGitCommitStatus")]
        public global::Vercel.GetProjectResponseGitProviderOptionsConsolidatedGitCommitStatus? ConsolidatedGitCommitStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseGitProviderOptions" /> class.
        /// </summary>
        /// <param name="createDeployments">
        /// Whether the Vercel bot should automatically create GitHub deployments https://docs.github.com/en/rest/deployments/deployments#about-deployments NOTE: repository-dispatch events should be used instead
        /// </param>
        /// <param name="disableRepositoryDispatchEvents">
        /// Whether the Vercel bot should not automatically create GitHub repository-dispatch events on deployment events. https://vercel.com/docs/git/vercel-for-github#repository-dispatch-events
        /// </param>
        /// <param name="requireVerifiedCommits">
        /// Whether the project requires commits to be signed before deployments will be created.
        /// </param>
        /// <param name="gitCommitStatus">
        /// Whether Vercel should post commit statuses for this project. When omitted, commit statuses remain enabled.
        /// </param>
        /// <param name="consolidatedGitCommitStatus">
        /// Configuration for consolidated git commit status reporting. When enabled, Vercel will post a single consolidated commit status instead of individual statuses for each deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseGitProviderOptions(
            global::Vercel.GetProjectResponseGitProviderOptionsCreateDeployments createDeployments,
            bool? disableRepositoryDispatchEvents,
            bool? requireVerifiedCommits,
            bool? gitCommitStatus,
            global::Vercel.GetProjectResponseGitProviderOptionsConsolidatedGitCommitStatus? consolidatedGitCommitStatus)
        {
            this.CreateDeployments = createDeployments;
            this.DisableRepositoryDispatchEvents = disableRepositoryDispatchEvents;
            this.RequireVerifiedCommits = requireVerifiedCommits;
            this.GitCommitStatus = gitCommitStatus;
            this.ConsolidatedGitCommitStatus = consolidatedGitCommitStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseGitProviderOptions" /> class.
        /// </summary>
        public GetProjectResponseGitProviderOptions()
        {
        }
    }
}