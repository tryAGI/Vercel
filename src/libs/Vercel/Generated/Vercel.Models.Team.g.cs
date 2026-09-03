
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Data representing a Team.
    /// </summary>
    public sealed partial class Team
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect")]
        public global::Vercel.TeamConnect? Connect { get; set; }

        /// <summary>
        /// The ID of the user who created the Team.<br/>
        /// Example: R6efeCJQ2HKXywuasPDc0fOWB
        /// </summary>
        /// <example>R6efeCJQ2HKXywuasPDc0fOWB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorId { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the Team was last updated.<br/>
        /// Example: 1611796915677L
        /// </summary>
        /// <example>1611796915677L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Hostname that'll be matched with emails on sign-up to automatically join the Team.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailDomain")]
        public string? EmailDomain { get; set; }

        /// <summary>
        /// When "Single Sign-On (SAML)" is configured, this object contains information regarding the configuration of the Identity Provider (IdP).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml")]
        public global::Vercel.TeamSaml? Saml { get; set; }

        /// <summary>
        /// Code that can be used to join this Team. Only visible to Team owners.<br/>
        /// Example: hasihf9e89
        /// </summary>
        /// <example>hasihf9e89</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteCode")]
        public string? InviteCode { get; set; }

        /// <summary>
        /// The team's billing plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        public global::Vercel.TeamBilling? Billing { get; set; }

        /// <summary>
        /// A short description of the Team.<br/>
        /// Example: Our mission is to make cloud computing accessible to everyone.
        /// </summary>
        /// <example>Our mission is to make cloud computing accessible to everyone.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default roles for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoles")]
        public global::Vercel.TeamDefaultRoles? DefaultRoles { get; set; }

        /// <summary>
        /// The prefix that is prepended to automatic aliases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stagingPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StagingPrefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.TeamResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        /// The hostname that is current set as preview deployment suffix.<br/>
        /// Example: example.dev
        /// </summary>
        /// <example>example.dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public string? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// Whether the team is a platform team.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public bool? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableHardAutoBlocks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>))]
        public global::Vercel.OneOf<double?, bool?>? DisableHardAutoBlocks { get; set; }

        /// <summary>
        /// Is remote caching enabled for this team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::Vercel.TeamRemoteCaching? RemoteCaching { get; set; }

        /// <summary>
        /// Default deployment protection for this team null indicates protection is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDeploymentProtection")]
        public global::Vercel.TeamDefaultDeploymentProtection? DefaultDeploymentProtection { get; set; }

        /// <summary>
        /// Default Passport configuration for new projects in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPassport")]
        public global::Vercel.TeamDefaultPassport? DefaultPassport { get; set; }

        /// <summary>
        /// Default deployment expiration settings for this team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultExpirationSettings")]
        public global::Vercel.TeamDefaultExpirationSettings? DefaultExpirationSettings { get; set; }

        /// <summary>
        /// Default job configuration applied to new projects created in this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultProjectJobs")]
        public global::Vercel.TeamDefaultProjectJobs? DefaultProjectJobs { get; set; }

        /// <summary>
        /// Whether toolbar is enabled on preview deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePreviewFeedback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamEnablePreviewFeedbackJsonConverter))]
        public global::Vercel.TeamEnablePreviewFeedback? EnablePreviewFeedback { get; set; }

        /// <summary>
        /// Whether toolbar is enabled on production deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableProductionFeedback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamEnableProductionFeedbackJsonConverter))]
        public global::Vercel.TeamEnableProductionFeedback? EnableProductionFeedback { get; set; }

        /// <summary>
        /// Sensitive environment variable policy for this team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitiveEnvironmentVariablePolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamSensitiveEnvironmentVariablePolicyJsonConverter))]
        public global::Vercel.TeamSensitiveEnvironmentVariablePolicy? SensitiveEnvironmentVariablePolicy { get; set; }

        /// <summary>
        /// Require production secrets to use a different value than preview or development.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disjunctiveProductionSecretPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamDisjunctiveProductionSecretPolicyJsonConverter))]
        public global::Vercel.TeamDisjunctiveProductionSecretPolicy? DisjunctiveProductionSecretPolicy { get; set; }

        /// <summary>
        /// Indicates if IP addresses should be accessible in observability (o11y) tooling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideIpAddresses")]
        public bool? HideIpAddresses { get; set; }

        /// <summary>
        /// Indicates if IP addresses should be accessible in log drains
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideIpAddressesInLogDrains")]
        public bool? HideIpAddressesInLogDrains { get; set; }

        /// <summary>
        /// Controls who can request access to protected deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpAccessRequestsMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamDpAccessRequestsModeJsonConverter))]
        public global::Vercel.TeamDpAccessRequestsMode? DpAccessRequestsMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBuckets")]
        public global::System.Collections.Generic.IList<global::Vercel.TeamIpBucket>? IpBuckets { get; set; }

        /// <summary>
        /// When enabled, all projects in the team require commits to be signed and verified by the git provider before deployments will be created. Projects may override this via `project.gitProviderOptions.requireVerifiedCommits` (gated by `Project:Update`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireVerifiedCommits")]
        public bool? RequireVerifiedCommits { get; set; }

        /// <summary>
        /// Default for projects in the team. When `true`, projects in this team will not emit GitHub repository-dispatch events on deployment events unless the project explicitly overrides this setting via `project.gitProviderOptions.disableRepositoryDispatchEvents`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableRepositoryDispatchEvents")]
        public bool? DisableRepositoryDispatchEvents { get; set; }

        /// <summary>
        /// When enabled, deployment protection settings require stricter permissions (owner-only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strictDeploymentProtectionSettings")]
        public global::Vercel.TeamStrictDeploymentProtectionSettings? StrictDeploymentProtectionSettings { get; set; }

        /// <summary>
        /// When enabled, creating shareable links requires Owner role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strictShareableLinks")]
        public global::Vercel.TeamStrictShareableLinks? StrictShareableLinks { get; set; }

        /// <summary>
        /// When enabled, adding, changing, or removing project password protection requires Owner role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strictPasswordProtectionSettings")]
        public global::Vercel.TeamStrictPasswordProtectionSettings? StrictPasswordProtectionSettings { get; set; }

        /// <summary>
        /// When enabled, creating and managing connectors requires Owner role or the ConnectorManager permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strictConnectors")]
        public global::Vercel.TeamStrictConnectors? StrictConnectors { get; set; }

        /// <summary>
        /// NSNB configuration for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsnbConfig")]
        public global::Vercel.TeamNsnbConfig? NsnbConfig { get; set; }

        /// <summary>
        /// Composable deployment-time policy for the team. Used as the default for every project on the team, with optional per-project overrides on `project.deploymentPolicy`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentPolicy")]
        public global::Vercel.TeamDeploymentPolicy? DeploymentPolicy { get; set; }

        /// <summary>
        /// Timestamp (ms) after which personal access tokens created at or before this time are considered invalid for this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalAccessTokensInvalidatedAt")]
        public double? PersonalAccessTokensInvalidatedAt { get; set; }

        /// <summary>
        /// Timestamp (ms) after which Vercel App tokens created at or before this time are considered invalid for this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appTokensInvalidatedAt")]
        public double? AppTokensInvalidatedAt { get; set; }

        /// <summary>
        /// Timestamp (ms) after which API keys created at or before this time are considered invalid for this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeysInvalidatedAt")]
        public double? ApiKeysInvalidatedAt { get; set; }

        /// <summary>
        /// Timestamp (ms) after which integration tokens created at or before this time are considered invalid for this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationTokensInvalidatedAt")]
        public double? IntegrationTokensInvalidatedAt { get; set; }

        /// <summary>
        /// The Team's unique identifier.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </summary>
        /// <example>team_nllPyCtREAqxxdyFKbbMDlxd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Team's slug, which is unique across the Vercel platform.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Name associated with the Team account, or `null` if none has been provided.<br/>
        /// Example: My Team
        /// </summary>
        /// <example>My Team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the file used as avatar for this Team.<br/>
        /// Example: 6eb07268bcfadd309905ffb1579354084c24655c
        /// </summary>
        /// <example>6eb07268bcfadd309905ffb1579354084c24655c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The membership of the authenticated User in relation to the Team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        public global::Vercel.TeamMembership? Membership { get; set; }

        /// <summary>
        /// UNIX timestamp (in milliseconds) when the Team was created.<br/>
        /// Example: 1630748523395L
        /// </summary>
        /// <example>1630748523395L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The organizationId for teams that belong to an organization (set on both the organization's root team and its child teams).<br/>
        /// Example: org_nllPyCtREAqxxdyFKbbMDlxd
        /// </summary>
        /// <example>org_nllPyCtREAqxxdyFKbbMDlxd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Best-effort ID of the organization’s root billing team. When present, compare `orgRootTeamId === id` to identify the root team. It may be omitted even when `parentId` is set if organization resolution fails or the referenced organization is missing. Always omitted for non-organization teams.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </summary>
        /// <example>team_nllPyCtREAqxxdyFKbbMDlxd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgRootTeamId")]
        public string? OrgRootTeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="creatorId">
        /// The ID of the user who created the Team.<br/>
        /// Example: R6efeCJQ2HKXywuasPDc0fOWB
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp (in milliseconds) of when the Team was last updated.<br/>
        /// Example: 1611796915677L
        /// </param>
        /// <param name="stagingPrefix">
        /// The prefix that is prepended to automatic aliases.
        /// </param>
        /// <param name="id">
        /// The Team's unique identifier.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </param>
        /// <param name="slug">
        /// The Team's slug, which is unique across the Vercel platform.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="createdAt">
        /// UNIX timestamp (in milliseconds) when the Team was created.<br/>
        /// Example: 1630748523395L
        /// </param>
        /// <param name="connect"></param>
        /// <param name="emailDomain">
        /// Hostname that'll be matched with emails on sign-up to automatically join the Team.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="saml">
        /// When "Single Sign-On (SAML)" is configured, this object contains information regarding the configuration of the Identity Provider (IdP).
        /// </param>
        /// <param name="inviteCode">
        /// Code that can be used to join this Team. Only visible to Team owners.<br/>
        /// Example: hasihf9e89
        /// </param>
        /// <param name="billing">
        /// The team's billing plan.
        /// </param>
        /// <param name="description">
        /// A short description of the Team.<br/>
        /// Example: Our mission is to make cloud computing accessible to everyone.
        /// </param>
        /// <param name="defaultRoles">
        /// Default roles for the team.
        /// </param>
        /// <param name="resourceConfig"></param>
        /// <param name="previewDeploymentSuffix">
        /// The hostname that is current set as preview deployment suffix.<br/>
        /// Example: example.dev
        /// </param>
        /// <param name="platform">
        /// Whether the team is a platform team.<br/>
        /// Example: true
        /// </param>
        /// <param name="disableHardAutoBlocks"></param>
        /// <param name="remoteCaching">
        /// Is remote caching enabled for this team
        /// </param>
        /// <param name="defaultDeploymentProtection">
        /// Default deployment protection for this team null indicates protection is disabled
        /// </param>
        /// <param name="defaultPassport">
        /// Default Passport configuration for new projects in this team.
        /// </param>
        /// <param name="defaultExpirationSettings">
        /// Default deployment expiration settings for this team
        /// </param>
        /// <param name="defaultProjectJobs">
        /// Default job configuration applied to new projects created in this team.
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Whether toolbar is enabled on preview deployments
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Whether toolbar is enabled on production deployments
        /// </param>
        /// <param name="sensitiveEnvironmentVariablePolicy">
        /// Sensitive environment variable policy for this team
        /// </param>
        /// <param name="disjunctiveProductionSecretPolicy">
        /// Require production secrets to use a different value than preview or development.
        /// </param>
        /// <param name="hideIpAddresses">
        /// Indicates if IP addresses should be accessible in observability (o11y) tooling
        /// </param>
        /// <param name="hideIpAddressesInLogDrains">
        /// Indicates if IP addresses should be accessible in log drains
        /// </param>
        /// <param name="dpAccessRequestsMode">
        /// Controls who can request access to protected deployments.
        /// </param>
        /// <param name="ipBuckets"></param>
        /// <param name="requireVerifiedCommits">
        /// When enabled, all projects in the team require commits to be signed and verified by the git provider before deployments will be created. Projects may override this via `project.gitProviderOptions.requireVerifiedCommits` (gated by `Project:Update`).
        /// </param>
        /// <param name="disableRepositoryDispatchEvents">
        /// Default for projects in the team. When `true`, projects in this team will not emit GitHub repository-dispatch events on deployment events unless the project explicitly overrides this setting via `project.gitProviderOptions.disableRepositoryDispatchEvents`.
        /// </param>
        /// <param name="strictDeploymentProtectionSettings">
        /// When enabled, deployment protection settings require stricter permissions (owner-only).
        /// </param>
        /// <param name="strictShareableLinks">
        /// When enabled, creating shareable links requires Owner role.
        /// </param>
        /// <param name="strictPasswordProtectionSettings">
        /// When enabled, adding, changing, or removing project password protection requires Owner role.
        /// </param>
        /// <param name="strictConnectors">
        /// When enabled, creating and managing connectors requires Owner role or the ConnectorManager permission.
        /// </param>
        /// <param name="nsnbConfig">
        /// NSNB configuration for the team.
        /// </param>
        /// <param name="deploymentPolicy">
        /// Composable deployment-time policy for the team. Used as the default for every project on the team, with optional per-project overrides on `project.deploymentPolicy`.
        /// </param>
        /// <param name="personalAccessTokensInvalidatedAt">
        /// Timestamp (ms) after which personal access tokens created at or before this time are considered invalid for this team.
        /// </param>
        /// <param name="appTokensInvalidatedAt">
        /// Timestamp (ms) after which Vercel App tokens created at or before this time are considered invalid for this team.
        /// </param>
        /// <param name="apiKeysInvalidatedAt">
        /// Timestamp (ms) after which API keys created at or before this time are considered invalid for this team.
        /// </param>
        /// <param name="integrationTokensInvalidatedAt">
        /// Timestamp (ms) after which integration tokens created at or before this time are considered invalid for this team.
        /// </param>
        /// <param name="name">
        /// Name associated with the Team account, or `null` if none has been provided.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="avatar">
        /// The ID of the file used as avatar for this Team.<br/>
        /// Example: 6eb07268bcfadd309905ffb1579354084c24655c
        /// </param>
        /// <param name="membership">
        /// The membership of the authenticated User in relation to the Team.
        /// </param>
        /// <param name="parentId">
        /// The organizationId for teams that belong to an organization (set on both the organization's root team and its child teams).<br/>
        /// Example: org_nllPyCtREAqxxdyFKbbMDlxd
        /// </param>
        /// <param name="orgRootTeamId">
        /// Best-effort ID of the organization’s root billing team. When present, compare `orgRootTeamId === id` to identify the root team. It may be omitted even when `parentId` is set if organization resolution fails or the referenced organization is missing. Always omitted for non-organization teams.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Team(
            string creatorId,
            double updatedAt,
            string stagingPrefix,
            string id,
            string slug,
            double createdAt,
            global::Vercel.TeamConnect? connect,
            string? emailDomain,
            global::Vercel.TeamSaml? saml,
            string? inviteCode,
            global::Vercel.TeamBilling? billing,
            string? description,
            global::Vercel.TeamDefaultRoles? defaultRoles,
            global::Vercel.TeamResourceConfig? resourceConfig,
            string? previewDeploymentSuffix,
            bool? platform,
            global::Vercel.OneOf<double?, bool?>? disableHardAutoBlocks,
            global::Vercel.TeamRemoteCaching? remoteCaching,
            global::Vercel.TeamDefaultDeploymentProtection? defaultDeploymentProtection,
            global::Vercel.TeamDefaultPassport? defaultPassport,
            global::Vercel.TeamDefaultExpirationSettings? defaultExpirationSettings,
            global::Vercel.TeamDefaultProjectJobs? defaultProjectJobs,
            global::Vercel.TeamEnablePreviewFeedback? enablePreviewFeedback,
            global::Vercel.TeamEnableProductionFeedback? enableProductionFeedback,
            global::Vercel.TeamSensitiveEnvironmentVariablePolicy? sensitiveEnvironmentVariablePolicy,
            global::Vercel.TeamDisjunctiveProductionSecretPolicy? disjunctiveProductionSecretPolicy,
            bool? hideIpAddresses,
            bool? hideIpAddressesInLogDrains,
            global::Vercel.TeamDpAccessRequestsMode? dpAccessRequestsMode,
            global::System.Collections.Generic.IList<global::Vercel.TeamIpBucket>? ipBuckets,
            bool? requireVerifiedCommits,
            bool? disableRepositoryDispatchEvents,
            global::Vercel.TeamStrictDeploymentProtectionSettings? strictDeploymentProtectionSettings,
            global::Vercel.TeamStrictShareableLinks? strictShareableLinks,
            global::Vercel.TeamStrictPasswordProtectionSettings? strictPasswordProtectionSettings,
            global::Vercel.TeamStrictConnectors? strictConnectors,
            global::Vercel.TeamNsnbConfig? nsnbConfig,
            global::Vercel.TeamDeploymentPolicy? deploymentPolicy,
            double? personalAccessTokensInvalidatedAt,
            double? appTokensInvalidatedAt,
            double? apiKeysInvalidatedAt,
            double? integrationTokensInvalidatedAt,
            string? name,
            string? avatar,
            global::Vercel.TeamMembership? membership,
            string? parentId,
            string? orgRootTeamId)
        {
            this.Connect = connect;
            this.CreatorId = creatorId ?? throw new global::System.ArgumentNullException(nameof(creatorId));
            this.UpdatedAt = updatedAt;
            this.EmailDomain = emailDomain;
            this.Saml = saml;
            this.InviteCode = inviteCode;
            this.Billing = billing;
            this.Description = description;
            this.DefaultRoles = defaultRoles;
            this.StagingPrefix = stagingPrefix ?? throw new global::System.ArgumentNullException(nameof(stagingPrefix));
            this.ResourceConfig = resourceConfig;
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
            this.Platform = platform;
            this.DisableHardAutoBlocks = disableHardAutoBlocks;
            this.RemoteCaching = remoteCaching;
            this.DefaultDeploymentProtection = defaultDeploymentProtection;
            this.DefaultPassport = defaultPassport;
            this.DefaultExpirationSettings = defaultExpirationSettings;
            this.DefaultProjectJobs = defaultProjectJobs;
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.EnableProductionFeedback = enableProductionFeedback;
            this.SensitiveEnvironmentVariablePolicy = sensitiveEnvironmentVariablePolicy;
            this.DisjunctiveProductionSecretPolicy = disjunctiveProductionSecretPolicy;
            this.HideIpAddresses = hideIpAddresses;
            this.HideIpAddressesInLogDrains = hideIpAddressesInLogDrains;
            this.DpAccessRequestsMode = dpAccessRequestsMode;
            this.IpBuckets = ipBuckets;
            this.RequireVerifiedCommits = requireVerifiedCommits;
            this.DisableRepositoryDispatchEvents = disableRepositoryDispatchEvents;
            this.StrictDeploymentProtectionSettings = strictDeploymentProtectionSettings;
            this.StrictShareableLinks = strictShareableLinks;
            this.StrictPasswordProtectionSettings = strictPasswordProtectionSettings;
            this.StrictConnectors = strictConnectors;
            this.NsnbConfig = nsnbConfig;
            this.DeploymentPolicy = deploymentPolicy;
            this.PersonalAccessTokensInvalidatedAt = personalAccessTokensInvalidatedAt;
            this.AppTokensInvalidatedAt = appTokensInvalidatedAt;
            this.ApiKeysInvalidatedAt = apiKeysInvalidatedAt;
            this.IntegrationTokensInvalidatedAt = integrationTokensInvalidatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name;
            this.Avatar = avatar;
            this.Membership = membership;
            this.CreatedAt = createdAt;
            this.ParentId = parentId;
            this.OrgRootTeamId = orgRootTeamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        public Team()
        {
        }

    }
}