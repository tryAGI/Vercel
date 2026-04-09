
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The webhooks events<br/>
    /// Example: deployment.created
    /// </summary>
    public enum CreateWebhookResponseEvent
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
    public static class CreateWebhookResponseEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookResponseEvent value)
        {
            return value switch
            {
                CreateWebhookResponseEvent.AiGatewayAutoReloadLimitReached => "ai-gateway.auto-reload.limit-reached",
                CreateWebhookResponseEvent.AiGatewayBalanceDepleted => "ai-gateway.balance-depleted",
                CreateWebhookResponseEvent.AlertsTriggered => "alerts.triggered",
                CreateWebhookResponseEvent.BotidAnomaly => "botid.anomaly",
                CreateWebhookResponseEvent.BudgetReached => "budget.reached",
                CreateWebhookResponseEvent.CommentCreated => "comment.created",
                CreateWebhookResponseEvent.CommentDeleted => "comment.deleted",
                CreateWebhookResponseEvent.CommentMentioned => "comment.mentioned",
                CreateWebhookResponseEvent.CommentReactionAdded => "comment.reaction-added",
                CreateWebhookResponseEvent.CommentReactionRemoved => "comment.reaction-removed",
                CreateWebhookResponseEvent.CommentResolved => "comment.resolved",
                CreateWebhookResponseEvent.CommentUnresolved => "comment.unresolved",
                CreateWebhookResponseEvent.CommentUpdated => "comment.updated",
                CreateWebhookResponseEvent.Deployment => "deployment",
                CreateWebhookResponseEvent.DeploymentCanceledHyphen => "deployment-canceled",
                CreateWebhookResponseEvent.DeploymentCheckRerequestedHyphen => "deployment-check-rerequested",
                CreateWebhookResponseEvent.DeploymentChecksCompleted => "deployment-checks-completed",
                CreateWebhookResponseEvent.DeploymentErrorHyphen => "deployment-error",
                CreateWebhookResponseEvent.DeploymentPreparedHyphen => "deployment-prepared",
                CreateWebhookResponseEvent.DeploymentReadyHyphen => "deployment-ready",
                CreateWebhookResponseEvent.DeploymentCanceled => "deployment.canceled",
                CreateWebhookResponseEvent.DeploymentCheckRerequested => "deployment.check-rerequested",
                CreateWebhookResponseEvent.DeploymentCheckrunCancel => "deployment.checkrun.cancel",
                CreateWebhookResponseEvent.DeploymentCheckrunStart => "deployment.checkrun.start",
                CreateWebhookResponseEvent.DeploymentChecksFailed => "deployment.checks.failed",
                CreateWebhookResponseEvent.DeploymentChecksSucceeded => "deployment.checks.succeeded",
                CreateWebhookResponseEvent.DeploymentCleanup => "deployment.cleanup",
                CreateWebhookResponseEvent.DeploymentCreated => "deployment.created",
                CreateWebhookResponseEvent.DeploymentError => "deployment.error",
                CreateWebhookResponseEvent.DeploymentIntegrationActionCancel => "deployment.integration.action.cancel",
                CreateWebhookResponseEvent.DeploymentIntegrationActionCleanup => "deployment.integration.action.cleanup",
                CreateWebhookResponseEvent.DeploymentIntegrationActionStart => "deployment.integration.action.start",
                CreateWebhookResponseEvent.DeploymentPromoted => "deployment.promoted",
                CreateWebhookResponseEvent.DeploymentReady => "deployment.ready",
                CreateWebhookResponseEvent.DeploymentRollback => "deployment.rollback",
                CreateWebhookResponseEvent.DeploymentSucceeded => "deployment.succeeded",
                CreateWebhookResponseEvent.DomainCreatedHyphen => "domain-created",
                CreateWebhookResponseEvent.DomainAutoRenewChanged => "domain.auto-renew.changed",
                CreateWebhookResponseEvent.DomainCertificateAdd => "domain.certificate.add",
                CreateWebhookResponseEvent.DomainCertificateAddFailed => "domain.certificate.add.failed",
                CreateWebhookResponseEvent.DomainCertificateDeleted => "domain.certificate.deleted",
                CreateWebhookResponseEvent.DomainCertificateRenew => "domain.certificate.renew",
                CreateWebhookResponseEvent.DomainCertificateRenewFailed => "domain.certificate.renew.failed",
                CreateWebhookResponseEvent.DomainCreated => "domain.created",
                CreateWebhookResponseEvent.DomainDnsRecordsChanged => "domain.dns.records.changed",
                CreateWebhookResponseEvent.DomainRenewal => "domain.renewal",
                CreateWebhookResponseEvent.DomainRenewalFailed => "domain.renewal.failed",
                CreateWebhookResponseEvent.DomainTransferInCompleted => "domain.transfer-in.completed",
                CreateWebhookResponseEvent.DomainTransferInFailed => "domain.transfer-in.failed",
                CreateWebhookResponseEvent.DomainTransferInStarted => "domain.transfer-in.started",
                CreateWebhookResponseEvent.EdgeConfigCreated => "edge-config.created",
                CreateWebhookResponseEvent.EdgeConfigDeleted => "edge-config.deleted",
                CreateWebhookResponseEvent.EdgeConfigItemsUpdated => "edge-config.items.updated",
                CreateWebhookResponseEvent.FirewallAttack => "firewall.attack",
                CreateWebhookResponseEvent.FirewallCustomRuleAnomaly => "firewall.custom-rule-anomaly",
                CreateWebhookResponseEvent.FirewallSystemRuleAnomaly => "firewall.system-rule-anomaly",
                CreateWebhookResponseEvent.FlagCreated => "flag.created",
                CreateWebhookResponseEvent.FlagDeleted => "flag.deleted",
                CreateWebhookResponseEvent.FlagSegmentCreated => "flag.segment.created",
                CreateWebhookResponseEvent.FlagSegmentDeleted => "flag.segment.deleted",
                CreateWebhookResponseEvent.FlagSegmentUpdated => "flag.segment.updated",
                CreateWebhookResponseEvent.FlagUpdated => "flag.updated",
                CreateWebhookResponseEvent.IntegrationConfigurationPermissionUpdatedHyphen => "integration-configuration-permission-updated",
                CreateWebhookResponseEvent.IntegrationConfigurationRemovedHyphen => "integration-configuration-removed",
                CreateWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmedHyphen => "integration-configuration-scope-change-confirmed",
                CreateWebhookResponseEvent.IntegrationConfigurationPermissionUpgraded => "integration-configuration.permission-upgraded",
                CreateWebhookResponseEvent.IntegrationConfigurationRemoved => "integration-configuration.removed",
                CreateWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration.scope-change-confirmed",
                CreateWebhookResponseEvent.IntegrationConfigurationTransferred => "integration-configuration.transferred",
                CreateWebhookResponseEvent.IntegrationResourceProjectConnected => "integration-resource.project-connected",
                CreateWebhookResponseEvent.IntegrationResourceProjectDisconnected => "integration-resource.project-disconnected",
                CreateWebhookResponseEvent.MarketplaceInvoiceCreated => "marketplace.invoice.created",
                CreateWebhookResponseEvent.MarketplaceInvoiceNotpaid => "marketplace.invoice.notpaid",
                CreateWebhookResponseEvent.MarketplaceInvoiceOverdue => "marketplace.invoice.overdue",
                CreateWebhookResponseEvent.MarketplaceInvoicePaid => "marketplace.invoice.paid",
                CreateWebhookResponseEvent.MarketplaceInvoiceRefunded => "marketplace.invoice.refunded",
                CreateWebhookResponseEvent.MarketplaceMemberChanged => "marketplace.member.changed",
                CreateWebhookResponseEvent.MessageCreated => "message.created",
                CreateWebhookResponseEvent.MessageDeleted => "message.deleted",
                CreateWebhookResponseEvent.MessageMentioned => "message.mentioned",
                CreateWebhookResponseEvent.MessageReactionAdded => "message.reaction-added",
                CreateWebhookResponseEvent.MessageReactionRemoved => "message.reaction-removed",
                CreateWebhookResponseEvent.MessageUpdated => "message.updated",
                CreateWebhookResponseEvent.ObservabilityAnomaly => "observability.anomaly",
                CreateWebhookResponseEvent.ObservabilityAnomalyError => "observability.anomaly-error",
                CreateWebhookResponseEvent.ObservabilityErrorAnomaly => "observability.error-anomaly",
                CreateWebhookResponseEvent.ObservabilityUsageAnomaly => "observability.usage-anomaly",
                CreateWebhookResponseEvent.ProjectCreatedHyphen => "project-created",
                CreateWebhookResponseEvent.ProjectRemovedHyphen => "project-removed",
                CreateWebhookResponseEvent.ProjectCreated => "project.created",
                CreateWebhookResponseEvent.ProjectDomainCreated => "project.domain.created",
                CreateWebhookResponseEvent.ProjectDomainDeleted => "project.domain.deleted",
                CreateWebhookResponseEvent.ProjectDomainMoved => "project.domain.moved",
                CreateWebhookResponseEvent.ProjectDomainUnverified => "project.domain.unverified",
                CreateWebhookResponseEvent.ProjectDomainUpdated => "project.domain.updated",
                CreateWebhookResponseEvent.ProjectDomainVerified => "project.domain.verified",
                CreateWebhookResponseEvent.ProjectEnvVariableCreated => "project.env-variable.created",
                CreateWebhookResponseEvent.ProjectEnvVariableDeleted => "project.env-variable.deleted",
                CreateWebhookResponseEvent.ProjectEnvVariableUpdated => "project.env-variable.updated",
                CreateWebhookResponseEvent.ProjectRemoved => "project.removed",
                CreateWebhookResponseEvent.ProjectRenamed => "project.renamed",
                CreateWebhookResponseEvent.ProjectRollingReleaseAborted => "project.rolling-release.aborted",
                CreateWebhookResponseEvent.ProjectRollingReleaseApproved => "project.rolling-release.approved",
                CreateWebhookResponseEvent.ProjectRollingReleaseCompleted => "project.rolling-release.completed",
                CreateWebhookResponseEvent.ProjectRollingReleaseStarted => "project.rolling-release.started",
                CreateWebhookResponseEvent.TestWebhook => "test-webhook",
                CreateWebhookResponseEvent.ThreadResolved => "thread.resolved",
                CreateWebhookResponseEvent.ThreadUnresolved => "thread.unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookResponseEvent? ToEnum(string value)
        {
            return value switch
            {
                "ai-gateway.auto-reload.limit-reached" => CreateWebhookResponseEvent.AiGatewayAutoReloadLimitReached,
                "ai-gateway.balance-depleted" => CreateWebhookResponseEvent.AiGatewayBalanceDepleted,
                "alerts.triggered" => CreateWebhookResponseEvent.AlertsTriggered,
                "botid.anomaly" => CreateWebhookResponseEvent.BotidAnomaly,
                "budget.reached" => CreateWebhookResponseEvent.BudgetReached,
                "comment.created" => CreateWebhookResponseEvent.CommentCreated,
                "comment.deleted" => CreateWebhookResponseEvent.CommentDeleted,
                "comment.mentioned" => CreateWebhookResponseEvent.CommentMentioned,
                "comment.reaction-added" => CreateWebhookResponseEvent.CommentReactionAdded,
                "comment.reaction-removed" => CreateWebhookResponseEvent.CommentReactionRemoved,
                "comment.resolved" => CreateWebhookResponseEvent.CommentResolved,
                "comment.unresolved" => CreateWebhookResponseEvent.CommentUnresolved,
                "comment.updated" => CreateWebhookResponseEvent.CommentUpdated,
                "deployment" => CreateWebhookResponseEvent.Deployment,
                "deployment-canceled" => CreateWebhookResponseEvent.DeploymentCanceledHyphen,
                "deployment-check-rerequested" => CreateWebhookResponseEvent.DeploymentCheckRerequestedHyphen,
                "deployment-checks-completed" => CreateWebhookResponseEvent.DeploymentChecksCompleted,
                "deployment-error" => CreateWebhookResponseEvent.DeploymentErrorHyphen,
                "deployment-prepared" => CreateWebhookResponseEvent.DeploymentPreparedHyphen,
                "deployment-ready" => CreateWebhookResponseEvent.DeploymentReadyHyphen,
                "deployment.canceled" => CreateWebhookResponseEvent.DeploymentCanceled,
                "deployment.check-rerequested" => CreateWebhookResponseEvent.DeploymentCheckRerequested,
                "deployment.checkrun.cancel" => CreateWebhookResponseEvent.DeploymentCheckrunCancel,
                "deployment.checkrun.start" => CreateWebhookResponseEvent.DeploymentCheckrunStart,
                "deployment.checks.failed" => CreateWebhookResponseEvent.DeploymentChecksFailed,
                "deployment.checks.succeeded" => CreateWebhookResponseEvent.DeploymentChecksSucceeded,
                "deployment.cleanup" => CreateWebhookResponseEvent.DeploymentCleanup,
                "deployment.created" => CreateWebhookResponseEvent.DeploymentCreated,
                "deployment.error" => CreateWebhookResponseEvent.DeploymentError,
                "deployment.integration.action.cancel" => CreateWebhookResponseEvent.DeploymentIntegrationActionCancel,
                "deployment.integration.action.cleanup" => CreateWebhookResponseEvent.DeploymentIntegrationActionCleanup,
                "deployment.integration.action.start" => CreateWebhookResponseEvent.DeploymentIntegrationActionStart,
                "deployment.promoted" => CreateWebhookResponseEvent.DeploymentPromoted,
                "deployment.ready" => CreateWebhookResponseEvent.DeploymentReady,
                "deployment.rollback" => CreateWebhookResponseEvent.DeploymentRollback,
                "deployment.succeeded" => CreateWebhookResponseEvent.DeploymentSucceeded,
                "domain-created" => CreateWebhookResponseEvent.DomainCreatedHyphen,
                "domain.auto-renew.changed" => CreateWebhookResponseEvent.DomainAutoRenewChanged,
                "domain.certificate.add" => CreateWebhookResponseEvent.DomainCertificateAdd,
                "domain.certificate.add.failed" => CreateWebhookResponseEvent.DomainCertificateAddFailed,
                "domain.certificate.deleted" => CreateWebhookResponseEvent.DomainCertificateDeleted,
                "domain.certificate.renew" => CreateWebhookResponseEvent.DomainCertificateRenew,
                "domain.certificate.renew.failed" => CreateWebhookResponseEvent.DomainCertificateRenewFailed,
                "domain.created" => CreateWebhookResponseEvent.DomainCreated,
                "domain.dns.records.changed" => CreateWebhookResponseEvent.DomainDnsRecordsChanged,
                "domain.renewal" => CreateWebhookResponseEvent.DomainRenewal,
                "domain.renewal.failed" => CreateWebhookResponseEvent.DomainRenewalFailed,
                "domain.transfer-in.completed" => CreateWebhookResponseEvent.DomainTransferInCompleted,
                "domain.transfer-in.failed" => CreateWebhookResponseEvent.DomainTransferInFailed,
                "domain.transfer-in.started" => CreateWebhookResponseEvent.DomainTransferInStarted,
                "edge-config.created" => CreateWebhookResponseEvent.EdgeConfigCreated,
                "edge-config.deleted" => CreateWebhookResponseEvent.EdgeConfigDeleted,
                "edge-config.items.updated" => CreateWebhookResponseEvent.EdgeConfigItemsUpdated,
                "firewall.attack" => CreateWebhookResponseEvent.FirewallAttack,
                "firewall.custom-rule-anomaly" => CreateWebhookResponseEvent.FirewallCustomRuleAnomaly,
                "firewall.system-rule-anomaly" => CreateWebhookResponseEvent.FirewallSystemRuleAnomaly,
                "flag.created" => CreateWebhookResponseEvent.FlagCreated,
                "flag.deleted" => CreateWebhookResponseEvent.FlagDeleted,
                "flag.segment.created" => CreateWebhookResponseEvent.FlagSegmentCreated,
                "flag.segment.deleted" => CreateWebhookResponseEvent.FlagSegmentDeleted,
                "flag.segment.updated" => CreateWebhookResponseEvent.FlagSegmentUpdated,
                "flag.updated" => CreateWebhookResponseEvent.FlagUpdated,
                "integration-configuration-permission-updated" => CreateWebhookResponseEvent.IntegrationConfigurationPermissionUpdatedHyphen,
                "integration-configuration-removed" => CreateWebhookResponseEvent.IntegrationConfigurationRemovedHyphen,
                "integration-configuration-scope-change-confirmed" => CreateWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmedHyphen,
                "integration-configuration.permission-upgraded" => CreateWebhookResponseEvent.IntegrationConfigurationPermissionUpgraded,
                "integration-configuration.removed" => CreateWebhookResponseEvent.IntegrationConfigurationRemoved,
                "integration-configuration.scope-change-confirmed" => CreateWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration.transferred" => CreateWebhookResponseEvent.IntegrationConfigurationTransferred,
                "integration-resource.project-connected" => CreateWebhookResponseEvent.IntegrationResourceProjectConnected,
                "integration-resource.project-disconnected" => CreateWebhookResponseEvent.IntegrationResourceProjectDisconnected,
                "marketplace.invoice.created" => CreateWebhookResponseEvent.MarketplaceInvoiceCreated,
                "marketplace.invoice.notpaid" => CreateWebhookResponseEvent.MarketplaceInvoiceNotpaid,
                "marketplace.invoice.overdue" => CreateWebhookResponseEvent.MarketplaceInvoiceOverdue,
                "marketplace.invoice.paid" => CreateWebhookResponseEvent.MarketplaceInvoicePaid,
                "marketplace.invoice.refunded" => CreateWebhookResponseEvent.MarketplaceInvoiceRefunded,
                "marketplace.member.changed" => CreateWebhookResponseEvent.MarketplaceMemberChanged,
                "message.created" => CreateWebhookResponseEvent.MessageCreated,
                "message.deleted" => CreateWebhookResponseEvent.MessageDeleted,
                "message.mentioned" => CreateWebhookResponseEvent.MessageMentioned,
                "message.reaction-added" => CreateWebhookResponseEvent.MessageReactionAdded,
                "message.reaction-removed" => CreateWebhookResponseEvent.MessageReactionRemoved,
                "message.updated" => CreateWebhookResponseEvent.MessageUpdated,
                "observability.anomaly" => CreateWebhookResponseEvent.ObservabilityAnomaly,
                "observability.anomaly-error" => CreateWebhookResponseEvent.ObservabilityAnomalyError,
                "observability.error-anomaly" => CreateWebhookResponseEvent.ObservabilityErrorAnomaly,
                "observability.usage-anomaly" => CreateWebhookResponseEvent.ObservabilityUsageAnomaly,
                "project-created" => CreateWebhookResponseEvent.ProjectCreatedHyphen,
                "project-removed" => CreateWebhookResponseEvent.ProjectRemovedHyphen,
                "project.created" => CreateWebhookResponseEvent.ProjectCreated,
                "project.domain.created" => CreateWebhookResponseEvent.ProjectDomainCreated,
                "project.domain.deleted" => CreateWebhookResponseEvent.ProjectDomainDeleted,
                "project.domain.moved" => CreateWebhookResponseEvent.ProjectDomainMoved,
                "project.domain.unverified" => CreateWebhookResponseEvent.ProjectDomainUnverified,
                "project.domain.updated" => CreateWebhookResponseEvent.ProjectDomainUpdated,
                "project.domain.verified" => CreateWebhookResponseEvent.ProjectDomainVerified,
                "project.env-variable.created" => CreateWebhookResponseEvent.ProjectEnvVariableCreated,
                "project.env-variable.deleted" => CreateWebhookResponseEvent.ProjectEnvVariableDeleted,
                "project.env-variable.updated" => CreateWebhookResponseEvent.ProjectEnvVariableUpdated,
                "project.removed" => CreateWebhookResponseEvent.ProjectRemoved,
                "project.renamed" => CreateWebhookResponseEvent.ProjectRenamed,
                "project.rolling-release.aborted" => CreateWebhookResponseEvent.ProjectRollingReleaseAborted,
                "project.rolling-release.approved" => CreateWebhookResponseEvent.ProjectRollingReleaseApproved,
                "project.rolling-release.completed" => CreateWebhookResponseEvent.ProjectRollingReleaseCompleted,
                "project.rolling-release.started" => CreateWebhookResponseEvent.ProjectRollingReleaseStarted,
                "test-webhook" => CreateWebhookResponseEvent.TestWebhook,
                "thread.resolved" => CreateWebhookResponseEvent.ThreadResolved,
                "thread.unresolved" => CreateWebhookResponseEvent.ThreadUnresolved,
                _ => null,
            };
        }
    }
}