
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebhookRequestEvent
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
    public static class CreateWebhookRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookRequestEvent value)
        {
            return value switch
            {
                CreateWebhookRequestEvent.AiGatewayAutoReloadLimitReached => "ai-gateway.auto-reload.limit-reached",
                CreateWebhookRequestEvent.AiGatewayBalanceDepleted => "ai-gateway.balance-depleted",
                CreateWebhookRequestEvent.AlertsTriggered => "alerts.triggered",
                CreateWebhookRequestEvent.BotidAnomaly => "botid.anomaly",
                CreateWebhookRequestEvent.BudgetReached => "budget.reached",
                CreateWebhookRequestEvent.CommentCreated => "comment.created",
                CreateWebhookRequestEvent.CommentDeleted => "comment.deleted",
                CreateWebhookRequestEvent.CommentMentioned => "comment.mentioned",
                CreateWebhookRequestEvent.CommentReactionAdded => "comment.reaction-added",
                CreateWebhookRequestEvent.CommentReactionRemoved => "comment.reaction-removed",
                CreateWebhookRequestEvent.CommentResolved => "comment.resolved",
                CreateWebhookRequestEvent.CommentUnresolved => "comment.unresolved",
                CreateWebhookRequestEvent.CommentUpdated => "comment.updated",
                CreateWebhookRequestEvent.Deployment => "deployment",
                CreateWebhookRequestEvent.DeploymentCanceledHyphen => "deployment-canceled",
                CreateWebhookRequestEvent.DeploymentCheckRerequestedHyphen => "deployment-check-rerequested",
                CreateWebhookRequestEvent.DeploymentChecksCompleted => "deployment-checks-completed",
                CreateWebhookRequestEvent.DeploymentErrorHyphen => "deployment-error",
                CreateWebhookRequestEvent.DeploymentPreparedHyphen => "deployment-prepared",
                CreateWebhookRequestEvent.DeploymentReadyHyphen => "deployment-ready",
                CreateWebhookRequestEvent.DeploymentBuildRequested => "deployment.build-requested",
                CreateWebhookRequestEvent.DeploymentCanceled => "deployment.canceled",
                CreateWebhookRequestEvent.DeploymentCheckRerequested => "deployment.check-rerequested",
                CreateWebhookRequestEvent.DeploymentCheckrunCancel => "deployment.checkrun.cancel",
                CreateWebhookRequestEvent.DeploymentCheckrunStart => "deployment.checkrun.start",
                CreateWebhookRequestEvent.DeploymentChecksFailed => "deployment.checks.failed",
                CreateWebhookRequestEvent.DeploymentChecksSucceeded => "deployment.checks.succeeded",
                CreateWebhookRequestEvent.DeploymentCleanup => "deployment.cleanup",
                CreateWebhookRequestEvent.DeploymentCreated => "deployment.created",
                CreateWebhookRequestEvent.DeploymentError => "deployment.error",
                CreateWebhookRequestEvent.DeploymentIntegrationActionCancel => "deployment.integration.action.cancel",
                CreateWebhookRequestEvent.DeploymentIntegrationActionCleanup => "deployment.integration.action.cleanup",
                CreateWebhookRequestEvent.DeploymentIntegrationActionStart => "deployment.integration.action.start",
                CreateWebhookRequestEvent.DeploymentPromoted => "deployment.promoted",
                CreateWebhookRequestEvent.DeploymentReady => "deployment.ready",
                CreateWebhookRequestEvent.DeploymentRollback => "deployment.rollback",
                CreateWebhookRequestEvent.DeploymentSucceeded => "deployment.succeeded",
                CreateWebhookRequestEvent.DomainCreatedHyphen => "domain-created",
                CreateWebhookRequestEvent.DomainAutoRenewChanged => "domain.auto-renew.changed",
                CreateWebhookRequestEvent.DomainCertificateAdd => "domain.certificate.add",
                CreateWebhookRequestEvent.DomainCertificateAddFailed => "domain.certificate.add.failed",
                CreateWebhookRequestEvent.DomainCertificateDeleted => "domain.certificate.deleted",
                CreateWebhookRequestEvent.DomainCertificateRenew => "domain.certificate.renew",
                CreateWebhookRequestEvent.DomainCertificateRenewFailed => "domain.certificate.renew.failed",
                CreateWebhookRequestEvent.DomainCreated => "domain.created",
                CreateWebhookRequestEvent.DomainDnsRecordsChanged => "domain.dns.records.changed",
                CreateWebhookRequestEvent.DomainRenewal => "domain.renewal",
                CreateWebhookRequestEvent.DomainRenewalFailed => "domain.renewal.failed",
                CreateWebhookRequestEvent.DomainTransferInCompleted => "domain.transfer-in.completed",
                CreateWebhookRequestEvent.DomainTransferInFailed => "domain.transfer-in.failed",
                CreateWebhookRequestEvent.DomainTransferInStarted => "domain.transfer-in.started",
                CreateWebhookRequestEvent.EdgeConfigCreated => "edge-config.created",
                CreateWebhookRequestEvent.EdgeConfigDeleted => "edge-config.deleted",
                CreateWebhookRequestEvent.EdgeConfigItemsUpdated => "edge-config.items.updated",
                CreateWebhookRequestEvent.FirewallAttack => "firewall.attack",
                CreateWebhookRequestEvent.FirewallCustomRuleAnomaly => "firewall.custom-rule-anomaly",
                CreateWebhookRequestEvent.FirewallSystemRuleAnomaly => "firewall.system-rule-anomaly",
                CreateWebhookRequestEvent.FlagCreated => "flag.created",
                CreateWebhookRequestEvent.FlagDeleted => "flag.deleted",
                CreateWebhookRequestEvent.FlagSegmentCreated => "flag.segment.created",
                CreateWebhookRequestEvent.FlagSegmentDeleted => "flag.segment.deleted",
                CreateWebhookRequestEvent.FlagSegmentUpdated => "flag.segment.updated",
                CreateWebhookRequestEvent.FlagUpdated => "flag.updated",
                CreateWebhookRequestEvent.FunctionArchivalRequired => "function.archival-required",
                CreateWebhookRequestEvent.FunctionRemovalRequired => "function.removal-required",
                CreateWebhookRequestEvent.IntegrationConfigurationPermissionUpdatedHyphen => "integration-configuration-permission-updated",
                CreateWebhookRequestEvent.IntegrationConfigurationRemovedHyphen => "integration-configuration-removed",
                CreateWebhookRequestEvent.IntegrationConfigurationScopeChangeConfirmedHyphen => "integration-configuration-scope-change-confirmed",
                CreateWebhookRequestEvent.IntegrationConfigurationPermissionUpgraded => "integration-configuration.permission-upgraded",
                CreateWebhookRequestEvent.IntegrationConfigurationRemoved => "integration-configuration.removed",
                CreateWebhookRequestEvent.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration.scope-change-confirmed",
                CreateWebhookRequestEvent.IntegrationConfigurationTransferred => "integration-configuration.transferred",
                CreateWebhookRequestEvent.IntegrationResourceProjectConnected => "integration-resource.project-connected",
                CreateWebhookRequestEvent.IntegrationResourceProjectDisconnected => "integration-resource.project-disconnected",
                CreateWebhookRequestEvent.MarketplaceInvoiceCreated => "marketplace.invoice.created",
                CreateWebhookRequestEvent.MarketplaceInvoiceNotpaid => "marketplace.invoice.notpaid",
                CreateWebhookRequestEvent.MarketplaceInvoiceOverdue => "marketplace.invoice.overdue",
                CreateWebhookRequestEvent.MarketplaceInvoicePaid => "marketplace.invoice.paid",
                CreateWebhookRequestEvent.MarketplaceInvoiceRefunded => "marketplace.invoice.refunded",
                CreateWebhookRequestEvent.MarketplaceMemberChanged => "marketplace.member.changed",
                CreateWebhookRequestEvent.MessageCreated => "message.created",
                CreateWebhookRequestEvent.MessageDeleted => "message.deleted",
                CreateWebhookRequestEvent.MessageMentioned => "message.mentioned",
                CreateWebhookRequestEvent.MessageReactionAdded => "message.reaction-added",
                CreateWebhookRequestEvent.MessageReactionRemoved => "message.reaction-removed",
                CreateWebhookRequestEvent.MessageUpdated => "message.updated",
                CreateWebhookRequestEvent.ObservabilityAnomaly => "observability.anomaly",
                CreateWebhookRequestEvent.ObservabilityAnomalyError => "observability.anomaly-error",
                CreateWebhookRequestEvent.ObservabilityErrorAnomaly => "observability.error-anomaly",
                CreateWebhookRequestEvent.ObservabilityUsageAnomaly => "observability.usage-anomaly",
                CreateWebhookRequestEvent.ProjectCreatedHyphen => "project-created",
                CreateWebhookRequestEvent.ProjectRemovedHyphen => "project-removed",
                CreateWebhookRequestEvent.ProjectCreated => "project.created",
                CreateWebhookRequestEvent.ProjectDomainCreated => "project.domain.created",
                CreateWebhookRequestEvent.ProjectDomainDeleted => "project.domain.deleted",
                CreateWebhookRequestEvent.ProjectDomainMoved => "project.domain.moved",
                CreateWebhookRequestEvent.ProjectDomainUnverified => "project.domain.unverified",
                CreateWebhookRequestEvent.ProjectDomainUpdated => "project.domain.updated",
                CreateWebhookRequestEvent.ProjectDomainVerified => "project.domain.verified",
                CreateWebhookRequestEvent.ProjectEnvVariableCreated => "project.env-variable.created",
                CreateWebhookRequestEvent.ProjectEnvVariableDeleted => "project.env-variable.deleted",
                CreateWebhookRequestEvent.ProjectEnvVariableUpdated => "project.env-variable.updated",
                CreateWebhookRequestEvent.ProjectRemoved => "project.removed",
                CreateWebhookRequestEvent.ProjectRenamed => "project.renamed",
                CreateWebhookRequestEvent.ProjectRollingReleaseAborted => "project.rolling-release.aborted",
                CreateWebhookRequestEvent.ProjectRollingReleaseApproved => "project.rolling-release.approved",
                CreateWebhookRequestEvent.ProjectRollingReleaseCompleted => "project.rolling-release.completed",
                CreateWebhookRequestEvent.ProjectRollingReleaseStarted => "project.rolling-release.started",
                CreateWebhookRequestEvent.TestWebhook => "test-webhook",
                CreateWebhookRequestEvent.ThreadResolved => "thread.resolved",
                CreateWebhookRequestEvent.ThreadUnresolved => "thread.unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookRequestEvent? ToEnum(string value)
        {
            return value switch
            {
                "ai-gateway.auto-reload.limit-reached" => CreateWebhookRequestEvent.AiGatewayAutoReloadLimitReached,
                "ai-gateway.balance-depleted" => CreateWebhookRequestEvent.AiGatewayBalanceDepleted,
                "alerts.triggered" => CreateWebhookRequestEvent.AlertsTriggered,
                "botid.anomaly" => CreateWebhookRequestEvent.BotidAnomaly,
                "budget.reached" => CreateWebhookRequestEvent.BudgetReached,
                "comment.created" => CreateWebhookRequestEvent.CommentCreated,
                "comment.deleted" => CreateWebhookRequestEvent.CommentDeleted,
                "comment.mentioned" => CreateWebhookRequestEvent.CommentMentioned,
                "comment.reaction-added" => CreateWebhookRequestEvent.CommentReactionAdded,
                "comment.reaction-removed" => CreateWebhookRequestEvent.CommentReactionRemoved,
                "comment.resolved" => CreateWebhookRequestEvent.CommentResolved,
                "comment.unresolved" => CreateWebhookRequestEvent.CommentUnresolved,
                "comment.updated" => CreateWebhookRequestEvent.CommentUpdated,
                "deployment" => CreateWebhookRequestEvent.Deployment,
                "deployment-canceled" => CreateWebhookRequestEvent.DeploymentCanceledHyphen,
                "deployment-check-rerequested" => CreateWebhookRequestEvent.DeploymentCheckRerequestedHyphen,
                "deployment-checks-completed" => CreateWebhookRequestEvent.DeploymentChecksCompleted,
                "deployment-error" => CreateWebhookRequestEvent.DeploymentErrorHyphen,
                "deployment-prepared" => CreateWebhookRequestEvent.DeploymentPreparedHyphen,
                "deployment-ready" => CreateWebhookRequestEvent.DeploymentReadyHyphen,
                "deployment.build-requested" => CreateWebhookRequestEvent.DeploymentBuildRequested,
                "deployment.canceled" => CreateWebhookRequestEvent.DeploymentCanceled,
                "deployment.check-rerequested" => CreateWebhookRequestEvent.DeploymentCheckRerequested,
                "deployment.checkrun.cancel" => CreateWebhookRequestEvent.DeploymentCheckrunCancel,
                "deployment.checkrun.start" => CreateWebhookRequestEvent.DeploymentCheckrunStart,
                "deployment.checks.failed" => CreateWebhookRequestEvent.DeploymentChecksFailed,
                "deployment.checks.succeeded" => CreateWebhookRequestEvent.DeploymentChecksSucceeded,
                "deployment.cleanup" => CreateWebhookRequestEvent.DeploymentCleanup,
                "deployment.created" => CreateWebhookRequestEvent.DeploymentCreated,
                "deployment.error" => CreateWebhookRequestEvent.DeploymentError,
                "deployment.integration.action.cancel" => CreateWebhookRequestEvent.DeploymentIntegrationActionCancel,
                "deployment.integration.action.cleanup" => CreateWebhookRequestEvent.DeploymentIntegrationActionCleanup,
                "deployment.integration.action.start" => CreateWebhookRequestEvent.DeploymentIntegrationActionStart,
                "deployment.promoted" => CreateWebhookRequestEvent.DeploymentPromoted,
                "deployment.ready" => CreateWebhookRequestEvent.DeploymentReady,
                "deployment.rollback" => CreateWebhookRequestEvent.DeploymentRollback,
                "deployment.succeeded" => CreateWebhookRequestEvent.DeploymentSucceeded,
                "domain-created" => CreateWebhookRequestEvent.DomainCreatedHyphen,
                "domain.auto-renew.changed" => CreateWebhookRequestEvent.DomainAutoRenewChanged,
                "domain.certificate.add" => CreateWebhookRequestEvent.DomainCertificateAdd,
                "domain.certificate.add.failed" => CreateWebhookRequestEvent.DomainCertificateAddFailed,
                "domain.certificate.deleted" => CreateWebhookRequestEvent.DomainCertificateDeleted,
                "domain.certificate.renew" => CreateWebhookRequestEvent.DomainCertificateRenew,
                "domain.certificate.renew.failed" => CreateWebhookRequestEvent.DomainCertificateRenewFailed,
                "domain.created" => CreateWebhookRequestEvent.DomainCreated,
                "domain.dns.records.changed" => CreateWebhookRequestEvent.DomainDnsRecordsChanged,
                "domain.renewal" => CreateWebhookRequestEvent.DomainRenewal,
                "domain.renewal.failed" => CreateWebhookRequestEvent.DomainRenewalFailed,
                "domain.transfer-in.completed" => CreateWebhookRequestEvent.DomainTransferInCompleted,
                "domain.transfer-in.failed" => CreateWebhookRequestEvent.DomainTransferInFailed,
                "domain.transfer-in.started" => CreateWebhookRequestEvent.DomainTransferInStarted,
                "edge-config.created" => CreateWebhookRequestEvent.EdgeConfigCreated,
                "edge-config.deleted" => CreateWebhookRequestEvent.EdgeConfigDeleted,
                "edge-config.items.updated" => CreateWebhookRequestEvent.EdgeConfigItemsUpdated,
                "firewall.attack" => CreateWebhookRequestEvent.FirewallAttack,
                "firewall.custom-rule-anomaly" => CreateWebhookRequestEvent.FirewallCustomRuleAnomaly,
                "firewall.system-rule-anomaly" => CreateWebhookRequestEvent.FirewallSystemRuleAnomaly,
                "flag.created" => CreateWebhookRequestEvent.FlagCreated,
                "flag.deleted" => CreateWebhookRequestEvent.FlagDeleted,
                "flag.segment.created" => CreateWebhookRequestEvent.FlagSegmentCreated,
                "flag.segment.deleted" => CreateWebhookRequestEvent.FlagSegmentDeleted,
                "flag.segment.updated" => CreateWebhookRequestEvent.FlagSegmentUpdated,
                "flag.updated" => CreateWebhookRequestEvent.FlagUpdated,
                "function.archival-required" => CreateWebhookRequestEvent.FunctionArchivalRequired,
                "function.removal-required" => CreateWebhookRequestEvent.FunctionRemovalRequired,
                "integration-configuration-permission-updated" => CreateWebhookRequestEvent.IntegrationConfigurationPermissionUpdatedHyphen,
                "integration-configuration-removed" => CreateWebhookRequestEvent.IntegrationConfigurationRemovedHyphen,
                "integration-configuration-scope-change-confirmed" => CreateWebhookRequestEvent.IntegrationConfigurationScopeChangeConfirmedHyphen,
                "integration-configuration.permission-upgraded" => CreateWebhookRequestEvent.IntegrationConfigurationPermissionUpgraded,
                "integration-configuration.removed" => CreateWebhookRequestEvent.IntegrationConfigurationRemoved,
                "integration-configuration.scope-change-confirmed" => CreateWebhookRequestEvent.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration.transferred" => CreateWebhookRequestEvent.IntegrationConfigurationTransferred,
                "integration-resource.project-connected" => CreateWebhookRequestEvent.IntegrationResourceProjectConnected,
                "integration-resource.project-disconnected" => CreateWebhookRequestEvent.IntegrationResourceProjectDisconnected,
                "marketplace.invoice.created" => CreateWebhookRequestEvent.MarketplaceInvoiceCreated,
                "marketplace.invoice.notpaid" => CreateWebhookRequestEvent.MarketplaceInvoiceNotpaid,
                "marketplace.invoice.overdue" => CreateWebhookRequestEvent.MarketplaceInvoiceOverdue,
                "marketplace.invoice.paid" => CreateWebhookRequestEvent.MarketplaceInvoicePaid,
                "marketplace.invoice.refunded" => CreateWebhookRequestEvent.MarketplaceInvoiceRefunded,
                "marketplace.member.changed" => CreateWebhookRequestEvent.MarketplaceMemberChanged,
                "message.created" => CreateWebhookRequestEvent.MessageCreated,
                "message.deleted" => CreateWebhookRequestEvent.MessageDeleted,
                "message.mentioned" => CreateWebhookRequestEvent.MessageMentioned,
                "message.reaction-added" => CreateWebhookRequestEvent.MessageReactionAdded,
                "message.reaction-removed" => CreateWebhookRequestEvent.MessageReactionRemoved,
                "message.updated" => CreateWebhookRequestEvent.MessageUpdated,
                "observability.anomaly" => CreateWebhookRequestEvent.ObservabilityAnomaly,
                "observability.anomaly-error" => CreateWebhookRequestEvent.ObservabilityAnomalyError,
                "observability.error-anomaly" => CreateWebhookRequestEvent.ObservabilityErrorAnomaly,
                "observability.usage-anomaly" => CreateWebhookRequestEvent.ObservabilityUsageAnomaly,
                "project-created" => CreateWebhookRequestEvent.ProjectCreatedHyphen,
                "project-removed" => CreateWebhookRequestEvent.ProjectRemovedHyphen,
                "project.created" => CreateWebhookRequestEvent.ProjectCreated,
                "project.domain.created" => CreateWebhookRequestEvent.ProjectDomainCreated,
                "project.domain.deleted" => CreateWebhookRequestEvent.ProjectDomainDeleted,
                "project.domain.moved" => CreateWebhookRequestEvent.ProjectDomainMoved,
                "project.domain.unverified" => CreateWebhookRequestEvent.ProjectDomainUnverified,
                "project.domain.updated" => CreateWebhookRequestEvent.ProjectDomainUpdated,
                "project.domain.verified" => CreateWebhookRequestEvent.ProjectDomainVerified,
                "project.env-variable.created" => CreateWebhookRequestEvent.ProjectEnvVariableCreated,
                "project.env-variable.deleted" => CreateWebhookRequestEvent.ProjectEnvVariableDeleted,
                "project.env-variable.updated" => CreateWebhookRequestEvent.ProjectEnvVariableUpdated,
                "project.removed" => CreateWebhookRequestEvent.ProjectRemoved,
                "project.renamed" => CreateWebhookRequestEvent.ProjectRenamed,
                "project.rolling-release.aborted" => CreateWebhookRequestEvent.ProjectRollingReleaseAborted,
                "project.rolling-release.approved" => CreateWebhookRequestEvent.ProjectRollingReleaseApproved,
                "project.rolling-release.completed" => CreateWebhookRequestEvent.ProjectRollingReleaseCompleted,
                "project.rolling-release.started" => CreateWebhookRequestEvent.ProjectRollingReleaseStarted,
                "test-webhook" => CreateWebhookRequestEvent.TestWebhook,
                "thread.resolved" => CreateWebhookRequestEvent.ThreadResolved,
                "thread.unresolved" => CreateWebhookRequestEvent.ThreadUnresolved,
                _ => null,
            };
        }
    }
}