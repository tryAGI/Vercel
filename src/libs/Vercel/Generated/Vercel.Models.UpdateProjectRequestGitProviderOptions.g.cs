
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Miscellaneous options related to how this projects interacts with the linked git source.
    /// </summary>
    public sealed partial class UpdateProjectRequestGitProviderOptions
    {
        /// <summary>
        /// Whether or not Vercel should automatically create GitHub deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createDeployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestGitProviderOptionsCreateDeploymentsJsonConverter))]
        public global::Vercel.UpdateProjectRequestGitProviderOptionsCreateDeployments? CreateDeployments { get; set; }

        /// <summary>
        /// Whether Vercel should not automatically create GitHub repository-dispatch events on deployment events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableRepositoryDispatchEvents")]
        public bool? DisableRepositoryDispatchEvents { get; set; }

        /// <summary>
        /// Whether the project requires commits to be signed &amp; verified before deployments will be created. `true` enables, `false` disables (explicit override of the team setting), `null` clears the override to inherit from the team setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireVerifiedCommits")]
        public bool? RequireVerifiedCommits { get; set; }

        /// <summary>
        /// Whether Vercel should post git commit statuses for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitCommitStatus")]
        public bool? GitCommitStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestGitProviderOptions" /> class.
        /// </summary>
        /// <param name="createDeployments">
        /// Whether or not Vercel should automatically create GitHub deployments
        /// </param>
        /// <param name="disableRepositoryDispatchEvents">
        /// Whether Vercel should not automatically create GitHub repository-dispatch events on deployment events.
        /// </param>
        /// <param name="requireVerifiedCommits">
        /// Whether the project requires commits to be signed &amp; verified before deployments will be created. `true` enables, `false` disables (explicit override of the team setting), `null` clears the override to inherit from the team setting.
        /// </param>
        /// <param name="gitCommitStatus">
        /// Whether Vercel should post git commit statuses for this project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestGitProviderOptions(
            global::Vercel.UpdateProjectRequestGitProviderOptionsCreateDeployments? createDeployments,
            bool? disableRepositoryDispatchEvents,
            bool? requireVerifiedCommits,
            bool? gitCommitStatus)
        {
            this.CreateDeployments = createDeployments;
            this.DisableRepositoryDispatchEvents = disableRepositoryDispatchEvents;
            this.RequireVerifiedCommits = requireVerifiedCommits;
            this.GitCommitStatus = gitCommitStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestGitProviderOptions" /> class.
        /// </summary>
        public UpdateProjectRequestGitProviderOptions()
        {
        }

    }
}