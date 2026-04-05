
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant68JobVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPushedAt")]
        public double? RepoPushedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitInfo")]
        public global::Vercel.UserEventPayloadVariant68JobVariant4CommitInfo? CommitInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forced")]
        public bool? Forced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant4TypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant68JobVariant4Type Type { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant68JobVariant4GitHashtagVercelItem>? GitHashtagVercel { get; set; }

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
        public global::Vercel.UserEventPayloadVariant68JobVariant4GitComments? GitComments { get; set; }

        /// <summary>
        /// Since 28 Feb 2024 If set to true, identifies that the git job was created for a manual git deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isManualGitDeploy")]
        public bool? IsManualGitDeploy { get; set; }

        /// <summary>
        /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitVerification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant4CommitVerificationJsonConverter))]
        public global::Vercel.UserEventPayloadVariant68JobVariant4CommitVerification? CommitVerification { get; set; }

        /// <summary>
        /// Since March 2026 Records a successful NSNB auto-add result so later GitHub PR comments can deterministically explain why this SHA was allowed to deploy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsnbSideEffect")]
        public global::Vercel.UserEventPayloadVariant68JobVariant4NsnbSideEffect? NsnbSideEffect { get; set; }

        /// <summary>
        /// Remote account id of the committer details (github id etc, not vercel). Note that the committer name/email are user input verbatim and not verified. Github does appear to resolve the given email to the username so we can trust that. If the username matches that of the sender, which is verified info, then we can use the account id and account type. See api-incoming, where we determine and set this property Note that even with that, the account may still have been spoofed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committerGitUserId")]
        public double? CommitterGitUserId { get; set; }

        /// <summary>
        /// Remote account type of the committer details (github type etc, not vercel). Note that the committer name/email are user input verbatim and not verified. Github does appear to resolve the given email to the username so we can trust that. If the username matches that of the sender, which is verified info, then we can use the account id and account type. See api-incoming, where we determine and set this property Note that even with that, the account may still have been spoofed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committerGitUserType")]
        public string? CommitterGitUserType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forceNew")]
        public bool? ForceNew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployHook")]
        public global::Vercel.UserEventPayloadVariant68JobVariant4DeployHook? DeployHook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeSha")]
        public string? BeforeSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultBranch")]
        public string? DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventful")]
        public bool? Eventful { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubDeploymentId")]
        public string? GithubDeploymentId { get; set; }

        /// <summary>
        /// Information about the head commit/branch for a GitHub repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant4HeadInfo HeadInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPrivate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPrivate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedProjectId")]
        public string? LinkedProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prId")]
        public double? PrId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RepoId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant68JobVariant4ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant68JobVariant4Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customHost")]
        public string? CustomHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant4" /> class.
        /// </summary>
        /// <param name="headInfo">
        /// Information about the head commit/branch for a GitHub repository
        /// </param>
        /// <param name="installationId"></param>
        /// <param name="isPrivate"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="repoId"></param>
        /// <param name="provider"></param>
        /// <param name="repoPushedAt"></param>
        /// <param name="commitInfo"></param>
        /// <param name="forced"></param>
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
        /// <param name="committerGitUserId">
        /// Remote account id of the committer details (github id etc, not vercel). Note that the committer name/email are user input verbatim and not verified. Github does appear to resolve the given email to the username so we can trust that. If the username matches that of the sender, which is verified info, then we can use the account id and account type. See api-incoming, where we determine and set this property Note that even with that, the account may still have been spoofed.
        /// </param>
        /// <param name="committerGitUserType">
        /// Remote account type of the committer details (github type etc, not vercel). Note that the committer name/email are user input verbatim and not verified. Github does appear to resolve the given email to the username so we can trust that. If the username matches that of the sender, which is verified info, then we can use the account id and account type. See api-incoming, where we determine and set this property Note that even with that, the account may still have been spoofed.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="forceNew"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deployHook"></param>
        /// <param name="beforeSha"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="eventful"></param>
        /// <param name="githubDeploymentId"></param>
        /// <param name="linkedProjectId"></param>
        /// <param name="prId"></param>
        /// <param name="projectId"></param>
        /// <param name="customEnvId"></param>
        /// <param name="target"></param>
        /// <param name="url"></param>
        /// <param name="withCache"></param>
        /// <param name="customHost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant68JobVariant4(
            global::Vercel.UserEventPayloadVariant68JobVariant4HeadInfo headInfo,
            double installationId,
            bool isPrivate,
            string org,
            string repo,
            double repoId,
            global::Vercel.UserEventPayloadVariant68JobVariant4Provider provider,
            double? repoPushedAt,
            global::Vercel.UserEventPayloadVariant68JobVariant4CommitInfo? commitInfo,
            bool? forced,
            global::Vercel.UserEventPayloadVariant68JobVariant4Type type,
            bool? authorized,
            string? authorizedBy,
            global::System.Collections.Generic.IList<string>? jobProjectIds,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? jobPairs,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? skippedJobPairs,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant68JobVariant4GitHashtagVercelItem>? gitHashtagVercel,
            double? connectedProjectCount,
            double? prIdOrZero,
            global::Vercel.UserEventPayloadVariant68JobVariant4GitComments? gitComments,
            bool? isManualGitDeploy,
            global::Vercel.UserEventPayloadVariant68JobVariant4CommitVerification? commitVerification,
            global::Vercel.UserEventPayloadVariant68JobVariant4NsnbSideEffect? nsnbSideEffect,
            double? committerGitUserId,
            string? committerGitUserType,
            double? createdAt,
            bool? forceNew,
            string? deploymentId,
            global::Vercel.UserEventPayloadVariant68JobVariant4DeployHook? deployHook,
            string? beforeSha,
            string? defaultBranch,
            bool? eventful,
            string? githubDeploymentId,
            string? linkedProjectId,
            double? prId,
            string? projectId,
            string? customEnvId,
            string? target,
            string? url,
            bool? withCache,
            string? customHost)
        {
            this.RepoPushedAt = repoPushedAt;
            this.CommitInfo = commitInfo;
            this.Forced = forced;
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
            this.CommitterGitUserId = committerGitUserId;
            this.CommitterGitUserType = committerGitUserType;
            this.CreatedAt = createdAt;
            this.ForceNew = forceNew;
            this.DeploymentId = deploymentId;
            this.DeployHook = deployHook;
            this.BeforeSha = beforeSha;
            this.DefaultBranch = defaultBranch;
            this.Eventful = eventful;
            this.GithubDeploymentId = githubDeploymentId;
            this.HeadInfo = headInfo ?? throw new global::System.ArgumentNullException(nameof(headInfo));
            this.InstallationId = installationId;
            this.IsPrivate = isPrivate;
            this.LinkedProjectId = linkedProjectId;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.PrId = prId;
            this.ProjectId = projectId;
            this.CustomEnvId = customEnvId;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.RepoId = repoId;
            this.Target = target;
            this.Url = url;
            this.WithCache = withCache;
            this.Provider = provider;
            this.CustomHost = customHost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant68JobVariant4" /> class.
        /// </summary>
        public UserEventPayloadVariant68JobVariant4()
        {
        }
    }
}