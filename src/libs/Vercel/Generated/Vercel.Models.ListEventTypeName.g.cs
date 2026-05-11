
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The name of the event type.<br/>
    /// Example: deployment-created
    /// </summary>
    public enum ListEventTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        AccessGroupCreated,
        /// <summary>
        /// 
        /// </summary>
        AccessGroupDeleted,
        /// <summary>
        /// 
        /// </summary>
        AccessGroupProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        AccessGroupUpdated,
        /// <summary>
        /// 
        /// </summary>
        AccessGroupUserAdded,
        /// <summary>
        /// 
        /// </summary>
        AccessGroupUserRemoved,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningAccountBlocked,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningAccountLinked,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningAccountRelinked,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningAccountUnlinked,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningCredentialsRotated,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningPlanChanged,
        /// <summary>
        /// 
        /// </summary>
        AgenticProvisioningTeamCreated,
        /// <summary>
        /// 
        /// </summary>
        AiAlertInvestigation,
        /// <summary>
        /// 
        /// </summary>
        AiCodeReview,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayByokCredentialCreated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayByokCredentialDeleted,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayByokCredentialUpdated,
        /// <summary>
        /// 
        /// </summary>
        AlertRuleCreated,
        /// <summary>
        /// 
        /// </summary>
        AlertRuleDeleted,
        /// <summary>
        /// 
        /// </summary>
        AlertRuleUpdated,
        /// <summary>
        /// 
        /// </summary>
        Alias,
        /// <summary>
        /// 
        /// </summary>
        AliasChown,
        /// <summary>
        /// 
        /// </summary>
        AliasDelete,
        /// <summary>
        /// 
        /// </summary>
        AliasInviteCreated,
        /// <summary>
        /// 
        /// </summary>
        AliasInviteJoined,
        /// <summary>
        /// 
        /// </summary>
        AliasInviteRevoked,
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionBypassCreated,
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionBypassException,
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionBypassRegenerated,
        /// <summary>
        /// 
        /// </summary>
        AliasProtectionBypassRevoked,
        /// <summary>
        /// 
        /// </summary>
        AliasSystem,
        /// <summary>
        /// 
        /// </summary>
        AliasUserScopedAccessDenied,
        /// <summary>
        /// 
        /// </summary>
        AliasUserScopedAccessGranted,
        /// <summary>
        /// 
        /// </summary>
        AliasUserScopedAccessRequested,
        /// <summary>
        /// 
        /// </summary>
        AliasUserScopedAccessRevoked,
        /// <summary>
        /// 
        /// </summary>
        AliasesAssigned,
        /// <summary>
        /// 
        /// </summary>
        AttackModeDisabled,
        /// <summary>
        /// 
        /// </summary>
        AttackModeEnabled,
        /// <summary>
        /// 
        /// </summary>
        AuditLogExportDownloaded,
        /// <summary>
        /// 
        /// </summary>
        AuditLogExportRequested,
        /// <summary>
        /// 
        /// </summary>
        AuthorizeGitDeployment,
        /// <summary>
        /// 
        /// </summary>
        AutoExposeSystemEnvs,
        /// <summary>
        /// 
        /// </summary>
        Avatar,
        /// <summary>
        /// 
        /// </summary>
        BulkRedirectsSettingsUpdated,
        /// <summary>
        /// 
        /// </summary>
        BulkRedirectsVersionPromoted,
        /// <summary>
        /// 
        /// </summary>
        BulkRedirectsVersionRestored,
        /// <summary>
        /// 
        /// </summary>
        Cert,
        /// <summary>
        /// 
        /// </summary>
        CertAutorenew,
        /// <summary>
        /// 
        /// </summary>
        CertChown,
        /// <summary>
        /// 
        /// </summary>
        CertClone,
        /// <summary>
        /// 
        /// </summary>
        CertDelete,
        /// <summary>
        /// 
        /// </summary>
        CertRenew,
        /// <summary>
        /// 
        /// </summary>
        CertReplace,
        /// <summary>
        /// 
        /// </summary>
        CertSystemCreate,
        /// <summary>
        /// 
        /// </summary>
        ConcurrentBuildsUpdate,
        /// <summary>
        /// 
        /// </summary>
        ConnectBitbucket,
        /// <summary>
        /// 
        /// </summary>
        ConnectBitbucketApp,
        /// <summary>
        /// 
        /// </summary>
        ConnectConfigurationCreated,
        /// <summary>
        /// 
        /// </summary>
        ConnectConfigurationDeleted,
        /// <summary>
        /// 
        /// </summary>
        ConnectConfigurationLinkUpdated,
        /// <summary>
        /// 
        /// </summary>
        ConnectConfigurationLinked,
        /// <summary>
        /// 
        /// </summary>
        ConnectConfigurationUnlinked,
        /// <summary>
        /// 
        /// </summary>
        ConnectConfigurationUpdated,
        /// <summary>
        /// 
        /// </summary>
        ConnectGithub,
        /// <summary>
        /// 
        /// </summary>
        ConnectGithubCustomHost,
        /// <summary>
        /// 
        /// </summary>
        ConnectGithubLimited,
        /// <summary>
        /// 
        /// </summary>
        ConnectGitlab,
        /// <summary>
        /// 
        /// </summary>
        ConnectGitlabApp,
        /// <summary>
        /// 
        /// </summary>
        CustomSuffixClear,
        /// <summary>
        /// 
        /// </summary>
        CustomSuffixDisable,
        /// <summary>
        /// 
        /// </summary>
        CustomSuffixEnable,
        /// <summary>
        /// 
        /// </summary>
        CustomSuffixPending,
        /// <summary>
        /// 
        /// </summary>
        CustomSuffixReady,
        /// <summary>
        /// 
        /// </summary>
        DeployHookCreated,
        /// <summary>
        /// 
        /// </summary>
        DeployHookDeduped,
        /// <summary>
        /// 
        /// </summary>
        DeployHookDeleted,
        /// <summary>
        /// 
        /// </summary>
        DeployHookProcessed,
        /// <summary>
        /// 
        /// </summary>
        Deployment,
        /// <summary>
        /// 
        /// </summary>
        DeploymentCheckCreated,
        /// <summary>
        /// 
        /// </summary>
        DeploymentCheckDeleted,
        /// <summary>
        /// 
        /// </summary>
        DeploymentCheckUpdated,
        /// <summary>
        /// 
        /// </summary>
        DeploymentChown,
        /// <summary>
        /// 
        /// </summary>
        DeploymentCreationBlocked,
        /// <summary>
        /// 
        /// </summary>
        DeploymentDelete,
        /// <summary>
        /// 
        /// </summary>
        DisabledIntegrationInstallationRemoved,
        /// <summary>
        /// 
        /// </summary>
        DisconnectBitbucketApp,
        /// <summary>
        /// 
        /// </summary>
        DisconnectGithub,
        /// <summary>
        /// 
        /// </summary>
        DisconnectGithubCustomHost,
        /// <summary>
        /// 
        /// </summary>
        DisconnectGithubLimited,
        /// <summary>
        /// 
        /// </summary>
        DisconnectGitlabApp,
        /// <summary>
        /// 
        /// </summary>
        DnsAdd,
        /// <summary>
        /// 
        /// </summary>
        DnsDelete,
        /// <summary>
        /// 
        /// </summary>
        DnsUpdate,
        /// <summary>
        /// 
        /// </summary>
        DnsZonefileImport,
        /// <summary>
        /// 
        /// </summary>
        Domain,
        /// <summary>
        /// 
        /// </summary>
        DomainBuy,
        /// <summary>
        /// 
        /// </summary>
        DomainCdn,
        /// <summary>
        /// 
        /// </summary>
        DomainChown,
        /// <summary>
        /// 
        /// </summary>
        DomainCustomNsChange,
        /// <summary>
        /// 
        /// </summary>
        DomainDelegated,
        /// <summary>
        /// 
        /// </summary>
        DomainDelete,
        /// <summary>
        /// 
        /// </summary>
        DomainMoveIn,
        /// <summary>
        /// 
        /// </summary>
        DomainMoveOut,
        /// <summary>
        /// 
        /// </summary>
        DomainMoveOutRequestSent,
        /// <summary>
        /// 
        /// </summary>
        DomainRenewChange,
        /// <summary>
        /// 
        /// </summary>
        DomainServiceTypeUpdated,
        /// <summary>
        /// 
        /// </summary>
        DomainTransferIn,
        /// <summary>
        /// 
        /// </summary>
        DomainTransferInCanceled,
        /// <summary>
        /// 
        /// </summary>
        DomainTransferInCompleted,
        /// <summary>
        /// 
        /// </summary>
        DomainZoneChange,
        /// <summary>
        /// 
        /// </summary>
        DrainCreated,
        /// <summary>
        /// 
        /// </summary>
        DrainDeleted,
        /// <summary>
        /// 
        /// </summary>
        DrainDisabled,
        /// <summary>
        /// 
        /// </summary>
        DrainEnabled,
        /// <summary>
        /// 
        /// </summary>
        DrainUpdated,
        /// <summary>
        /// 
        /// </summary>
        EdgeCacheDangerouslyDeleteBySrcImages,
        /// <summary>
        /// 
        /// </summary>
        EdgeCacheDangerouslyDeleteByTags,
        /// <summary>
        /// 
        /// </summary>
        EdgeCacheInvalidateBySrcImages,
        /// <summary>
        /// 
        /// </summary>
        EdgeCacheInvalidateByTags,
        /// <summary>
        /// 
        /// </summary>
        EdgeCachePurgeAll,
        /// <summary>
        /// 
        /// </summary>
        EdgeCacheRollbackPurge,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigCreated,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigDeleted,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigItemsUpdated,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigSchemaDeleted,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigSchemaUpdated,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigTokenCreated,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigTokenDeleted,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigTransferIn,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigTransferOut,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigUpdated,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        EmailNotificationRuleRemoved,
        /// <summary>
        /// 
        /// </summary>
        EmailNotificationRuleUpdated,
        /// <summary>
        /// 
        /// </summary>
        EnforceSensitiveEnvironmentVariables,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableAdd,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableDelete,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableEdit,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_cli_dev,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_cli_env_add,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_cli_env_ls,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_cli_env_pull,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_cli_env_rm,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_cli_pull,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_unknownSource,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRead_v0_env_pull,
        /// <summary>
        /// 
        /// </summary>
        EnvVariableRotated,
        /// <summary>
        /// 
        /// </summary>
        FirewallBypassCreated,
        /// <summary>
        /// 
        /// </summary>
        FirewallBypassDeleted,
        /// <summary>
        /// 
        /// </summary>
        FirewallConfigModified,
        /// <summary>
        /// 
        /// </summary>
        FirewallConfigPromoted,
        /// <summary>
        /// 
        /// </summary>
        FirewallConfigRemoved,
        /// <summary>
        /// 
        /// </summary>
        FirewallManagedRulegroupUpdated,
        /// <summary>
        /// 
        /// </summary>
        FirewallManagedRulesetUpdated,
        /// <summary>
        /// 
        /// </summary>
        Flag,
        /// <summary>
        /// 
        /// </summary>
        FlagArchived,
        /// <summary>
        /// 
        /// </summary>
        FlagCreated,
        /// <summary>
        /// 
        /// </summary>
        FlagDeleted,
        /// <summary>
        /// 
        /// </summary>
        FlagUnarchived,
        /// <summary>
        /// 
        /// </summary>
        FlagUpdated,
        /// <summary>
        /// 
        /// </summary>
        FlagsExplorerSubscription,
        /// <summary>
        /// 
        /// </summary>
        FlagsSdkKey,
        /// <summary>
        /// 
        /// </summary>
        FlagsSdkKeyAdded,
        /// <summary>
        /// 
        /// </summary>
        FlagsSdkKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        FlagsSdkKeyRead,
        /// <summary>
        /// 
        /// </summary>
        FlagsSegment,
        /// <summary>
        /// 
        /// </summary>
        FlagsSettings,
        /// <summary>
        /// 
        /// </summary>
        InstantRollbackCreated,
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfigurationOwnerChanged,
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfigurationScopeChangeConfirmed,
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfigurationTransferInSuccess,
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfigurationTransferOutSuccess,
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfigurationsDisabled,
        /// <summary>
        /// 
        /// </summary>
        IntegrationInstallationBillingPlanUpdated,
        /// <summary>
        /// 
        /// </summary>
        IntegrationInstallationCompleted,
        /// <summary>
        /// 
        /// </summary>
        IntegrationInstallationPermissionUpdated,
        /// <summary>
        /// 
        /// </summary>
        IntegrationInstallationRemoved,
        /// <summary>
        /// 
        /// </summary>
        IntegrationScopeChanged,
        /// <summary>
        /// 
        /// </summary>
        InvoiceModified,
        /// <summary>
        /// 
        /// </summary>
        InvoiceRefunded,
        /// <summary>
        /// 
        /// </summary>
        LogDrainCreated,
        /// <summary>
        /// 
        /// </summary>
        LogDrainDeleted,
        /// <summary>
        /// 
        /// </summary>
        LogDrainDisabled,
        /// <summary>
        /// 
        /// </summary>
        LogDrainEnabled,
        /// <summary>
        /// 
        /// </summary>
        Login,
        /// <summary>
        /// 
        /// </summary>
        ManualDeploymentPromotionCreated,
        /// <summary>
        /// 
        /// </summary>
        MarketplaceIntegrationAllowlistUpdated,
        /// <summary>
        /// 
        /// </summary>
        MicrofrontendGroupAdded,
        /// <summary>
        /// 
        /// </summary>
        MicrofrontendGroupDeleted,
        /// <summary>
        /// 
        /// </summary>
        MicrofrontendGroupUpdated,
        /// <summary>
        /// 
        /// </summary>
        MicrofrontendProjectAddedToGroup,
        /// <summary>
        /// 
        /// </summary>
        MicrofrontendProjectRemovedFromGroup,
        /// <summary>
        /// 
        /// </summary>
        MicrofrontendProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        MonitoringDisabled,
        /// <summary>
        /// 
        /// </summary>
        MonitoringEnabled,
        /// <summary>
        /// 
        /// </summary>
        OauthAppConnectionCreated,
        /// <summary>
        /// 
        /// </summary>
        OauthAppConnectionRemoved,
        /// <summary>
        /// 
        /// </summary>
        OauthAppConnectionUpdated,
        /// <summary>
        /// 
        /// </summary>
        OauthAppCreated,
        /// <summary>
        /// 
        /// </summary>
        OauthAppDeleted,
        /// <summary>
        /// 
        /// </summary>
        OauthAppSecretDeleted,
        /// <summary>
        /// 
        /// </summary>
        OauthAppSecretGenerated,
        /// <summary>
        /// 
        /// </summary>
        OauthAppTokenCreated,
        /// <summary>
        /// 
        /// </summary>
        OauthAppUpdated,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityDisabled,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityEnabled,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityPlusProjectDisabled,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityPlusProjectEnabled,
        /// <summary>
        /// 
        /// </summary>
        OwnerBlocked,
        /// <summary>
        /// 
        /// </summary>
        OwnerSoftBlocked,
        /// <summary>
        /// 
        /// </summary>
        OwnerSoftUnblocked,
        /// <summary>
        /// 
        /// </summary>
        OwnerUnblocked,
        /// <summary>
        /// 
        /// </summary>
        PageIntegrityConfigUpdated,
        /// <summary>
        /// 
        /// </summary>
        PageIntegrityHeaderApproved,
        /// <summary>
        /// 
        /// </summary>
        PageIntegrityResourceApproved,
        /// <summary>
        /// 
        /// </summary>
        PageIntegrityResourceDeleted,
        /// <summary>
        /// 
        /// </summary>
        PageIntegrityResourceRejected,
        /// <summary>
        /// 
        /// </summary>
        PasskeyCreated,
        /// <summary>
        /// 
        /// </summary>
        PasskeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        PasskeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        PasswordProtectionDisabled,
        /// <summary>
        /// 
        /// </summary>
        PasswordProtectionEnabled,
        /// <summary>
        /// 
        /// </summary>
        PaymentMethodAdded,
        /// <summary>
        /// 
        /// </summary>
        PaymentMethodDefaultUpdated,
        /// <summary>
        /// 
        /// </summary>
        PaymentMethodRemoved,
        /// <summary>
        /// 
        /// </summary>
        Plan,
        /// <summary>
        /// 
        /// </summary>
        PreviewDeploymentSuffixDisabled,
        /// <summary>
        /// 
        /// </summary>
        PreviewDeploymentSuffixEnabled,
        /// <summary>
        /// 
        /// </summary>
        PreviewDeploymentSuffixUpdate,
        /// <summary>
        /// 
        /// </summary>
        PrivatelinkEndpointCreated,
        /// <summary>
        /// 
        /// </summary>
        PrivatelinkEndpointDeleted,
        /// <summary>
        /// 
        /// </summary>
        PrivatelinkEndpointUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProductionBranchUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectAddAlias,
        /// <summary>
        /// 
        /// </summary>
        ProjectAddRedirect,
        /// <summary>
        /// 
        /// </summary>
        ProjectAffectedProjectsDeploymentsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectAliasConfiguredChange,
        /// <summary>
        /// 
        /// </summary>
        ProjectAnalyticsDisabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectAnalyticsEnabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectAutoAssignCustomProductionDomainsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectAutomationBypass,
        /// <summary>
        /// 
        /// </summary>
        ProjectBuildCommandUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectBuildLogsAndSourceProtectionUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectBuildMachineUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectClientCertDelete,
        /// <summary>
        /// 
        /// </summary>
        ProjectClientCertUpload,
        /// <summary>
        /// 
        /// </summary>
        ProjectConnectConfigurations,
        /// <summary>
        /// 
        /// </summary>
        ProjectConsolidatedGitCommitStatusUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectCreated,
        /// <summary>
        /// 
        /// </summary>
        ProjectCronJobsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectCustomEnvironmentCreated,
        /// <summary>
        /// 
        /// </summary>
        ProjectCustomEnvironmentDeleted,
        /// <summary>
        /// 
        /// </summary>
        ProjectCustomEnvironmentUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectCustomerSuccessCodeVisibilityUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectDelegatedProtectionDisabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectDelegatedProtectionEnabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectDelegatedProtectionUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectDelete,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeploymentPolicyUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeploymentRetentionUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectDirectoryListing,
        /// <summary>
        /// 
        /// </summary>
        ProjectDomainDeleted,
        /// <summary>
        /// 
        /// </summary>
        ProjectDomainMoved,
        /// <summary>
        /// 
        /// </summary>
        ProjectDomainUnverified,
        /// <summary>
        /// 
        /// </summary>
        ProjectDomainUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectDomainVerified,
        /// <summary>
        /// 
        /// </summary>
        ProjectElasticConcurrencyUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectExpirationLocked,
        /// <summary>
        /// 
        /// </summary>
        ProjectExpirationScheduled,
        /// <summary>
        /// 
        /// </summary>
        ProjectExpirationUnlocked,
        /// <summary>
        /// 
        /// </summary>
        ProjectExternalRewriteCachingUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectFrameworkUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionCpuMemory,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionFailover,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionMaxDuration,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionRegions,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionsBetaUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionsFluidDisabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectFunctionsFluidEnabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitCommitCommentsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitCommitStatusToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitCreateDeploymentsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitForkProtectionUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitLfsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitPrCommentsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitRepositoryConnected,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitRepositoryDisconnected,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitRepositoryDispatchEventsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectGitRequireVerifiedCommitsToggled,
        /// <summary>
        /// 
        /// </summary>
        ProjectIgnoredBuildStepUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectInstallCommandUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectMemberAdded,
        /// <summary>
        /// 
        /// </summary>
        ProjectMemberInvited,
        /// <summary>
        /// 
        /// </summary>
        ProjectMemberRemoved,
        /// <summary>
        /// 
        /// </summary>
        ProjectMemberRemovedBatch,
        /// <summary>
        /// 
        /// </summary>
        ProjectMemberUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectMoveInSuccess,
        /// <summary>
        /// 
        /// </summary>
        ProjectMoveOutFailed,
        /// <summary>
        /// 
        /// </summary>
        ProjectMoveOutStarted,
        /// <summary>
        /// 
        /// </summary>
        ProjectMoveOutSuccess,
        /// <summary>
        /// 
        /// </summary>
        ProjectName,
        /// <summary>
        /// 
        /// </summary>
        ProjectNodeVersionUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectOidcIssuerModeUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectOidcTokenCreated,
        /// <summary>
        /// 
        /// </summary>
        ProjectOptionsAllowlist,
        /// <summary>
        /// 
        /// </summary>
        ProjectOutputDirectoryUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectPasswordProtection,
        /// <summary>
        /// 
        /// </summary>
        ProjectPaused,
        /// <summary>
        /// 
        /// </summary>
        ProjectPreviewDeploymentSuffix,
        /// <summary>
        /// 
        /// </summary>
        ProjectPreviewEnvironmentBranchTrackingUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectPrioritizeProductionBuildsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectProgramEnrollmentChanged,
        /// <summary>
        /// 
        /// </summary>
        ProjectProtectedSourcemapsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseAborted,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseApproved,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseCompleted,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseConfigured,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseContinued,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseDisabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseEnabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleasePaused,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseStarted,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseSuggestedActionsGenerated,
        /// <summary>
        /// 
        /// </summary>
        ProjectRollingReleaseTimer,
        /// <summary>
        /// 
        /// </summary>
        ProjectRootDirectoryUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectRoutesVersionPromoted,
        /// <summary>
        /// 
        /// </summary>
        ProjectRoutesVersionRestored,
        /// <summary>
        /// 
        /// </summary>
        ProjectSkewProtectionAllowedDomainsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectSkewProtectionMaxAgeUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectSkewProtectionThresholdUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectSourceFilesOutsideRootDirectoryUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectSpeedInsightsDisabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectSpeedInsightsEnabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectSsoProtection,
        /// <summary>
        /// 
        /// </summary>
        ProjectStaticIpsUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectTrustedIps,
        /// <summary>
        /// 
        /// </summary>
        ProjectTrustedSources,
        /// <summary>
        /// 
        /// </summary>
        ProjectUnpaused,
        /// <summary>
        /// 
        /// </summary>
        ProjectWebAnalyticsDisabled,
        /// <summary>
        /// 
        /// </summary>
        ProjectWebAnalyticsEnabled,
        /// <summary>
        /// 
        /// </summary>
        ProtectedGitScopeAdded,
        /// <summary>
        /// 
        /// </summary>
        ProtectedGitScopeRemoved,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCachePurgeAll,
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// 
        /// </summary>
        ScaleAuto,
        /// <summary>
        /// 
        /// </summary>
        SecondaryEmailAdded,
        /// <summary>
        /// 
        /// </summary>
        SecondaryEmailRemoved,
        /// <summary>
        /// 
        /// </summary>
        SecondaryEmailVerified,
        /// <summary>
        /// 
        /// </summary>
        SecretAdd,
        /// <summary>
        /// 
        /// </summary>
        SecretDelete,
        /// <summary>
        /// 
        /// </summary>
        SecretRename,
        /// <summary>
        /// 
        /// </summary>
        SecurityPlusUpdated,
        /// <summary>
        /// 
        /// </summary>
        SetBio,
        /// <summary>
        /// 
        /// </summary>
        SetName,
        /// <summary>
        /// 
        /// </summary>
        SetProfiles,
        /// <summary>
        /// 
        /// </summary>
        SetScale,
        /// <summary>
        /// 
        /// </summary>
        SharedEnvVariableCreate,
        /// <summary>
        /// 
        /// </summary>
        SharedEnvVariableDelete,
        /// <summary>
        /// 
        /// </summary>
        SharedEnvVariableRead,
        /// <summary>
        /// 
        /// </summary>
        SharedEnvVariableUpdate,
        /// <summary>
        /// 
        /// </summary>
        ShowIpAddresses,
        /// <summary>
        /// 
        /// </summary>
        Signup,
        /// <summary>
        /// 
        /// </summary>
        SignupViaBitbucket,
        /// <summary>
        /// 
        /// </summary>
        SignupViaGithub,
        /// <summary>
        /// 
        /// </summary>
        SignupViaGitlab,
        /// <summary>
        /// 
        /// </summary>
        SpeedInsightsSettingsUpdated,
        /// <summary>
        /// 
        /// </summary>
        SpendCreated,
        /// <summary>
        /// 
        /// </summary>
        SpendDeleted,
        /// <summary>
        /// 
        /// </summary>
        SpendUpdated,
        /// <summary>
        /// 
        /// </summary>
        StorageAcceptTos,
        /// <summary>
        /// 
        /// </summary>
        StorageAccessTokenSet,
        /// <summary>
        /// 
        /// </summary>
        StorageAccessedDataBrowser,
        /// <summary>
        /// 
        /// </summary>
        StorageConnectProject,
        /// <summary>
        /// 
        /// </summary>
        StorageCreate,
        /// <summary>
        /// 
        /// </summary>
        StorageDelete,
        /// <summary>
        /// 
        /// </summary>
        StorageDisconnectProject,
        /// <summary>
        /// 
        /// </summary>
        StorageDisconnectProjects,
        /// <summary>
        /// 
        /// </summary>
        StorageInactiveStoreDeleted,
        /// <summary>
        /// 
        /// </summary>
        StorageResetCredentials,
        /// <summary>
        /// 
        /// </summary>
        StorageResourceReplCommand,
        /// <summary>
        /// 
        /// </summary>
        StorageSetLocked,
        /// <summary>
        /// 
        /// </summary>
        StorageTransferInSuccess,
        /// <summary>
        /// 
        /// </summary>
        StorageTransferOutSuccess,
        /// <summary>
        /// 
        /// </summary>
        StorageTransferRequestCreated,
        /// <summary>
        /// 
        /// </summary>
        StorageUpdate,
        /// <summary>
        /// 
        /// </summary>
        StorageUpdateProjectConnection,
        /// <summary>
        /// 
        /// </summary>
        StorageUpgradeProjectConnectionToOidc,
        /// <summary>
        /// 
        /// </summary>
        StorageViewSecret,
        /// <summary>
        /// 
        /// </summary>
        StrictDeploymentProtectionSettings,
        /// <summary>
        /// 
        /// </summary>
        StrictShareableLinks,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCreated,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionProductAdded,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionProductRemoved,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionUpdated,
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        TeamAvatarUpdate,
        /// <summary>
        /// 
        /// </summary>
        TeamDefaultBuildMachineUpdated,
        /// <summary>
        /// 
        /// </summary>
        TeamDelete,
        /// <summary>
        /// 
        /// </summary>
        TeamDeploymentPolicyUpdated,
        /// <summary>
        /// 
        /// </summary>
        TeamDomainVerificationCreated,
        /// <summary>
        /// 
        /// </summary>
        TeamDomainVerificationDeleted,
        /// <summary>
        /// 
        /// </summary>
        TeamDomainVerificationVerified,
        /// <summary>
        /// 
        /// </summary>
        TeamEmailDomainUpdate,
        /// <summary>
        /// 
        /// </summary>
        TeamEmuUpdated,
        /// <summary>
        /// 
        /// </summary>
        TeamEndedTrial,
        /// <summary>
        /// 
        /// </summary>
        TeamGitRepositoryDispatchEventsToggled,
        /// <summary>
        /// 
        /// </summary>
        TeamGitRequireVerifiedCommitsToggled,
        /// <summary>
        /// 
        /// </summary>
        TeamInviteBulkDelete,
        /// <summary>
        /// 
        /// </summary>
        TeamInviteCodeReset,
        /// <summary>
        /// 
        /// </summary>
        TeamInviteLinkCreated,
        /// <summary>
        /// 
        /// </summary>
        TeamInviteLinkDeleted,
        /// <summary>
        /// 
        /// </summary>
        TeamIpBlockingRulesCreated,
        /// <summary>
        /// 
        /// </summary>
        TeamIpBlockingRulesRemoved,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberAdd,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberConfirmRequest,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberDeclineRequest,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberDelete,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberEntitlementAdded,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberEntitlementCanceled,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberEntitlementReactivated,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberEntitlementRemoved,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberJoin,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberLeave,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberRequestAccess,
        /// <summary>
        /// 
        /// </summary>
        TeamMemberRoleUpdate,
        /// <summary>
        /// 
        /// </summary>
        TeamMfaEnforcementUpdated,
        /// <summary>
        /// 
        /// </summary>
        TeamNameUpdate,
        /// <summary>
        /// 
        /// </summary>
        TeamPaidInvoice,
        /// <summary>
        /// 
        /// </summary>
        TeamProgramEnrollmentChanged,
        /// <summary>
        /// 
        /// </summary>
        TeamRemoteCachingUpdate,
        /// <summary>
        /// 
        /// </summary>
        TeamSamlEnforced,
        /// <summary>
        /// 
        /// </summary>
        TeamSamlRoles,
        /// <summary>
        /// 
        /// </summary>
        TeamSlugUpdate,
        /// <summary>
        /// 
        /// </summary>
        TeamTokensInvalidated,
        /// <summary>
        /// 
        /// </summary>
        UnlinkLoginConnection,
        /// <summary>
        /// 
        /// </summary>
        UserDelete,
        /// <summary>
        /// 
        /// </summary>
        UserMfaChallengeVerified,
        /// <summary>
        /// 
        /// </summary>
        UserMfaConfigurationUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserMfaRecoveryCodesRegenerated,
        /// <summary>
        /// 
        /// </summary>
        UserMfaRemoved,
        /// <summary>
        /// 
        /// </summary>
        UserMfaTotpVerificationStarted,
        /// <summary>
        /// 
        /// </summary>
        UserMfaTotpVerified,
        /// <summary>
        /// 
        /// </summary>
        UserPrimaryEmailUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserTokenCreated,
        /// <summary>
        /// 
        /// </summary>
        UserTokenDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserTokensDeleted,
        /// <summary>
        /// 
        /// </summary>
        Username,
        /// <summary>
        /// 
        /// </summary>
        V0ChatAiUsage,
        /// <summary>
        /// 
        /// </summary>
        V0ChatCreated,
        /// <summary>
        /// 
        /// </summary>
        V0ChatMessageSent,
        /// <summary>
        /// 
        /// </summary>
        VercelAgentTeamTrialCreditsApplied,
        /// <summary>
        /// 
        /// </summary>
        VercelAppInstallationRequestDismissed,
        /// <summary>
        /// 
        /// </summary>
        VercelAppInstallationRequested,
        /// <summary>
        /// 
        /// </summary>
        VercelAppInstallationUpdated,
        /// <summary>
        /// 
        /// </summary>
        VercelAppInstalled,
        /// <summary>
        /// 
        /// </summary>
        VercelAppTokensRevoked,
        /// <summary>
        /// 
        /// </summary>
        VercelAppUninstalled,
        /// <summary>
        /// 
        /// </summary>
        VercelToolbar,
        /// <summary>
        /// 
        /// </summary>
        VpcPeeringConnectionAccepted,
        /// <summary>
        /// 
        /// </summary>
        VpcPeeringConnectionDeleted,
        /// <summary>
        /// 
        /// </summary>
        VpcPeeringConnectionRejected,
        /// <summary>
        /// 
        /// </summary>
        VpcPeeringConnectionUpdated,
        /// <summary>
        /// 
        /// </summary>
        VulnerabilityBannerDismissed,
        /// <summary>
        /// 
        /// </summary>
        WebAnalyticsTierUpdated,
        /// <summary>
        /// 
        /// </summary>
        WebhookCreated,
        /// <summary>
        /// 
        /// </summary>
        WebhookDeleted,
        /// <summary>
        /// 
        /// </summary>
        WebhookUpdated,
        /// <summary>
        /// 
        /// </summary>
        WorkflowDeploymentKeyAccessed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListEventTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEventTypeName value)
        {
            return value switch
            {
                ListEventTypeName.AccessGroupCreated => "access-group-created",
                ListEventTypeName.AccessGroupDeleted => "access-group-deleted",
                ListEventTypeName.AccessGroupProjectUpdated => "access-group-project-updated",
                ListEventTypeName.AccessGroupUpdated => "access-group-updated",
                ListEventTypeName.AccessGroupUserAdded => "access-group-user-added",
                ListEventTypeName.AccessGroupUserRemoved => "access-group-user-removed",
                ListEventTypeName.AgenticProvisioningAccountBlocked => "agentic-provisioning-account-blocked",
                ListEventTypeName.AgenticProvisioningAccountLinked => "agentic-provisioning-account-linked",
                ListEventTypeName.AgenticProvisioningAccountRelinked => "agentic-provisioning-account-relinked",
                ListEventTypeName.AgenticProvisioningAccountUnlinked => "agentic-provisioning-account-unlinked",
                ListEventTypeName.AgenticProvisioningCredentialsRotated => "agentic-provisioning-credentials-rotated",
                ListEventTypeName.AgenticProvisioningPlanChanged => "agentic-provisioning-plan-changed",
                ListEventTypeName.AgenticProvisioningTeamCreated => "agentic-provisioning-team-created",
                ListEventTypeName.AiAlertInvestigation => "ai-alert-investigation",
                ListEventTypeName.AiCodeReview => "ai-code-review",
                ListEventTypeName.AiGatewayApiKeyCreated => "ai-gateway-api-key-created",
                ListEventTypeName.AiGatewayApiKeyDeleted => "ai-gateway-api-key-deleted",
                ListEventTypeName.AiGatewayByokCredentialCreated => "ai-gateway-byok-credential-created",
                ListEventTypeName.AiGatewayByokCredentialDeleted => "ai-gateway-byok-credential-deleted",
                ListEventTypeName.AiGatewayByokCredentialUpdated => "ai-gateway-byok-credential-updated",
                ListEventTypeName.AlertRuleCreated => "alert-rule-created",
                ListEventTypeName.AlertRuleDeleted => "alert-rule-deleted",
                ListEventTypeName.AlertRuleUpdated => "alert-rule-updated",
                ListEventTypeName.Alias => "alias",
                ListEventTypeName.AliasChown => "alias-chown",
                ListEventTypeName.AliasDelete => "alias-delete",
                ListEventTypeName.AliasInviteCreated => "alias-invite-created",
                ListEventTypeName.AliasInviteJoined => "alias-invite-joined",
                ListEventTypeName.AliasInviteRevoked => "alias-invite-revoked",
                ListEventTypeName.AliasProtectionBypassCreated => "alias-protection-bypass-created",
                ListEventTypeName.AliasProtectionBypassException => "alias-protection-bypass-exception",
                ListEventTypeName.AliasProtectionBypassRegenerated => "alias-protection-bypass-regenerated",
                ListEventTypeName.AliasProtectionBypassRevoked => "alias-protection-bypass-revoked",
                ListEventTypeName.AliasSystem => "alias-system",
                ListEventTypeName.AliasUserScopedAccessDenied => "alias-user-scoped-access-denied",
                ListEventTypeName.AliasUserScopedAccessGranted => "alias-user-scoped-access-granted",
                ListEventTypeName.AliasUserScopedAccessRequested => "alias-user-scoped-access-requested",
                ListEventTypeName.AliasUserScopedAccessRevoked => "alias-user-scoped-access-revoked",
                ListEventTypeName.AliasesAssigned => "aliases-assigned",
                ListEventTypeName.AttackModeDisabled => "attack-mode-disabled",
                ListEventTypeName.AttackModeEnabled => "attack-mode-enabled",
                ListEventTypeName.AuditLogExportDownloaded => "audit-log-export-downloaded",
                ListEventTypeName.AuditLogExportRequested => "audit-log-export-requested",
                ListEventTypeName.AuthorizeGitDeployment => "authorize-git-deployment",
                ListEventTypeName.AutoExposeSystemEnvs => "auto-expose-system-envs",
                ListEventTypeName.Avatar => "avatar",
                ListEventTypeName.BulkRedirectsSettingsUpdated => "bulk-redirects-settings-updated",
                ListEventTypeName.BulkRedirectsVersionPromoted => "bulk-redirects-version-promoted",
                ListEventTypeName.BulkRedirectsVersionRestored => "bulk-redirects-version-restored",
                ListEventTypeName.Cert => "cert",
                ListEventTypeName.CertAutorenew => "cert-autorenew",
                ListEventTypeName.CertChown => "cert-chown",
                ListEventTypeName.CertClone => "cert-clone",
                ListEventTypeName.CertDelete => "cert-delete",
                ListEventTypeName.CertRenew => "cert-renew",
                ListEventTypeName.CertReplace => "cert-replace",
                ListEventTypeName.CertSystemCreate => "cert-system-create",
                ListEventTypeName.ConcurrentBuildsUpdate => "concurrent-builds-update",
                ListEventTypeName.ConnectBitbucket => "connect-bitbucket",
                ListEventTypeName.ConnectBitbucketApp => "connect-bitbucket-app",
                ListEventTypeName.ConnectConfigurationCreated => "connect-configuration-created",
                ListEventTypeName.ConnectConfigurationDeleted => "connect-configuration-deleted",
                ListEventTypeName.ConnectConfigurationLinkUpdated => "connect-configuration-link-updated",
                ListEventTypeName.ConnectConfigurationLinked => "connect-configuration-linked",
                ListEventTypeName.ConnectConfigurationUnlinked => "connect-configuration-unlinked",
                ListEventTypeName.ConnectConfigurationUpdated => "connect-configuration-updated",
                ListEventTypeName.ConnectGithub => "connect-github",
                ListEventTypeName.ConnectGithubCustomHost => "connect-github-custom-host",
                ListEventTypeName.ConnectGithubLimited => "connect-github-limited",
                ListEventTypeName.ConnectGitlab => "connect-gitlab",
                ListEventTypeName.ConnectGitlabApp => "connect-gitlab-app",
                ListEventTypeName.CustomSuffixClear => "custom-suffix-clear",
                ListEventTypeName.CustomSuffixDisable => "custom-suffix-disable",
                ListEventTypeName.CustomSuffixEnable => "custom-suffix-enable",
                ListEventTypeName.CustomSuffixPending => "custom-suffix-pending",
                ListEventTypeName.CustomSuffixReady => "custom-suffix-ready",
                ListEventTypeName.DeployHookCreated => "deploy-hook-created",
                ListEventTypeName.DeployHookDeduped => "deploy-hook-deduped",
                ListEventTypeName.DeployHookDeleted => "deploy-hook-deleted",
                ListEventTypeName.DeployHookProcessed => "deploy-hook-processed",
                ListEventTypeName.Deployment => "deployment",
                ListEventTypeName.DeploymentCheckCreated => "deployment-check-created",
                ListEventTypeName.DeploymentCheckDeleted => "deployment-check-deleted",
                ListEventTypeName.DeploymentCheckUpdated => "deployment-check-updated",
                ListEventTypeName.DeploymentChown => "deployment-chown",
                ListEventTypeName.DeploymentCreationBlocked => "deployment-creation-blocked",
                ListEventTypeName.DeploymentDelete => "deployment-delete",
                ListEventTypeName.DisabledIntegrationInstallationRemoved => "disabled-integration-installation-removed",
                ListEventTypeName.DisconnectBitbucketApp => "disconnect-bitbucket-app",
                ListEventTypeName.DisconnectGithub => "disconnect-github",
                ListEventTypeName.DisconnectGithubCustomHost => "disconnect-github-custom-host",
                ListEventTypeName.DisconnectGithubLimited => "disconnect-github-limited",
                ListEventTypeName.DisconnectGitlabApp => "disconnect-gitlab-app",
                ListEventTypeName.DnsAdd => "dns-add",
                ListEventTypeName.DnsDelete => "dns-delete",
                ListEventTypeName.DnsUpdate => "dns-update",
                ListEventTypeName.DnsZonefileImport => "dns-zonefile-import",
                ListEventTypeName.Domain => "domain",
                ListEventTypeName.DomainBuy => "domain-buy",
                ListEventTypeName.DomainCdn => "domain-cdn",
                ListEventTypeName.DomainChown => "domain-chown",
                ListEventTypeName.DomainCustomNsChange => "domain-custom-ns-change",
                ListEventTypeName.DomainDelegated => "domain-delegated",
                ListEventTypeName.DomainDelete => "domain-delete",
                ListEventTypeName.DomainMoveIn => "domain-move-in",
                ListEventTypeName.DomainMoveOut => "domain-move-out",
                ListEventTypeName.DomainMoveOutRequestSent => "domain-move-out-request-sent",
                ListEventTypeName.DomainRenewChange => "domain-renew-change",
                ListEventTypeName.DomainServiceTypeUpdated => "domain-service-type-updated",
                ListEventTypeName.DomainTransferIn => "domain-transfer-in",
                ListEventTypeName.DomainTransferInCanceled => "domain-transfer-in-canceled",
                ListEventTypeName.DomainTransferInCompleted => "domain-transfer-in-completed",
                ListEventTypeName.DomainZoneChange => "domain-zone-change",
                ListEventTypeName.DrainCreated => "drain-created",
                ListEventTypeName.DrainDeleted => "drain-deleted",
                ListEventTypeName.DrainDisabled => "drain-disabled",
                ListEventTypeName.DrainEnabled => "drain-enabled",
                ListEventTypeName.DrainUpdated => "drain-updated",
                ListEventTypeName.EdgeCacheDangerouslyDeleteBySrcImages => "edge-cache-dangerously-delete-by-src-images",
                ListEventTypeName.EdgeCacheDangerouslyDeleteByTags => "edge-cache-dangerously-delete-by-tags",
                ListEventTypeName.EdgeCacheInvalidateBySrcImages => "edge-cache-invalidate-by-src-images",
                ListEventTypeName.EdgeCacheInvalidateByTags => "edge-cache-invalidate-by-tags",
                ListEventTypeName.EdgeCachePurgeAll => "edge-cache-purge-all",
                ListEventTypeName.EdgeCacheRollbackPurge => "edge-cache-rollback-purge",
                ListEventTypeName.EdgeConfigCreated => "edge-config-created",
                ListEventTypeName.EdgeConfigDeleted => "edge-config-deleted",
                ListEventTypeName.EdgeConfigItemsUpdated => "edge-config-items-updated",
                ListEventTypeName.EdgeConfigSchemaDeleted => "edge-config-schema-deleted",
                ListEventTypeName.EdgeConfigSchemaUpdated => "edge-config-schema-updated",
                ListEventTypeName.EdgeConfigTokenCreated => "edge-config-token-created",
                ListEventTypeName.EdgeConfigTokenDeleted => "edge-config-token-deleted",
                ListEventTypeName.EdgeConfigTransferIn => "edge-config-transfer-in",
                ListEventTypeName.EdgeConfigTransferOut => "edge-config-transfer-out",
                ListEventTypeName.EdgeConfigUpdated => "edge-config-updated",
                ListEventTypeName.Email => "email",
                ListEventTypeName.EmailNotificationRuleRemoved => "email-notification-rule-removed",
                ListEventTypeName.EmailNotificationRuleUpdated => "email-notification-rule-updated",
                ListEventTypeName.EnforceSensitiveEnvironmentVariables => "enforce-sensitive-environment-variables",
                ListEventTypeName.EnvVariableAdd => "env-variable-add",
                ListEventTypeName.EnvVariableDelete => "env-variable-delete",
                ListEventTypeName.EnvVariableEdit => "env-variable-edit",
                ListEventTypeName.EnvVariableRead => "env-variable-read",
                ListEventTypeName.EnvVariableRead_cli_dev => "env-variable-read:cli:dev",
                ListEventTypeName.EnvVariableRead_cli_env_add => "env-variable-read:cli:env:add",
                ListEventTypeName.EnvVariableRead_cli_env_ls => "env-variable-read:cli:env:ls",
                ListEventTypeName.EnvVariableRead_cli_env_pull => "env-variable-read:cli:env:pull",
                ListEventTypeName.EnvVariableRead_cli_env_rm => "env-variable-read:cli:env:rm",
                ListEventTypeName.EnvVariableRead_cli_pull => "env-variable-read:cli:pull",
                ListEventTypeName.EnvVariableRead_unknownSource => "env-variable-read:unknown-source",
                ListEventTypeName.EnvVariableRead_v0_env_pull => "env-variable-read:v0:env:pull",
                ListEventTypeName.EnvVariableRotated => "env-variable-rotated",
                ListEventTypeName.FirewallBypassCreated => "firewall-bypass-created",
                ListEventTypeName.FirewallBypassDeleted => "firewall-bypass-deleted",
                ListEventTypeName.FirewallConfigModified => "firewall-config-modified",
                ListEventTypeName.FirewallConfigPromoted => "firewall-config-promoted",
                ListEventTypeName.FirewallConfigRemoved => "firewall-config-removed",
                ListEventTypeName.FirewallManagedRulegroupUpdated => "firewall-managed-rulegroup-updated",
                ListEventTypeName.FirewallManagedRulesetUpdated => "firewall-managed-ruleset-updated",
                ListEventTypeName.Flag => "flag",
                ListEventTypeName.FlagArchived => "flag-archived",
                ListEventTypeName.FlagCreated => "flag-created",
                ListEventTypeName.FlagDeleted => "flag-deleted",
                ListEventTypeName.FlagUnarchived => "flag-unarchived",
                ListEventTypeName.FlagUpdated => "flag-updated",
                ListEventTypeName.FlagsExplorerSubscription => "flags-explorer-subscription",
                ListEventTypeName.FlagsSdkKey => "flags-sdk-key",
                ListEventTypeName.FlagsSdkKeyAdded => "flags-sdk-key-added",
                ListEventTypeName.FlagsSdkKeyDeleted => "flags-sdk-key-deleted",
                ListEventTypeName.FlagsSdkKeyRead => "flags-sdk-key-read",
                ListEventTypeName.FlagsSegment => "flags-segment",
                ListEventTypeName.FlagsSettings => "flags-settings",
                ListEventTypeName.InstantRollbackCreated => "instant-rollback-created",
                ListEventTypeName.IntegrationConfigurationOwnerChanged => "integration-configuration-owner-changed",
                ListEventTypeName.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration-scope-change-confirmed",
                ListEventTypeName.IntegrationConfigurationTransferInSuccess => "integration-configuration-transfer-in-success",
                ListEventTypeName.IntegrationConfigurationTransferOutSuccess => "integration-configuration-transfer-out-success",
                ListEventTypeName.IntegrationConfigurationsDisabled => "integration-configurations-disabled",
                ListEventTypeName.IntegrationInstallationBillingPlanUpdated => "integration-installation-billing-plan-updated",
                ListEventTypeName.IntegrationInstallationCompleted => "integration-installation-completed",
                ListEventTypeName.IntegrationInstallationPermissionUpdated => "integration-installation-permission-updated",
                ListEventTypeName.IntegrationInstallationRemoved => "integration-installation-removed",
                ListEventTypeName.IntegrationScopeChanged => "integration-scope-changed",
                ListEventTypeName.InvoiceModified => "invoice-modified",
                ListEventTypeName.InvoiceRefunded => "invoice-refunded",
                ListEventTypeName.LogDrainCreated => "log-drain-created",
                ListEventTypeName.LogDrainDeleted => "log-drain-deleted",
                ListEventTypeName.LogDrainDisabled => "log-drain-disabled",
                ListEventTypeName.LogDrainEnabled => "log-drain-enabled",
                ListEventTypeName.Login => "login",
                ListEventTypeName.ManualDeploymentPromotionCreated => "manual-deployment-promotion-created",
                ListEventTypeName.MarketplaceIntegrationAllowlistUpdated => "marketplace-integration-allowlist-updated",
                ListEventTypeName.MicrofrontendGroupAdded => "microfrontend-group-added",
                ListEventTypeName.MicrofrontendGroupDeleted => "microfrontend-group-deleted",
                ListEventTypeName.MicrofrontendGroupUpdated => "microfrontend-group-updated",
                ListEventTypeName.MicrofrontendProjectAddedToGroup => "microfrontend-project-added-to-group",
                ListEventTypeName.MicrofrontendProjectRemovedFromGroup => "microfrontend-project-removed-from-group",
                ListEventTypeName.MicrofrontendProjectUpdated => "microfrontend-project-updated",
                ListEventTypeName.MonitoringDisabled => "monitoring-disabled",
                ListEventTypeName.MonitoringEnabled => "monitoring-enabled",
                ListEventTypeName.OauthAppConnectionCreated => "oauth-app-connection-created",
                ListEventTypeName.OauthAppConnectionRemoved => "oauth-app-connection-removed",
                ListEventTypeName.OauthAppConnectionUpdated => "oauth-app-connection-updated",
                ListEventTypeName.OauthAppCreated => "oauth-app-created",
                ListEventTypeName.OauthAppDeleted => "oauth-app-deleted",
                ListEventTypeName.OauthAppSecretDeleted => "oauth-app-secret-deleted",
                ListEventTypeName.OauthAppSecretGenerated => "oauth-app-secret-generated",
                ListEventTypeName.OauthAppTokenCreated => "oauth-app-token-created",
                ListEventTypeName.OauthAppUpdated => "oauth-app-updated",
                ListEventTypeName.ObservabilityDisabled => "observability-disabled",
                ListEventTypeName.ObservabilityEnabled => "observability-enabled",
                ListEventTypeName.ObservabilityPlusProjectDisabled => "observability-plus-project-disabled",
                ListEventTypeName.ObservabilityPlusProjectEnabled => "observability-plus-project-enabled",
                ListEventTypeName.OwnerBlocked => "owner-blocked",
                ListEventTypeName.OwnerSoftBlocked => "owner-soft-blocked",
                ListEventTypeName.OwnerSoftUnblocked => "owner-soft-unblocked",
                ListEventTypeName.OwnerUnblocked => "owner-unblocked",
                ListEventTypeName.PageIntegrityConfigUpdated => "page-integrity-config-updated",
                ListEventTypeName.PageIntegrityHeaderApproved => "page-integrity-header-approved",
                ListEventTypeName.PageIntegrityResourceApproved => "page-integrity-resource-approved",
                ListEventTypeName.PageIntegrityResourceDeleted => "page-integrity-resource-deleted",
                ListEventTypeName.PageIntegrityResourceRejected => "page-integrity-resource-rejected",
                ListEventTypeName.PasskeyCreated => "passkey-created",
                ListEventTypeName.PasskeyDeleted => "passkey-deleted",
                ListEventTypeName.PasskeyUpdated => "passkey-updated",
                ListEventTypeName.PasswordProtectionDisabled => "password-protection-disabled",
                ListEventTypeName.PasswordProtectionEnabled => "password-protection-enabled",
                ListEventTypeName.PaymentMethodAdded => "payment-method-added",
                ListEventTypeName.PaymentMethodDefaultUpdated => "payment-method-default-updated",
                ListEventTypeName.PaymentMethodRemoved => "payment-method-removed",
                ListEventTypeName.Plan => "plan",
                ListEventTypeName.PreviewDeploymentSuffixDisabled => "preview-deployment-suffix-disabled",
                ListEventTypeName.PreviewDeploymentSuffixEnabled => "preview-deployment-suffix-enabled",
                ListEventTypeName.PreviewDeploymentSuffixUpdate => "preview-deployment-suffix-update",
                ListEventTypeName.PrivatelinkEndpointCreated => "privatelink-endpoint-created",
                ListEventTypeName.PrivatelinkEndpointDeleted => "privatelink-endpoint-deleted",
                ListEventTypeName.PrivatelinkEndpointUpdated => "privatelink-endpoint-updated",
                ListEventTypeName.ProductionBranchUpdated => "production-branch-updated",
                ListEventTypeName.ProjectAddAlias => "project-add-alias",
                ListEventTypeName.ProjectAddRedirect => "project-add-redirect",
                ListEventTypeName.ProjectAffectedProjectsDeploymentsUpdated => "project-affected-projects-deployments-updated",
                ListEventTypeName.ProjectAliasConfiguredChange => "project-alias-configured-change",
                ListEventTypeName.ProjectAnalyticsDisabled => "project-analytics-disabled",
                ListEventTypeName.ProjectAnalyticsEnabled => "project-analytics-enabled",
                ListEventTypeName.ProjectAutoAssignCustomProductionDomainsUpdated => "project-auto-assign-custom-production-domains-updated",
                ListEventTypeName.ProjectAutomationBypass => "project-automation-bypass",
                ListEventTypeName.ProjectBuildCommandUpdated => "project-build-command-updated",
                ListEventTypeName.ProjectBuildLogsAndSourceProtectionUpdated => "project-build-logs-and-source-protection-updated",
                ListEventTypeName.ProjectBuildMachineUpdated => "project-build-machine-updated",
                ListEventTypeName.ProjectClientCertDelete => "project-client-cert-delete",
                ListEventTypeName.ProjectClientCertUpload => "project-client-cert-upload",
                ListEventTypeName.ProjectConnectConfigurations => "project-connect-configurations",
                ListEventTypeName.ProjectConsolidatedGitCommitStatusUpdated => "project-consolidated-git-commit-status-updated",
                ListEventTypeName.ProjectCreated => "project-created",
                ListEventTypeName.ProjectCronJobsToggled => "project-cron-jobs-toggled",
                ListEventTypeName.ProjectCustomEnvironmentCreated => "project-custom-environment-created",
                ListEventTypeName.ProjectCustomEnvironmentDeleted => "project-custom-environment-deleted",
                ListEventTypeName.ProjectCustomEnvironmentUpdated => "project-custom-environment-updated",
                ListEventTypeName.ProjectCustomerSuccessCodeVisibilityUpdated => "project-customer-success-code-visibility-updated",
                ListEventTypeName.ProjectDelegatedProtectionDisabled => "project-delegated-protection-disabled",
                ListEventTypeName.ProjectDelegatedProtectionEnabled => "project-delegated-protection-enabled",
                ListEventTypeName.ProjectDelegatedProtectionUpdated => "project-delegated-protection-updated",
                ListEventTypeName.ProjectDelete => "project-delete",
                ListEventTypeName.ProjectDeploymentPolicyUpdated => "project-deployment-policy-updated",
                ListEventTypeName.ProjectDeploymentRetentionUpdated => "project-deployment-retention-updated",
                ListEventTypeName.ProjectDirectoryListing => "project-directory-listing",
                ListEventTypeName.ProjectDomainDeleted => "project-domain-deleted",
                ListEventTypeName.ProjectDomainMoved => "project-domain-moved",
                ListEventTypeName.ProjectDomainUnverified => "project-domain-unverified",
                ListEventTypeName.ProjectDomainUpdated => "project-domain-updated",
                ListEventTypeName.ProjectDomainVerified => "project-domain-verified",
                ListEventTypeName.ProjectElasticConcurrencyUpdated => "project-elastic-concurrency-updated",
                ListEventTypeName.ProjectExpirationLocked => "project-expiration-locked",
                ListEventTypeName.ProjectExpirationScheduled => "project-expiration-scheduled",
                ListEventTypeName.ProjectExpirationUnlocked => "project-expiration-unlocked",
                ListEventTypeName.ProjectExternalRewriteCachingUpdated => "project-external-rewrite-caching-updated",
                ListEventTypeName.ProjectFrameworkUpdated => "project-framework-updated",
                ListEventTypeName.ProjectFunctionCpuMemory => "project-function-cpu-memory",
                ListEventTypeName.ProjectFunctionFailover => "project-function-failover",
                ListEventTypeName.ProjectFunctionMaxDuration => "project-function-max-duration",
                ListEventTypeName.ProjectFunctionRegions => "project-function-regions",
                ListEventTypeName.ProjectFunctionsBetaUpdated => "project-functions-beta-updated",
                ListEventTypeName.ProjectFunctionsFluidDisabled => "project-functions-fluid-disabled",
                ListEventTypeName.ProjectFunctionsFluidEnabled => "project-functions-fluid-enabled",
                ListEventTypeName.ProjectGitCommitCommentsToggled => "project-git-commit-comments-toggled",
                ListEventTypeName.ProjectGitCommitStatusToggled => "project-git-commit-status-toggled",
                ListEventTypeName.ProjectGitCreateDeploymentsToggled => "project-git-create-deployments-toggled",
                ListEventTypeName.ProjectGitForkProtectionUpdated => "project-git-fork-protection-updated",
                ListEventTypeName.ProjectGitLfsToggled => "project-git-lfs-toggled",
                ListEventTypeName.ProjectGitPrCommentsToggled => "project-git-pr-comments-toggled",
                ListEventTypeName.ProjectGitRepositoryConnected => "project-git-repository-connected",
                ListEventTypeName.ProjectGitRepositoryDisconnected => "project-git-repository-disconnected",
                ListEventTypeName.ProjectGitRepositoryDispatchEventsToggled => "project-git-repository-dispatch-events-toggled",
                ListEventTypeName.ProjectGitRequireVerifiedCommitsToggled => "project-git-require-verified-commits-toggled",
                ListEventTypeName.ProjectIgnoredBuildStepUpdated => "project-ignored-build-step-updated",
                ListEventTypeName.ProjectInstallCommandUpdated => "project-install-command-updated",
                ListEventTypeName.ProjectMemberAdded => "project-member-added",
                ListEventTypeName.ProjectMemberInvited => "project-member-invited",
                ListEventTypeName.ProjectMemberRemoved => "project-member-removed",
                ListEventTypeName.ProjectMemberRemovedBatch => "project-member-removed-batch",
                ListEventTypeName.ProjectMemberUpdated => "project-member-updated",
                ListEventTypeName.ProjectMoveInSuccess => "project-move-in-success",
                ListEventTypeName.ProjectMoveOutFailed => "project-move-out-failed",
                ListEventTypeName.ProjectMoveOutStarted => "project-move-out-started",
                ListEventTypeName.ProjectMoveOutSuccess => "project-move-out-success",
                ListEventTypeName.ProjectName => "project-name",
                ListEventTypeName.ProjectNodeVersionUpdated => "project-node-version-updated",
                ListEventTypeName.ProjectOidcIssuerModeUpdated => "project-oidc-issuer-mode-updated",
                ListEventTypeName.ProjectOidcTokenCreated => "project-oidc-token-created",
                ListEventTypeName.ProjectOptionsAllowlist => "project-options-allowlist",
                ListEventTypeName.ProjectOutputDirectoryUpdated => "project-output-directory-updated",
                ListEventTypeName.ProjectPasswordProtection => "project-password-protection",
                ListEventTypeName.ProjectPaused => "project-paused",
                ListEventTypeName.ProjectPreviewDeploymentSuffix => "project-preview-deployment-suffix",
                ListEventTypeName.ProjectPreviewEnvironmentBranchTrackingUpdated => "project-preview-environment-branch-tracking-updated",
                ListEventTypeName.ProjectPrioritizeProductionBuildsUpdated => "project-prioritize-production-builds-updated",
                ListEventTypeName.ProjectProgramEnrollmentChanged => "project-program-enrollment-changed",
                ListEventTypeName.ProjectProtectedSourcemapsUpdated => "project-protected-sourcemaps-updated",
                ListEventTypeName.ProjectRollingReleaseAborted => "project-rolling-release-aborted",
                ListEventTypeName.ProjectRollingReleaseApproved => "project-rolling-release-approved",
                ListEventTypeName.ProjectRollingReleaseCompleted => "project-rolling-release-completed",
                ListEventTypeName.ProjectRollingReleaseConfigured => "project-rolling-release-configured",
                ListEventTypeName.ProjectRollingReleaseContinued => "project-rolling-release-continued",
                ListEventTypeName.ProjectRollingReleaseDisabled => "project-rolling-release-disabled",
                ListEventTypeName.ProjectRollingReleaseEnabled => "project-rolling-release-enabled",
                ListEventTypeName.ProjectRollingReleasePaused => "project-rolling-release-paused",
                ListEventTypeName.ProjectRollingReleaseStarted => "project-rolling-release-started",
                ListEventTypeName.ProjectRollingReleaseSuggestedActionsGenerated => "project-rolling-release-suggested-actions-generated",
                ListEventTypeName.ProjectRollingReleaseTimer => "project-rolling-release-timer",
                ListEventTypeName.ProjectRootDirectoryUpdated => "project-root-directory-updated",
                ListEventTypeName.ProjectRoutesVersionPromoted => "project-routes-version-promoted",
                ListEventTypeName.ProjectRoutesVersionRestored => "project-routes-version-restored",
                ListEventTypeName.ProjectSkewProtectionAllowedDomainsUpdated => "project-skew-protection-allowed-domains-updated",
                ListEventTypeName.ProjectSkewProtectionMaxAgeUpdated => "project-skew-protection-max-age-updated",
                ListEventTypeName.ProjectSkewProtectionThresholdUpdated => "project-skew-protection-threshold-updated",
                ListEventTypeName.ProjectSourceFilesOutsideRootDirectoryUpdated => "project-source-files-outside-root-directory-updated",
                ListEventTypeName.ProjectSpeedInsightsDisabled => "project-speed-insights-disabled",
                ListEventTypeName.ProjectSpeedInsightsEnabled => "project-speed-insights-enabled",
                ListEventTypeName.ProjectSsoProtection => "project-sso-protection",
                ListEventTypeName.ProjectStaticIpsUpdated => "project-static-ips-updated",
                ListEventTypeName.ProjectTrustedIps => "project-trusted-ips",
                ListEventTypeName.ProjectTrustedSources => "project-trusted-sources",
                ListEventTypeName.ProjectUnpaused => "project-unpaused",
                ListEventTypeName.ProjectWebAnalyticsDisabled => "project-web-analytics-disabled",
                ListEventTypeName.ProjectWebAnalyticsEnabled => "project-web-analytics-enabled",
                ListEventTypeName.ProtectedGitScopeAdded => "protected-git-scope-added",
                ListEventTypeName.ProtectedGitScopeRemoved => "protected-git-scope-removed",
                ListEventTypeName.RuntimeCachePurgeAll => "runtime-cache-purge-all",
                ListEventTypeName.Scale => "scale",
                ListEventTypeName.ScaleAuto => "scale-auto",
                ListEventTypeName.SecondaryEmailAdded => "secondary-email-added",
                ListEventTypeName.SecondaryEmailRemoved => "secondary-email-removed",
                ListEventTypeName.SecondaryEmailVerified => "secondary-email-verified",
                ListEventTypeName.SecretAdd => "secret-add",
                ListEventTypeName.SecretDelete => "secret-delete",
                ListEventTypeName.SecretRename => "secret-rename",
                ListEventTypeName.SecurityPlusUpdated => "security-plus-updated",
                ListEventTypeName.SetBio => "set-bio",
                ListEventTypeName.SetName => "set-name",
                ListEventTypeName.SetProfiles => "set-profiles",
                ListEventTypeName.SetScale => "set-scale",
                ListEventTypeName.SharedEnvVariableCreate => "shared-env-variable-create",
                ListEventTypeName.SharedEnvVariableDelete => "shared-env-variable-delete",
                ListEventTypeName.SharedEnvVariableRead => "shared-env-variable-read",
                ListEventTypeName.SharedEnvVariableUpdate => "shared-env-variable-update",
                ListEventTypeName.ShowIpAddresses => "show-ip-addresses",
                ListEventTypeName.Signup => "signup",
                ListEventTypeName.SignupViaBitbucket => "signup-via-bitbucket",
                ListEventTypeName.SignupViaGithub => "signup-via-github",
                ListEventTypeName.SignupViaGitlab => "signup-via-gitlab",
                ListEventTypeName.SpeedInsightsSettingsUpdated => "speed-insights-settings-updated",
                ListEventTypeName.SpendCreated => "spend-created",
                ListEventTypeName.SpendDeleted => "spend-deleted",
                ListEventTypeName.SpendUpdated => "spend-updated",
                ListEventTypeName.StorageAcceptTos => "storage-accept-tos",
                ListEventTypeName.StorageAccessTokenSet => "storage-access-token-set",
                ListEventTypeName.StorageAccessedDataBrowser => "storage-accessed-data-browser",
                ListEventTypeName.StorageConnectProject => "storage-connect-project",
                ListEventTypeName.StorageCreate => "storage-create",
                ListEventTypeName.StorageDelete => "storage-delete",
                ListEventTypeName.StorageDisconnectProject => "storage-disconnect-project",
                ListEventTypeName.StorageDisconnectProjects => "storage-disconnect-projects",
                ListEventTypeName.StorageInactiveStoreDeleted => "storage-inactive-store-deleted",
                ListEventTypeName.StorageResetCredentials => "storage-reset-credentials",
                ListEventTypeName.StorageResourceReplCommand => "storage-resource-repl-command",
                ListEventTypeName.StorageSetLocked => "storage-set-locked",
                ListEventTypeName.StorageTransferInSuccess => "storage-transfer-in-success",
                ListEventTypeName.StorageTransferOutSuccess => "storage-transfer-out-success",
                ListEventTypeName.StorageTransferRequestCreated => "storage-transfer-request-created",
                ListEventTypeName.StorageUpdate => "storage-update",
                ListEventTypeName.StorageUpdateProjectConnection => "storage-update-project-connection",
                ListEventTypeName.StorageUpgradeProjectConnectionToOidc => "storage-upgrade-project-connection-to-oidc",
                ListEventTypeName.StorageViewSecret => "storage-view-secret",
                ListEventTypeName.StrictDeploymentProtectionSettings => "strict-deployment-protection-settings",
                ListEventTypeName.StrictShareableLinks => "strict-shareable-links",
                ListEventTypeName.SubscriptionCreated => "subscription-created",
                ListEventTypeName.SubscriptionProductAdded => "subscription-product-added",
                ListEventTypeName.SubscriptionProductRemoved => "subscription-product-removed",
                ListEventTypeName.SubscriptionUpdated => "subscription-updated",
                ListEventTypeName.Team => "team",
                ListEventTypeName.TeamAvatarUpdate => "team-avatar-update",
                ListEventTypeName.TeamDefaultBuildMachineUpdated => "team-default-build-machine-updated",
                ListEventTypeName.TeamDelete => "team-delete",
                ListEventTypeName.TeamDeploymentPolicyUpdated => "team-deployment-policy-updated",
                ListEventTypeName.TeamDomainVerificationCreated => "team-domain-verification-created",
                ListEventTypeName.TeamDomainVerificationDeleted => "team-domain-verification-deleted",
                ListEventTypeName.TeamDomainVerificationVerified => "team-domain-verification-verified",
                ListEventTypeName.TeamEmailDomainUpdate => "team-email-domain-update",
                ListEventTypeName.TeamEmuUpdated => "team-emu-updated",
                ListEventTypeName.TeamEndedTrial => "team-ended-trial",
                ListEventTypeName.TeamGitRepositoryDispatchEventsToggled => "team-git-repository-dispatch-events-toggled",
                ListEventTypeName.TeamGitRequireVerifiedCommitsToggled => "team-git-require-verified-commits-toggled",
                ListEventTypeName.TeamInviteBulkDelete => "team-invite-bulk-delete",
                ListEventTypeName.TeamInviteCodeReset => "team-invite-code-reset",
                ListEventTypeName.TeamInviteLinkCreated => "team-invite-link-created",
                ListEventTypeName.TeamInviteLinkDeleted => "team-invite-link-deleted",
                ListEventTypeName.TeamIpBlockingRulesCreated => "team-ip-blocking-rules-created",
                ListEventTypeName.TeamIpBlockingRulesRemoved => "team-ip-blocking-rules-removed",
                ListEventTypeName.TeamMemberAdd => "team-member-add",
                ListEventTypeName.TeamMemberConfirmRequest => "team-member-confirm-request",
                ListEventTypeName.TeamMemberDeclineRequest => "team-member-decline-request",
                ListEventTypeName.TeamMemberDelete => "team-member-delete",
                ListEventTypeName.TeamMemberEntitlementAdded => "team-member-entitlement-added",
                ListEventTypeName.TeamMemberEntitlementCanceled => "team-member-entitlement-canceled",
                ListEventTypeName.TeamMemberEntitlementReactivated => "team-member-entitlement-reactivated",
                ListEventTypeName.TeamMemberEntitlementRemoved => "team-member-entitlement-removed",
                ListEventTypeName.TeamMemberJoin => "team-member-join",
                ListEventTypeName.TeamMemberLeave => "team-member-leave",
                ListEventTypeName.TeamMemberRequestAccess => "team-member-request-access",
                ListEventTypeName.TeamMemberRoleUpdate => "team-member-role-update",
                ListEventTypeName.TeamMfaEnforcementUpdated => "team-mfa-enforcement-updated",
                ListEventTypeName.TeamNameUpdate => "team-name-update",
                ListEventTypeName.TeamPaidInvoice => "team-paid-invoice",
                ListEventTypeName.TeamProgramEnrollmentChanged => "team-program-enrollment-changed",
                ListEventTypeName.TeamRemoteCachingUpdate => "team-remote-caching-update",
                ListEventTypeName.TeamSamlEnforced => "team-saml-enforced",
                ListEventTypeName.TeamSamlRoles => "team-saml-roles",
                ListEventTypeName.TeamSlugUpdate => "team-slug-update",
                ListEventTypeName.TeamTokensInvalidated => "team-tokens-invalidated",
                ListEventTypeName.UnlinkLoginConnection => "unlink-login-connection",
                ListEventTypeName.UserDelete => "user-delete",
                ListEventTypeName.UserMfaChallengeVerified => "user-mfa-challenge-verified",
                ListEventTypeName.UserMfaConfigurationUpdated => "user-mfa-configuration-updated",
                ListEventTypeName.UserMfaRecoveryCodesRegenerated => "user-mfa-recovery-codes-regenerated",
                ListEventTypeName.UserMfaRemoved => "user-mfa-removed",
                ListEventTypeName.UserMfaTotpVerificationStarted => "user-mfa-totp-verification-started",
                ListEventTypeName.UserMfaTotpVerified => "user-mfa-totp-verified",
                ListEventTypeName.UserPrimaryEmailUpdated => "user-primary-email-updated",
                ListEventTypeName.UserTokenCreated => "user-token-created",
                ListEventTypeName.UserTokenDeleted => "user-token-deleted",
                ListEventTypeName.UserTokensDeleted => "user-tokens-deleted",
                ListEventTypeName.Username => "username",
                ListEventTypeName.V0ChatAiUsage => "v0-chat-ai-usage",
                ListEventTypeName.V0ChatCreated => "v0-chat-created",
                ListEventTypeName.V0ChatMessageSent => "v0-chat-message-sent",
                ListEventTypeName.VercelAgentTeamTrialCreditsApplied => "vercel-agent-team-trial-credits-applied",
                ListEventTypeName.VercelAppInstallationRequestDismissed => "vercel-app-installation-request-dismissed",
                ListEventTypeName.VercelAppInstallationRequested => "vercel-app-installation-requested",
                ListEventTypeName.VercelAppInstallationUpdated => "vercel-app-installation-updated",
                ListEventTypeName.VercelAppInstalled => "vercel-app-installed",
                ListEventTypeName.VercelAppTokensRevoked => "vercel-app-tokens-revoked",
                ListEventTypeName.VercelAppUninstalled => "vercel-app-uninstalled",
                ListEventTypeName.VercelToolbar => "vercel-toolbar",
                ListEventTypeName.VpcPeeringConnectionAccepted => "vpc-peering-connection-accepted",
                ListEventTypeName.VpcPeeringConnectionDeleted => "vpc-peering-connection-deleted",
                ListEventTypeName.VpcPeeringConnectionRejected => "vpc-peering-connection-rejected",
                ListEventTypeName.VpcPeeringConnectionUpdated => "vpc-peering-connection-updated",
                ListEventTypeName.VulnerabilityBannerDismissed => "vulnerability-banner-dismissed",
                ListEventTypeName.WebAnalyticsTierUpdated => "web-analytics-tier-updated",
                ListEventTypeName.WebhookCreated => "webhook-created",
                ListEventTypeName.WebhookDeleted => "webhook-deleted",
                ListEventTypeName.WebhookUpdated => "webhook-updated",
                ListEventTypeName.WorkflowDeploymentKeyAccessed => "workflow-deployment-key-accessed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEventTypeName? ToEnum(string value)
        {
            return value switch
            {
                "access-group-created" => ListEventTypeName.AccessGroupCreated,
                "access-group-deleted" => ListEventTypeName.AccessGroupDeleted,
                "access-group-project-updated" => ListEventTypeName.AccessGroupProjectUpdated,
                "access-group-updated" => ListEventTypeName.AccessGroupUpdated,
                "access-group-user-added" => ListEventTypeName.AccessGroupUserAdded,
                "access-group-user-removed" => ListEventTypeName.AccessGroupUserRemoved,
                "agentic-provisioning-account-blocked" => ListEventTypeName.AgenticProvisioningAccountBlocked,
                "agentic-provisioning-account-linked" => ListEventTypeName.AgenticProvisioningAccountLinked,
                "agentic-provisioning-account-relinked" => ListEventTypeName.AgenticProvisioningAccountRelinked,
                "agentic-provisioning-account-unlinked" => ListEventTypeName.AgenticProvisioningAccountUnlinked,
                "agentic-provisioning-credentials-rotated" => ListEventTypeName.AgenticProvisioningCredentialsRotated,
                "agentic-provisioning-plan-changed" => ListEventTypeName.AgenticProvisioningPlanChanged,
                "agentic-provisioning-team-created" => ListEventTypeName.AgenticProvisioningTeamCreated,
                "ai-alert-investigation" => ListEventTypeName.AiAlertInvestigation,
                "ai-code-review" => ListEventTypeName.AiCodeReview,
                "ai-gateway-api-key-created" => ListEventTypeName.AiGatewayApiKeyCreated,
                "ai-gateway-api-key-deleted" => ListEventTypeName.AiGatewayApiKeyDeleted,
                "ai-gateway-byok-credential-created" => ListEventTypeName.AiGatewayByokCredentialCreated,
                "ai-gateway-byok-credential-deleted" => ListEventTypeName.AiGatewayByokCredentialDeleted,
                "ai-gateway-byok-credential-updated" => ListEventTypeName.AiGatewayByokCredentialUpdated,
                "alert-rule-created" => ListEventTypeName.AlertRuleCreated,
                "alert-rule-deleted" => ListEventTypeName.AlertRuleDeleted,
                "alert-rule-updated" => ListEventTypeName.AlertRuleUpdated,
                "alias" => ListEventTypeName.Alias,
                "alias-chown" => ListEventTypeName.AliasChown,
                "alias-delete" => ListEventTypeName.AliasDelete,
                "alias-invite-created" => ListEventTypeName.AliasInviteCreated,
                "alias-invite-joined" => ListEventTypeName.AliasInviteJoined,
                "alias-invite-revoked" => ListEventTypeName.AliasInviteRevoked,
                "alias-protection-bypass-created" => ListEventTypeName.AliasProtectionBypassCreated,
                "alias-protection-bypass-exception" => ListEventTypeName.AliasProtectionBypassException,
                "alias-protection-bypass-regenerated" => ListEventTypeName.AliasProtectionBypassRegenerated,
                "alias-protection-bypass-revoked" => ListEventTypeName.AliasProtectionBypassRevoked,
                "alias-system" => ListEventTypeName.AliasSystem,
                "alias-user-scoped-access-denied" => ListEventTypeName.AliasUserScopedAccessDenied,
                "alias-user-scoped-access-granted" => ListEventTypeName.AliasUserScopedAccessGranted,
                "alias-user-scoped-access-requested" => ListEventTypeName.AliasUserScopedAccessRequested,
                "alias-user-scoped-access-revoked" => ListEventTypeName.AliasUserScopedAccessRevoked,
                "aliases-assigned" => ListEventTypeName.AliasesAssigned,
                "attack-mode-disabled" => ListEventTypeName.AttackModeDisabled,
                "attack-mode-enabled" => ListEventTypeName.AttackModeEnabled,
                "audit-log-export-downloaded" => ListEventTypeName.AuditLogExportDownloaded,
                "audit-log-export-requested" => ListEventTypeName.AuditLogExportRequested,
                "authorize-git-deployment" => ListEventTypeName.AuthorizeGitDeployment,
                "auto-expose-system-envs" => ListEventTypeName.AutoExposeSystemEnvs,
                "avatar" => ListEventTypeName.Avatar,
                "bulk-redirects-settings-updated" => ListEventTypeName.BulkRedirectsSettingsUpdated,
                "bulk-redirects-version-promoted" => ListEventTypeName.BulkRedirectsVersionPromoted,
                "bulk-redirects-version-restored" => ListEventTypeName.BulkRedirectsVersionRestored,
                "cert" => ListEventTypeName.Cert,
                "cert-autorenew" => ListEventTypeName.CertAutorenew,
                "cert-chown" => ListEventTypeName.CertChown,
                "cert-clone" => ListEventTypeName.CertClone,
                "cert-delete" => ListEventTypeName.CertDelete,
                "cert-renew" => ListEventTypeName.CertRenew,
                "cert-replace" => ListEventTypeName.CertReplace,
                "cert-system-create" => ListEventTypeName.CertSystemCreate,
                "concurrent-builds-update" => ListEventTypeName.ConcurrentBuildsUpdate,
                "connect-bitbucket" => ListEventTypeName.ConnectBitbucket,
                "connect-bitbucket-app" => ListEventTypeName.ConnectBitbucketApp,
                "connect-configuration-created" => ListEventTypeName.ConnectConfigurationCreated,
                "connect-configuration-deleted" => ListEventTypeName.ConnectConfigurationDeleted,
                "connect-configuration-link-updated" => ListEventTypeName.ConnectConfigurationLinkUpdated,
                "connect-configuration-linked" => ListEventTypeName.ConnectConfigurationLinked,
                "connect-configuration-unlinked" => ListEventTypeName.ConnectConfigurationUnlinked,
                "connect-configuration-updated" => ListEventTypeName.ConnectConfigurationUpdated,
                "connect-github" => ListEventTypeName.ConnectGithub,
                "connect-github-custom-host" => ListEventTypeName.ConnectGithubCustomHost,
                "connect-github-limited" => ListEventTypeName.ConnectGithubLimited,
                "connect-gitlab" => ListEventTypeName.ConnectGitlab,
                "connect-gitlab-app" => ListEventTypeName.ConnectGitlabApp,
                "custom-suffix-clear" => ListEventTypeName.CustomSuffixClear,
                "custom-suffix-disable" => ListEventTypeName.CustomSuffixDisable,
                "custom-suffix-enable" => ListEventTypeName.CustomSuffixEnable,
                "custom-suffix-pending" => ListEventTypeName.CustomSuffixPending,
                "custom-suffix-ready" => ListEventTypeName.CustomSuffixReady,
                "deploy-hook-created" => ListEventTypeName.DeployHookCreated,
                "deploy-hook-deduped" => ListEventTypeName.DeployHookDeduped,
                "deploy-hook-deleted" => ListEventTypeName.DeployHookDeleted,
                "deploy-hook-processed" => ListEventTypeName.DeployHookProcessed,
                "deployment" => ListEventTypeName.Deployment,
                "deployment-check-created" => ListEventTypeName.DeploymentCheckCreated,
                "deployment-check-deleted" => ListEventTypeName.DeploymentCheckDeleted,
                "deployment-check-updated" => ListEventTypeName.DeploymentCheckUpdated,
                "deployment-chown" => ListEventTypeName.DeploymentChown,
                "deployment-creation-blocked" => ListEventTypeName.DeploymentCreationBlocked,
                "deployment-delete" => ListEventTypeName.DeploymentDelete,
                "disabled-integration-installation-removed" => ListEventTypeName.DisabledIntegrationInstallationRemoved,
                "disconnect-bitbucket-app" => ListEventTypeName.DisconnectBitbucketApp,
                "disconnect-github" => ListEventTypeName.DisconnectGithub,
                "disconnect-github-custom-host" => ListEventTypeName.DisconnectGithubCustomHost,
                "disconnect-github-limited" => ListEventTypeName.DisconnectGithubLimited,
                "disconnect-gitlab-app" => ListEventTypeName.DisconnectGitlabApp,
                "dns-add" => ListEventTypeName.DnsAdd,
                "dns-delete" => ListEventTypeName.DnsDelete,
                "dns-update" => ListEventTypeName.DnsUpdate,
                "dns-zonefile-import" => ListEventTypeName.DnsZonefileImport,
                "domain" => ListEventTypeName.Domain,
                "domain-buy" => ListEventTypeName.DomainBuy,
                "domain-cdn" => ListEventTypeName.DomainCdn,
                "domain-chown" => ListEventTypeName.DomainChown,
                "domain-custom-ns-change" => ListEventTypeName.DomainCustomNsChange,
                "domain-delegated" => ListEventTypeName.DomainDelegated,
                "domain-delete" => ListEventTypeName.DomainDelete,
                "domain-move-in" => ListEventTypeName.DomainMoveIn,
                "domain-move-out" => ListEventTypeName.DomainMoveOut,
                "domain-move-out-request-sent" => ListEventTypeName.DomainMoveOutRequestSent,
                "domain-renew-change" => ListEventTypeName.DomainRenewChange,
                "domain-service-type-updated" => ListEventTypeName.DomainServiceTypeUpdated,
                "domain-transfer-in" => ListEventTypeName.DomainTransferIn,
                "domain-transfer-in-canceled" => ListEventTypeName.DomainTransferInCanceled,
                "domain-transfer-in-completed" => ListEventTypeName.DomainTransferInCompleted,
                "domain-zone-change" => ListEventTypeName.DomainZoneChange,
                "drain-created" => ListEventTypeName.DrainCreated,
                "drain-deleted" => ListEventTypeName.DrainDeleted,
                "drain-disabled" => ListEventTypeName.DrainDisabled,
                "drain-enabled" => ListEventTypeName.DrainEnabled,
                "drain-updated" => ListEventTypeName.DrainUpdated,
                "edge-cache-dangerously-delete-by-src-images" => ListEventTypeName.EdgeCacheDangerouslyDeleteBySrcImages,
                "edge-cache-dangerously-delete-by-tags" => ListEventTypeName.EdgeCacheDangerouslyDeleteByTags,
                "edge-cache-invalidate-by-src-images" => ListEventTypeName.EdgeCacheInvalidateBySrcImages,
                "edge-cache-invalidate-by-tags" => ListEventTypeName.EdgeCacheInvalidateByTags,
                "edge-cache-purge-all" => ListEventTypeName.EdgeCachePurgeAll,
                "edge-cache-rollback-purge" => ListEventTypeName.EdgeCacheRollbackPurge,
                "edge-config-created" => ListEventTypeName.EdgeConfigCreated,
                "edge-config-deleted" => ListEventTypeName.EdgeConfigDeleted,
                "edge-config-items-updated" => ListEventTypeName.EdgeConfigItemsUpdated,
                "edge-config-schema-deleted" => ListEventTypeName.EdgeConfigSchemaDeleted,
                "edge-config-schema-updated" => ListEventTypeName.EdgeConfigSchemaUpdated,
                "edge-config-token-created" => ListEventTypeName.EdgeConfigTokenCreated,
                "edge-config-token-deleted" => ListEventTypeName.EdgeConfigTokenDeleted,
                "edge-config-transfer-in" => ListEventTypeName.EdgeConfigTransferIn,
                "edge-config-transfer-out" => ListEventTypeName.EdgeConfigTransferOut,
                "edge-config-updated" => ListEventTypeName.EdgeConfigUpdated,
                "email" => ListEventTypeName.Email,
                "email-notification-rule-removed" => ListEventTypeName.EmailNotificationRuleRemoved,
                "email-notification-rule-updated" => ListEventTypeName.EmailNotificationRuleUpdated,
                "enforce-sensitive-environment-variables" => ListEventTypeName.EnforceSensitiveEnvironmentVariables,
                "env-variable-add" => ListEventTypeName.EnvVariableAdd,
                "env-variable-delete" => ListEventTypeName.EnvVariableDelete,
                "env-variable-edit" => ListEventTypeName.EnvVariableEdit,
                "env-variable-read" => ListEventTypeName.EnvVariableRead,
                "env-variable-read:cli:dev" => ListEventTypeName.EnvVariableRead_cli_dev,
                "env-variable-read:cli:env:add" => ListEventTypeName.EnvVariableRead_cli_env_add,
                "env-variable-read:cli:env:ls" => ListEventTypeName.EnvVariableRead_cli_env_ls,
                "env-variable-read:cli:env:pull" => ListEventTypeName.EnvVariableRead_cli_env_pull,
                "env-variable-read:cli:env:rm" => ListEventTypeName.EnvVariableRead_cli_env_rm,
                "env-variable-read:cli:pull" => ListEventTypeName.EnvVariableRead_cli_pull,
                "env-variable-read:unknown-source" => ListEventTypeName.EnvVariableRead_unknownSource,
                "env-variable-read:v0:env:pull" => ListEventTypeName.EnvVariableRead_v0_env_pull,
                "env-variable-rotated" => ListEventTypeName.EnvVariableRotated,
                "firewall-bypass-created" => ListEventTypeName.FirewallBypassCreated,
                "firewall-bypass-deleted" => ListEventTypeName.FirewallBypassDeleted,
                "firewall-config-modified" => ListEventTypeName.FirewallConfigModified,
                "firewall-config-promoted" => ListEventTypeName.FirewallConfigPromoted,
                "firewall-config-removed" => ListEventTypeName.FirewallConfigRemoved,
                "firewall-managed-rulegroup-updated" => ListEventTypeName.FirewallManagedRulegroupUpdated,
                "firewall-managed-ruleset-updated" => ListEventTypeName.FirewallManagedRulesetUpdated,
                "flag" => ListEventTypeName.Flag,
                "flag-archived" => ListEventTypeName.FlagArchived,
                "flag-created" => ListEventTypeName.FlagCreated,
                "flag-deleted" => ListEventTypeName.FlagDeleted,
                "flag-unarchived" => ListEventTypeName.FlagUnarchived,
                "flag-updated" => ListEventTypeName.FlagUpdated,
                "flags-explorer-subscription" => ListEventTypeName.FlagsExplorerSubscription,
                "flags-sdk-key" => ListEventTypeName.FlagsSdkKey,
                "flags-sdk-key-added" => ListEventTypeName.FlagsSdkKeyAdded,
                "flags-sdk-key-deleted" => ListEventTypeName.FlagsSdkKeyDeleted,
                "flags-sdk-key-read" => ListEventTypeName.FlagsSdkKeyRead,
                "flags-segment" => ListEventTypeName.FlagsSegment,
                "flags-settings" => ListEventTypeName.FlagsSettings,
                "instant-rollback-created" => ListEventTypeName.InstantRollbackCreated,
                "integration-configuration-owner-changed" => ListEventTypeName.IntegrationConfigurationOwnerChanged,
                "integration-configuration-scope-change-confirmed" => ListEventTypeName.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration-transfer-in-success" => ListEventTypeName.IntegrationConfigurationTransferInSuccess,
                "integration-configuration-transfer-out-success" => ListEventTypeName.IntegrationConfigurationTransferOutSuccess,
                "integration-configurations-disabled" => ListEventTypeName.IntegrationConfigurationsDisabled,
                "integration-installation-billing-plan-updated" => ListEventTypeName.IntegrationInstallationBillingPlanUpdated,
                "integration-installation-completed" => ListEventTypeName.IntegrationInstallationCompleted,
                "integration-installation-permission-updated" => ListEventTypeName.IntegrationInstallationPermissionUpdated,
                "integration-installation-removed" => ListEventTypeName.IntegrationInstallationRemoved,
                "integration-scope-changed" => ListEventTypeName.IntegrationScopeChanged,
                "invoice-modified" => ListEventTypeName.InvoiceModified,
                "invoice-refunded" => ListEventTypeName.InvoiceRefunded,
                "log-drain-created" => ListEventTypeName.LogDrainCreated,
                "log-drain-deleted" => ListEventTypeName.LogDrainDeleted,
                "log-drain-disabled" => ListEventTypeName.LogDrainDisabled,
                "log-drain-enabled" => ListEventTypeName.LogDrainEnabled,
                "login" => ListEventTypeName.Login,
                "manual-deployment-promotion-created" => ListEventTypeName.ManualDeploymentPromotionCreated,
                "marketplace-integration-allowlist-updated" => ListEventTypeName.MarketplaceIntegrationAllowlistUpdated,
                "microfrontend-group-added" => ListEventTypeName.MicrofrontendGroupAdded,
                "microfrontend-group-deleted" => ListEventTypeName.MicrofrontendGroupDeleted,
                "microfrontend-group-updated" => ListEventTypeName.MicrofrontendGroupUpdated,
                "microfrontend-project-added-to-group" => ListEventTypeName.MicrofrontendProjectAddedToGroup,
                "microfrontend-project-removed-from-group" => ListEventTypeName.MicrofrontendProjectRemovedFromGroup,
                "microfrontend-project-updated" => ListEventTypeName.MicrofrontendProjectUpdated,
                "monitoring-disabled" => ListEventTypeName.MonitoringDisabled,
                "monitoring-enabled" => ListEventTypeName.MonitoringEnabled,
                "oauth-app-connection-created" => ListEventTypeName.OauthAppConnectionCreated,
                "oauth-app-connection-removed" => ListEventTypeName.OauthAppConnectionRemoved,
                "oauth-app-connection-updated" => ListEventTypeName.OauthAppConnectionUpdated,
                "oauth-app-created" => ListEventTypeName.OauthAppCreated,
                "oauth-app-deleted" => ListEventTypeName.OauthAppDeleted,
                "oauth-app-secret-deleted" => ListEventTypeName.OauthAppSecretDeleted,
                "oauth-app-secret-generated" => ListEventTypeName.OauthAppSecretGenerated,
                "oauth-app-token-created" => ListEventTypeName.OauthAppTokenCreated,
                "oauth-app-updated" => ListEventTypeName.OauthAppUpdated,
                "observability-disabled" => ListEventTypeName.ObservabilityDisabled,
                "observability-enabled" => ListEventTypeName.ObservabilityEnabled,
                "observability-plus-project-disabled" => ListEventTypeName.ObservabilityPlusProjectDisabled,
                "observability-plus-project-enabled" => ListEventTypeName.ObservabilityPlusProjectEnabled,
                "owner-blocked" => ListEventTypeName.OwnerBlocked,
                "owner-soft-blocked" => ListEventTypeName.OwnerSoftBlocked,
                "owner-soft-unblocked" => ListEventTypeName.OwnerSoftUnblocked,
                "owner-unblocked" => ListEventTypeName.OwnerUnblocked,
                "page-integrity-config-updated" => ListEventTypeName.PageIntegrityConfigUpdated,
                "page-integrity-header-approved" => ListEventTypeName.PageIntegrityHeaderApproved,
                "page-integrity-resource-approved" => ListEventTypeName.PageIntegrityResourceApproved,
                "page-integrity-resource-deleted" => ListEventTypeName.PageIntegrityResourceDeleted,
                "page-integrity-resource-rejected" => ListEventTypeName.PageIntegrityResourceRejected,
                "passkey-created" => ListEventTypeName.PasskeyCreated,
                "passkey-deleted" => ListEventTypeName.PasskeyDeleted,
                "passkey-updated" => ListEventTypeName.PasskeyUpdated,
                "password-protection-disabled" => ListEventTypeName.PasswordProtectionDisabled,
                "password-protection-enabled" => ListEventTypeName.PasswordProtectionEnabled,
                "payment-method-added" => ListEventTypeName.PaymentMethodAdded,
                "payment-method-default-updated" => ListEventTypeName.PaymentMethodDefaultUpdated,
                "payment-method-removed" => ListEventTypeName.PaymentMethodRemoved,
                "plan" => ListEventTypeName.Plan,
                "preview-deployment-suffix-disabled" => ListEventTypeName.PreviewDeploymentSuffixDisabled,
                "preview-deployment-suffix-enabled" => ListEventTypeName.PreviewDeploymentSuffixEnabled,
                "preview-deployment-suffix-update" => ListEventTypeName.PreviewDeploymentSuffixUpdate,
                "privatelink-endpoint-created" => ListEventTypeName.PrivatelinkEndpointCreated,
                "privatelink-endpoint-deleted" => ListEventTypeName.PrivatelinkEndpointDeleted,
                "privatelink-endpoint-updated" => ListEventTypeName.PrivatelinkEndpointUpdated,
                "production-branch-updated" => ListEventTypeName.ProductionBranchUpdated,
                "project-add-alias" => ListEventTypeName.ProjectAddAlias,
                "project-add-redirect" => ListEventTypeName.ProjectAddRedirect,
                "project-affected-projects-deployments-updated" => ListEventTypeName.ProjectAffectedProjectsDeploymentsUpdated,
                "project-alias-configured-change" => ListEventTypeName.ProjectAliasConfiguredChange,
                "project-analytics-disabled" => ListEventTypeName.ProjectAnalyticsDisabled,
                "project-analytics-enabled" => ListEventTypeName.ProjectAnalyticsEnabled,
                "project-auto-assign-custom-production-domains-updated" => ListEventTypeName.ProjectAutoAssignCustomProductionDomainsUpdated,
                "project-automation-bypass" => ListEventTypeName.ProjectAutomationBypass,
                "project-build-command-updated" => ListEventTypeName.ProjectBuildCommandUpdated,
                "project-build-logs-and-source-protection-updated" => ListEventTypeName.ProjectBuildLogsAndSourceProtectionUpdated,
                "project-build-machine-updated" => ListEventTypeName.ProjectBuildMachineUpdated,
                "project-client-cert-delete" => ListEventTypeName.ProjectClientCertDelete,
                "project-client-cert-upload" => ListEventTypeName.ProjectClientCertUpload,
                "project-connect-configurations" => ListEventTypeName.ProjectConnectConfigurations,
                "project-consolidated-git-commit-status-updated" => ListEventTypeName.ProjectConsolidatedGitCommitStatusUpdated,
                "project-created" => ListEventTypeName.ProjectCreated,
                "project-cron-jobs-toggled" => ListEventTypeName.ProjectCronJobsToggled,
                "project-custom-environment-created" => ListEventTypeName.ProjectCustomEnvironmentCreated,
                "project-custom-environment-deleted" => ListEventTypeName.ProjectCustomEnvironmentDeleted,
                "project-custom-environment-updated" => ListEventTypeName.ProjectCustomEnvironmentUpdated,
                "project-customer-success-code-visibility-updated" => ListEventTypeName.ProjectCustomerSuccessCodeVisibilityUpdated,
                "project-delegated-protection-disabled" => ListEventTypeName.ProjectDelegatedProtectionDisabled,
                "project-delegated-protection-enabled" => ListEventTypeName.ProjectDelegatedProtectionEnabled,
                "project-delegated-protection-updated" => ListEventTypeName.ProjectDelegatedProtectionUpdated,
                "project-delete" => ListEventTypeName.ProjectDelete,
                "project-deployment-policy-updated" => ListEventTypeName.ProjectDeploymentPolicyUpdated,
                "project-deployment-retention-updated" => ListEventTypeName.ProjectDeploymentRetentionUpdated,
                "project-directory-listing" => ListEventTypeName.ProjectDirectoryListing,
                "project-domain-deleted" => ListEventTypeName.ProjectDomainDeleted,
                "project-domain-moved" => ListEventTypeName.ProjectDomainMoved,
                "project-domain-unverified" => ListEventTypeName.ProjectDomainUnverified,
                "project-domain-updated" => ListEventTypeName.ProjectDomainUpdated,
                "project-domain-verified" => ListEventTypeName.ProjectDomainVerified,
                "project-elastic-concurrency-updated" => ListEventTypeName.ProjectElasticConcurrencyUpdated,
                "project-expiration-locked" => ListEventTypeName.ProjectExpirationLocked,
                "project-expiration-scheduled" => ListEventTypeName.ProjectExpirationScheduled,
                "project-expiration-unlocked" => ListEventTypeName.ProjectExpirationUnlocked,
                "project-external-rewrite-caching-updated" => ListEventTypeName.ProjectExternalRewriteCachingUpdated,
                "project-framework-updated" => ListEventTypeName.ProjectFrameworkUpdated,
                "project-function-cpu-memory" => ListEventTypeName.ProjectFunctionCpuMemory,
                "project-function-failover" => ListEventTypeName.ProjectFunctionFailover,
                "project-function-max-duration" => ListEventTypeName.ProjectFunctionMaxDuration,
                "project-function-regions" => ListEventTypeName.ProjectFunctionRegions,
                "project-functions-beta-updated" => ListEventTypeName.ProjectFunctionsBetaUpdated,
                "project-functions-fluid-disabled" => ListEventTypeName.ProjectFunctionsFluidDisabled,
                "project-functions-fluid-enabled" => ListEventTypeName.ProjectFunctionsFluidEnabled,
                "project-git-commit-comments-toggled" => ListEventTypeName.ProjectGitCommitCommentsToggled,
                "project-git-commit-status-toggled" => ListEventTypeName.ProjectGitCommitStatusToggled,
                "project-git-create-deployments-toggled" => ListEventTypeName.ProjectGitCreateDeploymentsToggled,
                "project-git-fork-protection-updated" => ListEventTypeName.ProjectGitForkProtectionUpdated,
                "project-git-lfs-toggled" => ListEventTypeName.ProjectGitLfsToggled,
                "project-git-pr-comments-toggled" => ListEventTypeName.ProjectGitPrCommentsToggled,
                "project-git-repository-connected" => ListEventTypeName.ProjectGitRepositoryConnected,
                "project-git-repository-disconnected" => ListEventTypeName.ProjectGitRepositoryDisconnected,
                "project-git-repository-dispatch-events-toggled" => ListEventTypeName.ProjectGitRepositoryDispatchEventsToggled,
                "project-git-require-verified-commits-toggled" => ListEventTypeName.ProjectGitRequireVerifiedCommitsToggled,
                "project-ignored-build-step-updated" => ListEventTypeName.ProjectIgnoredBuildStepUpdated,
                "project-install-command-updated" => ListEventTypeName.ProjectInstallCommandUpdated,
                "project-member-added" => ListEventTypeName.ProjectMemberAdded,
                "project-member-invited" => ListEventTypeName.ProjectMemberInvited,
                "project-member-removed" => ListEventTypeName.ProjectMemberRemoved,
                "project-member-removed-batch" => ListEventTypeName.ProjectMemberRemovedBatch,
                "project-member-updated" => ListEventTypeName.ProjectMemberUpdated,
                "project-move-in-success" => ListEventTypeName.ProjectMoveInSuccess,
                "project-move-out-failed" => ListEventTypeName.ProjectMoveOutFailed,
                "project-move-out-started" => ListEventTypeName.ProjectMoveOutStarted,
                "project-move-out-success" => ListEventTypeName.ProjectMoveOutSuccess,
                "project-name" => ListEventTypeName.ProjectName,
                "project-node-version-updated" => ListEventTypeName.ProjectNodeVersionUpdated,
                "project-oidc-issuer-mode-updated" => ListEventTypeName.ProjectOidcIssuerModeUpdated,
                "project-oidc-token-created" => ListEventTypeName.ProjectOidcTokenCreated,
                "project-options-allowlist" => ListEventTypeName.ProjectOptionsAllowlist,
                "project-output-directory-updated" => ListEventTypeName.ProjectOutputDirectoryUpdated,
                "project-password-protection" => ListEventTypeName.ProjectPasswordProtection,
                "project-paused" => ListEventTypeName.ProjectPaused,
                "project-preview-deployment-suffix" => ListEventTypeName.ProjectPreviewDeploymentSuffix,
                "project-preview-environment-branch-tracking-updated" => ListEventTypeName.ProjectPreviewEnvironmentBranchTrackingUpdated,
                "project-prioritize-production-builds-updated" => ListEventTypeName.ProjectPrioritizeProductionBuildsUpdated,
                "project-program-enrollment-changed" => ListEventTypeName.ProjectProgramEnrollmentChanged,
                "project-protected-sourcemaps-updated" => ListEventTypeName.ProjectProtectedSourcemapsUpdated,
                "project-rolling-release-aborted" => ListEventTypeName.ProjectRollingReleaseAborted,
                "project-rolling-release-approved" => ListEventTypeName.ProjectRollingReleaseApproved,
                "project-rolling-release-completed" => ListEventTypeName.ProjectRollingReleaseCompleted,
                "project-rolling-release-configured" => ListEventTypeName.ProjectRollingReleaseConfigured,
                "project-rolling-release-continued" => ListEventTypeName.ProjectRollingReleaseContinued,
                "project-rolling-release-disabled" => ListEventTypeName.ProjectRollingReleaseDisabled,
                "project-rolling-release-enabled" => ListEventTypeName.ProjectRollingReleaseEnabled,
                "project-rolling-release-paused" => ListEventTypeName.ProjectRollingReleasePaused,
                "project-rolling-release-started" => ListEventTypeName.ProjectRollingReleaseStarted,
                "project-rolling-release-suggested-actions-generated" => ListEventTypeName.ProjectRollingReleaseSuggestedActionsGenerated,
                "project-rolling-release-timer" => ListEventTypeName.ProjectRollingReleaseTimer,
                "project-root-directory-updated" => ListEventTypeName.ProjectRootDirectoryUpdated,
                "project-routes-version-promoted" => ListEventTypeName.ProjectRoutesVersionPromoted,
                "project-routes-version-restored" => ListEventTypeName.ProjectRoutesVersionRestored,
                "project-skew-protection-allowed-domains-updated" => ListEventTypeName.ProjectSkewProtectionAllowedDomainsUpdated,
                "project-skew-protection-max-age-updated" => ListEventTypeName.ProjectSkewProtectionMaxAgeUpdated,
                "project-skew-protection-threshold-updated" => ListEventTypeName.ProjectSkewProtectionThresholdUpdated,
                "project-source-files-outside-root-directory-updated" => ListEventTypeName.ProjectSourceFilesOutsideRootDirectoryUpdated,
                "project-speed-insights-disabled" => ListEventTypeName.ProjectSpeedInsightsDisabled,
                "project-speed-insights-enabled" => ListEventTypeName.ProjectSpeedInsightsEnabled,
                "project-sso-protection" => ListEventTypeName.ProjectSsoProtection,
                "project-static-ips-updated" => ListEventTypeName.ProjectStaticIpsUpdated,
                "project-trusted-ips" => ListEventTypeName.ProjectTrustedIps,
                "project-trusted-sources" => ListEventTypeName.ProjectTrustedSources,
                "project-unpaused" => ListEventTypeName.ProjectUnpaused,
                "project-web-analytics-disabled" => ListEventTypeName.ProjectWebAnalyticsDisabled,
                "project-web-analytics-enabled" => ListEventTypeName.ProjectWebAnalyticsEnabled,
                "protected-git-scope-added" => ListEventTypeName.ProtectedGitScopeAdded,
                "protected-git-scope-removed" => ListEventTypeName.ProtectedGitScopeRemoved,
                "runtime-cache-purge-all" => ListEventTypeName.RuntimeCachePurgeAll,
                "scale" => ListEventTypeName.Scale,
                "scale-auto" => ListEventTypeName.ScaleAuto,
                "secondary-email-added" => ListEventTypeName.SecondaryEmailAdded,
                "secondary-email-removed" => ListEventTypeName.SecondaryEmailRemoved,
                "secondary-email-verified" => ListEventTypeName.SecondaryEmailVerified,
                "secret-add" => ListEventTypeName.SecretAdd,
                "secret-delete" => ListEventTypeName.SecretDelete,
                "secret-rename" => ListEventTypeName.SecretRename,
                "security-plus-updated" => ListEventTypeName.SecurityPlusUpdated,
                "set-bio" => ListEventTypeName.SetBio,
                "set-name" => ListEventTypeName.SetName,
                "set-profiles" => ListEventTypeName.SetProfiles,
                "set-scale" => ListEventTypeName.SetScale,
                "shared-env-variable-create" => ListEventTypeName.SharedEnvVariableCreate,
                "shared-env-variable-delete" => ListEventTypeName.SharedEnvVariableDelete,
                "shared-env-variable-read" => ListEventTypeName.SharedEnvVariableRead,
                "shared-env-variable-update" => ListEventTypeName.SharedEnvVariableUpdate,
                "show-ip-addresses" => ListEventTypeName.ShowIpAddresses,
                "signup" => ListEventTypeName.Signup,
                "signup-via-bitbucket" => ListEventTypeName.SignupViaBitbucket,
                "signup-via-github" => ListEventTypeName.SignupViaGithub,
                "signup-via-gitlab" => ListEventTypeName.SignupViaGitlab,
                "speed-insights-settings-updated" => ListEventTypeName.SpeedInsightsSettingsUpdated,
                "spend-created" => ListEventTypeName.SpendCreated,
                "spend-deleted" => ListEventTypeName.SpendDeleted,
                "spend-updated" => ListEventTypeName.SpendUpdated,
                "storage-accept-tos" => ListEventTypeName.StorageAcceptTos,
                "storage-access-token-set" => ListEventTypeName.StorageAccessTokenSet,
                "storage-accessed-data-browser" => ListEventTypeName.StorageAccessedDataBrowser,
                "storage-connect-project" => ListEventTypeName.StorageConnectProject,
                "storage-create" => ListEventTypeName.StorageCreate,
                "storage-delete" => ListEventTypeName.StorageDelete,
                "storage-disconnect-project" => ListEventTypeName.StorageDisconnectProject,
                "storage-disconnect-projects" => ListEventTypeName.StorageDisconnectProjects,
                "storage-inactive-store-deleted" => ListEventTypeName.StorageInactiveStoreDeleted,
                "storage-reset-credentials" => ListEventTypeName.StorageResetCredentials,
                "storage-resource-repl-command" => ListEventTypeName.StorageResourceReplCommand,
                "storage-set-locked" => ListEventTypeName.StorageSetLocked,
                "storage-transfer-in-success" => ListEventTypeName.StorageTransferInSuccess,
                "storage-transfer-out-success" => ListEventTypeName.StorageTransferOutSuccess,
                "storage-transfer-request-created" => ListEventTypeName.StorageTransferRequestCreated,
                "storage-update" => ListEventTypeName.StorageUpdate,
                "storage-update-project-connection" => ListEventTypeName.StorageUpdateProjectConnection,
                "storage-upgrade-project-connection-to-oidc" => ListEventTypeName.StorageUpgradeProjectConnectionToOidc,
                "storage-view-secret" => ListEventTypeName.StorageViewSecret,
                "strict-deployment-protection-settings" => ListEventTypeName.StrictDeploymentProtectionSettings,
                "strict-shareable-links" => ListEventTypeName.StrictShareableLinks,
                "subscription-created" => ListEventTypeName.SubscriptionCreated,
                "subscription-product-added" => ListEventTypeName.SubscriptionProductAdded,
                "subscription-product-removed" => ListEventTypeName.SubscriptionProductRemoved,
                "subscription-updated" => ListEventTypeName.SubscriptionUpdated,
                "team" => ListEventTypeName.Team,
                "team-avatar-update" => ListEventTypeName.TeamAvatarUpdate,
                "team-default-build-machine-updated" => ListEventTypeName.TeamDefaultBuildMachineUpdated,
                "team-delete" => ListEventTypeName.TeamDelete,
                "team-deployment-policy-updated" => ListEventTypeName.TeamDeploymentPolicyUpdated,
                "team-domain-verification-created" => ListEventTypeName.TeamDomainVerificationCreated,
                "team-domain-verification-deleted" => ListEventTypeName.TeamDomainVerificationDeleted,
                "team-domain-verification-verified" => ListEventTypeName.TeamDomainVerificationVerified,
                "team-email-domain-update" => ListEventTypeName.TeamEmailDomainUpdate,
                "team-emu-updated" => ListEventTypeName.TeamEmuUpdated,
                "team-ended-trial" => ListEventTypeName.TeamEndedTrial,
                "team-git-repository-dispatch-events-toggled" => ListEventTypeName.TeamGitRepositoryDispatchEventsToggled,
                "team-git-require-verified-commits-toggled" => ListEventTypeName.TeamGitRequireVerifiedCommitsToggled,
                "team-invite-bulk-delete" => ListEventTypeName.TeamInviteBulkDelete,
                "team-invite-code-reset" => ListEventTypeName.TeamInviteCodeReset,
                "team-invite-link-created" => ListEventTypeName.TeamInviteLinkCreated,
                "team-invite-link-deleted" => ListEventTypeName.TeamInviteLinkDeleted,
                "team-ip-blocking-rules-created" => ListEventTypeName.TeamIpBlockingRulesCreated,
                "team-ip-blocking-rules-removed" => ListEventTypeName.TeamIpBlockingRulesRemoved,
                "team-member-add" => ListEventTypeName.TeamMemberAdd,
                "team-member-confirm-request" => ListEventTypeName.TeamMemberConfirmRequest,
                "team-member-decline-request" => ListEventTypeName.TeamMemberDeclineRequest,
                "team-member-delete" => ListEventTypeName.TeamMemberDelete,
                "team-member-entitlement-added" => ListEventTypeName.TeamMemberEntitlementAdded,
                "team-member-entitlement-canceled" => ListEventTypeName.TeamMemberEntitlementCanceled,
                "team-member-entitlement-reactivated" => ListEventTypeName.TeamMemberEntitlementReactivated,
                "team-member-entitlement-removed" => ListEventTypeName.TeamMemberEntitlementRemoved,
                "team-member-join" => ListEventTypeName.TeamMemberJoin,
                "team-member-leave" => ListEventTypeName.TeamMemberLeave,
                "team-member-request-access" => ListEventTypeName.TeamMemberRequestAccess,
                "team-member-role-update" => ListEventTypeName.TeamMemberRoleUpdate,
                "team-mfa-enforcement-updated" => ListEventTypeName.TeamMfaEnforcementUpdated,
                "team-name-update" => ListEventTypeName.TeamNameUpdate,
                "team-paid-invoice" => ListEventTypeName.TeamPaidInvoice,
                "team-program-enrollment-changed" => ListEventTypeName.TeamProgramEnrollmentChanged,
                "team-remote-caching-update" => ListEventTypeName.TeamRemoteCachingUpdate,
                "team-saml-enforced" => ListEventTypeName.TeamSamlEnforced,
                "team-saml-roles" => ListEventTypeName.TeamSamlRoles,
                "team-slug-update" => ListEventTypeName.TeamSlugUpdate,
                "team-tokens-invalidated" => ListEventTypeName.TeamTokensInvalidated,
                "unlink-login-connection" => ListEventTypeName.UnlinkLoginConnection,
                "user-delete" => ListEventTypeName.UserDelete,
                "user-mfa-challenge-verified" => ListEventTypeName.UserMfaChallengeVerified,
                "user-mfa-configuration-updated" => ListEventTypeName.UserMfaConfigurationUpdated,
                "user-mfa-recovery-codes-regenerated" => ListEventTypeName.UserMfaRecoveryCodesRegenerated,
                "user-mfa-removed" => ListEventTypeName.UserMfaRemoved,
                "user-mfa-totp-verification-started" => ListEventTypeName.UserMfaTotpVerificationStarted,
                "user-mfa-totp-verified" => ListEventTypeName.UserMfaTotpVerified,
                "user-primary-email-updated" => ListEventTypeName.UserPrimaryEmailUpdated,
                "user-token-created" => ListEventTypeName.UserTokenCreated,
                "user-token-deleted" => ListEventTypeName.UserTokenDeleted,
                "user-tokens-deleted" => ListEventTypeName.UserTokensDeleted,
                "username" => ListEventTypeName.Username,
                "v0-chat-ai-usage" => ListEventTypeName.V0ChatAiUsage,
                "v0-chat-created" => ListEventTypeName.V0ChatCreated,
                "v0-chat-message-sent" => ListEventTypeName.V0ChatMessageSent,
                "vercel-agent-team-trial-credits-applied" => ListEventTypeName.VercelAgentTeamTrialCreditsApplied,
                "vercel-app-installation-request-dismissed" => ListEventTypeName.VercelAppInstallationRequestDismissed,
                "vercel-app-installation-requested" => ListEventTypeName.VercelAppInstallationRequested,
                "vercel-app-installation-updated" => ListEventTypeName.VercelAppInstallationUpdated,
                "vercel-app-installed" => ListEventTypeName.VercelAppInstalled,
                "vercel-app-tokens-revoked" => ListEventTypeName.VercelAppTokensRevoked,
                "vercel-app-uninstalled" => ListEventTypeName.VercelAppUninstalled,
                "vercel-toolbar" => ListEventTypeName.VercelToolbar,
                "vpc-peering-connection-accepted" => ListEventTypeName.VpcPeeringConnectionAccepted,
                "vpc-peering-connection-deleted" => ListEventTypeName.VpcPeeringConnectionDeleted,
                "vpc-peering-connection-rejected" => ListEventTypeName.VpcPeeringConnectionRejected,
                "vpc-peering-connection-updated" => ListEventTypeName.VpcPeeringConnectionUpdated,
                "vulnerability-banner-dismissed" => ListEventTypeName.VulnerabilityBannerDismissed,
                "web-analytics-tier-updated" => ListEventTypeName.WebAnalyticsTierUpdated,
                "webhook-created" => ListEventTypeName.WebhookCreated,
                "webhook-deleted" => ListEventTypeName.WebhookDeleted,
                "webhook-updated" => ListEventTypeName.WebhookUpdated,
                "workflow-deployment-key-accessed" => ListEventTypeName.WorkflowDeploymentKeyAccessed,
                _ => null,
            };
        }
    }
}