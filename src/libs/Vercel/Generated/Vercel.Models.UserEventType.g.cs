
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of the event.<br/>
    /// Example: login
    /// </summary>
    public enum UserEventType
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
        AiGatewayApiKeyQuotaUpdated,
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
        AiGatewayGuardrailsUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayModelAllowlistModelsUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayModelAllowlistToggled,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayPrivateModelCreated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayPrivateModelDeleted,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayPrivateModelUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayPrivateProviderCreated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayPrivateProviderDeleted,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayPrivateProviderUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayProviderAllowlistProvidersUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayProviderAllowlistToggled,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayRuleCreated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayRuleDeleted,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayRuleUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayVirtualModelConfigArchived,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayVirtualModelConfigCreated,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayVirtualModelConfigRestored,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayVirtualModelConfigUpdated,
        /// <summary>
        /// 
        /// </summary>
        AiOmniagent,
        /// <summary>
        /// 
        /// </summary>
        AlertInvestigationProjectAllowlistUpdated,
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
        ConnectAttachProject,
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
        ConnectCreateConnector,
        /// <summary>
        /// 
        /// </summary>
        ConnectDeleteConnector,
        /// <summary>
        /// 
        /// </summary>
        ConnectDeleteInstallation,
        /// <summary>
        /// 
        /// </summary>
        ConnectDetachProject,
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
        ConnectImportTokens,
        /// <summary>
        /// 
        /// </summary>
        ConnectRevokeAllTokens,
        /// <summary>
        /// 
        /// </summary>
        ConnectUpdateConnector,
        /// <summary>
        /// 
        /// </summary>
        ConnectUpdateTriggerDestinations,
        /// <summary>
        /// 
        /// </summary>
        ConnectUpsertInstallation,
        /// <summary>
        /// 
        /// </summary>
        CustomAlertCreated,
        /// <summary>
        /// 
        /// </summary>
        CustomAlertDeleted,
        /// <summary>
        /// 
        /// </summary>
        CustomAlertUpdated,
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
        DeploymentPolicyBlocked,
        /// <summary>
        /// 
        /// </summary>
        DeploymentUndeleted,
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
        DnsRecordInternal,
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
        DomainZoneChangeInternal,
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
        EdgeConfigBackupRestored,
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
        EmuMemberRemovedUnverifiedDomain,
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
        EnvVariableMasked,
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
        FlagsTransferred,
        /// <summary>
        /// 
        /// </summary>
        GitAccountIntegrationLinkAdded,
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
        IntegrationResourceSqlQueryExecuted,
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
        MonitoringAlertUpdated,
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
        OrganizationCreate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationDelete,
        /// <summary>
        /// 
        /// </summary>
        OrganizationSlugUpdate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationTeamAdd,
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
        PageIntegrityHeaderRejected,
        /// <summary>
        /// 
        /// </summary>
        PageIntegrityInventoryCleared,
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
        PassportAccessGranted,
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
        ProjectAvatarUpdate,
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
        ProjectExpirationReached,
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
        ProjectPassportUpdated,
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
        ProjectRollbackDescriptionUpdated,
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
        ProjectSandboxUrlProtectionUpdated,
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
        SandboxAliasAssigned,
        /// <summary>
        /// 
        /// </summary>
        SandboxAliasDelete,
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
        SecurityListCreated,
        /// <summary>
        /// 
        /// </summary>
        SecurityListDeleted,
        /// <summary>
        /// 
        /// </summary>
        SecurityListUpdated,
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
        StrictPasswordProtectionSettings,
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
        TeamDefaultPassportUpdated,
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
        TeamEmuAccountSplit,
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
        TeamFirewallConfigModified,
        /// <summary>
        /// 
        /// </summary>
        TeamFirewallConfigPromoted,
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
        TeamMemberSsoAuthorizationAttempt,
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
        TeamRemoteCachingPurge,
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
        UserEmuAccountArchived,
        /// <summary>
        /// 
        /// </summary>
        UserEmuAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserEmuAccountRecovered,
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
        UserMfaSetupSkipped,
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
        VcrImageDeleted,
        /// <summary>
        /// 
        /// </summary>
        VcrImagePushed,
        /// <summary>
        /// 
        /// </summary>
        VcrRepositoryCreated,
        /// <summary>
        /// 
        /// </summary>
        VcrRepositoryDeleted,
        /// <summary>
        /// 
        /// </summary>
        VercelAgentElevatedPermissionsApproved,
        /// <summary>
        /// 
        /// </summary>
        VercelAgentElevatedPermissionsRequested,
        /// <summary>
        /// 
        /// </summary>
        VercelAgentSessionCreated,
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
    public static class UserEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventType value)
        {
            return value switch
            {
                UserEventType.AccessGroupCreated => "access-group-created",
                UserEventType.AccessGroupDeleted => "access-group-deleted",
                UserEventType.AccessGroupProjectUpdated => "access-group-project-updated",
                UserEventType.AccessGroupUpdated => "access-group-updated",
                UserEventType.AccessGroupUserAdded => "access-group-user-added",
                UserEventType.AccessGroupUserRemoved => "access-group-user-removed",
                UserEventType.AgenticProvisioningAccountBlocked => "agentic-provisioning-account-blocked",
                UserEventType.AgenticProvisioningAccountLinked => "agentic-provisioning-account-linked",
                UserEventType.AgenticProvisioningAccountRelinked => "agentic-provisioning-account-relinked",
                UserEventType.AgenticProvisioningAccountUnlinked => "agentic-provisioning-account-unlinked",
                UserEventType.AgenticProvisioningCredentialsRotated => "agentic-provisioning-credentials-rotated",
                UserEventType.AgenticProvisioningPlanChanged => "agentic-provisioning-plan-changed",
                UserEventType.AgenticProvisioningTeamCreated => "agentic-provisioning-team-created",
                UserEventType.AiAlertInvestigation => "ai-alert-investigation",
                UserEventType.AiCodeReview => "ai-code-review",
                UserEventType.AiGatewayApiKeyCreated => "ai-gateway-api-key-created",
                UserEventType.AiGatewayApiKeyDeleted => "ai-gateway-api-key-deleted",
                UserEventType.AiGatewayApiKeyQuotaUpdated => "ai-gateway-api-key-quota-updated",
                UserEventType.AiGatewayByokCredentialCreated => "ai-gateway-byok-credential-created",
                UserEventType.AiGatewayByokCredentialDeleted => "ai-gateway-byok-credential-deleted",
                UserEventType.AiGatewayByokCredentialUpdated => "ai-gateway-byok-credential-updated",
                UserEventType.AiGatewayGuardrailsUpdated => "ai-gateway-guardrails-updated",
                UserEventType.AiGatewayModelAllowlistModelsUpdated => "ai-gateway-model-allowlist-models-updated",
                UserEventType.AiGatewayModelAllowlistToggled => "ai-gateway-model-allowlist-toggled",
                UserEventType.AiGatewayPrivateModelCreated => "ai-gateway-private-model-created",
                UserEventType.AiGatewayPrivateModelDeleted => "ai-gateway-private-model-deleted",
                UserEventType.AiGatewayPrivateModelUpdated => "ai-gateway-private-model-updated",
                UserEventType.AiGatewayPrivateProviderCreated => "ai-gateway-private-provider-created",
                UserEventType.AiGatewayPrivateProviderDeleted => "ai-gateway-private-provider-deleted",
                UserEventType.AiGatewayPrivateProviderUpdated => "ai-gateway-private-provider-updated",
                UserEventType.AiGatewayProviderAllowlistProvidersUpdated => "ai-gateway-provider-allowlist-providers-updated",
                UserEventType.AiGatewayProviderAllowlistToggled => "ai-gateway-provider-allowlist-toggled",
                UserEventType.AiGatewayRuleCreated => "ai-gateway-rule-created",
                UserEventType.AiGatewayRuleDeleted => "ai-gateway-rule-deleted",
                UserEventType.AiGatewayRuleUpdated => "ai-gateway-rule-updated",
                UserEventType.AiGatewayVirtualModelConfigArchived => "ai-gateway-virtual-model-config-archived",
                UserEventType.AiGatewayVirtualModelConfigCreated => "ai-gateway-virtual-model-config-created",
                UserEventType.AiGatewayVirtualModelConfigRestored => "ai-gateway-virtual-model-config-restored",
                UserEventType.AiGatewayVirtualModelConfigUpdated => "ai-gateway-virtual-model-config-updated",
                UserEventType.AiOmniagent => "ai-omniagent",
                UserEventType.AlertInvestigationProjectAllowlistUpdated => "alert-investigation-project-allowlist-updated",
                UserEventType.AlertRuleCreated => "alert-rule-created",
                UserEventType.AlertRuleDeleted => "alert-rule-deleted",
                UserEventType.AlertRuleUpdated => "alert-rule-updated",
                UserEventType.Alias => "alias",
                UserEventType.AliasChown => "alias-chown",
                UserEventType.AliasDelete => "alias-delete",
                UserEventType.AliasInviteCreated => "alias-invite-created",
                UserEventType.AliasInviteJoined => "alias-invite-joined",
                UserEventType.AliasInviteRevoked => "alias-invite-revoked",
                UserEventType.AliasProtectionBypassCreated => "alias-protection-bypass-created",
                UserEventType.AliasProtectionBypassException => "alias-protection-bypass-exception",
                UserEventType.AliasProtectionBypassRegenerated => "alias-protection-bypass-regenerated",
                UserEventType.AliasProtectionBypassRevoked => "alias-protection-bypass-revoked",
                UserEventType.AliasSystem => "alias-system",
                UserEventType.AliasUserScopedAccessDenied => "alias-user-scoped-access-denied",
                UserEventType.AliasUserScopedAccessGranted => "alias-user-scoped-access-granted",
                UserEventType.AliasUserScopedAccessRequested => "alias-user-scoped-access-requested",
                UserEventType.AliasUserScopedAccessRevoked => "alias-user-scoped-access-revoked",
                UserEventType.AliasesAssigned => "aliases-assigned",
                UserEventType.AttackModeDisabled => "attack-mode-disabled",
                UserEventType.AttackModeEnabled => "attack-mode-enabled",
                UserEventType.AuditLogExportDownloaded => "audit-log-export-downloaded",
                UserEventType.AuditLogExportRequested => "audit-log-export-requested",
                UserEventType.AuthorizeGitDeployment => "authorize-git-deployment",
                UserEventType.AutoExposeSystemEnvs => "auto-expose-system-envs",
                UserEventType.Avatar => "avatar",
                UserEventType.BulkRedirectsSettingsUpdated => "bulk-redirects-settings-updated",
                UserEventType.BulkRedirectsVersionPromoted => "bulk-redirects-version-promoted",
                UserEventType.BulkRedirectsVersionRestored => "bulk-redirects-version-restored",
                UserEventType.Cert => "cert",
                UserEventType.CertAutorenew => "cert-autorenew",
                UserEventType.CertChown => "cert-chown",
                UserEventType.CertClone => "cert-clone",
                UserEventType.CertDelete => "cert-delete",
                UserEventType.CertRenew => "cert-renew",
                UserEventType.CertReplace => "cert-replace",
                UserEventType.CertSystemCreate => "cert-system-create",
                UserEventType.ConcurrentBuildsUpdate => "concurrent-builds-update",
                UserEventType.ConnectAttachProject => "connect-attach-project",
                UserEventType.ConnectBitbucket => "connect-bitbucket",
                UserEventType.ConnectBitbucketApp => "connect-bitbucket-app",
                UserEventType.ConnectConfigurationCreated => "connect-configuration-created",
                UserEventType.ConnectConfigurationDeleted => "connect-configuration-deleted",
                UserEventType.ConnectConfigurationLinkUpdated => "connect-configuration-link-updated",
                UserEventType.ConnectConfigurationLinked => "connect-configuration-linked",
                UserEventType.ConnectConfigurationUnlinked => "connect-configuration-unlinked",
                UserEventType.ConnectConfigurationUpdated => "connect-configuration-updated",
                UserEventType.ConnectCreateConnector => "connect-create-connector",
                UserEventType.ConnectDeleteConnector => "connect-delete-connector",
                UserEventType.ConnectDeleteInstallation => "connect-delete-installation",
                UserEventType.ConnectDetachProject => "connect-detach-project",
                UserEventType.ConnectGithub => "connect-github",
                UserEventType.ConnectGithubCustomHost => "connect-github-custom-host",
                UserEventType.ConnectGithubLimited => "connect-github-limited",
                UserEventType.ConnectGitlab => "connect-gitlab",
                UserEventType.ConnectGitlabApp => "connect-gitlab-app",
                UserEventType.ConnectImportTokens => "connect-import-tokens",
                UserEventType.ConnectRevokeAllTokens => "connect-revoke-all-tokens",
                UserEventType.ConnectUpdateConnector => "connect-update-connector",
                UserEventType.ConnectUpdateTriggerDestinations => "connect-update-trigger-destinations",
                UserEventType.ConnectUpsertInstallation => "connect-upsert-installation",
                UserEventType.CustomAlertCreated => "custom-alert-created",
                UserEventType.CustomAlertDeleted => "custom-alert-deleted",
                UserEventType.CustomAlertUpdated => "custom-alert-updated",
                UserEventType.CustomSuffixClear => "custom-suffix-clear",
                UserEventType.CustomSuffixDisable => "custom-suffix-disable",
                UserEventType.CustomSuffixEnable => "custom-suffix-enable",
                UserEventType.CustomSuffixPending => "custom-suffix-pending",
                UserEventType.CustomSuffixReady => "custom-suffix-ready",
                UserEventType.DeployHookCreated => "deploy-hook-created",
                UserEventType.DeployHookDeduped => "deploy-hook-deduped",
                UserEventType.DeployHookDeleted => "deploy-hook-deleted",
                UserEventType.DeployHookProcessed => "deploy-hook-processed",
                UserEventType.Deployment => "deployment",
                UserEventType.DeploymentCheckCreated => "deployment-check-created",
                UserEventType.DeploymentCheckDeleted => "deployment-check-deleted",
                UserEventType.DeploymentCheckUpdated => "deployment-check-updated",
                UserEventType.DeploymentChown => "deployment-chown",
                UserEventType.DeploymentCreationBlocked => "deployment-creation-blocked",
                UserEventType.DeploymentDelete => "deployment-delete",
                UserEventType.DeploymentPolicyBlocked => "deployment-policy-blocked",
                UserEventType.DeploymentUndeleted => "deployment-undeleted",
                UserEventType.DisabledIntegrationInstallationRemoved => "disabled-integration-installation-removed",
                UserEventType.DisconnectBitbucketApp => "disconnect-bitbucket-app",
                UserEventType.DisconnectGithub => "disconnect-github",
                UserEventType.DisconnectGithubCustomHost => "disconnect-github-custom-host",
                UserEventType.DisconnectGithubLimited => "disconnect-github-limited",
                UserEventType.DisconnectGitlabApp => "disconnect-gitlab-app",
                UserEventType.DnsAdd => "dns-add",
                UserEventType.DnsDelete => "dns-delete",
                UserEventType.DnsRecordInternal => "dns-record-internal",
                UserEventType.DnsUpdate => "dns-update",
                UserEventType.DnsZonefileImport => "dns-zonefile-import",
                UserEventType.Domain => "domain",
                UserEventType.DomainBuy => "domain-buy",
                UserEventType.DomainCdn => "domain-cdn",
                UserEventType.DomainChown => "domain-chown",
                UserEventType.DomainCustomNsChange => "domain-custom-ns-change",
                UserEventType.DomainDelegated => "domain-delegated",
                UserEventType.DomainDelete => "domain-delete",
                UserEventType.DomainMoveIn => "domain-move-in",
                UserEventType.DomainMoveOut => "domain-move-out",
                UserEventType.DomainMoveOutRequestSent => "domain-move-out-request-sent",
                UserEventType.DomainRenewChange => "domain-renew-change",
                UserEventType.DomainServiceTypeUpdated => "domain-service-type-updated",
                UserEventType.DomainTransferIn => "domain-transfer-in",
                UserEventType.DomainTransferInCanceled => "domain-transfer-in-canceled",
                UserEventType.DomainTransferInCompleted => "domain-transfer-in-completed",
                UserEventType.DomainZoneChange => "domain-zone-change",
                UserEventType.DomainZoneChangeInternal => "domain-zone-change-internal",
                UserEventType.DrainCreated => "drain-created",
                UserEventType.DrainDeleted => "drain-deleted",
                UserEventType.DrainDisabled => "drain-disabled",
                UserEventType.DrainEnabled => "drain-enabled",
                UserEventType.DrainUpdated => "drain-updated",
                UserEventType.EdgeCacheDangerouslyDeleteBySrcImages => "edge-cache-dangerously-delete-by-src-images",
                UserEventType.EdgeCacheDangerouslyDeleteByTags => "edge-cache-dangerously-delete-by-tags",
                UserEventType.EdgeCacheInvalidateBySrcImages => "edge-cache-invalidate-by-src-images",
                UserEventType.EdgeCacheInvalidateByTags => "edge-cache-invalidate-by-tags",
                UserEventType.EdgeCachePurgeAll => "edge-cache-purge-all",
                UserEventType.EdgeCacheRollbackPurge => "edge-cache-rollback-purge",
                UserEventType.EdgeConfigBackupRestored => "edge-config-backup-restored",
                UserEventType.EdgeConfigCreated => "edge-config-created",
                UserEventType.EdgeConfigDeleted => "edge-config-deleted",
                UserEventType.EdgeConfigItemsUpdated => "edge-config-items-updated",
                UserEventType.EdgeConfigSchemaDeleted => "edge-config-schema-deleted",
                UserEventType.EdgeConfigSchemaUpdated => "edge-config-schema-updated",
                UserEventType.EdgeConfigTokenCreated => "edge-config-token-created",
                UserEventType.EdgeConfigTokenDeleted => "edge-config-token-deleted",
                UserEventType.EdgeConfigTransferIn => "edge-config-transfer-in",
                UserEventType.EdgeConfigTransferOut => "edge-config-transfer-out",
                UserEventType.EdgeConfigUpdated => "edge-config-updated",
                UserEventType.Email => "email",
                UserEventType.EmailNotificationRuleRemoved => "email-notification-rule-removed",
                UserEventType.EmailNotificationRuleUpdated => "email-notification-rule-updated",
                UserEventType.EmuMemberRemovedUnverifiedDomain => "emu-member-removed-unverified-domain",
                UserEventType.EnforceSensitiveEnvironmentVariables => "enforce-sensitive-environment-variables",
                UserEventType.EnvVariableAdd => "env-variable-add",
                UserEventType.EnvVariableDelete => "env-variable-delete",
                UserEventType.EnvVariableEdit => "env-variable-edit",
                UserEventType.EnvVariableMasked => "env-variable-masked",
                UserEventType.EnvVariableRead => "env-variable-read",
                UserEventType.EnvVariableRead_cli_dev => "env-variable-read:cli:dev",
                UserEventType.EnvVariableRead_cli_env_add => "env-variable-read:cli:env:add",
                UserEventType.EnvVariableRead_cli_env_ls => "env-variable-read:cli:env:ls",
                UserEventType.EnvVariableRead_cli_env_pull => "env-variable-read:cli:env:pull",
                UserEventType.EnvVariableRead_cli_env_rm => "env-variable-read:cli:env:rm",
                UserEventType.EnvVariableRead_cli_pull => "env-variable-read:cli:pull",
                UserEventType.EnvVariableRead_unknownSource => "env-variable-read:unknown-source",
                UserEventType.EnvVariableRead_v0_env_pull => "env-variable-read:v0:env:pull",
                UserEventType.EnvVariableRotated => "env-variable-rotated",
                UserEventType.FirewallBypassCreated => "firewall-bypass-created",
                UserEventType.FirewallBypassDeleted => "firewall-bypass-deleted",
                UserEventType.FirewallConfigModified => "firewall-config-modified",
                UserEventType.FirewallConfigPromoted => "firewall-config-promoted",
                UserEventType.FirewallConfigRemoved => "firewall-config-removed",
                UserEventType.FirewallManagedRulegroupUpdated => "firewall-managed-rulegroup-updated",
                UserEventType.FirewallManagedRulesetUpdated => "firewall-managed-ruleset-updated",
                UserEventType.Flag => "flag",
                UserEventType.FlagArchived => "flag-archived",
                UserEventType.FlagCreated => "flag-created",
                UserEventType.FlagDeleted => "flag-deleted",
                UserEventType.FlagUnarchived => "flag-unarchived",
                UserEventType.FlagUpdated => "flag-updated",
                UserEventType.FlagsExplorerSubscription => "flags-explorer-subscription",
                UserEventType.FlagsSdkKey => "flags-sdk-key",
                UserEventType.FlagsSdkKeyAdded => "flags-sdk-key-added",
                UserEventType.FlagsSdkKeyDeleted => "flags-sdk-key-deleted",
                UserEventType.FlagsSdkKeyRead => "flags-sdk-key-read",
                UserEventType.FlagsSegment => "flags-segment",
                UserEventType.FlagsSettings => "flags-settings",
                UserEventType.FlagsTransferred => "flags-transferred",
                UserEventType.GitAccountIntegrationLinkAdded => "git_account_integration_link_added",
                UserEventType.InstantRollbackCreated => "instant-rollback-created",
                UserEventType.IntegrationConfigurationOwnerChanged => "integration-configuration-owner-changed",
                UserEventType.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration-scope-change-confirmed",
                UserEventType.IntegrationConfigurationTransferInSuccess => "integration-configuration-transfer-in-success",
                UserEventType.IntegrationConfigurationTransferOutSuccess => "integration-configuration-transfer-out-success",
                UserEventType.IntegrationConfigurationsDisabled => "integration-configurations-disabled",
                UserEventType.IntegrationInstallationBillingPlanUpdated => "integration-installation-billing-plan-updated",
                UserEventType.IntegrationInstallationCompleted => "integration-installation-completed",
                UserEventType.IntegrationInstallationPermissionUpdated => "integration-installation-permission-updated",
                UserEventType.IntegrationInstallationRemoved => "integration-installation-removed",
                UserEventType.IntegrationResourceSqlQueryExecuted => "integration-resource-sql-query-executed",
                UserEventType.IntegrationScopeChanged => "integration-scope-changed",
                UserEventType.InvoiceModified => "invoice-modified",
                UserEventType.InvoiceRefunded => "invoice-refunded",
                UserEventType.LogDrainCreated => "log-drain-created",
                UserEventType.LogDrainDeleted => "log-drain-deleted",
                UserEventType.LogDrainDisabled => "log-drain-disabled",
                UserEventType.LogDrainEnabled => "log-drain-enabled",
                UserEventType.Login => "login",
                UserEventType.ManualDeploymentPromotionCreated => "manual-deployment-promotion-created",
                UserEventType.MarketplaceIntegrationAllowlistUpdated => "marketplace-integration-allowlist-updated",
                UserEventType.MicrofrontendGroupAdded => "microfrontend-group-added",
                UserEventType.MicrofrontendGroupDeleted => "microfrontend-group-deleted",
                UserEventType.MicrofrontendGroupUpdated => "microfrontend-group-updated",
                UserEventType.MicrofrontendProjectAddedToGroup => "microfrontend-project-added-to-group",
                UserEventType.MicrofrontendProjectRemovedFromGroup => "microfrontend-project-removed-from-group",
                UserEventType.MicrofrontendProjectUpdated => "microfrontend-project-updated",
                UserEventType.MonitoringAlertUpdated => "monitoring-alert-updated",
                UserEventType.MonitoringDisabled => "monitoring-disabled",
                UserEventType.MonitoringEnabled => "monitoring-enabled",
                UserEventType.OauthAppConnectionCreated => "oauth-app-connection-created",
                UserEventType.OauthAppConnectionRemoved => "oauth-app-connection-removed",
                UserEventType.OauthAppConnectionUpdated => "oauth-app-connection-updated",
                UserEventType.OauthAppCreated => "oauth-app-created",
                UserEventType.OauthAppDeleted => "oauth-app-deleted",
                UserEventType.OauthAppSecretDeleted => "oauth-app-secret-deleted",
                UserEventType.OauthAppSecretGenerated => "oauth-app-secret-generated",
                UserEventType.OauthAppTokenCreated => "oauth-app-token-created",
                UserEventType.OauthAppUpdated => "oauth-app-updated",
                UserEventType.ObservabilityDisabled => "observability-disabled",
                UserEventType.ObservabilityEnabled => "observability-enabled",
                UserEventType.ObservabilityPlusProjectDisabled => "observability-plus-project-disabled",
                UserEventType.ObservabilityPlusProjectEnabled => "observability-plus-project-enabled",
                UserEventType.OrganizationCreate => "organization-create",
                UserEventType.OrganizationDelete => "organization-delete",
                UserEventType.OrganizationSlugUpdate => "organization-slug-update",
                UserEventType.OrganizationTeamAdd => "organization-team-add",
                UserEventType.OwnerBlocked => "owner-blocked",
                UserEventType.OwnerSoftBlocked => "owner-soft-blocked",
                UserEventType.OwnerSoftUnblocked => "owner-soft-unblocked",
                UserEventType.OwnerUnblocked => "owner-unblocked",
                UserEventType.PageIntegrityConfigUpdated => "page-integrity-config-updated",
                UserEventType.PageIntegrityHeaderApproved => "page-integrity-header-approved",
                UserEventType.PageIntegrityHeaderRejected => "page-integrity-header-rejected",
                UserEventType.PageIntegrityInventoryCleared => "page-integrity-inventory-cleared",
                UserEventType.PageIntegrityResourceApproved => "page-integrity-resource-approved",
                UserEventType.PageIntegrityResourceDeleted => "page-integrity-resource-deleted",
                UserEventType.PageIntegrityResourceRejected => "page-integrity-resource-rejected",
                UserEventType.PasskeyCreated => "passkey-created",
                UserEventType.PasskeyDeleted => "passkey-deleted",
                UserEventType.PasskeyUpdated => "passkey-updated",
                UserEventType.PassportAccessGranted => "passport-access-granted",
                UserEventType.PasswordProtectionDisabled => "password-protection-disabled",
                UserEventType.PasswordProtectionEnabled => "password-protection-enabled",
                UserEventType.PaymentMethodAdded => "payment-method-added",
                UserEventType.PaymentMethodDefaultUpdated => "payment-method-default-updated",
                UserEventType.PaymentMethodRemoved => "payment-method-removed",
                UserEventType.Plan => "plan",
                UserEventType.PreviewDeploymentSuffixDisabled => "preview-deployment-suffix-disabled",
                UserEventType.PreviewDeploymentSuffixEnabled => "preview-deployment-suffix-enabled",
                UserEventType.PreviewDeploymentSuffixUpdate => "preview-deployment-suffix-update",
                UserEventType.PrivatelinkEndpointCreated => "privatelink-endpoint-created",
                UserEventType.PrivatelinkEndpointDeleted => "privatelink-endpoint-deleted",
                UserEventType.PrivatelinkEndpointUpdated => "privatelink-endpoint-updated",
                UserEventType.ProductionBranchUpdated => "production-branch-updated",
                UserEventType.ProjectAddAlias => "project-add-alias",
                UserEventType.ProjectAddRedirect => "project-add-redirect",
                UserEventType.ProjectAffectedProjectsDeploymentsUpdated => "project-affected-projects-deployments-updated",
                UserEventType.ProjectAliasConfiguredChange => "project-alias-configured-change",
                UserEventType.ProjectAnalyticsDisabled => "project-analytics-disabled",
                UserEventType.ProjectAnalyticsEnabled => "project-analytics-enabled",
                UserEventType.ProjectAutoAssignCustomProductionDomainsUpdated => "project-auto-assign-custom-production-domains-updated",
                UserEventType.ProjectAutomationBypass => "project-automation-bypass",
                UserEventType.ProjectAvatarUpdate => "project-avatar-update",
                UserEventType.ProjectBuildCommandUpdated => "project-build-command-updated",
                UserEventType.ProjectBuildLogsAndSourceProtectionUpdated => "project-build-logs-and-source-protection-updated",
                UserEventType.ProjectBuildMachineUpdated => "project-build-machine-updated",
                UserEventType.ProjectClientCertDelete => "project-client-cert-delete",
                UserEventType.ProjectClientCertUpload => "project-client-cert-upload",
                UserEventType.ProjectConnectConfigurations => "project-connect-configurations",
                UserEventType.ProjectConsolidatedGitCommitStatusUpdated => "project-consolidated-git-commit-status-updated",
                UserEventType.ProjectCreated => "project-created",
                UserEventType.ProjectCronJobsToggled => "project-cron-jobs-toggled",
                UserEventType.ProjectCustomEnvironmentCreated => "project-custom-environment-created",
                UserEventType.ProjectCustomEnvironmentDeleted => "project-custom-environment-deleted",
                UserEventType.ProjectCustomEnvironmentUpdated => "project-custom-environment-updated",
                UserEventType.ProjectCustomerSuccessCodeVisibilityUpdated => "project-customer-success-code-visibility-updated",
                UserEventType.ProjectDelete => "project-delete",
                UserEventType.ProjectDeploymentPolicyUpdated => "project-deployment-policy-updated",
                UserEventType.ProjectDeploymentRetentionUpdated => "project-deployment-retention-updated",
                UserEventType.ProjectDirectoryListing => "project-directory-listing",
                UserEventType.ProjectDomainDeleted => "project-domain-deleted",
                UserEventType.ProjectDomainMoved => "project-domain-moved",
                UserEventType.ProjectDomainUnverified => "project-domain-unverified",
                UserEventType.ProjectDomainUpdated => "project-domain-updated",
                UserEventType.ProjectDomainVerified => "project-domain-verified",
                UserEventType.ProjectElasticConcurrencyUpdated => "project-elastic-concurrency-updated",
                UserEventType.ProjectExpirationLocked => "project-expiration-locked",
                UserEventType.ProjectExpirationReached => "project-expiration-reached",
                UserEventType.ProjectExpirationScheduled => "project-expiration-scheduled",
                UserEventType.ProjectExpirationUnlocked => "project-expiration-unlocked",
                UserEventType.ProjectExternalRewriteCachingUpdated => "project-external-rewrite-caching-updated",
                UserEventType.ProjectFrameworkUpdated => "project-framework-updated",
                UserEventType.ProjectFunctionCpuMemory => "project-function-cpu-memory",
                UserEventType.ProjectFunctionFailover => "project-function-failover",
                UserEventType.ProjectFunctionMaxDuration => "project-function-max-duration",
                UserEventType.ProjectFunctionRegions => "project-function-regions",
                UserEventType.ProjectFunctionsBetaUpdated => "project-functions-beta-updated",
                UserEventType.ProjectFunctionsFluidDisabled => "project-functions-fluid-disabled",
                UserEventType.ProjectFunctionsFluidEnabled => "project-functions-fluid-enabled",
                UserEventType.ProjectGitCommitCommentsToggled => "project-git-commit-comments-toggled",
                UserEventType.ProjectGitCommitStatusToggled => "project-git-commit-status-toggled",
                UserEventType.ProjectGitCreateDeploymentsToggled => "project-git-create-deployments-toggled",
                UserEventType.ProjectGitForkProtectionUpdated => "project-git-fork-protection-updated",
                UserEventType.ProjectGitLfsToggled => "project-git-lfs-toggled",
                UserEventType.ProjectGitPrCommentsToggled => "project-git-pr-comments-toggled",
                UserEventType.ProjectGitRepositoryConnected => "project-git-repository-connected",
                UserEventType.ProjectGitRepositoryDisconnected => "project-git-repository-disconnected",
                UserEventType.ProjectGitRepositoryDispatchEventsToggled => "project-git-repository-dispatch-events-toggled",
                UserEventType.ProjectGitRequireVerifiedCommitsToggled => "project-git-require-verified-commits-toggled",
                UserEventType.ProjectIgnoredBuildStepUpdated => "project-ignored-build-step-updated",
                UserEventType.ProjectInstallCommandUpdated => "project-install-command-updated",
                UserEventType.ProjectMemberAdded => "project-member-added",
                UserEventType.ProjectMemberInvited => "project-member-invited",
                UserEventType.ProjectMemberRemoved => "project-member-removed",
                UserEventType.ProjectMemberRemovedBatch => "project-member-removed-batch",
                UserEventType.ProjectMemberUpdated => "project-member-updated",
                UserEventType.ProjectMoveInSuccess => "project-move-in-success",
                UserEventType.ProjectMoveOutFailed => "project-move-out-failed",
                UserEventType.ProjectMoveOutStarted => "project-move-out-started",
                UserEventType.ProjectMoveOutSuccess => "project-move-out-success",
                UserEventType.ProjectName => "project-name",
                UserEventType.ProjectNodeVersionUpdated => "project-node-version-updated",
                UserEventType.ProjectOidcIssuerModeUpdated => "project-oidc-issuer-mode-updated",
                UserEventType.ProjectOidcTokenCreated => "project-oidc-token-created",
                UserEventType.ProjectOptionsAllowlist => "project-options-allowlist",
                UserEventType.ProjectOutputDirectoryUpdated => "project-output-directory-updated",
                UserEventType.ProjectPassportUpdated => "project-passport-updated",
                UserEventType.ProjectPasswordProtection => "project-password-protection",
                UserEventType.ProjectPaused => "project-paused",
                UserEventType.ProjectPreviewDeploymentSuffix => "project-preview-deployment-suffix",
                UserEventType.ProjectPreviewEnvironmentBranchTrackingUpdated => "project-preview-environment-branch-tracking-updated",
                UserEventType.ProjectPrioritizeProductionBuildsUpdated => "project-prioritize-production-builds-updated",
                UserEventType.ProjectProgramEnrollmentChanged => "project-program-enrollment-changed",
                UserEventType.ProjectProtectedSourcemapsUpdated => "project-protected-sourcemaps-updated",
                UserEventType.ProjectRollbackDescriptionUpdated => "project-rollback-description-updated",
                UserEventType.ProjectRollingReleaseAborted => "project-rolling-release-aborted",
                UserEventType.ProjectRollingReleaseApproved => "project-rolling-release-approved",
                UserEventType.ProjectRollingReleaseCompleted => "project-rolling-release-completed",
                UserEventType.ProjectRollingReleaseConfigured => "project-rolling-release-configured",
                UserEventType.ProjectRollingReleaseContinued => "project-rolling-release-continued",
                UserEventType.ProjectRollingReleaseDisabled => "project-rolling-release-disabled",
                UserEventType.ProjectRollingReleaseEnabled => "project-rolling-release-enabled",
                UserEventType.ProjectRollingReleasePaused => "project-rolling-release-paused",
                UserEventType.ProjectRollingReleaseStarted => "project-rolling-release-started",
                UserEventType.ProjectRollingReleaseSuggestedActionsGenerated => "project-rolling-release-suggested-actions-generated",
                UserEventType.ProjectRollingReleaseTimer => "project-rolling-release-timer",
                UserEventType.ProjectRootDirectoryUpdated => "project-root-directory-updated",
                UserEventType.ProjectRoutesVersionPromoted => "project-routes-version-promoted",
                UserEventType.ProjectRoutesVersionRestored => "project-routes-version-restored",
                UserEventType.ProjectSandboxUrlProtectionUpdated => "project-sandbox-url-protection-updated",
                UserEventType.ProjectSkewProtectionAllowedDomainsUpdated => "project-skew-protection-allowed-domains-updated",
                UserEventType.ProjectSkewProtectionMaxAgeUpdated => "project-skew-protection-max-age-updated",
                UserEventType.ProjectSkewProtectionThresholdUpdated => "project-skew-protection-threshold-updated",
                UserEventType.ProjectSourceFilesOutsideRootDirectoryUpdated => "project-source-files-outside-root-directory-updated",
                UserEventType.ProjectSpeedInsightsDisabled => "project-speed-insights-disabled",
                UserEventType.ProjectSpeedInsightsEnabled => "project-speed-insights-enabled",
                UserEventType.ProjectSsoProtection => "project-sso-protection",
                UserEventType.ProjectStaticIpsUpdated => "project-static-ips-updated",
                UserEventType.ProjectTrustedIps => "project-trusted-ips",
                UserEventType.ProjectTrustedSources => "project-trusted-sources",
                UserEventType.ProjectUnpaused => "project-unpaused",
                UserEventType.ProjectWebAnalyticsDisabled => "project-web-analytics-disabled",
                UserEventType.ProjectWebAnalyticsEnabled => "project-web-analytics-enabled",
                UserEventType.ProtectedGitScopeAdded => "protected-git-scope-added",
                UserEventType.ProtectedGitScopeRemoved => "protected-git-scope-removed",
                UserEventType.RuntimeCachePurgeAll => "runtime-cache-purge-all",
                UserEventType.SandboxAliasAssigned => "sandbox-alias-assigned",
                UserEventType.SandboxAliasDelete => "sandbox-alias-delete",
                UserEventType.Scale => "scale",
                UserEventType.ScaleAuto => "scale-auto",
                UserEventType.SecondaryEmailAdded => "secondary-email-added",
                UserEventType.SecondaryEmailRemoved => "secondary-email-removed",
                UserEventType.SecondaryEmailVerified => "secondary-email-verified",
                UserEventType.SecretAdd => "secret-add",
                UserEventType.SecretDelete => "secret-delete",
                UserEventType.SecretRename => "secret-rename",
                UserEventType.SecurityListCreated => "security-list-created",
                UserEventType.SecurityListDeleted => "security-list-deleted",
                UserEventType.SecurityListUpdated => "security-list-updated",
                UserEventType.SecurityPlusUpdated => "security-plus-updated",
                UserEventType.SetBio => "set-bio",
                UserEventType.SetName => "set-name",
                UserEventType.SetProfiles => "set-profiles",
                UserEventType.SetScale => "set-scale",
                UserEventType.SharedEnvVariableCreate => "shared-env-variable-create",
                UserEventType.SharedEnvVariableDelete => "shared-env-variable-delete",
                UserEventType.SharedEnvVariableRead => "shared-env-variable-read",
                UserEventType.SharedEnvVariableUpdate => "shared-env-variable-update",
                UserEventType.ShowIpAddresses => "show-ip-addresses",
                UserEventType.Signup => "signup",
                UserEventType.SignupViaBitbucket => "signup-via-bitbucket",
                UserEventType.SignupViaGithub => "signup-via-github",
                UserEventType.SignupViaGitlab => "signup-via-gitlab",
                UserEventType.SpeedInsightsSettingsUpdated => "speed-insights-settings-updated",
                UserEventType.SpendCreated => "spend-created",
                UserEventType.SpendDeleted => "spend-deleted",
                UserEventType.SpendUpdated => "spend-updated",
                UserEventType.StorageAcceptTos => "storage-accept-tos",
                UserEventType.StorageAccessTokenSet => "storage-access-token-set",
                UserEventType.StorageAccessedDataBrowser => "storage-accessed-data-browser",
                UserEventType.StorageConnectProject => "storage-connect-project",
                UserEventType.StorageCreate => "storage-create",
                UserEventType.StorageDelete => "storage-delete",
                UserEventType.StorageDisconnectProject => "storage-disconnect-project",
                UserEventType.StorageDisconnectProjects => "storage-disconnect-projects",
                UserEventType.StorageInactiveStoreDeleted => "storage-inactive-store-deleted",
                UserEventType.StorageResetCredentials => "storage-reset-credentials",
                UserEventType.StorageResourceReplCommand => "storage-resource-repl-command",
                UserEventType.StorageSetLocked => "storage-set-locked",
                UserEventType.StorageTransferInSuccess => "storage-transfer-in-success",
                UserEventType.StorageTransferOutSuccess => "storage-transfer-out-success",
                UserEventType.StorageTransferRequestCreated => "storage-transfer-request-created",
                UserEventType.StorageUpdate => "storage-update",
                UserEventType.StorageUpdateProjectConnection => "storage-update-project-connection",
                UserEventType.StorageUpgradeProjectConnectionToOidc => "storage-upgrade-project-connection-to-oidc",
                UserEventType.StorageViewSecret => "storage-view-secret",
                UserEventType.StrictDeploymentProtectionSettings => "strict-deployment-protection-settings",
                UserEventType.StrictPasswordProtectionSettings => "strict-password-protection-settings",
                UserEventType.StrictShareableLinks => "strict-shareable-links",
                UserEventType.SubscriptionCreated => "subscription-created",
                UserEventType.SubscriptionProductAdded => "subscription-product-added",
                UserEventType.SubscriptionProductRemoved => "subscription-product-removed",
                UserEventType.SubscriptionUpdated => "subscription-updated",
                UserEventType.Team => "team",
                UserEventType.TeamAvatarUpdate => "team-avatar-update",
                UserEventType.TeamDefaultBuildMachineUpdated => "team-default-build-machine-updated",
                UserEventType.TeamDefaultPassportUpdated => "team-default-passport-updated",
                UserEventType.TeamDelete => "team-delete",
                UserEventType.TeamDeploymentPolicyUpdated => "team-deployment-policy-updated",
                UserEventType.TeamDomainVerificationCreated => "team-domain-verification-created",
                UserEventType.TeamDomainVerificationDeleted => "team-domain-verification-deleted",
                UserEventType.TeamDomainVerificationVerified => "team-domain-verification-verified",
                UserEventType.TeamEmailDomainUpdate => "team-email-domain-update",
                UserEventType.TeamEmuAccountSplit => "team-emu-account-split",
                UserEventType.TeamEmuUpdated => "team-emu-updated",
                UserEventType.TeamEndedTrial => "team-ended-trial",
                UserEventType.TeamFirewallConfigModified => "team-firewall-config-modified",
                UserEventType.TeamFirewallConfigPromoted => "team-firewall-config-promoted",
                UserEventType.TeamGitRepositoryDispatchEventsToggled => "team-git-repository-dispatch-events-toggled",
                UserEventType.TeamGitRequireVerifiedCommitsToggled => "team-git-require-verified-commits-toggled",
                UserEventType.TeamInviteBulkDelete => "team-invite-bulk-delete",
                UserEventType.TeamInviteCodeReset => "team-invite-code-reset",
                UserEventType.TeamInviteLinkCreated => "team-invite-link-created",
                UserEventType.TeamInviteLinkDeleted => "team-invite-link-deleted",
                UserEventType.TeamIpBlockingRulesCreated => "team-ip-blocking-rules-created",
                UserEventType.TeamIpBlockingRulesRemoved => "team-ip-blocking-rules-removed",
                UserEventType.TeamMemberAdd => "team-member-add",
                UserEventType.TeamMemberConfirmRequest => "team-member-confirm-request",
                UserEventType.TeamMemberDeclineRequest => "team-member-decline-request",
                UserEventType.TeamMemberDelete => "team-member-delete",
                UserEventType.TeamMemberEntitlementAdded => "team-member-entitlement-added",
                UserEventType.TeamMemberEntitlementCanceled => "team-member-entitlement-canceled",
                UserEventType.TeamMemberEntitlementReactivated => "team-member-entitlement-reactivated",
                UserEventType.TeamMemberEntitlementRemoved => "team-member-entitlement-removed",
                UserEventType.TeamMemberJoin => "team-member-join",
                UserEventType.TeamMemberLeave => "team-member-leave",
                UserEventType.TeamMemberRequestAccess => "team-member-request-access",
                UserEventType.TeamMemberRoleUpdate => "team-member-role-update",
                UserEventType.TeamMemberSsoAuthorizationAttempt => "team-member-sso-authorization-attempt",
                UserEventType.TeamMfaEnforcementUpdated => "team-mfa-enforcement-updated",
                UserEventType.TeamNameUpdate => "team-name-update",
                UserEventType.TeamPaidInvoice => "team-paid-invoice",
                UserEventType.TeamProgramEnrollmentChanged => "team-program-enrollment-changed",
                UserEventType.TeamRemoteCachingPurge => "team-remote-caching-purge",
                UserEventType.TeamRemoteCachingUpdate => "team-remote-caching-update",
                UserEventType.TeamSamlEnforced => "team-saml-enforced",
                UserEventType.TeamSamlRoles => "team-saml-roles",
                UserEventType.TeamSlugUpdate => "team-slug-update",
                UserEventType.TeamTokensInvalidated => "team-tokens-invalidated",
                UserEventType.UnlinkLoginConnection => "unlink-login-connection",
                UserEventType.UserDelete => "user-delete",
                UserEventType.UserEmuAccountArchived => "user-emu-account-archived",
                UserEventType.UserEmuAccountDeleted => "user-emu-account-deleted",
                UserEventType.UserEmuAccountRecovered => "user-emu-account-recovered",
                UserEventType.UserMfaChallengeVerified => "user-mfa-challenge-verified",
                UserEventType.UserMfaConfigurationUpdated => "user-mfa-configuration-updated",
                UserEventType.UserMfaRecoveryCodesRegenerated => "user-mfa-recovery-codes-regenerated",
                UserEventType.UserMfaRemoved => "user-mfa-removed",
                UserEventType.UserMfaSetupSkipped => "user-mfa-setup-skipped",
                UserEventType.UserMfaTotpVerificationStarted => "user-mfa-totp-verification-started",
                UserEventType.UserMfaTotpVerified => "user-mfa-totp-verified",
                UserEventType.UserPrimaryEmailUpdated => "user-primary-email-updated",
                UserEventType.UserTokenCreated => "user-token-created",
                UserEventType.UserTokenDeleted => "user-token-deleted",
                UserEventType.UserTokensDeleted => "user-tokens-deleted",
                UserEventType.Username => "username",
                UserEventType.V0ChatAiUsage => "v0-chat-ai-usage",
                UserEventType.V0ChatCreated => "v0-chat-created",
                UserEventType.V0ChatMessageSent => "v0-chat-message-sent",
                UserEventType.VcrImageDeleted => "vcr-image-deleted",
                UserEventType.VcrImagePushed => "vcr-image-pushed",
                UserEventType.VcrRepositoryCreated => "vcr-repository-created",
                UserEventType.VcrRepositoryDeleted => "vcr-repository-deleted",
                UserEventType.VercelAgentElevatedPermissionsApproved => "vercel-agent-elevated-permissions-approved",
                UserEventType.VercelAgentElevatedPermissionsRequested => "vercel-agent-elevated-permissions-requested",
                UserEventType.VercelAgentSessionCreated => "vercel-agent-session-created",
                UserEventType.VercelAgentTeamTrialCreditsApplied => "vercel-agent-team-trial-credits-applied",
                UserEventType.VercelAppInstallationRequestDismissed => "vercel-app-installation-request-dismissed",
                UserEventType.VercelAppInstallationRequested => "vercel-app-installation-requested",
                UserEventType.VercelAppInstallationUpdated => "vercel-app-installation-updated",
                UserEventType.VercelAppInstalled => "vercel-app-installed",
                UserEventType.VercelAppTokensRevoked => "vercel-app-tokens-revoked",
                UserEventType.VercelAppUninstalled => "vercel-app-uninstalled",
                UserEventType.VercelToolbar => "vercel-toolbar",
                UserEventType.VpcPeeringConnectionAccepted => "vpc-peering-connection-accepted",
                UserEventType.VpcPeeringConnectionDeleted => "vpc-peering-connection-deleted",
                UserEventType.VpcPeeringConnectionRejected => "vpc-peering-connection-rejected",
                UserEventType.VpcPeeringConnectionUpdated => "vpc-peering-connection-updated",
                UserEventType.VulnerabilityBannerDismissed => "vulnerability-banner-dismissed",
                UserEventType.WebAnalyticsTierUpdated => "web-analytics-tier-updated",
                UserEventType.WebhookCreated => "webhook-created",
                UserEventType.WebhookDeleted => "webhook-deleted",
                UserEventType.WebhookUpdated => "webhook-updated",
                UserEventType.WorkflowDeploymentKeyAccessed => "workflow-deployment-key-accessed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventType? ToEnum(string value)
        {
            return value switch
            {
                "access-group-created" => UserEventType.AccessGroupCreated,
                "access-group-deleted" => UserEventType.AccessGroupDeleted,
                "access-group-project-updated" => UserEventType.AccessGroupProjectUpdated,
                "access-group-updated" => UserEventType.AccessGroupUpdated,
                "access-group-user-added" => UserEventType.AccessGroupUserAdded,
                "access-group-user-removed" => UserEventType.AccessGroupUserRemoved,
                "agentic-provisioning-account-blocked" => UserEventType.AgenticProvisioningAccountBlocked,
                "agentic-provisioning-account-linked" => UserEventType.AgenticProvisioningAccountLinked,
                "agentic-provisioning-account-relinked" => UserEventType.AgenticProvisioningAccountRelinked,
                "agentic-provisioning-account-unlinked" => UserEventType.AgenticProvisioningAccountUnlinked,
                "agentic-provisioning-credentials-rotated" => UserEventType.AgenticProvisioningCredentialsRotated,
                "agentic-provisioning-plan-changed" => UserEventType.AgenticProvisioningPlanChanged,
                "agentic-provisioning-team-created" => UserEventType.AgenticProvisioningTeamCreated,
                "ai-alert-investigation" => UserEventType.AiAlertInvestigation,
                "ai-code-review" => UserEventType.AiCodeReview,
                "ai-gateway-api-key-created" => UserEventType.AiGatewayApiKeyCreated,
                "ai-gateway-api-key-deleted" => UserEventType.AiGatewayApiKeyDeleted,
                "ai-gateway-api-key-quota-updated" => UserEventType.AiGatewayApiKeyQuotaUpdated,
                "ai-gateway-byok-credential-created" => UserEventType.AiGatewayByokCredentialCreated,
                "ai-gateway-byok-credential-deleted" => UserEventType.AiGatewayByokCredentialDeleted,
                "ai-gateway-byok-credential-updated" => UserEventType.AiGatewayByokCredentialUpdated,
                "ai-gateway-guardrails-updated" => UserEventType.AiGatewayGuardrailsUpdated,
                "ai-gateway-model-allowlist-models-updated" => UserEventType.AiGatewayModelAllowlistModelsUpdated,
                "ai-gateway-model-allowlist-toggled" => UserEventType.AiGatewayModelAllowlistToggled,
                "ai-gateway-private-model-created" => UserEventType.AiGatewayPrivateModelCreated,
                "ai-gateway-private-model-deleted" => UserEventType.AiGatewayPrivateModelDeleted,
                "ai-gateway-private-model-updated" => UserEventType.AiGatewayPrivateModelUpdated,
                "ai-gateway-private-provider-created" => UserEventType.AiGatewayPrivateProviderCreated,
                "ai-gateway-private-provider-deleted" => UserEventType.AiGatewayPrivateProviderDeleted,
                "ai-gateway-private-provider-updated" => UserEventType.AiGatewayPrivateProviderUpdated,
                "ai-gateway-provider-allowlist-providers-updated" => UserEventType.AiGatewayProviderAllowlistProvidersUpdated,
                "ai-gateway-provider-allowlist-toggled" => UserEventType.AiGatewayProviderAllowlistToggled,
                "ai-gateway-rule-created" => UserEventType.AiGatewayRuleCreated,
                "ai-gateway-rule-deleted" => UserEventType.AiGatewayRuleDeleted,
                "ai-gateway-rule-updated" => UserEventType.AiGatewayRuleUpdated,
                "ai-gateway-virtual-model-config-archived" => UserEventType.AiGatewayVirtualModelConfigArchived,
                "ai-gateway-virtual-model-config-created" => UserEventType.AiGatewayVirtualModelConfigCreated,
                "ai-gateway-virtual-model-config-restored" => UserEventType.AiGatewayVirtualModelConfigRestored,
                "ai-gateway-virtual-model-config-updated" => UserEventType.AiGatewayVirtualModelConfigUpdated,
                "ai-omniagent" => UserEventType.AiOmniagent,
                "alert-investigation-project-allowlist-updated" => UserEventType.AlertInvestigationProjectAllowlistUpdated,
                "alert-rule-created" => UserEventType.AlertRuleCreated,
                "alert-rule-deleted" => UserEventType.AlertRuleDeleted,
                "alert-rule-updated" => UserEventType.AlertRuleUpdated,
                "alias" => UserEventType.Alias,
                "alias-chown" => UserEventType.AliasChown,
                "alias-delete" => UserEventType.AliasDelete,
                "alias-invite-created" => UserEventType.AliasInviteCreated,
                "alias-invite-joined" => UserEventType.AliasInviteJoined,
                "alias-invite-revoked" => UserEventType.AliasInviteRevoked,
                "alias-protection-bypass-created" => UserEventType.AliasProtectionBypassCreated,
                "alias-protection-bypass-exception" => UserEventType.AliasProtectionBypassException,
                "alias-protection-bypass-regenerated" => UserEventType.AliasProtectionBypassRegenerated,
                "alias-protection-bypass-revoked" => UserEventType.AliasProtectionBypassRevoked,
                "alias-system" => UserEventType.AliasSystem,
                "alias-user-scoped-access-denied" => UserEventType.AliasUserScopedAccessDenied,
                "alias-user-scoped-access-granted" => UserEventType.AliasUserScopedAccessGranted,
                "alias-user-scoped-access-requested" => UserEventType.AliasUserScopedAccessRequested,
                "alias-user-scoped-access-revoked" => UserEventType.AliasUserScopedAccessRevoked,
                "aliases-assigned" => UserEventType.AliasesAssigned,
                "attack-mode-disabled" => UserEventType.AttackModeDisabled,
                "attack-mode-enabled" => UserEventType.AttackModeEnabled,
                "audit-log-export-downloaded" => UserEventType.AuditLogExportDownloaded,
                "audit-log-export-requested" => UserEventType.AuditLogExportRequested,
                "authorize-git-deployment" => UserEventType.AuthorizeGitDeployment,
                "auto-expose-system-envs" => UserEventType.AutoExposeSystemEnvs,
                "avatar" => UserEventType.Avatar,
                "bulk-redirects-settings-updated" => UserEventType.BulkRedirectsSettingsUpdated,
                "bulk-redirects-version-promoted" => UserEventType.BulkRedirectsVersionPromoted,
                "bulk-redirects-version-restored" => UserEventType.BulkRedirectsVersionRestored,
                "cert" => UserEventType.Cert,
                "cert-autorenew" => UserEventType.CertAutorenew,
                "cert-chown" => UserEventType.CertChown,
                "cert-clone" => UserEventType.CertClone,
                "cert-delete" => UserEventType.CertDelete,
                "cert-renew" => UserEventType.CertRenew,
                "cert-replace" => UserEventType.CertReplace,
                "cert-system-create" => UserEventType.CertSystemCreate,
                "concurrent-builds-update" => UserEventType.ConcurrentBuildsUpdate,
                "connect-attach-project" => UserEventType.ConnectAttachProject,
                "connect-bitbucket" => UserEventType.ConnectBitbucket,
                "connect-bitbucket-app" => UserEventType.ConnectBitbucketApp,
                "connect-configuration-created" => UserEventType.ConnectConfigurationCreated,
                "connect-configuration-deleted" => UserEventType.ConnectConfigurationDeleted,
                "connect-configuration-link-updated" => UserEventType.ConnectConfigurationLinkUpdated,
                "connect-configuration-linked" => UserEventType.ConnectConfigurationLinked,
                "connect-configuration-unlinked" => UserEventType.ConnectConfigurationUnlinked,
                "connect-configuration-updated" => UserEventType.ConnectConfigurationUpdated,
                "connect-create-connector" => UserEventType.ConnectCreateConnector,
                "connect-delete-connector" => UserEventType.ConnectDeleteConnector,
                "connect-delete-installation" => UserEventType.ConnectDeleteInstallation,
                "connect-detach-project" => UserEventType.ConnectDetachProject,
                "connect-github" => UserEventType.ConnectGithub,
                "connect-github-custom-host" => UserEventType.ConnectGithubCustomHost,
                "connect-github-limited" => UserEventType.ConnectGithubLimited,
                "connect-gitlab" => UserEventType.ConnectGitlab,
                "connect-gitlab-app" => UserEventType.ConnectGitlabApp,
                "connect-import-tokens" => UserEventType.ConnectImportTokens,
                "connect-revoke-all-tokens" => UserEventType.ConnectRevokeAllTokens,
                "connect-update-connector" => UserEventType.ConnectUpdateConnector,
                "connect-update-trigger-destinations" => UserEventType.ConnectUpdateTriggerDestinations,
                "connect-upsert-installation" => UserEventType.ConnectUpsertInstallation,
                "custom-alert-created" => UserEventType.CustomAlertCreated,
                "custom-alert-deleted" => UserEventType.CustomAlertDeleted,
                "custom-alert-updated" => UserEventType.CustomAlertUpdated,
                "custom-suffix-clear" => UserEventType.CustomSuffixClear,
                "custom-suffix-disable" => UserEventType.CustomSuffixDisable,
                "custom-suffix-enable" => UserEventType.CustomSuffixEnable,
                "custom-suffix-pending" => UserEventType.CustomSuffixPending,
                "custom-suffix-ready" => UserEventType.CustomSuffixReady,
                "deploy-hook-created" => UserEventType.DeployHookCreated,
                "deploy-hook-deduped" => UserEventType.DeployHookDeduped,
                "deploy-hook-deleted" => UserEventType.DeployHookDeleted,
                "deploy-hook-processed" => UserEventType.DeployHookProcessed,
                "deployment" => UserEventType.Deployment,
                "deployment-check-created" => UserEventType.DeploymentCheckCreated,
                "deployment-check-deleted" => UserEventType.DeploymentCheckDeleted,
                "deployment-check-updated" => UserEventType.DeploymentCheckUpdated,
                "deployment-chown" => UserEventType.DeploymentChown,
                "deployment-creation-blocked" => UserEventType.DeploymentCreationBlocked,
                "deployment-delete" => UserEventType.DeploymentDelete,
                "deployment-policy-blocked" => UserEventType.DeploymentPolicyBlocked,
                "deployment-undeleted" => UserEventType.DeploymentUndeleted,
                "disabled-integration-installation-removed" => UserEventType.DisabledIntegrationInstallationRemoved,
                "disconnect-bitbucket-app" => UserEventType.DisconnectBitbucketApp,
                "disconnect-github" => UserEventType.DisconnectGithub,
                "disconnect-github-custom-host" => UserEventType.DisconnectGithubCustomHost,
                "disconnect-github-limited" => UserEventType.DisconnectGithubLimited,
                "disconnect-gitlab-app" => UserEventType.DisconnectGitlabApp,
                "dns-add" => UserEventType.DnsAdd,
                "dns-delete" => UserEventType.DnsDelete,
                "dns-record-internal" => UserEventType.DnsRecordInternal,
                "dns-update" => UserEventType.DnsUpdate,
                "dns-zonefile-import" => UserEventType.DnsZonefileImport,
                "domain" => UserEventType.Domain,
                "domain-buy" => UserEventType.DomainBuy,
                "domain-cdn" => UserEventType.DomainCdn,
                "domain-chown" => UserEventType.DomainChown,
                "domain-custom-ns-change" => UserEventType.DomainCustomNsChange,
                "domain-delegated" => UserEventType.DomainDelegated,
                "domain-delete" => UserEventType.DomainDelete,
                "domain-move-in" => UserEventType.DomainMoveIn,
                "domain-move-out" => UserEventType.DomainMoveOut,
                "domain-move-out-request-sent" => UserEventType.DomainMoveOutRequestSent,
                "domain-renew-change" => UserEventType.DomainRenewChange,
                "domain-service-type-updated" => UserEventType.DomainServiceTypeUpdated,
                "domain-transfer-in" => UserEventType.DomainTransferIn,
                "domain-transfer-in-canceled" => UserEventType.DomainTransferInCanceled,
                "domain-transfer-in-completed" => UserEventType.DomainTransferInCompleted,
                "domain-zone-change" => UserEventType.DomainZoneChange,
                "domain-zone-change-internal" => UserEventType.DomainZoneChangeInternal,
                "drain-created" => UserEventType.DrainCreated,
                "drain-deleted" => UserEventType.DrainDeleted,
                "drain-disabled" => UserEventType.DrainDisabled,
                "drain-enabled" => UserEventType.DrainEnabled,
                "drain-updated" => UserEventType.DrainUpdated,
                "edge-cache-dangerously-delete-by-src-images" => UserEventType.EdgeCacheDangerouslyDeleteBySrcImages,
                "edge-cache-dangerously-delete-by-tags" => UserEventType.EdgeCacheDangerouslyDeleteByTags,
                "edge-cache-invalidate-by-src-images" => UserEventType.EdgeCacheInvalidateBySrcImages,
                "edge-cache-invalidate-by-tags" => UserEventType.EdgeCacheInvalidateByTags,
                "edge-cache-purge-all" => UserEventType.EdgeCachePurgeAll,
                "edge-cache-rollback-purge" => UserEventType.EdgeCacheRollbackPurge,
                "edge-config-backup-restored" => UserEventType.EdgeConfigBackupRestored,
                "edge-config-created" => UserEventType.EdgeConfigCreated,
                "edge-config-deleted" => UserEventType.EdgeConfigDeleted,
                "edge-config-items-updated" => UserEventType.EdgeConfigItemsUpdated,
                "edge-config-schema-deleted" => UserEventType.EdgeConfigSchemaDeleted,
                "edge-config-schema-updated" => UserEventType.EdgeConfigSchemaUpdated,
                "edge-config-token-created" => UserEventType.EdgeConfigTokenCreated,
                "edge-config-token-deleted" => UserEventType.EdgeConfigTokenDeleted,
                "edge-config-transfer-in" => UserEventType.EdgeConfigTransferIn,
                "edge-config-transfer-out" => UserEventType.EdgeConfigTransferOut,
                "edge-config-updated" => UserEventType.EdgeConfigUpdated,
                "email" => UserEventType.Email,
                "email-notification-rule-removed" => UserEventType.EmailNotificationRuleRemoved,
                "email-notification-rule-updated" => UserEventType.EmailNotificationRuleUpdated,
                "emu-member-removed-unverified-domain" => UserEventType.EmuMemberRemovedUnverifiedDomain,
                "enforce-sensitive-environment-variables" => UserEventType.EnforceSensitiveEnvironmentVariables,
                "env-variable-add" => UserEventType.EnvVariableAdd,
                "env-variable-delete" => UserEventType.EnvVariableDelete,
                "env-variable-edit" => UserEventType.EnvVariableEdit,
                "env-variable-masked" => UserEventType.EnvVariableMasked,
                "env-variable-read" => UserEventType.EnvVariableRead,
                "env-variable-read:cli:dev" => UserEventType.EnvVariableRead_cli_dev,
                "env-variable-read:cli:env:add" => UserEventType.EnvVariableRead_cli_env_add,
                "env-variable-read:cli:env:ls" => UserEventType.EnvVariableRead_cli_env_ls,
                "env-variable-read:cli:env:pull" => UserEventType.EnvVariableRead_cli_env_pull,
                "env-variable-read:cli:env:rm" => UserEventType.EnvVariableRead_cli_env_rm,
                "env-variable-read:cli:pull" => UserEventType.EnvVariableRead_cli_pull,
                "env-variable-read:unknown-source" => UserEventType.EnvVariableRead_unknownSource,
                "env-variable-read:v0:env:pull" => UserEventType.EnvVariableRead_v0_env_pull,
                "env-variable-rotated" => UserEventType.EnvVariableRotated,
                "firewall-bypass-created" => UserEventType.FirewallBypassCreated,
                "firewall-bypass-deleted" => UserEventType.FirewallBypassDeleted,
                "firewall-config-modified" => UserEventType.FirewallConfigModified,
                "firewall-config-promoted" => UserEventType.FirewallConfigPromoted,
                "firewall-config-removed" => UserEventType.FirewallConfigRemoved,
                "firewall-managed-rulegroup-updated" => UserEventType.FirewallManagedRulegroupUpdated,
                "firewall-managed-ruleset-updated" => UserEventType.FirewallManagedRulesetUpdated,
                "flag" => UserEventType.Flag,
                "flag-archived" => UserEventType.FlagArchived,
                "flag-created" => UserEventType.FlagCreated,
                "flag-deleted" => UserEventType.FlagDeleted,
                "flag-unarchived" => UserEventType.FlagUnarchived,
                "flag-updated" => UserEventType.FlagUpdated,
                "flags-explorer-subscription" => UserEventType.FlagsExplorerSubscription,
                "flags-sdk-key" => UserEventType.FlagsSdkKey,
                "flags-sdk-key-added" => UserEventType.FlagsSdkKeyAdded,
                "flags-sdk-key-deleted" => UserEventType.FlagsSdkKeyDeleted,
                "flags-sdk-key-read" => UserEventType.FlagsSdkKeyRead,
                "flags-segment" => UserEventType.FlagsSegment,
                "flags-settings" => UserEventType.FlagsSettings,
                "flags-transferred" => UserEventType.FlagsTransferred,
                "git_account_integration_link_added" => UserEventType.GitAccountIntegrationLinkAdded,
                "instant-rollback-created" => UserEventType.InstantRollbackCreated,
                "integration-configuration-owner-changed" => UserEventType.IntegrationConfigurationOwnerChanged,
                "integration-configuration-scope-change-confirmed" => UserEventType.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration-transfer-in-success" => UserEventType.IntegrationConfigurationTransferInSuccess,
                "integration-configuration-transfer-out-success" => UserEventType.IntegrationConfigurationTransferOutSuccess,
                "integration-configurations-disabled" => UserEventType.IntegrationConfigurationsDisabled,
                "integration-installation-billing-plan-updated" => UserEventType.IntegrationInstallationBillingPlanUpdated,
                "integration-installation-completed" => UserEventType.IntegrationInstallationCompleted,
                "integration-installation-permission-updated" => UserEventType.IntegrationInstallationPermissionUpdated,
                "integration-installation-removed" => UserEventType.IntegrationInstallationRemoved,
                "integration-resource-sql-query-executed" => UserEventType.IntegrationResourceSqlQueryExecuted,
                "integration-scope-changed" => UserEventType.IntegrationScopeChanged,
                "invoice-modified" => UserEventType.InvoiceModified,
                "invoice-refunded" => UserEventType.InvoiceRefunded,
                "log-drain-created" => UserEventType.LogDrainCreated,
                "log-drain-deleted" => UserEventType.LogDrainDeleted,
                "log-drain-disabled" => UserEventType.LogDrainDisabled,
                "log-drain-enabled" => UserEventType.LogDrainEnabled,
                "login" => UserEventType.Login,
                "manual-deployment-promotion-created" => UserEventType.ManualDeploymentPromotionCreated,
                "marketplace-integration-allowlist-updated" => UserEventType.MarketplaceIntegrationAllowlistUpdated,
                "microfrontend-group-added" => UserEventType.MicrofrontendGroupAdded,
                "microfrontend-group-deleted" => UserEventType.MicrofrontendGroupDeleted,
                "microfrontend-group-updated" => UserEventType.MicrofrontendGroupUpdated,
                "microfrontend-project-added-to-group" => UserEventType.MicrofrontendProjectAddedToGroup,
                "microfrontend-project-removed-from-group" => UserEventType.MicrofrontendProjectRemovedFromGroup,
                "microfrontend-project-updated" => UserEventType.MicrofrontendProjectUpdated,
                "monitoring-alert-updated" => UserEventType.MonitoringAlertUpdated,
                "monitoring-disabled" => UserEventType.MonitoringDisabled,
                "monitoring-enabled" => UserEventType.MonitoringEnabled,
                "oauth-app-connection-created" => UserEventType.OauthAppConnectionCreated,
                "oauth-app-connection-removed" => UserEventType.OauthAppConnectionRemoved,
                "oauth-app-connection-updated" => UserEventType.OauthAppConnectionUpdated,
                "oauth-app-created" => UserEventType.OauthAppCreated,
                "oauth-app-deleted" => UserEventType.OauthAppDeleted,
                "oauth-app-secret-deleted" => UserEventType.OauthAppSecretDeleted,
                "oauth-app-secret-generated" => UserEventType.OauthAppSecretGenerated,
                "oauth-app-token-created" => UserEventType.OauthAppTokenCreated,
                "oauth-app-updated" => UserEventType.OauthAppUpdated,
                "observability-disabled" => UserEventType.ObservabilityDisabled,
                "observability-enabled" => UserEventType.ObservabilityEnabled,
                "observability-plus-project-disabled" => UserEventType.ObservabilityPlusProjectDisabled,
                "observability-plus-project-enabled" => UserEventType.ObservabilityPlusProjectEnabled,
                "organization-create" => UserEventType.OrganizationCreate,
                "organization-delete" => UserEventType.OrganizationDelete,
                "organization-slug-update" => UserEventType.OrganizationSlugUpdate,
                "organization-team-add" => UserEventType.OrganizationTeamAdd,
                "owner-blocked" => UserEventType.OwnerBlocked,
                "owner-soft-blocked" => UserEventType.OwnerSoftBlocked,
                "owner-soft-unblocked" => UserEventType.OwnerSoftUnblocked,
                "owner-unblocked" => UserEventType.OwnerUnblocked,
                "page-integrity-config-updated" => UserEventType.PageIntegrityConfigUpdated,
                "page-integrity-header-approved" => UserEventType.PageIntegrityHeaderApproved,
                "page-integrity-header-rejected" => UserEventType.PageIntegrityHeaderRejected,
                "page-integrity-inventory-cleared" => UserEventType.PageIntegrityInventoryCleared,
                "page-integrity-resource-approved" => UserEventType.PageIntegrityResourceApproved,
                "page-integrity-resource-deleted" => UserEventType.PageIntegrityResourceDeleted,
                "page-integrity-resource-rejected" => UserEventType.PageIntegrityResourceRejected,
                "passkey-created" => UserEventType.PasskeyCreated,
                "passkey-deleted" => UserEventType.PasskeyDeleted,
                "passkey-updated" => UserEventType.PasskeyUpdated,
                "passport-access-granted" => UserEventType.PassportAccessGranted,
                "password-protection-disabled" => UserEventType.PasswordProtectionDisabled,
                "password-protection-enabled" => UserEventType.PasswordProtectionEnabled,
                "payment-method-added" => UserEventType.PaymentMethodAdded,
                "payment-method-default-updated" => UserEventType.PaymentMethodDefaultUpdated,
                "payment-method-removed" => UserEventType.PaymentMethodRemoved,
                "plan" => UserEventType.Plan,
                "preview-deployment-suffix-disabled" => UserEventType.PreviewDeploymentSuffixDisabled,
                "preview-deployment-suffix-enabled" => UserEventType.PreviewDeploymentSuffixEnabled,
                "preview-deployment-suffix-update" => UserEventType.PreviewDeploymentSuffixUpdate,
                "privatelink-endpoint-created" => UserEventType.PrivatelinkEndpointCreated,
                "privatelink-endpoint-deleted" => UserEventType.PrivatelinkEndpointDeleted,
                "privatelink-endpoint-updated" => UserEventType.PrivatelinkEndpointUpdated,
                "production-branch-updated" => UserEventType.ProductionBranchUpdated,
                "project-add-alias" => UserEventType.ProjectAddAlias,
                "project-add-redirect" => UserEventType.ProjectAddRedirect,
                "project-affected-projects-deployments-updated" => UserEventType.ProjectAffectedProjectsDeploymentsUpdated,
                "project-alias-configured-change" => UserEventType.ProjectAliasConfiguredChange,
                "project-analytics-disabled" => UserEventType.ProjectAnalyticsDisabled,
                "project-analytics-enabled" => UserEventType.ProjectAnalyticsEnabled,
                "project-auto-assign-custom-production-domains-updated" => UserEventType.ProjectAutoAssignCustomProductionDomainsUpdated,
                "project-automation-bypass" => UserEventType.ProjectAutomationBypass,
                "project-avatar-update" => UserEventType.ProjectAvatarUpdate,
                "project-build-command-updated" => UserEventType.ProjectBuildCommandUpdated,
                "project-build-logs-and-source-protection-updated" => UserEventType.ProjectBuildLogsAndSourceProtectionUpdated,
                "project-build-machine-updated" => UserEventType.ProjectBuildMachineUpdated,
                "project-client-cert-delete" => UserEventType.ProjectClientCertDelete,
                "project-client-cert-upload" => UserEventType.ProjectClientCertUpload,
                "project-connect-configurations" => UserEventType.ProjectConnectConfigurations,
                "project-consolidated-git-commit-status-updated" => UserEventType.ProjectConsolidatedGitCommitStatusUpdated,
                "project-created" => UserEventType.ProjectCreated,
                "project-cron-jobs-toggled" => UserEventType.ProjectCronJobsToggled,
                "project-custom-environment-created" => UserEventType.ProjectCustomEnvironmentCreated,
                "project-custom-environment-deleted" => UserEventType.ProjectCustomEnvironmentDeleted,
                "project-custom-environment-updated" => UserEventType.ProjectCustomEnvironmentUpdated,
                "project-customer-success-code-visibility-updated" => UserEventType.ProjectCustomerSuccessCodeVisibilityUpdated,
                "project-delete" => UserEventType.ProjectDelete,
                "project-deployment-policy-updated" => UserEventType.ProjectDeploymentPolicyUpdated,
                "project-deployment-retention-updated" => UserEventType.ProjectDeploymentRetentionUpdated,
                "project-directory-listing" => UserEventType.ProjectDirectoryListing,
                "project-domain-deleted" => UserEventType.ProjectDomainDeleted,
                "project-domain-moved" => UserEventType.ProjectDomainMoved,
                "project-domain-unverified" => UserEventType.ProjectDomainUnverified,
                "project-domain-updated" => UserEventType.ProjectDomainUpdated,
                "project-domain-verified" => UserEventType.ProjectDomainVerified,
                "project-elastic-concurrency-updated" => UserEventType.ProjectElasticConcurrencyUpdated,
                "project-expiration-locked" => UserEventType.ProjectExpirationLocked,
                "project-expiration-reached" => UserEventType.ProjectExpirationReached,
                "project-expiration-scheduled" => UserEventType.ProjectExpirationScheduled,
                "project-expiration-unlocked" => UserEventType.ProjectExpirationUnlocked,
                "project-external-rewrite-caching-updated" => UserEventType.ProjectExternalRewriteCachingUpdated,
                "project-framework-updated" => UserEventType.ProjectFrameworkUpdated,
                "project-function-cpu-memory" => UserEventType.ProjectFunctionCpuMemory,
                "project-function-failover" => UserEventType.ProjectFunctionFailover,
                "project-function-max-duration" => UserEventType.ProjectFunctionMaxDuration,
                "project-function-regions" => UserEventType.ProjectFunctionRegions,
                "project-functions-beta-updated" => UserEventType.ProjectFunctionsBetaUpdated,
                "project-functions-fluid-disabled" => UserEventType.ProjectFunctionsFluidDisabled,
                "project-functions-fluid-enabled" => UserEventType.ProjectFunctionsFluidEnabled,
                "project-git-commit-comments-toggled" => UserEventType.ProjectGitCommitCommentsToggled,
                "project-git-commit-status-toggled" => UserEventType.ProjectGitCommitStatusToggled,
                "project-git-create-deployments-toggled" => UserEventType.ProjectGitCreateDeploymentsToggled,
                "project-git-fork-protection-updated" => UserEventType.ProjectGitForkProtectionUpdated,
                "project-git-lfs-toggled" => UserEventType.ProjectGitLfsToggled,
                "project-git-pr-comments-toggled" => UserEventType.ProjectGitPrCommentsToggled,
                "project-git-repository-connected" => UserEventType.ProjectGitRepositoryConnected,
                "project-git-repository-disconnected" => UserEventType.ProjectGitRepositoryDisconnected,
                "project-git-repository-dispatch-events-toggled" => UserEventType.ProjectGitRepositoryDispatchEventsToggled,
                "project-git-require-verified-commits-toggled" => UserEventType.ProjectGitRequireVerifiedCommitsToggled,
                "project-ignored-build-step-updated" => UserEventType.ProjectIgnoredBuildStepUpdated,
                "project-install-command-updated" => UserEventType.ProjectInstallCommandUpdated,
                "project-member-added" => UserEventType.ProjectMemberAdded,
                "project-member-invited" => UserEventType.ProjectMemberInvited,
                "project-member-removed" => UserEventType.ProjectMemberRemoved,
                "project-member-removed-batch" => UserEventType.ProjectMemberRemovedBatch,
                "project-member-updated" => UserEventType.ProjectMemberUpdated,
                "project-move-in-success" => UserEventType.ProjectMoveInSuccess,
                "project-move-out-failed" => UserEventType.ProjectMoveOutFailed,
                "project-move-out-started" => UserEventType.ProjectMoveOutStarted,
                "project-move-out-success" => UserEventType.ProjectMoveOutSuccess,
                "project-name" => UserEventType.ProjectName,
                "project-node-version-updated" => UserEventType.ProjectNodeVersionUpdated,
                "project-oidc-issuer-mode-updated" => UserEventType.ProjectOidcIssuerModeUpdated,
                "project-oidc-token-created" => UserEventType.ProjectOidcTokenCreated,
                "project-options-allowlist" => UserEventType.ProjectOptionsAllowlist,
                "project-output-directory-updated" => UserEventType.ProjectOutputDirectoryUpdated,
                "project-passport-updated" => UserEventType.ProjectPassportUpdated,
                "project-password-protection" => UserEventType.ProjectPasswordProtection,
                "project-paused" => UserEventType.ProjectPaused,
                "project-preview-deployment-suffix" => UserEventType.ProjectPreviewDeploymentSuffix,
                "project-preview-environment-branch-tracking-updated" => UserEventType.ProjectPreviewEnvironmentBranchTrackingUpdated,
                "project-prioritize-production-builds-updated" => UserEventType.ProjectPrioritizeProductionBuildsUpdated,
                "project-program-enrollment-changed" => UserEventType.ProjectProgramEnrollmentChanged,
                "project-protected-sourcemaps-updated" => UserEventType.ProjectProtectedSourcemapsUpdated,
                "project-rollback-description-updated" => UserEventType.ProjectRollbackDescriptionUpdated,
                "project-rolling-release-aborted" => UserEventType.ProjectRollingReleaseAborted,
                "project-rolling-release-approved" => UserEventType.ProjectRollingReleaseApproved,
                "project-rolling-release-completed" => UserEventType.ProjectRollingReleaseCompleted,
                "project-rolling-release-configured" => UserEventType.ProjectRollingReleaseConfigured,
                "project-rolling-release-continued" => UserEventType.ProjectRollingReleaseContinued,
                "project-rolling-release-disabled" => UserEventType.ProjectRollingReleaseDisabled,
                "project-rolling-release-enabled" => UserEventType.ProjectRollingReleaseEnabled,
                "project-rolling-release-paused" => UserEventType.ProjectRollingReleasePaused,
                "project-rolling-release-started" => UserEventType.ProjectRollingReleaseStarted,
                "project-rolling-release-suggested-actions-generated" => UserEventType.ProjectRollingReleaseSuggestedActionsGenerated,
                "project-rolling-release-timer" => UserEventType.ProjectRollingReleaseTimer,
                "project-root-directory-updated" => UserEventType.ProjectRootDirectoryUpdated,
                "project-routes-version-promoted" => UserEventType.ProjectRoutesVersionPromoted,
                "project-routes-version-restored" => UserEventType.ProjectRoutesVersionRestored,
                "project-sandbox-url-protection-updated" => UserEventType.ProjectSandboxUrlProtectionUpdated,
                "project-skew-protection-allowed-domains-updated" => UserEventType.ProjectSkewProtectionAllowedDomainsUpdated,
                "project-skew-protection-max-age-updated" => UserEventType.ProjectSkewProtectionMaxAgeUpdated,
                "project-skew-protection-threshold-updated" => UserEventType.ProjectSkewProtectionThresholdUpdated,
                "project-source-files-outside-root-directory-updated" => UserEventType.ProjectSourceFilesOutsideRootDirectoryUpdated,
                "project-speed-insights-disabled" => UserEventType.ProjectSpeedInsightsDisabled,
                "project-speed-insights-enabled" => UserEventType.ProjectSpeedInsightsEnabled,
                "project-sso-protection" => UserEventType.ProjectSsoProtection,
                "project-static-ips-updated" => UserEventType.ProjectStaticIpsUpdated,
                "project-trusted-ips" => UserEventType.ProjectTrustedIps,
                "project-trusted-sources" => UserEventType.ProjectTrustedSources,
                "project-unpaused" => UserEventType.ProjectUnpaused,
                "project-web-analytics-disabled" => UserEventType.ProjectWebAnalyticsDisabled,
                "project-web-analytics-enabled" => UserEventType.ProjectWebAnalyticsEnabled,
                "protected-git-scope-added" => UserEventType.ProtectedGitScopeAdded,
                "protected-git-scope-removed" => UserEventType.ProtectedGitScopeRemoved,
                "runtime-cache-purge-all" => UserEventType.RuntimeCachePurgeAll,
                "sandbox-alias-assigned" => UserEventType.SandboxAliasAssigned,
                "sandbox-alias-delete" => UserEventType.SandboxAliasDelete,
                "scale" => UserEventType.Scale,
                "scale-auto" => UserEventType.ScaleAuto,
                "secondary-email-added" => UserEventType.SecondaryEmailAdded,
                "secondary-email-removed" => UserEventType.SecondaryEmailRemoved,
                "secondary-email-verified" => UserEventType.SecondaryEmailVerified,
                "secret-add" => UserEventType.SecretAdd,
                "secret-delete" => UserEventType.SecretDelete,
                "secret-rename" => UserEventType.SecretRename,
                "security-list-created" => UserEventType.SecurityListCreated,
                "security-list-deleted" => UserEventType.SecurityListDeleted,
                "security-list-updated" => UserEventType.SecurityListUpdated,
                "security-plus-updated" => UserEventType.SecurityPlusUpdated,
                "set-bio" => UserEventType.SetBio,
                "set-name" => UserEventType.SetName,
                "set-profiles" => UserEventType.SetProfiles,
                "set-scale" => UserEventType.SetScale,
                "shared-env-variable-create" => UserEventType.SharedEnvVariableCreate,
                "shared-env-variable-delete" => UserEventType.SharedEnvVariableDelete,
                "shared-env-variable-read" => UserEventType.SharedEnvVariableRead,
                "shared-env-variable-update" => UserEventType.SharedEnvVariableUpdate,
                "show-ip-addresses" => UserEventType.ShowIpAddresses,
                "signup" => UserEventType.Signup,
                "signup-via-bitbucket" => UserEventType.SignupViaBitbucket,
                "signup-via-github" => UserEventType.SignupViaGithub,
                "signup-via-gitlab" => UserEventType.SignupViaGitlab,
                "speed-insights-settings-updated" => UserEventType.SpeedInsightsSettingsUpdated,
                "spend-created" => UserEventType.SpendCreated,
                "spend-deleted" => UserEventType.SpendDeleted,
                "spend-updated" => UserEventType.SpendUpdated,
                "storage-accept-tos" => UserEventType.StorageAcceptTos,
                "storage-access-token-set" => UserEventType.StorageAccessTokenSet,
                "storage-accessed-data-browser" => UserEventType.StorageAccessedDataBrowser,
                "storage-connect-project" => UserEventType.StorageConnectProject,
                "storage-create" => UserEventType.StorageCreate,
                "storage-delete" => UserEventType.StorageDelete,
                "storage-disconnect-project" => UserEventType.StorageDisconnectProject,
                "storage-disconnect-projects" => UserEventType.StorageDisconnectProjects,
                "storage-inactive-store-deleted" => UserEventType.StorageInactiveStoreDeleted,
                "storage-reset-credentials" => UserEventType.StorageResetCredentials,
                "storage-resource-repl-command" => UserEventType.StorageResourceReplCommand,
                "storage-set-locked" => UserEventType.StorageSetLocked,
                "storage-transfer-in-success" => UserEventType.StorageTransferInSuccess,
                "storage-transfer-out-success" => UserEventType.StorageTransferOutSuccess,
                "storage-transfer-request-created" => UserEventType.StorageTransferRequestCreated,
                "storage-update" => UserEventType.StorageUpdate,
                "storage-update-project-connection" => UserEventType.StorageUpdateProjectConnection,
                "storage-upgrade-project-connection-to-oidc" => UserEventType.StorageUpgradeProjectConnectionToOidc,
                "storage-view-secret" => UserEventType.StorageViewSecret,
                "strict-deployment-protection-settings" => UserEventType.StrictDeploymentProtectionSettings,
                "strict-password-protection-settings" => UserEventType.StrictPasswordProtectionSettings,
                "strict-shareable-links" => UserEventType.StrictShareableLinks,
                "subscription-created" => UserEventType.SubscriptionCreated,
                "subscription-product-added" => UserEventType.SubscriptionProductAdded,
                "subscription-product-removed" => UserEventType.SubscriptionProductRemoved,
                "subscription-updated" => UserEventType.SubscriptionUpdated,
                "team" => UserEventType.Team,
                "team-avatar-update" => UserEventType.TeamAvatarUpdate,
                "team-default-build-machine-updated" => UserEventType.TeamDefaultBuildMachineUpdated,
                "team-default-passport-updated" => UserEventType.TeamDefaultPassportUpdated,
                "team-delete" => UserEventType.TeamDelete,
                "team-deployment-policy-updated" => UserEventType.TeamDeploymentPolicyUpdated,
                "team-domain-verification-created" => UserEventType.TeamDomainVerificationCreated,
                "team-domain-verification-deleted" => UserEventType.TeamDomainVerificationDeleted,
                "team-domain-verification-verified" => UserEventType.TeamDomainVerificationVerified,
                "team-email-domain-update" => UserEventType.TeamEmailDomainUpdate,
                "team-emu-account-split" => UserEventType.TeamEmuAccountSplit,
                "team-emu-updated" => UserEventType.TeamEmuUpdated,
                "team-ended-trial" => UserEventType.TeamEndedTrial,
                "team-firewall-config-modified" => UserEventType.TeamFirewallConfigModified,
                "team-firewall-config-promoted" => UserEventType.TeamFirewallConfigPromoted,
                "team-git-repository-dispatch-events-toggled" => UserEventType.TeamGitRepositoryDispatchEventsToggled,
                "team-git-require-verified-commits-toggled" => UserEventType.TeamGitRequireVerifiedCommitsToggled,
                "team-invite-bulk-delete" => UserEventType.TeamInviteBulkDelete,
                "team-invite-code-reset" => UserEventType.TeamInviteCodeReset,
                "team-invite-link-created" => UserEventType.TeamInviteLinkCreated,
                "team-invite-link-deleted" => UserEventType.TeamInviteLinkDeleted,
                "team-ip-blocking-rules-created" => UserEventType.TeamIpBlockingRulesCreated,
                "team-ip-blocking-rules-removed" => UserEventType.TeamIpBlockingRulesRemoved,
                "team-member-add" => UserEventType.TeamMemberAdd,
                "team-member-confirm-request" => UserEventType.TeamMemberConfirmRequest,
                "team-member-decline-request" => UserEventType.TeamMemberDeclineRequest,
                "team-member-delete" => UserEventType.TeamMemberDelete,
                "team-member-entitlement-added" => UserEventType.TeamMemberEntitlementAdded,
                "team-member-entitlement-canceled" => UserEventType.TeamMemberEntitlementCanceled,
                "team-member-entitlement-reactivated" => UserEventType.TeamMemberEntitlementReactivated,
                "team-member-entitlement-removed" => UserEventType.TeamMemberEntitlementRemoved,
                "team-member-join" => UserEventType.TeamMemberJoin,
                "team-member-leave" => UserEventType.TeamMemberLeave,
                "team-member-request-access" => UserEventType.TeamMemberRequestAccess,
                "team-member-role-update" => UserEventType.TeamMemberRoleUpdate,
                "team-member-sso-authorization-attempt" => UserEventType.TeamMemberSsoAuthorizationAttempt,
                "team-mfa-enforcement-updated" => UserEventType.TeamMfaEnforcementUpdated,
                "team-name-update" => UserEventType.TeamNameUpdate,
                "team-paid-invoice" => UserEventType.TeamPaidInvoice,
                "team-program-enrollment-changed" => UserEventType.TeamProgramEnrollmentChanged,
                "team-remote-caching-purge" => UserEventType.TeamRemoteCachingPurge,
                "team-remote-caching-update" => UserEventType.TeamRemoteCachingUpdate,
                "team-saml-enforced" => UserEventType.TeamSamlEnforced,
                "team-saml-roles" => UserEventType.TeamSamlRoles,
                "team-slug-update" => UserEventType.TeamSlugUpdate,
                "team-tokens-invalidated" => UserEventType.TeamTokensInvalidated,
                "unlink-login-connection" => UserEventType.UnlinkLoginConnection,
                "user-delete" => UserEventType.UserDelete,
                "user-emu-account-archived" => UserEventType.UserEmuAccountArchived,
                "user-emu-account-deleted" => UserEventType.UserEmuAccountDeleted,
                "user-emu-account-recovered" => UserEventType.UserEmuAccountRecovered,
                "user-mfa-challenge-verified" => UserEventType.UserMfaChallengeVerified,
                "user-mfa-configuration-updated" => UserEventType.UserMfaConfigurationUpdated,
                "user-mfa-recovery-codes-regenerated" => UserEventType.UserMfaRecoveryCodesRegenerated,
                "user-mfa-removed" => UserEventType.UserMfaRemoved,
                "user-mfa-setup-skipped" => UserEventType.UserMfaSetupSkipped,
                "user-mfa-totp-verification-started" => UserEventType.UserMfaTotpVerificationStarted,
                "user-mfa-totp-verified" => UserEventType.UserMfaTotpVerified,
                "user-primary-email-updated" => UserEventType.UserPrimaryEmailUpdated,
                "user-token-created" => UserEventType.UserTokenCreated,
                "user-token-deleted" => UserEventType.UserTokenDeleted,
                "user-tokens-deleted" => UserEventType.UserTokensDeleted,
                "username" => UserEventType.Username,
                "v0-chat-ai-usage" => UserEventType.V0ChatAiUsage,
                "v0-chat-created" => UserEventType.V0ChatCreated,
                "v0-chat-message-sent" => UserEventType.V0ChatMessageSent,
                "vcr-image-deleted" => UserEventType.VcrImageDeleted,
                "vcr-image-pushed" => UserEventType.VcrImagePushed,
                "vcr-repository-created" => UserEventType.VcrRepositoryCreated,
                "vcr-repository-deleted" => UserEventType.VcrRepositoryDeleted,
                "vercel-agent-elevated-permissions-approved" => UserEventType.VercelAgentElevatedPermissionsApproved,
                "vercel-agent-elevated-permissions-requested" => UserEventType.VercelAgentElevatedPermissionsRequested,
                "vercel-agent-session-created" => UserEventType.VercelAgentSessionCreated,
                "vercel-agent-team-trial-credits-applied" => UserEventType.VercelAgentTeamTrialCreditsApplied,
                "vercel-app-installation-request-dismissed" => UserEventType.VercelAppInstallationRequestDismissed,
                "vercel-app-installation-requested" => UserEventType.VercelAppInstallationRequested,
                "vercel-app-installation-updated" => UserEventType.VercelAppInstallationUpdated,
                "vercel-app-installed" => UserEventType.VercelAppInstalled,
                "vercel-app-tokens-revoked" => UserEventType.VercelAppTokensRevoked,
                "vercel-app-uninstalled" => UserEventType.VercelAppUninstalled,
                "vercel-toolbar" => UserEventType.VercelToolbar,
                "vpc-peering-connection-accepted" => UserEventType.VpcPeeringConnectionAccepted,
                "vpc-peering-connection-deleted" => UserEventType.VpcPeeringConnectionDeleted,
                "vpc-peering-connection-rejected" => UserEventType.VpcPeeringConnectionRejected,
                "vpc-peering-connection-updated" => UserEventType.VpcPeeringConnectionUpdated,
                "vulnerability-banner-dismissed" => UserEventType.VulnerabilityBannerDismissed,
                "web-analytics-tier-updated" => UserEventType.WebAnalyticsTierUpdated,
                "webhook-created" => UserEventType.WebhookCreated,
                "webhook-deleted" => UserEventType.WebhookDeleted,
                "webhook-updated" => UserEventType.WebhookUpdated,
                "workflow-deployment-key-accessed" => UserEventType.WorkflowDeploymentKeyAccessed,
                _ => null,
            };
        }
    }
}