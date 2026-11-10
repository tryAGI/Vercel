
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared18cf6c9c9480cd61
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKShared18cf6c9c9480cd61SourceVariant1, global::Vercel.AutoSDKShared18cf6c9c9480cd61SourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.AutoSDKShared18cf6c9c9480cd61SourceVariant1, global::Vercel.AutoSDKShared18cf6c9c9480cd61SourceVariant2> Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitSha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitSha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61Skipped? Skipped { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bootstrappingStarted")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61BootstrappingStarted? BootstrappingStarted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bootstrappingFailed")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61BootstrappingFailed? BootstrappingFailed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxSnapshotted")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted? SandboxSnapshotted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxNamed")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61SandboxNamed? SandboxNamed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitionsCreated")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61JobDefinitionsCreated? JobDefinitionsCreated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61Completed? Completed { get; set; }

        /// <summary>
        /// The terminal setup result. Omitted while invocation setup is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupConclusion")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61SetupConclusion? SetupConclusion { get; set; }

        /// <summary>
        /// The aggregate outcome of every job in the invocation. Omitted while jobs are still running. Any failed job → "failed"; any (non-cascade) skipped job → "skipped"; else "succeeded". Present on completed invocations written after the field shipped; absent on older rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runConclusion")]
        public global::Vercel.AutoSDKShared18cf6c9c9480cd61RunConclusion? RunConclusion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared18cf6c9c9480cd61" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="attempt"></param>
        /// <param name="teamId"></param>
        /// <param name="source"></param>
        /// <param name="createdAt"></param>
        /// <param name="repositoryKey"></param>
        /// <param name="ref"></param>
        /// <param name="commitSha"></param>
        /// <param name="status"></param>
        /// <param name="skipped"></param>
        /// <param name="bootstrappingStarted"></param>
        /// <param name="bootstrappingFailed"></param>
        /// <param name="sandboxSnapshotted"></param>
        /// <param name="sandboxNamed"></param>
        /// <param name="jobDefinitionsCreated"></param>
        /// <param name="completed"></param>
        /// <param name="setupConclusion">
        /// The terminal setup result. Omitted while invocation setup is still running.
        /// </param>
        /// <param name="runConclusion">
        /// The aggregate outcome of every job in the invocation. Omitted while jobs are still running. Any failed job → "failed"; any (non-cascade) skipped job → "skipped"; else "succeeded". Present on completed invocations written after the field shipped; absent on older rows.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared18cf6c9c9480cd61(
            string invocationId,
            double attempt,
            string teamId,
            global::Vercel.AnyOf<global::Vercel.AutoSDKShared18cf6c9c9480cd61SourceVariant1, global::Vercel.AutoSDKShared18cf6c9c9480cd61SourceVariant2> source,
            double createdAt,
            string repositoryKey,
            string @ref,
            string commitSha,
            string status,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61Skipped? skipped,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61BootstrappingStarted? bootstrappingStarted,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61BootstrappingFailed? bootstrappingFailed,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61SandboxSnapshotted? sandboxSnapshotted,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61SandboxNamed? sandboxNamed,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61JobDefinitionsCreated? jobDefinitionsCreated,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61Completed? completed,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61SetupConclusion? setupConclusion,
            global::Vercel.AutoSDKShared18cf6c9c9480cd61RunConclusion? runConclusion)
        {
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.Attempt = attempt;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Source = source;
            this.CreatedAt = createdAt;
            this.RepositoryKey = repositoryKey ?? throw new global::System.ArgumentNullException(nameof(repositoryKey));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.CommitSha = commitSha ?? throw new global::System.ArgumentNullException(nameof(commitSha));
            this.Skipped = skipped;
            this.BootstrappingStarted = bootstrappingStarted;
            this.BootstrappingFailed = bootstrappingFailed;
            this.SandboxSnapshotted = sandboxSnapshotted;
            this.SandboxNamed = sandboxNamed;
            this.JobDefinitionsCreated = jobDefinitionsCreated;
            this.Completed = completed;
            this.SetupConclusion = setupConclusion;
            this.RunConclusion = runConclusion;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared18cf6c9c9480cd61" /> class.
        /// </summary>
        public AutoSDKShared18cf6c9c9480cd61()
        {
        }

    }
}