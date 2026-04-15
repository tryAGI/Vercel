
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The webhooks events<br/>
    /// Example: deployment.created
    /// </summary>
    public enum GetWebhookResponseEvent
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
    public static class GetWebhookResponseEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookResponseEvent value)
        {
            return value switch
            {
                GetWebhookResponseEvent.AiGatewayAutoReloadLimitReached => "ai-gateway.auto-reload.limit-reached",
                GetWebhookResponseEvent.AiGatewayBalanceDepleted => "ai-gateway.balance-depleted",
                GetWebhookResponseEvent.AlertsTriggered => "alerts.triggered",
                GetWebhookResponseEvent.BotidAnomaly => "botid.anomaly",
                GetWebhookResponseEvent.BudgetReached => "budget.reached",
                GetWebhookResponseEvent.CommentCreated => "comment.created",
                GetWebhookResponseEvent.CommentDeleted => "comment.deleted",
                GetWebhookResponseEvent.CommentMentioned => "comment.mentioned",
                GetWebhookResponseEvent.CommentReactionAdded => "comment.reaction-added",
                GetWebhookResponseEvent.CommentReactionRemoved => "comment.reaction-removed",
                GetWebhookResponseEvent.CommentResolved => "comment.resolved",
                GetWebhookResponseEvent.CommentUnresolved => "comment.unresolved",
                GetWebhookResponseEvent.CommentUpdated => "comment.updated",
                GetWebhookResponseEvent.Deployment => "deployment",
                GetWebhookResponseEvent.DeploymentCanceledHyphen => "deployment-canceled",
                GetWebhookResponseEvent.DeploymentCheckRerequestedHyphen => "deployment-check-rerequested",
                GetWebhookResponseEvent.DeploymentChecksCompleted => "deployment-checks-completed",
                GetWebhookResponseEvent.DeploymentErrorHyphen => "deployment-error",
                GetWebhookResponseEvent.DeploymentPreparedHyphen => "deployment-prepared",
                GetWebhookResponseEvent.DeploymentReadyHyphen => "deployment-ready",
                GetWebhookResponseEvent.DeploymentBuildRequested => "deployment.build-requested",
                GetWebhookResponseEvent.DeploymentCanceled => "deployment.canceled",
                GetWebhookResponseEvent.DeploymentCheckRerequested => "deployment.check-rerequested",
                GetWebhookResponseEvent.DeploymentCheckrunCancel => "deployment.checkrun.cancel",
                GetWebhookResponseEvent.DeploymentCheckrunStart => "deployment.checkrun.start",
                GetWebhookResponseEvent.DeploymentChecksFailed => "deployment.checks.failed",
                GetWebhookResponseEvent.DeploymentChecksSucceeded => "deployment.checks.succeeded",
                GetWebhookResponseEvent.DeploymentCleanup => "deployment.cleanup",
                GetWebhookResponseEvent.DeploymentCreated => "deployment.created",
                GetWebhookResponseEvent.DeploymentError => "deployment.error",
                GetWebhookResponseEvent.DeploymentIntegrationActionCancel => "deployment.integration.action.cancel",
                GetWebhookResponseEvent.DeploymentIntegrationActionCleanup => "deployment.integration.action.cleanup",
                GetWebhookResponseEvent.DeploymentIntegrationActionStart => "deployment.integration.action.start",
                GetWebhookResponseEvent.DeploymentPromoted => "deployment.promoted",
                GetWebhookResponseEvent.DeploymentReady => "deployment.ready",
                GetWebhookResponseEvent.DeploymentRollback => "deployment.rollback",
                GetWebhookResponseEvent.DeploymentSucceeded => "deployment.succeeded",
                GetWebhookResponseEvent.DomainCreatedHyphen => "domain-created",
                GetWebhookResponseEvent.DomainAutoRenewChanged => "domain.auto-renew.changed",
                GetWebhookResponseEvent.DomainCertificateAdd => "domain.certificate.add",
                GetWebhookResponseEvent.DomainCertificateAddFailed => "domain.certificate.add.failed",
                GetWebhookResponseEvent.DomainCertificateDeleted => "domain.certificate.deleted",
                GetWebhookResponseEvent.DomainCertificateRenew => "domain.certificate.renew",
                GetWebhookResponseEvent.DomainCertificateRenewFailed => "domain.certificate.renew.failed",
                GetWebhookResponseEvent.DomainCreated => "domain.created",
                GetWebhookResponseEvent.DomainDnsRecordsChanged => "domain.dns.records.changed",
                GetWebhookResponseEvent.DomainRenewal => "domain.renewal",
                GetWebhookResponseEvent.DomainRenewalFailed => "domain.renewal.failed",
                GetWebhookResponseEvent.DomainTransferInCompleted => "domain.transfer-in.completed",
                GetWebhookResponseEvent.DomainTransferInFailed => "domain.transfer-in.failed",
                GetWebhookResponseEvent.DomainTransferInStarted => "domain.transfer-in.started",
                GetWebhookResponseEvent.EdgeConfigCreated => "edge-config.created",
                GetWebhookResponseEvent.EdgeConfigDeleted => "edge-config.deleted",
                GetWebhookResponseEvent.EdgeConfigItemsUpdated => "edge-config.items.updated",
                GetWebhookResponseEvent.FirewallAttack => "firewall.attack",
                GetWebhookResponseEvent.FirewallCustomRuleAnomaly => "firewall.custom-rule-anomaly",
                GetWebhookResponseEvent.FirewallSystemRuleAnomaly => "firewall.system-rule-anomaly",
                GetWebhookResponseEvent.FlagCreated => "flag.created",
                GetWebhookResponseEvent.FlagDeleted => "flag.deleted",
                GetWebhookResponseEvent.FlagSegmentCreated => "flag.segment.created",
                GetWebhookResponseEvent.FlagSegmentDeleted => "flag.segment.deleted",
                GetWebhookResponseEvent.FlagSegmentUpdated => "flag.segment.updated",
                GetWebhookResponseEvent.FlagUpdated => "flag.updated",
                GetWebhookResponseEvent.FunctionArchivalRequired => "function.archival-required",
                GetWebhookResponseEvent.FunctionRemovalRequired => "function.removal-required",
                GetWebhookResponseEvent.IntegrationConfigurationPermissionUpdatedHyphen => "integration-configuration-permission-updated",
                GetWebhookResponseEvent.IntegrationConfigurationRemovedHyphen => "integration-configuration-removed",
                GetWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmedHyphen => "integration-configuration-scope-change-confirmed",
                GetWebhookResponseEvent.IntegrationConfigurationPermissionUpgraded => "integration-configuration.permission-upgraded",
                GetWebhookResponseEvent.IntegrationConfigurationRemoved => "integration-configuration.removed",
                GetWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration.scope-change-confirmed",
                GetWebhookResponseEvent.IntegrationConfigurationTransferred => "integration-configuration.transferred",
                GetWebhookResponseEvent.IntegrationResourceProjectConnected => "integration-resource.project-connected",
                GetWebhookResponseEvent.IntegrationResourceProjectDisconnected => "integration-resource.project-disconnected",
                GetWebhookResponseEvent.MarketplaceInvoiceCreated => "marketplace.invoice.created",
                GetWebhookResponseEvent.MarketplaceInvoiceNotpaid => "marketplace.invoice.notpaid",
                GetWebhookResponseEvent.MarketplaceInvoiceOverdue => "marketplace.invoice.overdue",
                GetWebhookResponseEvent.MarketplaceInvoicePaid => "marketplace.invoice.paid",
                GetWebhookResponseEvent.MarketplaceInvoiceRefunded => "marketplace.invoice.refunded",
                GetWebhookResponseEvent.MarketplaceMemberChanged => "marketplace.member.changed",
                GetWebhookResponseEvent.MessageCreated => "message.created",
                GetWebhookResponseEvent.MessageDeleted => "message.deleted",
                GetWebhookResponseEvent.MessageMentioned => "message.mentioned",
                GetWebhookResponseEvent.MessageReactionAdded => "message.reaction-added",
                GetWebhookResponseEvent.MessageReactionRemoved => "message.reaction-removed",
                GetWebhookResponseEvent.MessageUpdated => "message.updated",
                GetWebhookResponseEvent.ObservabilityAnomaly => "observability.anomaly",
                GetWebhookResponseEvent.ObservabilityAnomalyError => "observability.anomaly-error",
                GetWebhookResponseEvent.ObservabilityErrorAnomaly => "observability.error-anomaly",
                GetWebhookResponseEvent.ObservabilityUsageAnomaly => "observability.usage-anomaly",
                GetWebhookResponseEvent.ProjectCreatedHyphen => "project-created",
                GetWebhookResponseEvent.ProjectRemovedHyphen => "project-removed",
                GetWebhookResponseEvent.ProjectCreated => "project.created",
                GetWebhookResponseEvent.ProjectDomainCreated => "project.domain.created",
                GetWebhookResponseEvent.ProjectDomainDeleted => "project.domain.deleted",
                GetWebhookResponseEvent.ProjectDomainMoved => "project.domain.moved",
                GetWebhookResponseEvent.ProjectDomainUnverified => "project.domain.unverified",
                GetWebhookResponseEvent.ProjectDomainUpdated => "project.domain.updated",
                GetWebhookResponseEvent.ProjectDomainVerified => "project.domain.verified",
                GetWebhookResponseEvent.ProjectEnvVariableCreated => "project.env-variable.created",
                GetWebhookResponseEvent.ProjectEnvVariableDeleted => "project.env-variable.deleted",
                GetWebhookResponseEvent.ProjectEnvVariableUpdated => "project.env-variable.updated",
                GetWebhookResponseEvent.ProjectRemoved => "project.removed",
                GetWebhookResponseEvent.ProjectRenamed => "project.renamed",
                GetWebhookResponseEvent.ProjectRollingReleaseAborted => "project.rolling-release.aborted",
                GetWebhookResponseEvent.ProjectRollingReleaseApproved => "project.rolling-release.approved",
                GetWebhookResponseEvent.ProjectRollingReleaseCompleted => "project.rolling-release.completed",
                GetWebhookResponseEvent.ProjectRollingReleaseStarted => "project.rolling-release.started",
                GetWebhookResponseEvent.TestWebhook => "test-webhook",
                GetWebhookResponseEvent.ThreadResolved => "thread.resolved",
                GetWebhookResponseEvent.ThreadUnresolved => "thread.unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookResponseEvent? ToEnum(string value)
        {
            return value switch
            {
                "ai-gateway.auto-reload.limit-reached" => GetWebhookResponseEvent.AiGatewayAutoReloadLimitReached,
                "ai-gateway.balance-depleted" => GetWebhookResponseEvent.AiGatewayBalanceDepleted,
                "alerts.triggered" => GetWebhookResponseEvent.AlertsTriggered,
                "botid.anomaly" => GetWebhookResponseEvent.BotidAnomaly,
                "budget.reached" => GetWebhookResponseEvent.BudgetReached,
                "comment.created" => GetWebhookResponseEvent.CommentCreated,
                "comment.deleted" => GetWebhookResponseEvent.CommentDeleted,
                "comment.mentioned" => GetWebhookResponseEvent.CommentMentioned,
                "comment.reaction-added" => GetWebhookResponseEvent.CommentReactionAdded,
                "comment.reaction-removed" => GetWebhookResponseEvent.CommentReactionRemoved,
                "comment.resolved" => GetWebhookResponseEvent.CommentResolved,
                "comment.unresolved" => GetWebhookResponseEvent.CommentUnresolved,
                "comment.updated" => GetWebhookResponseEvent.CommentUpdated,
                "deployment" => GetWebhookResponseEvent.Deployment,
                "deployment-canceled" => GetWebhookResponseEvent.DeploymentCanceledHyphen,
                "deployment-check-rerequested" => GetWebhookResponseEvent.DeploymentCheckRerequestedHyphen,
                "deployment-checks-completed" => GetWebhookResponseEvent.DeploymentChecksCompleted,
                "deployment-error" => GetWebhookResponseEvent.DeploymentErrorHyphen,
                "deployment-prepared" => GetWebhookResponseEvent.DeploymentPreparedHyphen,
                "deployment-ready" => GetWebhookResponseEvent.DeploymentReadyHyphen,
                "deployment.build-requested" => GetWebhookResponseEvent.DeploymentBuildRequested,
                "deployment.canceled" => GetWebhookResponseEvent.DeploymentCanceled,
                "deployment.check-rerequested" => GetWebhookResponseEvent.DeploymentCheckRerequested,
                "deployment.checkrun.cancel" => GetWebhookResponseEvent.DeploymentCheckrunCancel,
                "deployment.checkrun.start" => GetWebhookResponseEvent.DeploymentCheckrunStart,
                "deployment.checks.failed" => GetWebhookResponseEvent.DeploymentChecksFailed,
                "deployment.checks.succeeded" => GetWebhookResponseEvent.DeploymentChecksSucceeded,
                "deployment.cleanup" => GetWebhookResponseEvent.DeploymentCleanup,
                "deployment.created" => GetWebhookResponseEvent.DeploymentCreated,
                "deployment.error" => GetWebhookResponseEvent.DeploymentError,
                "deployment.integration.action.cancel" => GetWebhookResponseEvent.DeploymentIntegrationActionCancel,
                "deployment.integration.action.cleanup" => GetWebhookResponseEvent.DeploymentIntegrationActionCleanup,
                "deployment.integration.action.start" => GetWebhookResponseEvent.DeploymentIntegrationActionStart,
                "deployment.promoted" => GetWebhookResponseEvent.DeploymentPromoted,
                "deployment.ready" => GetWebhookResponseEvent.DeploymentReady,
                "deployment.rollback" => GetWebhookResponseEvent.DeploymentRollback,
                "deployment.succeeded" => GetWebhookResponseEvent.DeploymentSucceeded,
                "domain-created" => GetWebhookResponseEvent.DomainCreatedHyphen,
                "domain.auto-renew.changed" => GetWebhookResponseEvent.DomainAutoRenewChanged,
                "domain.certificate.add" => GetWebhookResponseEvent.DomainCertificateAdd,
                "domain.certificate.add.failed" => GetWebhookResponseEvent.DomainCertificateAddFailed,
                "domain.certificate.deleted" => GetWebhookResponseEvent.DomainCertificateDeleted,
                "domain.certificate.renew" => GetWebhookResponseEvent.DomainCertificateRenew,
                "domain.certificate.renew.failed" => GetWebhookResponseEvent.DomainCertificateRenewFailed,
                "domain.created" => GetWebhookResponseEvent.DomainCreated,
                "domain.dns.records.changed" => GetWebhookResponseEvent.DomainDnsRecordsChanged,
                "domain.renewal" => GetWebhookResponseEvent.DomainRenewal,
                "domain.renewal.failed" => GetWebhookResponseEvent.DomainRenewalFailed,
                "domain.transfer-in.completed" => GetWebhookResponseEvent.DomainTransferInCompleted,
                "domain.transfer-in.failed" => GetWebhookResponseEvent.DomainTransferInFailed,
                "domain.transfer-in.started" => GetWebhookResponseEvent.DomainTransferInStarted,
                "edge-config.created" => GetWebhookResponseEvent.EdgeConfigCreated,
                "edge-config.deleted" => GetWebhookResponseEvent.EdgeConfigDeleted,
                "edge-config.items.updated" => GetWebhookResponseEvent.EdgeConfigItemsUpdated,
                "firewall.attack" => GetWebhookResponseEvent.FirewallAttack,
                "firewall.custom-rule-anomaly" => GetWebhookResponseEvent.FirewallCustomRuleAnomaly,
                "firewall.system-rule-anomaly" => GetWebhookResponseEvent.FirewallSystemRuleAnomaly,
                "flag.created" => GetWebhookResponseEvent.FlagCreated,
                "flag.deleted" => GetWebhookResponseEvent.FlagDeleted,
                "flag.segment.created" => GetWebhookResponseEvent.FlagSegmentCreated,
                "flag.segment.deleted" => GetWebhookResponseEvent.FlagSegmentDeleted,
                "flag.segment.updated" => GetWebhookResponseEvent.FlagSegmentUpdated,
                "flag.updated" => GetWebhookResponseEvent.FlagUpdated,
                "function.archival-required" => GetWebhookResponseEvent.FunctionArchivalRequired,
                "function.removal-required" => GetWebhookResponseEvent.FunctionRemovalRequired,
                "integration-configuration-permission-updated" => GetWebhookResponseEvent.IntegrationConfigurationPermissionUpdatedHyphen,
                "integration-configuration-removed" => GetWebhookResponseEvent.IntegrationConfigurationRemovedHyphen,
                "integration-configuration-scope-change-confirmed" => GetWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmedHyphen,
                "integration-configuration.permission-upgraded" => GetWebhookResponseEvent.IntegrationConfigurationPermissionUpgraded,
                "integration-configuration.removed" => GetWebhookResponseEvent.IntegrationConfigurationRemoved,
                "integration-configuration.scope-change-confirmed" => GetWebhookResponseEvent.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration.transferred" => GetWebhookResponseEvent.IntegrationConfigurationTransferred,
                "integration-resource.project-connected" => GetWebhookResponseEvent.IntegrationResourceProjectConnected,
                "integration-resource.project-disconnected" => GetWebhookResponseEvent.IntegrationResourceProjectDisconnected,
                "marketplace.invoice.created" => GetWebhookResponseEvent.MarketplaceInvoiceCreated,
                "marketplace.invoice.notpaid" => GetWebhookResponseEvent.MarketplaceInvoiceNotpaid,
                "marketplace.invoice.overdue" => GetWebhookResponseEvent.MarketplaceInvoiceOverdue,
                "marketplace.invoice.paid" => GetWebhookResponseEvent.MarketplaceInvoicePaid,
                "marketplace.invoice.refunded" => GetWebhookResponseEvent.MarketplaceInvoiceRefunded,
                "marketplace.member.changed" => GetWebhookResponseEvent.MarketplaceMemberChanged,
                "message.created" => GetWebhookResponseEvent.MessageCreated,
                "message.deleted" => GetWebhookResponseEvent.MessageDeleted,
                "message.mentioned" => GetWebhookResponseEvent.MessageMentioned,
                "message.reaction-added" => GetWebhookResponseEvent.MessageReactionAdded,
                "message.reaction-removed" => GetWebhookResponseEvent.MessageReactionRemoved,
                "message.updated" => GetWebhookResponseEvent.MessageUpdated,
                "observability.anomaly" => GetWebhookResponseEvent.ObservabilityAnomaly,
                "observability.anomaly-error" => GetWebhookResponseEvent.ObservabilityAnomalyError,
                "observability.error-anomaly" => GetWebhookResponseEvent.ObservabilityErrorAnomaly,
                "observability.usage-anomaly" => GetWebhookResponseEvent.ObservabilityUsageAnomaly,
                "project-created" => GetWebhookResponseEvent.ProjectCreatedHyphen,
                "project-removed" => GetWebhookResponseEvent.ProjectRemovedHyphen,
                "project.created" => GetWebhookResponseEvent.ProjectCreated,
                "project.domain.created" => GetWebhookResponseEvent.ProjectDomainCreated,
                "project.domain.deleted" => GetWebhookResponseEvent.ProjectDomainDeleted,
                "project.domain.moved" => GetWebhookResponseEvent.ProjectDomainMoved,
                "project.domain.unverified" => GetWebhookResponseEvent.ProjectDomainUnverified,
                "project.domain.updated" => GetWebhookResponseEvent.ProjectDomainUpdated,
                "project.domain.verified" => GetWebhookResponseEvent.ProjectDomainVerified,
                "project.env-variable.created" => GetWebhookResponseEvent.ProjectEnvVariableCreated,
                "project.env-variable.deleted" => GetWebhookResponseEvent.ProjectEnvVariableDeleted,
                "project.env-variable.updated" => GetWebhookResponseEvent.ProjectEnvVariableUpdated,
                "project.removed" => GetWebhookResponseEvent.ProjectRemoved,
                "project.renamed" => GetWebhookResponseEvent.ProjectRenamed,
                "project.rolling-release.aborted" => GetWebhookResponseEvent.ProjectRollingReleaseAborted,
                "project.rolling-release.approved" => GetWebhookResponseEvent.ProjectRollingReleaseApproved,
                "project.rolling-release.completed" => GetWebhookResponseEvent.ProjectRollingReleaseCompleted,
                "project.rolling-release.started" => GetWebhookResponseEvent.ProjectRollingReleaseStarted,
                "test-webhook" => GetWebhookResponseEvent.TestWebhook,
                "thread.resolved" => GetWebhookResponseEvent.ThreadResolved,
                "thread.unresolved" => GetWebhookResponseEvent.ThreadUnresolved,
                _ => null,
            };
        }
    }
}