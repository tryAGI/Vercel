#nullable enable

namespace Vercel
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a Team<br/>
        /// Update the information of a Team specified by the `teamId` parameter. The request body should contain the information that will be updated on the Team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.Team> PatchTeamAsync(
            string teamId,

            global::Vercel.PatchTeamRequest request,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Team<br/>
        /// Update the information of a Team specified by the `teamId` parameter. The request body should contain the information that will be updated on the Team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.Team>> PatchTeamAsResponseAsync(
            string teamId,

            global::Vercel.PatchTeamRequest request,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Team<br/>
        /// Update the information of a Team specified by the `teamId` parameter. The request body should contain the information that will be updated on the Team.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="avatar">
        /// The hash value of an uploaded image.
        /// </param>
        /// <param name="description">
        /// A short text that describes the team.<br/>
        /// Example: Our mission is to make cloud computing accessible to everyone
        /// </param>
        /// <param name="emailDomain">
        /// Example: example.com
        /// </param>
        /// <param name="name">
        /// The name of the team.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Suffix that will be used for all preview deployments.<br/>
        /// Example: example.dev
        /// </param>
        /// <param name="regenerateInviteCode">
        /// Create a new invite code and replace the current one.<br/>
        /// Example: true
        /// </param>
        /// <param name="saml"></param>
        /// <param name="requestSlug">
        /// A new slug for the team.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Enable preview toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Enable production toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="sensitiveEnvironmentVariablePolicy">
        /// Sensitive environment variable policy: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="disjunctiveProductionSecretPolicy">
        /// Require production secrets to be in their own environment group: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="remoteCaching">
        /// Whether or not remote caching is enabled for the team
        /// </param>
        /// <param name="hideIpAddresses">
        /// Display or hide IP addresses in Monitoring queries.<br/>
        /// Example: false
        /// </param>
        /// <param name="hideIpAddressesInLogDrains">
        /// Display or hide IP addresses in Log Drains.<br/>
        /// Example: false
        /// </param>
        /// <param name="dpAccessRequestsMode">
        /// Controls who can request access to protected deployments.<br/>
        /// Example: none
        /// </param>
        /// <param name="requireVerifiedCommits">
        /// When enabled, all projects in the team require commits to be signed and verified by the git provider before deployments will be created.<br/>
        /// Example: true
        /// </param>
        /// <param name="disableRepositoryDispatchEvents">
        /// Default for projects in the team. When `true`, projects in this team will not emit GitHub repository-dispatch events on deployment events unless the project explicitly overrides this setting.<br/>
        /// Example: false
        /// </param>
        /// <param name="defaultDeploymentProtection">
        /// Default deployment protection settings for new projects.
        /// </param>
        /// <param name="defaultPassport">
        /// Default Passport configuration for new projects.
        /// </param>
        /// <param name="defaultExpirationSettings"></param>
        /// <param name="deploymentPolicy"></param>
        /// <param name="strictDeploymentProtectionSettings">
        /// When enabled, deployment protection settings require stricter permissions (owner-only).
        /// </param>
        /// <param name="strictShareableLinks">
        /// When enabled, creating shareable links requires Owner role.
        /// </param>
        /// <param name="strictPasswordProtectionSettings">
        /// When enabled, adding, changing, or removing project password protection requires Owner role.
        /// </param>
        /// <param name="nsnbConfig"></param>
        /// <param name="defaultProjectJobs"></param>
        /// <param name="resourceConfig">
        /// Resource configuration for the team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.Team> PatchTeamAsync(
            string teamId,
            string? slug = default,
            string? avatar = default,
            string? description = default,
            string? emailDomain = default,
            string? name = default,
            string? previewDeploymentSuffix = default,
            bool? regenerateInviteCode = default,
            global::Vercel.PatchTeamRequestSaml? saml = default,
            string? requestSlug = default,
            string? enablePreviewFeedback = default,
            string? enableProductionFeedback = default,
            string? sensitiveEnvironmentVariablePolicy = default,
            string? disjunctiveProductionSecretPolicy = default,
            global::Vercel.PatchTeamRequestRemoteCaching? remoteCaching = default,
            bool? hideIpAddresses = default,
            bool? hideIpAddressesInLogDrains = default,
            global::Vercel.PatchTeamRequestDpAccessRequestsMode? dpAccessRequestsMode = default,
            bool? requireVerifiedCommits = default,
            bool? disableRepositoryDispatchEvents = default,
            global::Vercel.PatchTeamRequestDefaultDeploymentProtection? defaultDeploymentProtection = default,
            global::Vercel.PatchTeamRequestDefaultPassport? defaultPassport = default,
            global::Vercel.PatchTeamRequestDefaultExpirationSettings? defaultExpirationSettings = default,
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestDeploymentPolicy, string>? deploymentPolicy = default,
            global::Vercel.PatchTeamRequestStrictDeploymentProtectionSettings? strictDeploymentProtectionSettings = default,
            global::Vercel.PatchTeamRequestStrictShareableLinks? strictShareableLinks = default,
            global::Vercel.PatchTeamRequestStrictPasswordProtectionSettings? strictPasswordProtectionSettings = default,
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestNsnbConfig, string>? nsnbConfig = default,
            global::Vercel.OneOf<global::Vercel.PatchTeamRequestDefaultProjectJobs, string>? defaultProjectJobs = default,
            global::Vercel.PatchTeamRequestResourceConfig? resourceConfig = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}