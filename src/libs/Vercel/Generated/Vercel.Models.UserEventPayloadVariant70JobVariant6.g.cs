
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant70JobVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant70JobVariant6TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant70JobVariant6Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized")]
        public bool? Authorized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizedBy")]
        public string? AuthorizedBy { get; set; }

        /// <summary>
        /// Since December 2022 All project ids associated to this job. Think monorepo. This job will be for one of these project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobProjectIds")]
        public global::System.Collections.Generic.IList<string>? JobProjectIds { get; set; }

        /// <summary>
        /// Since December 2022 Pairs of projects and owner ids to build for this build request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobPairs")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? JobPairs { get; set; }

        /// <summary>
        /// Since June 2024 Pairs of projects and owner ids to immediately finish (without building) because we want to create them in a skipped state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedJobPairs")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? SkippedJobPairs { get; set; }

        /// <summary>
        /// Since February 2022 All the hashtag-vercel tags found in the commit message triggering the deploy. For example, #VERCEL_DO_SOMETHING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitHashtagVercel")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant70JobVariant6GitHashtagVercelItem>? GitHashtagVercel { get; set; }

        /// <summary>
        /// Since April 2023 Cached count of how many projects are connected to the repo. Saves a few Cosmos queries down the road in the main flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedProjectCount")]
        public double? ConnectedProjectCount { get; set; }

        /// <summary>
        /// Since April 2023 If set then it is a cached result of asking the remote for the PR ID the commit that triggered this Job. Or zero if it was not a PR. This prevents a few git round trips by the git updater.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prIdOrZero")]
        public double? PrIdOrZero { get; set; }

        /// <summary>
        /// Since June 2023 Determines if comments should be posted to the git host. Replaces `github.silent` in the vercel.json.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.UserEventPayloadVariant70JobVariant6GitComments? GitComments { get; set; }

        /// <summary>
        /// Since 28 Feb 2024 If set to true, identifies that the git job was created for a manual git deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isManualGitDeploy")]
        public bool? IsManualGitDeploy { get; set; }

        /// <summary>
        /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitVerification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant70JobVariant6CommitVerificationJsonConverter))]
        public global::Vercel.UserEventPayloadVariant70JobVariant6CommitVerification? CommitVerification { get; set; }

        /// <summary>
        /// Since March 2026 Records a successful NSNB auto-add result so later GitHub PR comments can deterministically explain why this SHA was allowed to deploy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsnbSideEffect")]
        public global::Vercel.UserEventPayloadVariant70JobVariant6NsnbSideEffect? NsnbSideEffect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public global::Vercel.UserEventPayloadVariant70JobVariant6Commit? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployHook")]
        public global::Vercel.UserEventPayloadVariant70JobVariant6DeployHook? DeployHook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventful")]
        public bool? Eventful { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forceNew")]
        public bool? ForceNew { get; set; }

        /// <summary>
        /// GitLab
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant70JobVariant6HeadInfo HeadInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedProjectId")]
        public string? LinkedProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prId")]
        public double? PrId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant70JobVariant6Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvId")]
        public string? CustomEnvId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPushedAt")]
        public double? RepoPushedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silent")]
        public bool? Silent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withCache")]
        public bool? WithCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant70JobVariant6ProviderJsonConverter))]
        public global::Vercel.UserEventPayloadVariant70JobVariant6Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant70JobVariant6" /> class.
        /// </summary>
        /// <param name="headInfo">
        /// GitLab
        /// </param>
        /// <param name="project"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="type"></param>
        /// <param name="authorized"></param>
        /// <param name="authorizedBy"></param>
        /// <param name="jobProjectIds">
        /// Since December 2022 All project ids associated to this job. Think monorepo. This job will be for one of these project.
        /// </param>
        /// <param name="jobPairs">
        /// Since December 2022 Pairs of projects and owner ids to build for this build request.
        /// </param>
        /// <param name="skippedJobPairs">
        /// Since June 2024 Pairs of projects and owner ids to immediately finish (without building) because we want to create them in a skipped state.
        /// </param>
        /// <param name="gitHashtagVercel">
        /// Since February 2022 All the hashtag-vercel tags found in the commit message triggering the deploy. For example, #VERCEL_DO_SOMETHING
        /// </param>
        /// <param name="connectedProjectCount">
        /// Since April 2023 Cached count of how many projects are connected to the repo. Saves a few Cosmos queries down the road in the main flow.
        /// </param>
        /// <param name="prIdOrZero">
        /// Since April 2023 If set then it is a cached result of asking the remote for the PR ID the commit that triggered this Job. Or zero if it was not a PR. This prevents a few git round trips by the git updater.
        /// </param>
        /// <param name="gitComments">
        /// Since June 2023 Determines if comments should be posted to the git host. Replaces `github.silent` in the vercel.json.
        /// </param>
        /// <param name="isManualGitDeploy">
        /// Since 28 Feb 2024 If set to true, identifies that the git job was created for a manual git deployment
        /// </param>
        /// <param name="commitVerification">
        /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
        /// </param>
        /// <param name="nsnbSideEffect">
        /// Since March 2026 Records a successful NSNB auto-add result so later GitHub PR comments can deterministically explain why this SHA was allowed to deploy.
        /// </param>
        /// <param name="commit"></param>
        /// <param name="createdAt"></param>
        /// <param name="deployHook"></param>
        /// <param name="deploymentId"></param>
        /// <param name="eventful"></param>
        /// <param name="forceNew"></param>
        /// <param name="linkedProjectId"></param>
        /// <param name="prId"></param>
        /// <param name="projectId"></param>
        /// <param name="customEnvId"></param>
        /// <param name="repoPushedAt"></param>
        /// <param name="silent"></param>
        /// <param name="target"></param>
        /// <param name="url"></param>
        /// <param name="withCache"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant70JobVariant6(
            global::Vercel.UserEventPayloadVariant70JobVariant6HeadInfo headInfo,
            global::Vercel.UserEventPayloadVariant70JobVariant6Project project,
            string @ref,
            string sha,
            global::Vercel.UserEventPayloadVariant70JobVariant6Type type,
            bool? authorized,
            string? authorizedBy,
            global::System.Collections.Generic.IList<string>? jobProjectIds,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? jobPairs,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? skippedJobPairs,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant70JobVariant6GitHashtagVercelItem>? gitHashtagVercel,
            double? connectedProjectCount,
            double? prIdOrZero,
            global::Vercel.UserEventPayloadVariant70JobVariant6GitComments? gitComments,
            bool? isManualGitDeploy,
            global::Vercel.UserEventPayloadVariant70JobVariant6CommitVerification? commitVerification,
            global::Vercel.UserEventPayloadVariant70JobVariant6NsnbSideEffect? nsnbSideEffect,
            global::Vercel.UserEventPayloadVariant70JobVariant6Commit? commit,
            double? createdAt,
            global::Vercel.UserEventPayloadVariant70JobVariant6DeployHook? deployHook,
            string? deploymentId,
            bool? eventful,
            bool? forceNew,
            string? linkedProjectId,
            double? prId,
            string? projectId,
            string? customEnvId,
            double? repoPushedAt,
            bool? silent,
            string? target,
            string? url,
            bool? withCache,
            global::Vercel.UserEventPayloadVariant70JobVariant6Provider provider)
        {
            this.Type = type;
            this.Authorized = authorized;
            this.AuthorizedBy = authorizedBy;
            this.JobProjectIds = jobProjectIds;
            this.JobPairs = jobPairs;
            this.SkippedJobPairs = skippedJobPairs;
            this.GitHashtagVercel = gitHashtagVercel;
            this.ConnectedProjectCount = connectedProjectCount;
            this.PrIdOrZero = prIdOrZero;
            this.GitComments = gitComments;
            this.IsManualGitDeploy = isManualGitDeploy;
            this.CommitVerification = commitVerification;
            this.NsnbSideEffect = nsnbSideEffect;
            this.Commit = commit;
            this.CreatedAt = createdAt;
            this.DeployHook = deployHook;
            this.DeploymentId = deploymentId;
            this.Eventful = eventful;
            this.ForceNew = forceNew;
            this.HeadInfo = headInfo ?? throw new global::System.ArgumentNullException(nameof(headInfo));
            this.LinkedProjectId = linkedProjectId;
            this.PrId = prId;
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ProjectId = projectId;
            this.CustomEnvId = customEnvId;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RepoPushedAt = repoPushedAt;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Silent = silent;
            this.Target = target;
            this.Url = url;
            this.WithCache = withCache;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant70JobVariant6" /> class.
        /// </summary>
        public UserEventPayloadVariant70JobVariant6()
        {
        }
    }
}