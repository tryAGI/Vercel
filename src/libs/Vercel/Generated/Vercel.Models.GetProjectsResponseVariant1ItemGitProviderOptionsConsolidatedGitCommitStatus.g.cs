
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration for consolidated git commit status reporting. When enabled, Vercel will post a single consolidated commit status instead of individual statuses for each deployment.
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemGitProviderOptionsConsolidatedGitCommitStatus
    {
        /// <summary>
        /// Whether consolidated commit status is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether to propagate individual deployment failures to the consolidated status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagateFailures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PropagateFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemGitProviderOptionsConsolidatedGitCommitStatus" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether consolidated commit status is enabled.
        /// </param>
        /// <param name="propagateFailures">
        /// Whether to propagate individual deployment failures to the consolidated status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemGitProviderOptionsConsolidatedGitCommitStatus(
            bool enabled,
            bool propagateFailures)
        {
            this.Enabled = enabled;
            this.PropagateFailures = propagateFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemGitProviderOptionsConsolidatedGitCommitStatus" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemGitProviderOptionsConsolidatedGitCommitStatus()
        {
        }
    }
}