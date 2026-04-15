
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The webhooks events<br/>
    /// Example: deployment.created
    /// </summary>
    public enum GetWebhooksResponseVariant2ItemEvent
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
    public static class GetWebhooksResponseVariant2ItemEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhooksResponseVariant2ItemEvent value)
        {
            return value switch
            {
                GetWebhooksResponseVariant2ItemEvent.AiGatewayAutoReloadLimitReached => "ai-gateway.auto-reload.limit-reached",
                GetWebhooksResponseVariant2ItemEvent.AiGatewayBalanceDepleted => "ai-gateway.balance-depleted",
                GetWebhooksResponseVariant2ItemEvent.AlertsTriggered => "alerts.triggered",
                GetWebhooksResponseVariant2ItemEvent.BotidAnomaly => "botid.anomaly",
                GetWebhooksResponseVariant2ItemEvent.BudgetReached => "budget.reached",
                GetWebhooksResponseVariant2ItemEvent.CommentCreated => "comment.created",
                GetWebhooksResponseVariant2ItemEvent.CommentDeleted => "comment.deleted",
                GetWebhooksResponseVariant2ItemEvent.CommentMentioned => "comment.mentioned",
                GetWebhooksResponseVariant2ItemEvent.CommentReactionAdded => "comment.reaction-added",
                GetWebhooksResponseVariant2ItemEvent.CommentReactionRemoved => "comment.reaction-removed",
                GetWebhooksResponseVariant2ItemEvent.CommentResolved => "comment.resolved",
                GetWebhooksResponseVariant2ItemEvent.CommentUnresolved => "comment.unresolved",
                GetWebhooksResponseVariant2ItemEvent.CommentUpdated => "comment.updated",
                GetWebhooksResponseVariant2ItemEvent.Deployment => "deployment",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCanceledHyphen => "deployment-canceled",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCheckRerequestedHyphen => "deployment-check-rerequested",
                GetWebhooksResponseVariant2ItemEvent.DeploymentChecksCompleted => "deployment-checks-completed",
                GetWebhooksResponseVariant2ItemEvent.DeploymentErrorHyphen => "deployment-error",
                GetWebhooksResponseVariant2ItemEvent.DeploymentPreparedHyphen => "deployment-prepared",
                GetWebhooksResponseVariant2ItemEvent.DeploymentReadyHyphen => "deployment-ready",
                GetWebhooksResponseVariant2ItemEvent.DeploymentBuildRequested => "deployment.build-requested",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCanceled => "deployment.canceled",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCheckRerequested => "deployment.check-rerequested",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCheckrunCancel => "deployment.checkrun.cancel",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCheckrunStart => "deployment.checkrun.start",
                GetWebhooksResponseVariant2ItemEvent.DeploymentChecksFailed => "deployment.checks.failed",
                GetWebhooksResponseVariant2ItemEvent.DeploymentChecksSucceeded => "deployment.checks.succeeded",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCleanup => "deployment.cleanup",
                GetWebhooksResponseVariant2ItemEvent.DeploymentCreated => "deployment.created",
                GetWebhooksResponseVariant2ItemEvent.DeploymentError => "deployment.error",
                GetWebhooksResponseVariant2ItemEvent.DeploymentIntegrationActionCancel => "deployment.integration.action.cancel",
                GetWebhooksResponseVariant2ItemEvent.DeploymentIntegrationActionCleanup => "deployment.integration.action.cleanup",
                GetWebhooksResponseVariant2ItemEvent.DeploymentIntegrationActionStart => "deployment.integration.action.start",
                GetWebhooksResponseVariant2ItemEvent.DeploymentPromoted => "deployment.promoted",
                GetWebhooksResponseVariant2ItemEvent.DeploymentReady => "deployment.ready",
                GetWebhooksResponseVariant2ItemEvent.DeploymentRollback => "deployment.rollback",
                GetWebhooksResponseVariant2ItemEvent.DeploymentSucceeded => "deployment.succeeded",
                GetWebhooksResponseVariant2ItemEvent.DomainCreatedHyphen => "domain-created",
                GetWebhooksResponseVariant2ItemEvent.DomainAutoRenewChanged => "domain.auto-renew.changed",
                GetWebhooksResponseVariant2ItemEvent.DomainCertificateAdd => "domain.certificate.add",
                GetWebhooksResponseVariant2ItemEvent.DomainCertificateAddFailed => "domain.certificate.add.failed",
                GetWebhooksResponseVariant2ItemEvent.DomainCertificateDeleted => "domain.certificate.deleted",
                GetWebhooksResponseVariant2ItemEvent.DomainCertificateRenew => "domain.certificate.renew",
                GetWebhooksResponseVariant2ItemEvent.DomainCertificateRenewFailed => "domain.certificate.renew.failed",
                GetWebhooksResponseVariant2ItemEvent.DomainCreated => "domain.created",
                GetWebhooksResponseVariant2ItemEvent.DomainDnsRecordsChanged => "domain.dns.records.changed",
                GetWebhooksResponseVariant2ItemEvent.DomainRenewal => "domain.renewal",
                GetWebhooksResponseVariant2ItemEvent.DomainRenewalFailed => "domain.renewal.failed",
                GetWebhooksResponseVariant2ItemEvent.DomainTransferInCompleted => "domain.transfer-in.completed",
                GetWebhooksResponseVariant2ItemEvent.DomainTransferInFailed => "domain.transfer-in.failed",
                GetWebhooksResponseVariant2ItemEvent.DomainTransferInStarted => "domain.transfer-in.started",
                GetWebhooksResponseVariant2ItemEvent.EdgeConfigCreated => "edge-config.created",
                GetWebhooksResponseVariant2ItemEvent.EdgeConfigDeleted => "edge-config.deleted",
                GetWebhooksResponseVariant2ItemEvent.EdgeConfigItemsUpdated => "edge-config.items.updated",
                GetWebhooksResponseVariant2ItemEvent.FirewallAttack => "firewall.attack",
                GetWebhooksResponseVariant2ItemEvent.FirewallCustomRuleAnomaly => "firewall.custom-rule-anomaly",
                GetWebhooksResponseVariant2ItemEvent.FirewallSystemRuleAnomaly => "firewall.system-rule-anomaly",
                GetWebhooksResponseVariant2ItemEvent.FlagCreated => "flag.created",
                GetWebhooksResponseVariant2ItemEvent.FlagDeleted => "flag.deleted",
                GetWebhooksResponseVariant2ItemEvent.FlagSegmentCreated => "flag.segment.created",
                GetWebhooksResponseVariant2ItemEvent.FlagSegmentDeleted => "flag.segment.deleted",
                GetWebhooksResponseVariant2ItemEvent.FlagSegmentUpdated => "flag.segment.updated",
                GetWebhooksResponseVariant2ItemEvent.FlagUpdated => "flag.updated",
                GetWebhooksResponseVariant2ItemEvent.FunctionArchivalRequired => "function.archival-required",
                GetWebhooksResponseVariant2ItemEvent.FunctionRemovalRequired => "function.removal-required",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationPermissionUpdatedHyphen => "integration-configuration-permission-updated",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationRemovedHyphen => "integration-configuration-removed",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationScopeChangeConfirmedHyphen => "integration-configuration-scope-change-confirmed",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationPermissionUpgraded => "integration-configuration.permission-upgraded",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationRemoved => "integration-configuration.removed",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration.scope-change-confirmed",
                GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationTransferred => "integration-configuration.transferred",
                GetWebhooksResponseVariant2ItemEvent.IntegrationResourceProjectConnected => "integration-resource.project-connected",
                GetWebhooksResponseVariant2ItemEvent.IntegrationResourceProjectDisconnected => "integration-resource.project-disconnected",
                GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceCreated => "marketplace.invoice.created",
                GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceNotpaid => "marketplace.invoice.notpaid",
                GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceOverdue => "marketplace.invoice.overdue",
                GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoicePaid => "marketplace.invoice.paid",
                GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceRefunded => "marketplace.invoice.refunded",
                GetWebhooksResponseVariant2ItemEvent.MarketplaceMemberChanged => "marketplace.member.changed",
                GetWebhooksResponseVariant2ItemEvent.MessageCreated => "message.created",
                GetWebhooksResponseVariant2ItemEvent.MessageDeleted => "message.deleted",
                GetWebhooksResponseVariant2ItemEvent.MessageMentioned => "message.mentioned",
                GetWebhooksResponseVariant2ItemEvent.MessageReactionAdded => "message.reaction-added",
                GetWebhooksResponseVariant2ItemEvent.MessageReactionRemoved => "message.reaction-removed",
                GetWebhooksResponseVariant2ItemEvent.MessageUpdated => "message.updated",
                GetWebhooksResponseVariant2ItemEvent.ObservabilityAnomaly => "observability.anomaly",
                GetWebhooksResponseVariant2ItemEvent.ObservabilityAnomalyError => "observability.anomaly-error",
                GetWebhooksResponseVariant2ItemEvent.ObservabilityErrorAnomaly => "observability.error-anomaly",
                GetWebhooksResponseVariant2ItemEvent.ObservabilityUsageAnomaly => "observability.usage-anomaly",
                GetWebhooksResponseVariant2ItemEvent.ProjectCreatedHyphen => "project-created",
                GetWebhooksResponseVariant2ItemEvent.ProjectRemovedHyphen => "project-removed",
                GetWebhooksResponseVariant2ItemEvent.ProjectCreated => "project.created",
                GetWebhooksResponseVariant2ItemEvent.ProjectDomainCreated => "project.domain.created",
                GetWebhooksResponseVariant2ItemEvent.ProjectDomainDeleted => "project.domain.deleted",
                GetWebhooksResponseVariant2ItemEvent.ProjectDomainMoved => "project.domain.moved",
                GetWebhooksResponseVariant2ItemEvent.ProjectDomainUnverified => "project.domain.unverified",
                GetWebhooksResponseVariant2ItemEvent.ProjectDomainUpdated => "project.domain.updated",
                GetWebhooksResponseVariant2ItemEvent.ProjectDomainVerified => "project.domain.verified",
                GetWebhooksResponseVariant2ItemEvent.ProjectEnvVariableCreated => "project.env-variable.created",
                GetWebhooksResponseVariant2ItemEvent.ProjectEnvVariableDeleted => "project.env-variable.deleted",
                GetWebhooksResponseVariant2ItemEvent.ProjectEnvVariableUpdated => "project.env-variable.updated",
                GetWebhooksResponseVariant2ItemEvent.ProjectRemoved => "project.removed",
                GetWebhooksResponseVariant2ItemEvent.ProjectRenamed => "project.renamed",
                GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseAborted => "project.rolling-release.aborted",
                GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseApproved => "project.rolling-release.approved",
                GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseCompleted => "project.rolling-release.completed",
                GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseStarted => "project.rolling-release.started",
                GetWebhooksResponseVariant2ItemEvent.TestWebhook => "test-webhook",
                GetWebhooksResponseVariant2ItemEvent.ThreadResolved => "thread.resolved",
                GetWebhooksResponseVariant2ItemEvent.ThreadUnresolved => "thread.unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhooksResponseVariant2ItemEvent? ToEnum(string value)
        {
            return value switch
            {
                "ai-gateway.auto-reload.limit-reached" => GetWebhooksResponseVariant2ItemEvent.AiGatewayAutoReloadLimitReached,
                "ai-gateway.balance-depleted" => GetWebhooksResponseVariant2ItemEvent.AiGatewayBalanceDepleted,
                "alerts.triggered" => GetWebhooksResponseVariant2ItemEvent.AlertsTriggered,
                "botid.anomaly" => GetWebhooksResponseVariant2ItemEvent.BotidAnomaly,
                "budget.reached" => GetWebhooksResponseVariant2ItemEvent.BudgetReached,
                "comment.created" => GetWebhooksResponseVariant2ItemEvent.CommentCreated,
                "comment.deleted" => GetWebhooksResponseVariant2ItemEvent.CommentDeleted,
                "comment.mentioned" => GetWebhooksResponseVariant2ItemEvent.CommentMentioned,
                "comment.reaction-added" => GetWebhooksResponseVariant2ItemEvent.CommentReactionAdded,
                "comment.reaction-removed" => GetWebhooksResponseVariant2ItemEvent.CommentReactionRemoved,
                "comment.resolved" => GetWebhooksResponseVariant2ItemEvent.CommentResolved,
                "comment.unresolved" => GetWebhooksResponseVariant2ItemEvent.CommentUnresolved,
                "comment.updated" => GetWebhooksResponseVariant2ItemEvent.CommentUpdated,
                "deployment" => GetWebhooksResponseVariant2ItemEvent.Deployment,
                "deployment-canceled" => GetWebhooksResponseVariant2ItemEvent.DeploymentCanceledHyphen,
                "deployment-check-rerequested" => GetWebhooksResponseVariant2ItemEvent.DeploymentCheckRerequestedHyphen,
                "deployment-checks-completed" => GetWebhooksResponseVariant2ItemEvent.DeploymentChecksCompleted,
                "deployment-error" => GetWebhooksResponseVariant2ItemEvent.DeploymentErrorHyphen,
                "deployment-prepared" => GetWebhooksResponseVariant2ItemEvent.DeploymentPreparedHyphen,
                "deployment-ready" => GetWebhooksResponseVariant2ItemEvent.DeploymentReadyHyphen,
                "deployment.build-requested" => GetWebhooksResponseVariant2ItemEvent.DeploymentBuildRequested,
                "deployment.canceled" => GetWebhooksResponseVariant2ItemEvent.DeploymentCanceled,
                "deployment.check-rerequested" => GetWebhooksResponseVariant2ItemEvent.DeploymentCheckRerequested,
                "deployment.checkrun.cancel" => GetWebhooksResponseVariant2ItemEvent.DeploymentCheckrunCancel,
                "deployment.checkrun.start" => GetWebhooksResponseVariant2ItemEvent.DeploymentCheckrunStart,
                "deployment.checks.failed" => GetWebhooksResponseVariant2ItemEvent.DeploymentChecksFailed,
                "deployment.checks.succeeded" => GetWebhooksResponseVariant2ItemEvent.DeploymentChecksSucceeded,
                "deployment.cleanup" => GetWebhooksResponseVariant2ItemEvent.DeploymentCleanup,
                "deployment.created" => GetWebhooksResponseVariant2ItemEvent.DeploymentCreated,
                "deployment.error" => GetWebhooksResponseVariant2ItemEvent.DeploymentError,
                "deployment.integration.action.cancel" => GetWebhooksResponseVariant2ItemEvent.DeploymentIntegrationActionCancel,
                "deployment.integration.action.cleanup" => GetWebhooksResponseVariant2ItemEvent.DeploymentIntegrationActionCleanup,
                "deployment.integration.action.start" => GetWebhooksResponseVariant2ItemEvent.DeploymentIntegrationActionStart,
                "deployment.promoted" => GetWebhooksResponseVariant2ItemEvent.DeploymentPromoted,
                "deployment.ready" => GetWebhooksResponseVariant2ItemEvent.DeploymentReady,
                "deployment.rollback" => GetWebhooksResponseVariant2ItemEvent.DeploymentRollback,
                "deployment.succeeded" => GetWebhooksResponseVariant2ItemEvent.DeploymentSucceeded,
                "domain-created" => GetWebhooksResponseVariant2ItemEvent.DomainCreatedHyphen,
                "domain.auto-renew.changed" => GetWebhooksResponseVariant2ItemEvent.DomainAutoRenewChanged,
                "domain.certificate.add" => GetWebhooksResponseVariant2ItemEvent.DomainCertificateAdd,
                "domain.certificate.add.failed" => GetWebhooksResponseVariant2ItemEvent.DomainCertificateAddFailed,
                "domain.certificate.deleted" => GetWebhooksResponseVariant2ItemEvent.DomainCertificateDeleted,
                "domain.certificate.renew" => GetWebhooksResponseVariant2ItemEvent.DomainCertificateRenew,
                "domain.certificate.renew.failed" => GetWebhooksResponseVariant2ItemEvent.DomainCertificateRenewFailed,
                "domain.created" => GetWebhooksResponseVariant2ItemEvent.DomainCreated,
                "domain.dns.records.changed" => GetWebhooksResponseVariant2ItemEvent.DomainDnsRecordsChanged,
                "domain.renewal" => GetWebhooksResponseVariant2ItemEvent.DomainRenewal,
                "domain.renewal.failed" => GetWebhooksResponseVariant2ItemEvent.DomainRenewalFailed,
                "domain.transfer-in.completed" => GetWebhooksResponseVariant2ItemEvent.DomainTransferInCompleted,
                "domain.transfer-in.failed" => GetWebhooksResponseVariant2ItemEvent.DomainTransferInFailed,
                "domain.transfer-in.started" => GetWebhooksResponseVariant2ItemEvent.DomainTransferInStarted,
                "edge-config.created" => GetWebhooksResponseVariant2ItemEvent.EdgeConfigCreated,
                "edge-config.deleted" => GetWebhooksResponseVariant2ItemEvent.EdgeConfigDeleted,
                "edge-config.items.updated" => GetWebhooksResponseVariant2ItemEvent.EdgeConfigItemsUpdated,
                "firewall.attack" => GetWebhooksResponseVariant2ItemEvent.FirewallAttack,
                "firewall.custom-rule-anomaly" => GetWebhooksResponseVariant2ItemEvent.FirewallCustomRuleAnomaly,
                "firewall.system-rule-anomaly" => GetWebhooksResponseVariant2ItemEvent.FirewallSystemRuleAnomaly,
                "flag.created" => GetWebhooksResponseVariant2ItemEvent.FlagCreated,
                "flag.deleted" => GetWebhooksResponseVariant2ItemEvent.FlagDeleted,
                "flag.segment.created" => GetWebhooksResponseVariant2ItemEvent.FlagSegmentCreated,
                "flag.segment.deleted" => GetWebhooksResponseVariant2ItemEvent.FlagSegmentDeleted,
                "flag.segment.updated" => GetWebhooksResponseVariant2ItemEvent.FlagSegmentUpdated,
                "flag.updated" => GetWebhooksResponseVariant2ItemEvent.FlagUpdated,
                "function.archival-required" => GetWebhooksResponseVariant2ItemEvent.FunctionArchivalRequired,
                "function.removal-required" => GetWebhooksResponseVariant2ItemEvent.FunctionRemovalRequired,
                "integration-configuration-permission-updated" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationPermissionUpdatedHyphen,
                "integration-configuration-removed" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationRemovedHyphen,
                "integration-configuration-scope-change-confirmed" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationScopeChangeConfirmedHyphen,
                "integration-configuration.permission-upgraded" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationPermissionUpgraded,
                "integration-configuration.removed" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationRemoved,
                "integration-configuration.scope-change-confirmed" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration.transferred" => GetWebhooksResponseVariant2ItemEvent.IntegrationConfigurationTransferred,
                "integration-resource.project-connected" => GetWebhooksResponseVariant2ItemEvent.IntegrationResourceProjectConnected,
                "integration-resource.project-disconnected" => GetWebhooksResponseVariant2ItemEvent.IntegrationResourceProjectDisconnected,
                "marketplace.invoice.created" => GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceCreated,
                "marketplace.invoice.notpaid" => GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceNotpaid,
                "marketplace.invoice.overdue" => GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceOverdue,
                "marketplace.invoice.paid" => GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoicePaid,
                "marketplace.invoice.refunded" => GetWebhooksResponseVariant2ItemEvent.MarketplaceInvoiceRefunded,
                "marketplace.member.changed" => GetWebhooksResponseVariant2ItemEvent.MarketplaceMemberChanged,
                "message.created" => GetWebhooksResponseVariant2ItemEvent.MessageCreated,
                "message.deleted" => GetWebhooksResponseVariant2ItemEvent.MessageDeleted,
                "message.mentioned" => GetWebhooksResponseVariant2ItemEvent.MessageMentioned,
                "message.reaction-added" => GetWebhooksResponseVariant2ItemEvent.MessageReactionAdded,
                "message.reaction-removed" => GetWebhooksResponseVariant2ItemEvent.MessageReactionRemoved,
                "message.updated" => GetWebhooksResponseVariant2ItemEvent.MessageUpdated,
                "observability.anomaly" => GetWebhooksResponseVariant2ItemEvent.ObservabilityAnomaly,
                "observability.anomaly-error" => GetWebhooksResponseVariant2ItemEvent.ObservabilityAnomalyError,
                "observability.error-anomaly" => GetWebhooksResponseVariant2ItemEvent.ObservabilityErrorAnomaly,
                "observability.usage-anomaly" => GetWebhooksResponseVariant2ItemEvent.ObservabilityUsageAnomaly,
                "project-created" => GetWebhooksResponseVariant2ItemEvent.ProjectCreatedHyphen,
                "project-removed" => GetWebhooksResponseVariant2ItemEvent.ProjectRemovedHyphen,
                "project.created" => GetWebhooksResponseVariant2ItemEvent.ProjectCreated,
                "project.domain.created" => GetWebhooksResponseVariant2ItemEvent.ProjectDomainCreated,
                "project.domain.deleted" => GetWebhooksResponseVariant2ItemEvent.ProjectDomainDeleted,
                "project.domain.moved" => GetWebhooksResponseVariant2ItemEvent.ProjectDomainMoved,
                "project.domain.unverified" => GetWebhooksResponseVariant2ItemEvent.ProjectDomainUnverified,
                "project.domain.updated" => GetWebhooksResponseVariant2ItemEvent.ProjectDomainUpdated,
                "project.domain.verified" => GetWebhooksResponseVariant2ItemEvent.ProjectDomainVerified,
                "project.env-variable.created" => GetWebhooksResponseVariant2ItemEvent.ProjectEnvVariableCreated,
                "project.env-variable.deleted" => GetWebhooksResponseVariant2ItemEvent.ProjectEnvVariableDeleted,
                "project.env-variable.updated" => GetWebhooksResponseVariant2ItemEvent.ProjectEnvVariableUpdated,
                "project.removed" => GetWebhooksResponseVariant2ItemEvent.ProjectRemoved,
                "project.renamed" => GetWebhooksResponseVariant2ItemEvent.ProjectRenamed,
                "project.rolling-release.aborted" => GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseAborted,
                "project.rolling-release.approved" => GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseApproved,
                "project.rolling-release.completed" => GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseCompleted,
                "project.rolling-release.started" => GetWebhooksResponseVariant2ItemEvent.ProjectRollingReleaseStarted,
                "test-webhook" => GetWebhooksResponseVariant2ItemEvent.TestWebhook,
                "thread.resolved" => GetWebhooksResponseVariant2ItemEvent.ThreadResolved,
                "thread.unresolved" => GetWebhooksResponseVariant2ItemEvent.ThreadUnresolved,
                _ => null,
            };
        }
    }
}