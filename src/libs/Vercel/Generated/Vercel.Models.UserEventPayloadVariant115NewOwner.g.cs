
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abuse")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerAbuse? Abuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptanceState")]
        public string? AcceptanceState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedAt")]
        public double? AcceptedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant115NewOwnerBilling Billing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public double? Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockReason")]
        public string? BlockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public double? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerCredentialVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerCredentialVariant2>>? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbCustomerId")]
        public string? OrbCustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerDataCache? DataCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedTeams")]
        public global::System.Collections.Generic.IList<string>? DismissedTeams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerDismissedToast>? DismissedToasts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoriteProjectsAndSpaces")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerFavoriteProjectsAndSpace>? FavoriteProjectsAndSpaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importFlowGitNamespace")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? ImportFlowGitNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importFlowGitNamespaceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? ImportFlowGitNamespaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importFlowGitProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerImportFlowGitProviderJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerImportFlowGitProvider? ImportFlowGitProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferredScopesAndGitNamespaces")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerPreferredScopesAndGitNamespace>? PreferredScopesAndGitNamespaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDomainReseller")]
        public bool? IsDomainReseller { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isZeitPub")]
        public bool? IsZeitPub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testAccountExpiresAt")]
        public double? TestAccountExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxActiveSlots")]
        public double? MaxActiveSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platformVersion")]
        public double? PlatformVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preventAutoBlocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>))]
        public global::Vercel.OneOf<double?, bool?>? PreventAutoBlocking { get; set; }

        /// <summary>
        /// Overrides our DEFAULT project domains limit per account or per project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDomainsLimit")]
        public double? ProjectDomainsLimit { get; set; }

        /// <summary>
        /// Represents configuration for remote caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerRemoteCaching? RemoteCaching { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedAliasesAt")]
        public double? RemovedAliasesAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedBillingSubscriptionAt")]
        public double? RemovedBillingSubscriptionAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedConfigurationsAt")]
        public double? RemovedConfigurationsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedDeploymentsAt")]
        public double? RemovedDeploymentsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedDomiansAt")]
        public double? RemovedDomiansAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedEventsAt")]
        public double? RemovedEventsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedProjectsAt")]
        public double? RemovedProjectsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedSecretsAt")]
        public double? RemovedSecretsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedSharedEnvVarsAt")]
        public double? RemovedSharedEnvVarsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedEdgeConfigsAt")]
        public double? RemovedEdgeConfigsAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        /// User | Team resource limits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceLimits")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant115NewOwnerResourceLimits2>? ResourceLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeDashboardViews")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardView>? ActiveDashboardViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondaryEmails")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerSecondaryEmail>? SecondaryEmails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailDomains")]
        public global::System.Collections.Generic.IList<string>? EmailDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailNotifications")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerEmailNotifications? EmailNotifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siftScore")]
        public double? SiftScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siftScores")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant115NewOwnerSiftScores2>? SiftScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siftRoute")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerSiftRoute? SiftRoute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sfdcId")]
        public string? SfdcId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("softBlock")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerSoftBlock? SoftBlock { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stagingPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StagingPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sysToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SysToken { get; set; }

        /// <summary>
        /// A helper that allows to describe a relationship attribute. It receives the shape of a relationship plus the foreignKey name to make it mandatory in the resulting type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerTeam>? Teams { get; set; }

        /// <summary>
        /// Introduced 2022-04-12 An array of teamIds (for trial teams created after 2022-04-01), created by the user in question. Used in determining whether the team has a trial available in utils/api-teams/user-has-trial-available.ts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialTeamIds")]
        public global::System.Collections.Generic.IList<string>? TrialTeamIds { get; set; }

        /// <summary>
        /// Introduced 2022-04-19 Number of maximum trials to allocate to a user. When undefined, defaults to MAX_TRIALS in utils/api-teams/user-has-trial-available.ts. This is set to trialTeamIds + 1 by services/api-backoffice/src/handlers/add-additional-trial.ts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTrials")]
        public double? MaxTrials { get; set; }

        /// <summary>
        /// Deprecated on 2022-04-12 in favor of trialTeamIds and using utils/api-teams/user-has-trial-available.ts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialTeamId")]
        public string? TrialTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerType Type { get; set; }

        /// <summary>
        /// Contains the timestamps when a user was notified about their usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageAlerts")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerUsageAlerts? UsageAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overageUsageAlerts")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerOverageUsageAlerts? OverageUsageAlerts { get; set; }

        /// <summary>
        /// Contains the timestamps for usage summary emails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overageMetadata")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerOverageMetadata? OverageMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Whether the Vercel Toolbar is enabled for preview deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePreviewFeedback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerEnablePreviewFeedbackJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerEnablePreviewFeedback? EnablePreviewFeedback { get; set; }

        /// <summary>
        /// Information about which features are blocked for a user. Blocks can be either soft (the user can still access the feature, but with a warning, e.g. prompting an upgrade) or hard (the user cannot access the feature at all).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureBlocks")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocks? FeatureBlocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultTeamId")]
        public string? DefaultTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerVersionJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerVersion Version { get; set; }

        /// <summary>
        /// An archive of information about the Northstar migration, derived from the old (deprecated) property, `northstarMigrationEvents`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("northstarMigration")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerNorthstarMigration? NorthstarMigration { get; set; }

        /// <summary>
        /// The salesforce opportunity ID that this user is linked to. This is used to automatically associate a team of the user's choosing with the opportunity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opportunityId")]
        public string? OpportunityId { get; set; }

        /// <summary>
        /// MFA configuration. When enabled, the user will be required to provide a second factor of authentication when logging in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfaConfiguration")]
        public global::Vercel.UserEventPayloadVariant115NewOwnerMfaConfiguration? MfaConfiguration { get; set; }

        /// <summary>
        /// Indicates that the underlying user entity is a managed user for the enterprise it's associated with The intention is that this field is only set to true for users that are provisioned by the enterprise which means that the domain associated with the user's email is the same domain associated with the team Allowing us to query information about the user's team at login time through the domain verification service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnterpriseManaged")]
        public bool? IsEnterpriseManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwner" /> class.
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="createdAt"></param>
        /// <param name="deploymentSecret"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="stagingPrefix"></param>
        /// <param name="sysToken"></param>
        /// <param name="username"></param>
        /// <param name="updatedAt"></param>
        /// <param name="abuse"></param>
        /// <param name="acceptanceState"></param>
        /// <param name="acceptedAt"></param>
        /// <param name="avatar"></param>
        /// <param name="blocked"></param>
        /// <param name="blockReason"></param>
        /// <param name="created"></param>
        /// <param name="credentials"></param>
        /// <param name="customerId"></param>
        /// <param name="orbCustomerId"></param>
        /// <param name="dataCache"></param>
        /// <param name="deletedAt"></param>
        /// <param name="dismissedTeams"></param>
        /// <param name="dismissedToasts"></param>
        /// <param name="favoriteProjectsAndSpaces"></param>
        /// <param name="importFlowGitNamespace"></param>
        /// <param name="importFlowGitNamespaceId"></param>
        /// <param name="importFlowGitProvider"></param>
        /// <param name="preferredScopesAndGitNamespaces"></param>
        /// <param name="isDomainReseller"></param>
        /// <param name="isZeitPub"></param>
        /// <param name="testAccountExpiresAt"></param>
        /// <param name="maxActiveSlots"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="platformVersion"></param>
        /// <param name="preventAutoBlocking"></param>
        /// <param name="projectDomainsLimit">
        /// Overrides our DEFAULT project domains limit per account or per project.
        /// </param>
        /// <param name="remoteCaching">
        /// Represents configuration for remote caching
        /// </param>
        /// <param name="removedAliasesAt"></param>
        /// <param name="removedBillingSubscriptionAt"></param>
        /// <param name="removedConfigurationsAt"></param>
        /// <param name="removedDeploymentsAt"></param>
        /// <param name="removedDomiansAt"></param>
        /// <param name="removedEventsAt"></param>
        /// <param name="removedProjectsAt"></param>
        /// <param name="removedSecretsAt"></param>
        /// <param name="removedSharedEnvVarsAt"></param>
        /// <param name="removedEdgeConfigsAt"></param>
        /// <param name="resourceConfig"></param>
        /// <param name="resourceLimits">
        /// User | Team resource limits
        /// </param>
        /// <param name="activeDashboardViews"></param>
        /// <param name="secondaryEmails"></param>
        /// <param name="emailDomains"></param>
        /// <param name="emailNotifications"></param>
        /// <param name="siftScore"></param>
        /// <param name="siftScores"></param>
        /// <param name="siftRoute"></param>
        /// <param name="sfdcId"></param>
        /// <param name="softBlock"></param>
        /// <param name="teams">
        /// A helper that allows to describe a relationship attribute. It receives the shape of a relationship plus the foreignKey name to make it mandatory in the resulting type.
        /// </param>
        /// <param name="trialTeamIds">
        /// Introduced 2022-04-12 An array of teamIds (for trial teams created after 2022-04-01), created by the user in question. Used in determining whether the team has a trial available in utils/api-teams/user-has-trial-available.ts.
        /// </param>
        /// <param name="maxTrials">
        /// Introduced 2022-04-19 Number of maximum trials to allocate to a user. When undefined, defaults to MAX_TRIALS in utils/api-teams/user-has-trial-available.ts. This is set to trialTeamIds + 1 by services/api-backoffice/src/handlers/add-additional-trial.ts.
        /// </param>
        /// <param name="trialTeamId">
        /// Deprecated on 2022-04-12 in favor of trialTeamIds and using utils/api-teams/user-has-trial-available.ts.
        /// </param>
        /// <param name="type"></param>
        /// <param name="usageAlerts">
        /// Contains the timestamps when a user was notified about their usage
        /// </param>
        /// <param name="overageUsageAlerts"></param>
        /// <param name="overageMetadata">
        /// Contains the timestamps for usage summary emails.
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Whether the Vercel Toolbar is enabled for preview deployments.
        /// </param>
        /// <param name="featureBlocks">
        /// Information about which features are blocked for a user. Blocks can be either soft (the user can still access the feature, but with a warning, e.g. prompting an upgrade) or hard (the user cannot access the feature at all).
        /// </param>
        /// <param name="defaultTeamId"></param>
        /// <param name="version"></param>
        /// <param name="northstarMigration">
        /// An archive of information about the Northstar migration, derived from the old (deprecated) property, `northstarMigrationEvents`.
        /// </param>
        /// <param name="opportunityId">
        /// The salesforce opportunity ID that this user is linked to. This is used to automatically associate a team of the user's choosing with the opportunity.
        /// </param>
        /// <param name="mfaConfiguration">
        /// MFA configuration. When enabled, the user will be required to provide a second factor of authentication when logging in.
        /// </param>
        /// <param name="isEnterpriseManaged">
        /// Indicates that the underlying user entity is a managed user for the enterprise it's associated with The intention is that this field is only set to true for users that are provisioned by the enterprise which means that the domain associated with the user's email is the same domain associated with the team Allowing us to query information about the user's team at login time through the domain verification service
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwner(
            global::Vercel.UserEventPayloadVariant115NewOwnerBilling billing,
            double createdAt,
            string deploymentSecret,
            string email,
            string id,
            string stagingPrefix,
            string sysToken,
            string username,
            double updatedAt,
            global::Vercel.UserEventPayloadVariant115NewOwnerAbuse? abuse,
            string? acceptanceState,
            double? acceptedAt,
            string? avatar,
            double? blocked,
            string? blockReason,
            double? created,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UserEventPayloadVariant115NewOwnerCredentialVariant1, global::Vercel.UserEventPayloadVariant115NewOwnerCredentialVariant2>>? credentials,
            string? customerId,
            string? orbCustomerId,
            global::Vercel.UserEventPayloadVariant115NewOwnerDataCache? dataCache,
            double? deletedAt,
            global::System.Collections.Generic.IList<string>? dismissedTeams,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerDismissedToast>? dismissedToasts,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerFavoriteProjectsAndSpace>? favoriteProjectsAndSpaces,
            global::Vercel.OneOf<string, double?>? importFlowGitNamespace,
            global::Vercel.OneOf<string, double?>? importFlowGitNamespaceId,
            global::Vercel.UserEventPayloadVariant115NewOwnerImportFlowGitProvider? importFlowGitProvider,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerPreferredScopesAndGitNamespace>? preferredScopesAndGitNamespaces,
            bool? isDomainReseller,
            bool? isZeitPub,
            double? testAccountExpiresAt,
            double? maxActiveSlots,
            string? name,
            string? phoneNumber,
            double? platformVersion,
            global::Vercel.OneOf<double?, bool?>? preventAutoBlocking,
            double? projectDomainsLimit,
            global::Vercel.UserEventPayloadVariant115NewOwnerRemoteCaching? remoteCaching,
            double? removedAliasesAt,
            double? removedBillingSubscriptionAt,
            double? removedConfigurationsAt,
            double? removedDeploymentsAt,
            double? removedDomiansAt,
            double? removedEventsAt,
            double? removedProjectsAt,
            double? removedSecretsAt,
            double? removedSharedEnvVarsAt,
            double? removedEdgeConfigsAt,
            global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfig? resourceConfig,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant115NewOwnerResourceLimits2>? resourceLimits,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardView>? activeDashboardViews,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerSecondaryEmail>? secondaryEmails,
            global::System.Collections.Generic.IList<string>? emailDomains,
            global::Vercel.UserEventPayloadVariant115NewOwnerEmailNotifications? emailNotifications,
            double? siftScore,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UserEventPayloadVariant115NewOwnerSiftScores2>? siftScores,
            global::Vercel.UserEventPayloadVariant115NewOwnerSiftRoute? siftRoute,
            string? sfdcId,
            global::Vercel.UserEventPayloadVariant115NewOwnerSoftBlock? softBlock,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant115NewOwnerTeam>? teams,
            global::System.Collections.Generic.IList<string>? trialTeamIds,
            double? maxTrials,
            string? trialTeamId,
            global::Vercel.UserEventPayloadVariant115NewOwnerType type,
            global::Vercel.UserEventPayloadVariant115NewOwnerUsageAlerts? usageAlerts,
            global::Vercel.UserEventPayloadVariant115NewOwnerOverageUsageAlerts? overageUsageAlerts,
            global::Vercel.UserEventPayloadVariant115NewOwnerOverageMetadata? overageMetadata,
            global::Vercel.UserEventPayloadVariant115NewOwnerEnablePreviewFeedback? enablePreviewFeedback,
            global::Vercel.UserEventPayloadVariant115NewOwnerFeatureBlocks? featureBlocks,
            string? defaultTeamId,
            global::Vercel.UserEventPayloadVariant115NewOwnerVersion version,
            global::Vercel.UserEventPayloadVariant115NewOwnerNorthstarMigration? northstarMigration,
            string? opportunityId,
            global::Vercel.UserEventPayloadVariant115NewOwnerMfaConfiguration? mfaConfiguration,
            bool? isEnterpriseManaged)
        {
            this.Abuse = abuse;
            this.AcceptanceState = acceptanceState;
            this.AcceptedAt = acceptedAt;
            this.Avatar = avatar;
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
            this.Blocked = blocked;
            this.BlockReason = blockReason;
            this.Created = created;
            this.CreatedAt = createdAt;
            this.Credentials = credentials;
            this.CustomerId = customerId;
            this.OrbCustomerId = orbCustomerId;
            this.DataCache = dataCache;
            this.DeletedAt = deletedAt;
            this.DeploymentSecret = deploymentSecret ?? throw new global::System.ArgumentNullException(nameof(deploymentSecret));
            this.DismissedTeams = dismissedTeams;
            this.DismissedToasts = dismissedToasts;
            this.FavoriteProjectsAndSpaces = favoriteProjectsAndSpaces;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ImportFlowGitNamespace = importFlowGitNamespace;
            this.ImportFlowGitNamespaceId = importFlowGitNamespaceId;
            this.ImportFlowGitProvider = importFlowGitProvider;
            this.PreferredScopesAndGitNamespaces = preferredScopesAndGitNamespaces;
            this.IsDomainReseller = isDomainReseller;
            this.IsZeitPub = isZeitPub;
            this.TestAccountExpiresAt = testAccountExpiresAt;
            this.MaxActiveSlots = maxActiveSlots;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.PlatformVersion = platformVersion;
            this.PreventAutoBlocking = preventAutoBlocking;
            this.ProjectDomainsLimit = projectDomainsLimit;
            this.RemoteCaching = remoteCaching;
            this.RemovedAliasesAt = removedAliasesAt;
            this.RemovedBillingSubscriptionAt = removedBillingSubscriptionAt;
            this.RemovedConfigurationsAt = removedConfigurationsAt;
            this.RemovedDeploymentsAt = removedDeploymentsAt;
            this.RemovedDomiansAt = removedDomiansAt;
            this.RemovedEventsAt = removedEventsAt;
            this.RemovedProjectsAt = removedProjectsAt;
            this.RemovedSecretsAt = removedSecretsAt;
            this.RemovedSharedEnvVarsAt = removedSharedEnvVarsAt;
            this.RemovedEdgeConfigsAt = removedEdgeConfigsAt;
            this.ResourceConfig = resourceConfig;
            this.ResourceLimits = resourceLimits;
            this.ActiveDashboardViews = activeDashboardViews;
            this.SecondaryEmails = secondaryEmails;
            this.EmailDomains = emailDomains;
            this.EmailNotifications = emailNotifications;
            this.SiftScore = siftScore;
            this.SiftScores = siftScores;
            this.SiftRoute = siftRoute;
            this.SfdcId = sfdcId;
            this.SoftBlock = softBlock;
            this.StagingPrefix = stagingPrefix ?? throw new global::System.ArgumentNullException(nameof(stagingPrefix));
            this.SysToken = sysToken ?? throw new global::System.ArgumentNullException(nameof(sysToken));
            this.Teams = teams;
            this.TrialTeamIds = trialTeamIds;
            this.MaxTrials = maxTrials;
            this.TrialTeamId = trialTeamId;
            this.Type = type;
            this.UsageAlerts = usageAlerts;
            this.OverageUsageAlerts = overageUsageAlerts;
            this.OverageMetadata = overageMetadata;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.UpdatedAt = updatedAt;
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.FeatureBlocks = featureBlocks;
            this.DefaultTeamId = defaultTeamId;
            this.Version = version;
            this.NorthstarMigration = northstarMigration;
            this.OpportunityId = opportunityId;
            this.MfaConfiguration = mfaConfiguration;
            this.IsEnterpriseManaged = isEnterpriseManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwner" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwner()
        {
        }
    }
}