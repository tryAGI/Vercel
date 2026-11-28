
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The webhooks events<br/>
    /// Example: deployment.created
    /// </summary>
    public enum AutoSDKShared1b53b94256f1b3c4
    {
        /// <summary>
        ///
        /// </summary>
        AiGatewayAutoReloadLimitReached,
        /// <summary>
        ///
        /// </summary>
        AiGatewayBalanceDepleted,
        /// <summary>
        ///
        /// </summary>
        AiGatewayBudgetUpdated,
        /// <summary>
        ///
        /// </summary>
        AlertsTriggered,
        /// <summary>
        ///
        /// </summary>
        BotidAnomaly,
        /// <summary>
        ///
        /// </summary>
        BudgetReached,
        /// <summary>
        ///
        /// </summary>
        CommentCreated,
        /// <summary>
        ///
        /// </summary>
        CommentDeleted,
        /// <summary>
        ///
        /// </summary>
        CommentMentioned,
        /// <summary>
        ///
        /// </summary>
        CommentReactionAdded,
        /// <summary>
        ///
        /// </summary>
        CommentReactionRemoved,
        /// <summary>
        ///
        /// </summary>
        CommentResolved,
        /// <summary>
        ///
        /// </summary>
        CommentUnresolved,
        /// <summary>
        ///
        /// </summary>
        CommentUpdated,
        /// <summary>
        ///
        /// </summary>
        Deployment,
        /// <summary>
        ///
        /// </summary>
        DeploymentCanceledHyphen,
        /// <summary>
        ///
        /// </summary>
        DeploymentCheckRerequestedHyphen,
        /// <summary>
        ///
        /// </summary>
        DeploymentChecksCompleted,
        /// <summary>
        ///
        /// </summary>
        DeploymentErrorHyphen,
        /// <summary>
        ///
        /// </summary>
        DeploymentPreparedHyphen,
        /// <summary>
        ///
        /// </summary>
        DeploymentReadyHyphen,
        /// <summary>
        ///
        /// </summary>
        DeploymentBlocked,
        /// <summary>
        ///
        /// </summary>
        DeploymentBuildRequested,
        /// <summary>
        ///
        /// </summary>
        DeploymentCanceled,
        /// <summary>
        ///
        /// </summary>
        DeploymentCheckRerequested,
        /// <summary>
        ///
        /// </summary>
        DeploymentCheckrunCancel,
        /// <summary>
        ///
        /// </summary>
        DeploymentCheckrunStart,
        /// <summary>
        ///
        /// </summary>
        DeploymentChecksFailed,
        /// <summary>
        ///
        /// </summary>
        DeploymentChecksSucceeded,
        /// <summary>
        ///
        /// </summary>
        DeploymentCleanup,
        /// <summary>
        ///
        /// </summary>
        DeploymentCreated,
        /// <summary>
        ///
        /// </summary>
        DeploymentError,
        /// <summary>
        ///
        /// </summary>
        DeploymentIntegrationActionCancel,
        /// <summary>
        ///
        /// </summary>
        DeploymentIntegrationActionCleanup,
        /// <summary>
        ///
        /// </summary>
        DeploymentIntegrationActionStart,
        /// <summary>
        ///
        /// </summary>
        DeploymentPromoted,
        /// <summary>
        ///
        /// </summary>
        DeploymentReady,
        /// <summary>
        ///
        /// </summary>
        DeploymentRollback,
        /// <summary>
        ///
        /// </summary>
        DeploymentSucceeded,
        /// <summary>
        ///
        /// </summary>
        DomainCreatedHyphen,
        /// <summary>
        ///
        /// </summary>
        DomainAutoRenewChanged,
        /// <summary>
        ///
        /// </summary>
        DomainCertificateAdd,
        /// <summary>
        ///
        /// </summary>
        DomainCertificateAddFailed,
        /// <summary>
        ///
        /// </summary>
        DomainCertificateDeleted,
        /// <summary>
        ///
        /// </summary>
        DomainCertificateRenew,
        /// <summary>
        ///
        /// </summary>
        DomainCertificateRenewFailed,
        /// <summary>
        ///
        /// </summary>
        DomainCreated,
        /// <summary>
        ///
        /// </summary>
        DomainDnsRecordsChanged,
        /// <summary>
        ///
        /// </summary>
        DomainRenewal,
        /// <summary>
        ///
        /// </summary>
        DomainRenewalFailed,
        /// <summary>
        ///
        /// </summary>
        DomainTransferInCompleted,
        /// <summary>
        ///
        /// </summary>
        DomainTransferInFailed,
        /// <summary>
        ///
        /// </summary>
        DomainTransferInStarted,
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
        FirewallAttack,
        /// <summary>
        ///
        /// </summary>
        FirewallCustomRuleAnomaly,
        /// <summary>
        ///
        /// </summary>
        FirewallSystemRuleAnomaly,
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
        FlagSegmentCreated,
        /// <summary>
        ///
        /// </summary>
        FlagSegmentDeleted,
        /// <summary>
        ///
        /// </summary>
        FlagSegmentUpdated,
        /// <summary>
        ///
        /// </summary>
        FlagUpdated,
        /// <summary>
        ///
        /// </summary>
        FunctionArchivalRequired,
        /// <summary>
        ///
        /// </summary>
        FunctionRemovalRequired,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationPermissionUpdatedHyphen,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationRemovedHyphen,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationScopeChangeConfirmedHyphen,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationPermissionUpgraded,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationRemoved,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationScopeChangeConfirmed,
        /// <summary>
        ///
        /// </summary>
        IntegrationConfigurationTransferred,
        /// <summary>
        ///
        /// </summary>
        IntegrationResourceProjectConnected,
        /// <summary>
        ///
        /// </summary>
        IntegrationResourceProjectDisconnected,
        /// <summary>
        ///
        /// </summary>
        MarketplaceInvoiceCreated,
        /// <summary>
        ///
        /// </summary>
        MarketplaceInvoiceNotpaid,
        /// <summary>
        ///
        /// </summary>
        MarketplaceInvoiceOverdue,
        /// <summary>
        ///
        /// </summary>
        MarketplaceInvoicePaid,
        /// <summary>
        ///
        /// </summary>
        MarketplaceInvoiceRefunded,
        /// <summary>
        ///
        /// </summary>
        MarketplaceMemberChanged,
        /// <summary>
        ///
        /// </summary>
        MessageCreated,
        /// <summary>
        ///
        /// </summary>
        MessageDeleted,
        /// <summary>
        ///
        /// </summary>
        MessageMentioned,
        /// <summary>
        ///
        /// </summary>
        MessageReactionAdded,
        /// <summary>
        ///
        /// </summary>
        MessageReactionRemoved,
        /// <summary>
        ///
        /// </summary>
        MessageUpdated,
        /// <summary>
        ///
        /// </summary>
        ObservabilityAnomaly,
        /// <summary>
        ///
        /// </summary>
        ObservabilityAnomalyError,
        /// <summary>
        ///
        /// </summary>
        ObservabilityErrorAnomaly,
        /// <summary>
        ///
        /// </summary>
        ObservabilityUsageAnomaly,
        /// <summary>
        ///
        /// </summary>
        PageIntegrityConnectSrcDetected,
        /// <summary>
        ///
        /// </summary>
        PageIntegrityHeaderChanged,
        /// <summary>
        ///
        /// </summary>
        PageIntegrityRuntimeWarningDetected,
        /// <summary>
        ///
        /// </summary>
        PageIntegrityScriptChanged,
        /// <summary>
        ///
        /// </summary>
        PageIntegrityScriptDetected,
        /// <summary>
        ///
        /// </summary>
        ProjectCreatedHyphen,
        /// <summary>
        ///
        /// </summary>
        ProjectRemovedHyphen,
        /// <summary>
        ///
        /// </summary>
        ProjectCreated,
        /// <summary>
        ///
        /// </summary>
        ProjectDomainCreated,
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
        ProjectEnvVariableCreated,
        /// <summary>
        ///
        /// </summary>
        ProjectEnvVariableDeleted,
        /// <summary>
        ///
        /// </summary>
        ProjectEnvVariableUpdated,
        /// <summary>
        ///
        /// </summary>
        ProjectRemoved,
        /// <summary>
        ///
        /// </summary>
        ProjectRenamed,
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
        ProjectRollingReleaseStarted,
        /// <summary>
        ///
        /// </summary>
        SandboxSessionExpiring,
        /// <summary>
        ///
        /// </summary>
        SandboxSessionStarted,
        /// <summary>
        ///
        /// </summary>
        SandboxSessionStopped,
        /// <summary>
        ///
        /// </summary>
        TestWebhook,
        /// <summary>
        ///
        /// </summary>
        ThreadResolved,
        /// <summary>
        ///
        /// </summary>
        ThreadUnresolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1b53b94256f1b3c4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1b53b94256f1b3c4 value)
        {
            return value switch
            {
                AutoSDKShared1b53b94256f1b3c4.AiGatewayAutoReloadLimitReached => "ai-gateway.auto-reload.limit-reached",
                AutoSDKShared1b53b94256f1b3c4.AiGatewayBalanceDepleted => "ai-gateway.balance-depleted",
                AutoSDKShared1b53b94256f1b3c4.AiGatewayBudgetUpdated => "ai-gateway.budget.updated",
                AutoSDKShared1b53b94256f1b3c4.AlertsTriggered => "alerts.triggered",
                AutoSDKShared1b53b94256f1b3c4.BotidAnomaly => "botid.anomaly",
                AutoSDKShared1b53b94256f1b3c4.BudgetReached => "budget.reached",
                AutoSDKShared1b53b94256f1b3c4.CommentCreated => "comment.created",
                AutoSDKShared1b53b94256f1b3c4.CommentDeleted => "comment.deleted",
                AutoSDKShared1b53b94256f1b3c4.CommentMentioned => "comment.mentioned",
                AutoSDKShared1b53b94256f1b3c4.CommentReactionAdded => "comment.reaction-added",
                AutoSDKShared1b53b94256f1b3c4.CommentReactionRemoved => "comment.reaction-removed",
                AutoSDKShared1b53b94256f1b3c4.CommentResolved => "comment.resolved",
                AutoSDKShared1b53b94256f1b3c4.CommentUnresolved => "comment.unresolved",
                AutoSDKShared1b53b94256f1b3c4.CommentUpdated => "comment.updated",
                AutoSDKShared1b53b94256f1b3c4.Deployment => "deployment",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCanceledHyphen => "deployment-canceled",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCheckRerequestedHyphen => "deployment-check-rerequested",
                AutoSDKShared1b53b94256f1b3c4.DeploymentChecksCompleted => "deployment-checks-completed",
                AutoSDKShared1b53b94256f1b3c4.DeploymentErrorHyphen => "deployment-error",
                AutoSDKShared1b53b94256f1b3c4.DeploymentPreparedHyphen => "deployment-prepared",
                AutoSDKShared1b53b94256f1b3c4.DeploymentReadyHyphen => "deployment-ready",
                AutoSDKShared1b53b94256f1b3c4.DeploymentBlocked => "deployment.blocked",
                AutoSDKShared1b53b94256f1b3c4.DeploymentBuildRequested => "deployment.build-requested",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCanceled => "deployment.canceled",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCheckRerequested => "deployment.check-rerequested",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCheckrunCancel => "deployment.checkrun.cancel",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCheckrunStart => "deployment.checkrun.start",
                AutoSDKShared1b53b94256f1b3c4.DeploymentChecksFailed => "deployment.checks.failed",
                AutoSDKShared1b53b94256f1b3c4.DeploymentChecksSucceeded => "deployment.checks.succeeded",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCleanup => "deployment.cleanup",
                AutoSDKShared1b53b94256f1b3c4.DeploymentCreated => "deployment.created",
                AutoSDKShared1b53b94256f1b3c4.DeploymentError => "deployment.error",
                AutoSDKShared1b53b94256f1b3c4.DeploymentIntegrationActionCancel => "deployment.integration.action.cancel",
                AutoSDKShared1b53b94256f1b3c4.DeploymentIntegrationActionCleanup => "deployment.integration.action.cleanup",
                AutoSDKShared1b53b94256f1b3c4.DeploymentIntegrationActionStart => "deployment.integration.action.start",
                AutoSDKShared1b53b94256f1b3c4.DeploymentPromoted => "deployment.promoted",
                AutoSDKShared1b53b94256f1b3c4.DeploymentReady => "deployment.ready",
                AutoSDKShared1b53b94256f1b3c4.DeploymentRollback => "deployment.rollback",
                AutoSDKShared1b53b94256f1b3c4.DeploymentSucceeded => "deployment.succeeded",
                AutoSDKShared1b53b94256f1b3c4.DomainCreatedHyphen => "domain-created",
                AutoSDKShared1b53b94256f1b3c4.DomainAutoRenewChanged => "domain.auto-renew.changed",
                AutoSDKShared1b53b94256f1b3c4.DomainCertificateAdd => "domain.certificate.add",
                AutoSDKShared1b53b94256f1b3c4.DomainCertificateAddFailed => "domain.certificate.add.failed",
                AutoSDKShared1b53b94256f1b3c4.DomainCertificateDeleted => "domain.certificate.deleted",
                AutoSDKShared1b53b94256f1b3c4.DomainCertificateRenew => "domain.certificate.renew",
                AutoSDKShared1b53b94256f1b3c4.DomainCertificateRenewFailed => "domain.certificate.renew.failed",
                AutoSDKShared1b53b94256f1b3c4.DomainCreated => "domain.created",
                AutoSDKShared1b53b94256f1b3c4.DomainDnsRecordsChanged => "domain.dns.records.changed",
                AutoSDKShared1b53b94256f1b3c4.DomainRenewal => "domain.renewal",
                AutoSDKShared1b53b94256f1b3c4.DomainRenewalFailed => "domain.renewal.failed",
                AutoSDKShared1b53b94256f1b3c4.DomainTransferInCompleted => "domain.transfer-in.completed",
                AutoSDKShared1b53b94256f1b3c4.DomainTransferInFailed => "domain.transfer-in.failed",
                AutoSDKShared1b53b94256f1b3c4.DomainTransferInStarted => "domain.transfer-in.started",
                AutoSDKShared1b53b94256f1b3c4.EdgeConfigCreated => "edge-config.created",
                AutoSDKShared1b53b94256f1b3c4.EdgeConfigDeleted => "edge-config.deleted",
                AutoSDKShared1b53b94256f1b3c4.EdgeConfigItemsUpdated => "edge-config.items.updated",
                AutoSDKShared1b53b94256f1b3c4.FirewallAttack => "firewall.attack",
                AutoSDKShared1b53b94256f1b3c4.FirewallCustomRuleAnomaly => "firewall.custom-rule-anomaly",
                AutoSDKShared1b53b94256f1b3c4.FirewallSystemRuleAnomaly => "firewall.system-rule-anomaly",
                AutoSDKShared1b53b94256f1b3c4.FlagCreated => "flag.created",
                AutoSDKShared1b53b94256f1b3c4.FlagDeleted => "flag.deleted",
                AutoSDKShared1b53b94256f1b3c4.FlagSegmentCreated => "flag.segment.created",
                AutoSDKShared1b53b94256f1b3c4.FlagSegmentDeleted => "flag.segment.deleted",
                AutoSDKShared1b53b94256f1b3c4.FlagSegmentUpdated => "flag.segment.updated",
                AutoSDKShared1b53b94256f1b3c4.FlagUpdated => "flag.updated",
                AutoSDKShared1b53b94256f1b3c4.FunctionArchivalRequired => "function.archival-required",
                AutoSDKShared1b53b94256f1b3c4.FunctionRemovalRequired => "function.removal-required",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationPermissionUpdatedHyphen => "integration-configuration-permission-updated",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationRemovedHyphen => "integration-configuration-removed",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationScopeChangeConfirmedHyphen => "integration-configuration-scope-change-confirmed",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationPermissionUpgraded => "integration-configuration.permission-upgraded",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationRemoved => "integration-configuration.removed",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration.scope-change-confirmed",
                AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationTransferred => "integration-configuration.transferred",
                AutoSDKShared1b53b94256f1b3c4.IntegrationResourceProjectConnected => "integration-resource.project-connected",
                AutoSDKShared1b53b94256f1b3c4.IntegrationResourceProjectDisconnected => "integration-resource.project-disconnected",
                AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceCreated => "marketplace.invoice.created",
                AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceNotpaid => "marketplace.invoice.notpaid",
                AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceOverdue => "marketplace.invoice.overdue",
                AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoicePaid => "marketplace.invoice.paid",
                AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceRefunded => "marketplace.invoice.refunded",
                AutoSDKShared1b53b94256f1b3c4.MarketplaceMemberChanged => "marketplace.member.changed",
                AutoSDKShared1b53b94256f1b3c4.MessageCreated => "message.created",
                AutoSDKShared1b53b94256f1b3c4.MessageDeleted => "message.deleted",
                AutoSDKShared1b53b94256f1b3c4.MessageMentioned => "message.mentioned",
                AutoSDKShared1b53b94256f1b3c4.MessageReactionAdded => "message.reaction-added",
                AutoSDKShared1b53b94256f1b3c4.MessageReactionRemoved => "message.reaction-removed",
                AutoSDKShared1b53b94256f1b3c4.MessageUpdated => "message.updated",
                AutoSDKShared1b53b94256f1b3c4.ObservabilityAnomaly => "observability.anomaly",
                AutoSDKShared1b53b94256f1b3c4.ObservabilityAnomalyError => "observability.anomaly-error",
                AutoSDKShared1b53b94256f1b3c4.ObservabilityErrorAnomaly => "observability.error-anomaly",
                AutoSDKShared1b53b94256f1b3c4.ObservabilityUsageAnomaly => "observability.usage-anomaly",
                AutoSDKShared1b53b94256f1b3c4.PageIntegrityConnectSrcDetected => "page-integrity.connect-src.detected",
                AutoSDKShared1b53b94256f1b3c4.PageIntegrityHeaderChanged => "page-integrity.header.changed",
                AutoSDKShared1b53b94256f1b3c4.PageIntegrityRuntimeWarningDetected => "page-integrity.runtime-warning.detected",
                AutoSDKShared1b53b94256f1b3c4.PageIntegrityScriptChanged => "page-integrity.script.changed",
                AutoSDKShared1b53b94256f1b3c4.PageIntegrityScriptDetected => "page-integrity.script.detected",
                AutoSDKShared1b53b94256f1b3c4.ProjectCreatedHyphen => "project-created",
                AutoSDKShared1b53b94256f1b3c4.ProjectRemovedHyphen => "project-removed",
                AutoSDKShared1b53b94256f1b3c4.ProjectCreated => "project.created",
                AutoSDKShared1b53b94256f1b3c4.ProjectDomainCreated => "project.domain.created",
                AutoSDKShared1b53b94256f1b3c4.ProjectDomainDeleted => "project.domain.deleted",
                AutoSDKShared1b53b94256f1b3c4.ProjectDomainMoved => "project.domain.moved",
                AutoSDKShared1b53b94256f1b3c4.ProjectDomainUnverified => "project.domain.unverified",
                AutoSDKShared1b53b94256f1b3c4.ProjectDomainUpdated => "project.domain.updated",
                AutoSDKShared1b53b94256f1b3c4.ProjectDomainVerified => "project.domain.verified",
                AutoSDKShared1b53b94256f1b3c4.ProjectEnvVariableCreated => "project.env-variable.created",
                AutoSDKShared1b53b94256f1b3c4.ProjectEnvVariableDeleted => "project.env-variable.deleted",
                AutoSDKShared1b53b94256f1b3c4.ProjectEnvVariableUpdated => "project.env-variable.updated",
                AutoSDKShared1b53b94256f1b3c4.ProjectRemoved => "project.removed",
                AutoSDKShared1b53b94256f1b3c4.ProjectRenamed => "project.renamed",
                AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseAborted => "project.rolling-release.aborted",
                AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseApproved => "project.rolling-release.approved",
                AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseCompleted => "project.rolling-release.completed",
                AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseStarted => "project.rolling-release.started",
                AutoSDKShared1b53b94256f1b3c4.SandboxSessionExpiring => "sandbox.session.expiring",
                AutoSDKShared1b53b94256f1b3c4.SandboxSessionStarted => "sandbox.session.started",
                AutoSDKShared1b53b94256f1b3c4.SandboxSessionStopped => "sandbox.session.stopped",
                AutoSDKShared1b53b94256f1b3c4.TestWebhook => "test-webhook",
                AutoSDKShared1b53b94256f1b3c4.ThreadResolved => "thread.resolved",
                AutoSDKShared1b53b94256f1b3c4.ThreadUnresolved => "thread.unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1b53b94256f1b3c4? ToEnum(string value)
        {
            return value switch
            {
                "ai-gateway.auto-reload.limit-reached" => AutoSDKShared1b53b94256f1b3c4.AiGatewayAutoReloadLimitReached,
                "ai-gateway.balance-depleted" => AutoSDKShared1b53b94256f1b3c4.AiGatewayBalanceDepleted,
                "ai-gateway.budget.updated" => AutoSDKShared1b53b94256f1b3c4.AiGatewayBudgetUpdated,
                "alerts.triggered" => AutoSDKShared1b53b94256f1b3c4.AlertsTriggered,
                "botid.anomaly" => AutoSDKShared1b53b94256f1b3c4.BotidAnomaly,
                "budget.reached" => AutoSDKShared1b53b94256f1b3c4.BudgetReached,
                "comment.created" => AutoSDKShared1b53b94256f1b3c4.CommentCreated,
                "comment.deleted" => AutoSDKShared1b53b94256f1b3c4.CommentDeleted,
                "comment.mentioned" => AutoSDKShared1b53b94256f1b3c4.CommentMentioned,
                "comment.reaction-added" => AutoSDKShared1b53b94256f1b3c4.CommentReactionAdded,
                "comment.reaction-removed" => AutoSDKShared1b53b94256f1b3c4.CommentReactionRemoved,
                "comment.resolved" => AutoSDKShared1b53b94256f1b3c4.CommentResolved,
                "comment.unresolved" => AutoSDKShared1b53b94256f1b3c4.CommentUnresolved,
                "comment.updated" => AutoSDKShared1b53b94256f1b3c4.CommentUpdated,
                "deployment" => AutoSDKShared1b53b94256f1b3c4.Deployment,
                "deployment-canceled" => AutoSDKShared1b53b94256f1b3c4.DeploymentCanceledHyphen,
                "deployment-check-rerequested" => AutoSDKShared1b53b94256f1b3c4.DeploymentCheckRerequestedHyphen,
                "deployment-checks-completed" => AutoSDKShared1b53b94256f1b3c4.DeploymentChecksCompleted,
                "deployment-error" => AutoSDKShared1b53b94256f1b3c4.DeploymentErrorHyphen,
                "deployment-prepared" => AutoSDKShared1b53b94256f1b3c4.DeploymentPreparedHyphen,
                "deployment-ready" => AutoSDKShared1b53b94256f1b3c4.DeploymentReadyHyphen,
                "deployment.blocked" => AutoSDKShared1b53b94256f1b3c4.DeploymentBlocked,
                "deployment.build-requested" => AutoSDKShared1b53b94256f1b3c4.DeploymentBuildRequested,
                "deployment.canceled" => AutoSDKShared1b53b94256f1b3c4.DeploymentCanceled,
                "deployment.check-rerequested" => AutoSDKShared1b53b94256f1b3c4.DeploymentCheckRerequested,
                "deployment.checkrun.cancel" => AutoSDKShared1b53b94256f1b3c4.DeploymentCheckrunCancel,
                "deployment.checkrun.start" => AutoSDKShared1b53b94256f1b3c4.DeploymentCheckrunStart,
                "deployment.checks.failed" => AutoSDKShared1b53b94256f1b3c4.DeploymentChecksFailed,
                "deployment.checks.succeeded" => AutoSDKShared1b53b94256f1b3c4.DeploymentChecksSucceeded,
                "deployment.cleanup" => AutoSDKShared1b53b94256f1b3c4.DeploymentCleanup,
                "deployment.created" => AutoSDKShared1b53b94256f1b3c4.DeploymentCreated,
                "deployment.error" => AutoSDKShared1b53b94256f1b3c4.DeploymentError,
                "deployment.integration.action.cancel" => AutoSDKShared1b53b94256f1b3c4.DeploymentIntegrationActionCancel,
                "deployment.integration.action.cleanup" => AutoSDKShared1b53b94256f1b3c4.DeploymentIntegrationActionCleanup,
                "deployment.integration.action.start" => AutoSDKShared1b53b94256f1b3c4.DeploymentIntegrationActionStart,
                "deployment.promoted" => AutoSDKShared1b53b94256f1b3c4.DeploymentPromoted,
                "deployment.ready" => AutoSDKShared1b53b94256f1b3c4.DeploymentReady,
                "deployment.rollback" => AutoSDKShared1b53b94256f1b3c4.DeploymentRollback,
                "deployment.succeeded" => AutoSDKShared1b53b94256f1b3c4.DeploymentSucceeded,
                "domain-created" => AutoSDKShared1b53b94256f1b3c4.DomainCreatedHyphen,
                "domain.auto-renew.changed" => AutoSDKShared1b53b94256f1b3c4.DomainAutoRenewChanged,
                "domain.certificate.add" => AutoSDKShared1b53b94256f1b3c4.DomainCertificateAdd,
                "domain.certificate.add.failed" => AutoSDKShared1b53b94256f1b3c4.DomainCertificateAddFailed,
                "domain.certificate.deleted" => AutoSDKShared1b53b94256f1b3c4.DomainCertificateDeleted,
                "domain.certificate.renew" => AutoSDKShared1b53b94256f1b3c4.DomainCertificateRenew,
                "domain.certificate.renew.failed" => AutoSDKShared1b53b94256f1b3c4.DomainCertificateRenewFailed,
                "domain.created" => AutoSDKShared1b53b94256f1b3c4.DomainCreated,
                "domain.dns.records.changed" => AutoSDKShared1b53b94256f1b3c4.DomainDnsRecordsChanged,
                "domain.renewal" => AutoSDKShared1b53b94256f1b3c4.DomainRenewal,
                "domain.renewal.failed" => AutoSDKShared1b53b94256f1b3c4.DomainRenewalFailed,
                "domain.transfer-in.completed" => AutoSDKShared1b53b94256f1b3c4.DomainTransferInCompleted,
                "domain.transfer-in.failed" => AutoSDKShared1b53b94256f1b3c4.DomainTransferInFailed,
                "domain.transfer-in.started" => AutoSDKShared1b53b94256f1b3c4.DomainTransferInStarted,
                "edge-config.created" => AutoSDKShared1b53b94256f1b3c4.EdgeConfigCreated,
                "edge-config.deleted" => AutoSDKShared1b53b94256f1b3c4.EdgeConfigDeleted,
                "edge-config.items.updated" => AutoSDKShared1b53b94256f1b3c4.EdgeConfigItemsUpdated,
                "firewall.attack" => AutoSDKShared1b53b94256f1b3c4.FirewallAttack,
                "firewall.custom-rule-anomaly" => AutoSDKShared1b53b94256f1b3c4.FirewallCustomRuleAnomaly,
                "firewall.system-rule-anomaly" => AutoSDKShared1b53b94256f1b3c4.FirewallSystemRuleAnomaly,
                "flag.created" => AutoSDKShared1b53b94256f1b3c4.FlagCreated,
                "flag.deleted" => AutoSDKShared1b53b94256f1b3c4.FlagDeleted,
                "flag.segment.created" => AutoSDKShared1b53b94256f1b3c4.FlagSegmentCreated,
                "flag.segment.deleted" => AutoSDKShared1b53b94256f1b3c4.FlagSegmentDeleted,
                "flag.segment.updated" => AutoSDKShared1b53b94256f1b3c4.FlagSegmentUpdated,
                "flag.updated" => AutoSDKShared1b53b94256f1b3c4.FlagUpdated,
                "function.archival-required" => AutoSDKShared1b53b94256f1b3c4.FunctionArchivalRequired,
                "function.removal-required" => AutoSDKShared1b53b94256f1b3c4.FunctionRemovalRequired,
                "integration-configuration-permission-updated" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationPermissionUpdatedHyphen,
                "integration-configuration-removed" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationRemovedHyphen,
                "integration-configuration-scope-change-confirmed" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationScopeChangeConfirmedHyphen,
                "integration-configuration.permission-upgraded" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationPermissionUpgraded,
                "integration-configuration.removed" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationRemoved,
                "integration-configuration.scope-change-confirmed" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration.transferred" => AutoSDKShared1b53b94256f1b3c4.IntegrationConfigurationTransferred,
                "integration-resource.project-connected" => AutoSDKShared1b53b94256f1b3c4.IntegrationResourceProjectConnected,
                "integration-resource.project-disconnected" => AutoSDKShared1b53b94256f1b3c4.IntegrationResourceProjectDisconnected,
                "marketplace.invoice.created" => AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceCreated,
                "marketplace.invoice.notpaid" => AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceNotpaid,
                "marketplace.invoice.overdue" => AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceOverdue,
                "marketplace.invoice.paid" => AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoicePaid,
                "marketplace.invoice.refunded" => AutoSDKShared1b53b94256f1b3c4.MarketplaceInvoiceRefunded,
                "marketplace.member.changed" => AutoSDKShared1b53b94256f1b3c4.MarketplaceMemberChanged,
                "message.created" => AutoSDKShared1b53b94256f1b3c4.MessageCreated,
                "message.deleted" => AutoSDKShared1b53b94256f1b3c4.MessageDeleted,
                "message.mentioned" => AutoSDKShared1b53b94256f1b3c4.MessageMentioned,
                "message.reaction-added" => AutoSDKShared1b53b94256f1b3c4.MessageReactionAdded,
                "message.reaction-removed" => AutoSDKShared1b53b94256f1b3c4.MessageReactionRemoved,
                "message.updated" => AutoSDKShared1b53b94256f1b3c4.MessageUpdated,
                "observability.anomaly" => AutoSDKShared1b53b94256f1b3c4.ObservabilityAnomaly,
                "observability.anomaly-error" => AutoSDKShared1b53b94256f1b3c4.ObservabilityAnomalyError,
                "observability.error-anomaly" => AutoSDKShared1b53b94256f1b3c4.ObservabilityErrorAnomaly,
                "observability.usage-anomaly" => AutoSDKShared1b53b94256f1b3c4.ObservabilityUsageAnomaly,
                "page-integrity.connect-src.detected" => AutoSDKShared1b53b94256f1b3c4.PageIntegrityConnectSrcDetected,
                "page-integrity.header.changed" => AutoSDKShared1b53b94256f1b3c4.PageIntegrityHeaderChanged,
                "page-integrity.runtime-warning.detected" => AutoSDKShared1b53b94256f1b3c4.PageIntegrityRuntimeWarningDetected,
                "page-integrity.script.changed" => AutoSDKShared1b53b94256f1b3c4.PageIntegrityScriptChanged,
                "page-integrity.script.detected" => AutoSDKShared1b53b94256f1b3c4.PageIntegrityScriptDetected,
                "project-created" => AutoSDKShared1b53b94256f1b3c4.ProjectCreatedHyphen,
                "project-removed" => AutoSDKShared1b53b94256f1b3c4.ProjectRemovedHyphen,
                "project.created" => AutoSDKShared1b53b94256f1b3c4.ProjectCreated,
                "project.domain.created" => AutoSDKShared1b53b94256f1b3c4.ProjectDomainCreated,
                "project.domain.deleted" => AutoSDKShared1b53b94256f1b3c4.ProjectDomainDeleted,
                "project.domain.moved" => AutoSDKShared1b53b94256f1b3c4.ProjectDomainMoved,
                "project.domain.unverified" => AutoSDKShared1b53b94256f1b3c4.ProjectDomainUnverified,
                "project.domain.updated" => AutoSDKShared1b53b94256f1b3c4.ProjectDomainUpdated,
                "project.domain.verified" => AutoSDKShared1b53b94256f1b3c4.ProjectDomainVerified,
                "project.env-variable.created" => AutoSDKShared1b53b94256f1b3c4.ProjectEnvVariableCreated,
                "project.env-variable.deleted" => AutoSDKShared1b53b94256f1b3c4.ProjectEnvVariableDeleted,
                "project.env-variable.updated" => AutoSDKShared1b53b94256f1b3c4.ProjectEnvVariableUpdated,
                "project.removed" => AutoSDKShared1b53b94256f1b3c4.ProjectRemoved,
                "project.renamed" => AutoSDKShared1b53b94256f1b3c4.ProjectRenamed,
                "project.rolling-release.aborted" => AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseAborted,
                "project.rolling-release.approved" => AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseApproved,
                "project.rolling-release.completed" => AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseCompleted,
                "project.rolling-release.started" => AutoSDKShared1b53b94256f1b3c4.ProjectRollingReleaseStarted,
                "sandbox.session.expiring" => AutoSDKShared1b53b94256f1b3c4.SandboxSessionExpiring,
                "sandbox.session.started" => AutoSDKShared1b53b94256f1b3c4.SandboxSessionStarted,
                "sandbox.session.stopped" => AutoSDKShared1b53b94256f1b3c4.SandboxSessionStopped,
                "test-webhook" => AutoSDKShared1b53b94256f1b3c4.TestWebhook,
                "thread.resolved" => AutoSDKShared1b53b94256f1b3c4.ThreadResolved,
                "thread.unresolved" => AutoSDKShared1b53b94256f1b3c4.ThreadUnresolved,
                _ => null,
            };
        }
    }
}