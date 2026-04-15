
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The webhooks events<br/>
    /// Example: deployment.created
    /// </summary>
    public enum GetWebhooksResponseVariant1ItemEvent
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
    public static class GetWebhooksResponseVariant1ItemEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhooksResponseVariant1ItemEvent value)
        {
            return value switch
            {
                GetWebhooksResponseVariant1ItemEvent.AiGatewayAutoReloadLimitReached => "ai-gateway.auto-reload.limit-reached",
                GetWebhooksResponseVariant1ItemEvent.AiGatewayBalanceDepleted => "ai-gateway.balance-depleted",
                GetWebhooksResponseVariant1ItemEvent.AlertsTriggered => "alerts.triggered",
                GetWebhooksResponseVariant1ItemEvent.BotidAnomaly => "botid.anomaly",
                GetWebhooksResponseVariant1ItemEvent.BudgetReached => "budget.reached",
                GetWebhooksResponseVariant1ItemEvent.CommentCreated => "comment.created",
                GetWebhooksResponseVariant1ItemEvent.CommentDeleted => "comment.deleted",
                GetWebhooksResponseVariant1ItemEvent.CommentMentioned => "comment.mentioned",
                GetWebhooksResponseVariant1ItemEvent.CommentReactionAdded => "comment.reaction-added",
                GetWebhooksResponseVariant1ItemEvent.CommentReactionRemoved => "comment.reaction-removed",
                GetWebhooksResponseVariant1ItemEvent.CommentResolved => "comment.resolved",
                GetWebhooksResponseVariant1ItemEvent.CommentUnresolved => "comment.unresolved",
                GetWebhooksResponseVariant1ItemEvent.CommentUpdated => "comment.updated",
                GetWebhooksResponseVariant1ItemEvent.Deployment => "deployment",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCanceledHyphen => "deployment-canceled",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCheckRerequestedHyphen => "deployment-check-rerequested",
                GetWebhooksResponseVariant1ItemEvent.DeploymentChecksCompleted => "deployment-checks-completed",
                GetWebhooksResponseVariant1ItemEvent.DeploymentErrorHyphen => "deployment-error",
                GetWebhooksResponseVariant1ItemEvent.DeploymentPreparedHyphen => "deployment-prepared",
                GetWebhooksResponseVariant1ItemEvent.DeploymentReadyHyphen => "deployment-ready",
                GetWebhooksResponseVariant1ItemEvent.DeploymentBuildRequested => "deployment.build-requested",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCanceled => "deployment.canceled",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCheckRerequested => "deployment.check-rerequested",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCheckrunCancel => "deployment.checkrun.cancel",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCheckrunStart => "deployment.checkrun.start",
                GetWebhooksResponseVariant1ItemEvent.DeploymentChecksFailed => "deployment.checks.failed",
                GetWebhooksResponseVariant1ItemEvent.DeploymentChecksSucceeded => "deployment.checks.succeeded",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCleanup => "deployment.cleanup",
                GetWebhooksResponseVariant1ItemEvent.DeploymentCreated => "deployment.created",
                GetWebhooksResponseVariant1ItemEvent.DeploymentError => "deployment.error",
                GetWebhooksResponseVariant1ItemEvent.DeploymentIntegrationActionCancel => "deployment.integration.action.cancel",
                GetWebhooksResponseVariant1ItemEvent.DeploymentIntegrationActionCleanup => "deployment.integration.action.cleanup",
                GetWebhooksResponseVariant1ItemEvent.DeploymentIntegrationActionStart => "deployment.integration.action.start",
                GetWebhooksResponseVariant1ItemEvent.DeploymentPromoted => "deployment.promoted",
                GetWebhooksResponseVariant1ItemEvent.DeploymentReady => "deployment.ready",
                GetWebhooksResponseVariant1ItemEvent.DeploymentRollback => "deployment.rollback",
                GetWebhooksResponseVariant1ItemEvent.DeploymentSucceeded => "deployment.succeeded",
                GetWebhooksResponseVariant1ItemEvent.DomainCreatedHyphen => "domain-created",
                GetWebhooksResponseVariant1ItemEvent.DomainAutoRenewChanged => "domain.auto-renew.changed",
                GetWebhooksResponseVariant1ItemEvent.DomainCertificateAdd => "domain.certificate.add",
                GetWebhooksResponseVariant1ItemEvent.DomainCertificateAddFailed => "domain.certificate.add.failed",
                GetWebhooksResponseVariant1ItemEvent.DomainCertificateDeleted => "domain.certificate.deleted",
                GetWebhooksResponseVariant1ItemEvent.DomainCertificateRenew => "domain.certificate.renew",
                GetWebhooksResponseVariant1ItemEvent.DomainCertificateRenewFailed => "domain.certificate.renew.failed",
                GetWebhooksResponseVariant1ItemEvent.DomainCreated => "domain.created",
                GetWebhooksResponseVariant1ItemEvent.DomainDnsRecordsChanged => "domain.dns.records.changed",
                GetWebhooksResponseVariant1ItemEvent.DomainRenewal => "domain.renewal",
                GetWebhooksResponseVariant1ItemEvent.DomainRenewalFailed => "domain.renewal.failed",
                GetWebhooksResponseVariant1ItemEvent.DomainTransferInCompleted => "domain.transfer-in.completed",
                GetWebhooksResponseVariant1ItemEvent.DomainTransferInFailed => "domain.transfer-in.failed",
                GetWebhooksResponseVariant1ItemEvent.DomainTransferInStarted => "domain.transfer-in.started",
                GetWebhooksResponseVariant1ItemEvent.EdgeConfigCreated => "edge-config.created",
                GetWebhooksResponseVariant1ItemEvent.EdgeConfigDeleted => "edge-config.deleted",
                GetWebhooksResponseVariant1ItemEvent.EdgeConfigItemsUpdated => "edge-config.items.updated",
                GetWebhooksResponseVariant1ItemEvent.FirewallAttack => "firewall.attack",
                GetWebhooksResponseVariant1ItemEvent.FirewallCustomRuleAnomaly => "firewall.custom-rule-anomaly",
                GetWebhooksResponseVariant1ItemEvent.FirewallSystemRuleAnomaly => "firewall.system-rule-anomaly",
                GetWebhooksResponseVariant1ItemEvent.FlagCreated => "flag.created",
                GetWebhooksResponseVariant1ItemEvent.FlagDeleted => "flag.deleted",
                GetWebhooksResponseVariant1ItemEvent.FlagSegmentCreated => "flag.segment.created",
                GetWebhooksResponseVariant1ItemEvent.FlagSegmentDeleted => "flag.segment.deleted",
                GetWebhooksResponseVariant1ItemEvent.FlagSegmentUpdated => "flag.segment.updated",
                GetWebhooksResponseVariant1ItemEvent.FlagUpdated => "flag.updated",
                GetWebhooksResponseVariant1ItemEvent.FunctionArchivalRequired => "function.archival-required",
                GetWebhooksResponseVariant1ItemEvent.FunctionRemovalRequired => "function.removal-required",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationPermissionUpdatedHyphen => "integration-configuration-permission-updated",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationRemovedHyphen => "integration-configuration-removed",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationScopeChangeConfirmedHyphen => "integration-configuration-scope-change-confirmed",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationPermissionUpgraded => "integration-configuration.permission-upgraded",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationRemoved => "integration-configuration.removed",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationScopeChangeConfirmed => "integration-configuration.scope-change-confirmed",
                GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationTransferred => "integration-configuration.transferred",
                GetWebhooksResponseVariant1ItemEvent.IntegrationResourceProjectConnected => "integration-resource.project-connected",
                GetWebhooksResponseVariant1ItemEvent.IntegrationResourceProjectDisconnected => "integration-resource.project-disconnected",
                GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceCreated => "marketplace.invoice.created",
                GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceNotpaid => "marketplace.invoice.notpaid",
                GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceOverdue => "marketplace.invoice.overdue",
                GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoicePaid => "marketplace.invoice.paid",
                GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceRefunded => "marketplace.invoice.refunded",
                GetWebhooksResponseVariant1ItemEvent.MarketplaceMemberChanged => "marketplace.member.changed",
                GetWebhooksResponseVariant1ItemEvent.MessageCreated => "message.created",
                GetWebhooksResponseVariant1ItemEvent.MessageDeleted => "message.deleted",
                GetWebhooksResponseVariant1ItemEvent.MessageMentioned => "message.mentioned",
                GetWebhooksResponseVariant1ItemEvent.MessageReactionAdded => "message.reaction-added",
                GetWebhooksResponseVariant1ItemEvent.MessageReactionRemoved => "message.reaction-removed",
                GetWebhooksResponseVariant1ItemEvent.MessageUpdated => "message.updated",
                GetWebhooksResponseVariant1ItemEvent.ObservabilityAnomaly => "observability.anomaly",
                GetWebhooksResponseVariant1ItemEvent.ObservabilityAnomalyError => "observability.anomaly-error",
                GetWebhooksResponseVariant1ItemEvent.ObservabilityErrorAnomaly => "observability.error-anomaly",
                GetWebhooksResponseVariant1ItemEvent.ObservabilityUsageAnomaly => "observability.usage-anomaly",
                GetWebhooksResponseVariant1ItemEvent.ProjectCreatedHyphen => "project-created",
                GetWebhooksResponseVariant1ItemEvent.ProjectRemovedHyphen => "project-removed",
                GetWebhooksResponseVariant1ItemEvent.ProjectCreated => "project.created",
                GetWebhooksResponseVariant1ItemEvent.ProjectDomainCreated => "project.domain.created",
                GetWebhooksResponseVariant1ItemEvent.ProjectDomainDeleted => "project.domain.deleted",
                GetWebhooksResponseVariant1ItemEvent.ProjectDomainMoved => "project.domain.moved",
                GetWebhooksResponseVariant1ItemEvent.ProjectDomainUnverified => "project.domain.unverified",
                GetWebhooksResponseVariant1ItemEvent.ProjectDomainUpdated => "project.domain.updated",
                GetWebhooksResponseVariant1ItemEvent.ProjectDomainVerified => "project.domain.verified",
                GetWebhooksResponseVariant1ItemEvent.ProjectEnvVariableCreated => "project.env-variable.created",
                GetWebhooksResponseVariant1ItemEvent.ProjectEnvVariableDeleted => "project.env-variable.deleted",
                GetWebhooksResponseVariant1ItemEvent.ProjectEnvVariableUpdated => "project.env-variable.updated",
                GetWebhooksResponseVariant1ItemEvent.ProjectRemoved => "project.removed",
                GetWebhooksResponseVariant1ItemEvent.ProjectRenamed => "project.renamed",
                GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseAborted => "project.rolling-release.aborted",
                GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseApproved => "project.rolling-release.approved",
                GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseCompleted => "project.rolling-release.completed",
                GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseStarted => "project.rolling-release.started",
                GetWebhooksResponseVariant1ItemEvent.TestWebhook => "test-webhook",
                GetWebhooksResponseVariant1ItemEvent.ThreadResolved => "thread.resolved",
                GetWebhooksResponseVariant1ItemEvent.ThreadUnresolved => "thread.unresolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhooksResponseVariant1ItemEvent? ToEnum(string value)
        {
            return value switch
            {
                "ai-gateway.auto-reload.limit-reached" => GetWebhooksResponseVariant1ItemEvent.AiGatewayAutoReloadLimitReached,
                "ai-gateway.balance-depleted" => GetWebhooksResponseVariant1ItemEvent.AiGatewayBalanceDepleted,
                "alerts.triggered" => GetWebhooksResponseVariant1ItemEvent.AlertsTriggered,
                "botid.anomaly" => GetWebhooksResponseVariant1ItemEvent.BotidAnomaly,
                "budget.reached" => GetWebhooksResponseVariant1ItemEvent.BudgetReached,
                "comment.created" => GetWebhooksResponseVariant1ItemEvent.CommentCreated,
                "comment.deleted" => GetWebhooksResponseVariant1ItemEvent.CommentDeleted,
                "comment.mentioned" => GetWebhooksResponseVariant1ItemEvent.CommentMentioned,
                "comment.reaction-added" => GetWebhooksResponseVariant1ItemEvent.CommentReactionAdded,
                "comment.reaction-removed" => GetWebhooksResponseVariant1ItemEvent.CommentReactionRemoved,
                "comment.resolved" => GetWebhooksResponseVariant1ItemEvent.CommentResolved,
                "comment.unresolved" => GetWebhooksResponseVariant1ItemEvent.CommentUnresolved,
                "comment.updated" => GetWebhooksResponseVariant1ItemEvent.CommentUpdated,
                "deployment" => GetWebhooksResponseVariant1ItemEvent.Deployment,
                "deployment-canceled" => GetWebhooksResponseVariant1ItemEvent.DeploymentCanceledHyphen,
                "deployment-check-rerequested" => GetWebhooksResponseVariant1ItemEvent.DeploymentCheckRerequestedHyphen,
                "deployment-checks-completed" => GetWebhooksResponseVariant1ItemEvent.DeploymentChecksCompleted,
                "deployment-error" => GetWebhooksResponseVariant1ItemEvent.DeploymentErrorHyphen,
                "deployment-prepared" => GetWebhooksResponseVariant1ItemEvent.DeploymentPreparedHyphen,
                "deployment-ready" => GetWebhooksResponseVariant1ItemEvent.DeploymentReadyHyphen,
                "deployment.build-requested" => GetWebhooksResponseVariant1ItemEvent.DeploymentBuildRequested,
                "deployment.canceled" => GetWebhooksResponseVariant1ItemEvent.DeploymentCanceled,
                "deployment.check-rerequested" => GetWebhooksResponseVariant1ItemEvent.DeploymentCheckRerequested,
                "deployment.checkrun.cancel" => GetWebhooksResponseVariant1ItemEvent.DeploymentCheckrunCancel,
                "deployment.checkrun.start" => GetWebhooksResponseVariant1ItemEvent.DeploymentCheckrunStart,
                "deployment.checks.failed" => GetWebhooksResponseVariant1ItemEvent.DeploymentChecksFailed,
                "deployment.checks.succeeded" => GetWebhooksResponseVariant1ItemEvent.DeploymentChecksSucceeded,
                "deployment.cleanup" => GetWebhooksResponseVariant1ItemEvent.DeploymentCleanup,
                "deployment.created" => GetWebhooksResponseVariant1ItemEvent.DeploymentCreated,
                "deployment.error" => GetWebhooksResponseVariant1ItemEvent.DeploymentError,
                "deployment.integration.action.cancel" => GetWebhooksResponseVariant1ItemEvent.DeploymentIntegrationActionCancel,
                "deployment.integration.action.cleanup" => GetWebhooksResponseVariant1ItemEvent.DeploymentIntegrationActionCleanup,
                "deployment.integration.action.start" => GetWebhooksResponseVariant1ItemEvent.DeploymentIntegrationActionStart,
                "deployment.promoted" => GetWebhooksResponseVariant1ItemEvent.DeploymentPromoted,
                "deployment.ready" => GetWebhooksResponseVariant1ItemEvent.DeploymentReady,
                "deployment.rollback" => GetWebhooksResponseVariant1ItemEvent.DeploymentRollback,
                "deployment.succeeded" => GetWebhooksResponseVariant1ItemEvent.DeploymentSucceeded,
                "domain-created" => GetWebhooksResponseVariant1ItemEvent.DomainCreatedHyphen,
                "domain.auto-renew.changed" => GetWebhooksResponseVariant1ItemEvent.DomainAutoRenewChanged,
                "domain.certificate.add" => GetWebhooksResponseVariant1ItemEvent.DomainCertificateAdd,
                "domain.certificate.add.failed" => GetWebhooksResponseVariant1ItemEvent.DomainCertificateAddFailed,
                "domain.certificate.deleted" => GetWebhooksResponseVariant1ItemEvent.DomainCertificateDeleted,
                "domain.certificate.renew" => GetWebhooksResponseVariant1ItemEvent.DomainCertificateRenew,
                "domain.certificate.renew.failed" => GetWebhooksResponseVariant1ItemEvent.DomainCertificateRenewFailed,
                "domain.created" => GetWebhooksResponseVariant1ItemEvent.DomainCreated,
                "domain.dns.records.changed" => GetWebhooksResponseVariant1ItemEvent.DomainDnsRecordsChanged,
                "domain.renewal" => GetWebhooksResponseVariant1ItemEvent.DomainRenewal,
                "domain.renewal.failed" => GetWebhooksResponseVariant1ItemEvent.DomainRenewalFailed,
                "domain.transfer-in.completed" => GetWebhooksResponseVariant1ItemEvent.DomainTransferInCompleted,
                "domain.transfer-in.failed" => GetWebhooksResponseVariant1ItemEvent.DomainTransferInFailed,
                "domain.transfer-in.started" => GetWebhooksResponseVariant1ItemEvent.DomainTransferInStarted,
                "edge-config.created" => GetWebhooksResponseVariant1ItemEvent.EdgeConfigCreated,
                "edge-config.deleted" => GetWebhooksResponseVariant1ItemEvent.EdgeConfigDeleted,
                "edge-config.items.updated" => GetWebhooksResponseVariant1ItemEvent.EdgeConfigItemsUpdated,
                "firewall.attack" => GetWebhooksResponseVariant1ItemEvent.FirewallAttack,
                "firewall.custom-rule-anomaly" => GetWebhooksResponseVariant1ItemEvent.FirewallCustomRuleAnomaly,
                "firewall.system-rule-anomaly" => GetWebhooksResponseVariant1ItemEvent.FirewallSystemRuleAnomaly,
                "flag.created" => GetWebhooksResponseVariant1ItemEvent.FlagCreated,
                "flag.deleted" => GetWebhooksResponseVariant1ItemEvent.FlagDeleted,
                "flag.segment.created" => GetWebhooksResponseVariant1ItemEvent.FlagSegmentCreated,
                "flag.segment.deleted" => GetWebhooksResponseVariant1ItemEvent.FlagSegmentDeleted,
                "flag.segment.updated" => GetWebhooksResponseVariant1ItemEvent.FlagSegmentUpdated,
                "flag.updated" => GetWebhooksResponseVariant1ItemEvent.FlagUpdated,
                "function.archival-required" => GetWebhooksResponseVariant1ItemEvent.FunctionArchivalRequired,
                "function.removal-required" => GetWebhooksResponseVariant1ItemEvent.FunctionRemovalRequired,
                "integration-configuration-permission-updated" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationPermissionUpdatedHyphen,
                "integration-configuration-removed" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationRemovedHyphen,
                "integration-configuration-scope-change-confirmed" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationScopeChangeConfirmedHyphen,
                "integration-configuration.permission-upgraded" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationPermissionUpgraded,
                "integration-configuration.removed" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationRemoved,
                "integration-configuration.scope-change-confirmed" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationScopeChangeConfirmed,
                "integration-configuration.transferred" => GetWebhooksResponseVariant1ItemEvent.IntegrationConfigurationTransferred,
                "integration-resource.project-connected" => GetWebhooksResponseVariant1ItemEvent.IntegrationResourceProjectConnected,
                "integration-resource.project-disconnected" => GetWebhooksResponseVariant1ItemEvent.IntegrationResourceProjectDisconnected,
                "marketplace.invoice.created" => GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceCreated,
                "marketplace.invoice.notpaid" => GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceNotpaid,
                "marketplace.invoice.overdue" => GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceOverdue,
                "marketplace.invoice.paid" => GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoicePaid,
                "marketplace.invoice.refunded" => GetWebhooksResponseVariant1ItemEvent.MarketplaceInvoiceRefunded,
                "marketplace.member.changed" => GetWebhooksResponseVariant1ItemEvent.MarketplaceMemberChanged,
                "message.created" => GetWebhooksResponseVariant1ItemEvent.MessageCreated,
                "message.deleted" => GetWebhooksResponseVariant1ItemEvent.MessageDeleted,
                "message.mentioned" => GetWebhooksResponseVariant1ItemEvent.MessageMentioned,
                "message.reaction-added" => GetWebhooksResponseVariant1ItemEvent.MessageReactionAdded,
                "message.reaction-removed" => GetWebhooksResponseVariant1ItemEvent.MessageReactionRemoved,
                "message.updated" => GetWebhooksResponseVariant1ItemEvent.MessageUpdated,
                "observability.anomaly" => GetWebhooksResponseVariant1ItemEvent.ObservabilityAnomaly,
                "observability.anomaly-error" => GetWebhooksResponseVariant1ItemEvent.ObservabilityAnomalyError,
                "observability.error-anomaly" => GetWebhooksResponseVariant1ItemEvent.ObservabilityErrorAnomaly,
                "observability.usage-anomaly" => GetWebhooksResponseVariant1ItemEvent.ObservabilityUsageAnomaly,
                "project-created" => GetWebhooksResponseVariant1ItemEvent.ProjectCreatedHyphen,
                "project-removed" => GetWebhooksResponseVariant1ItemEvent.ProjectRemovedHyphen,
                "project.created" => GetWebhooksResponseVariant1ItemEvent.ProjectCreated,
                "project.domain.created" => GetWebhooksResponseVariant1ItemEvent.ProjectDomainCreated,
                "project.domain.deleted" => GetWebhooksResponseVariant1ItemEvent.ProjectDomainDeleted,
                "project.domain.moved" => GetWebhooksResponseVariant1ItemEvent.ProjectDomainMoved,
                "project.domain.unverified" => GetWebhooksResponseVariant1ItemEvent.ProjectDomainUnverified,
                "project.domain.updated" => GetWebhooksResponseVariant1ItemEvent.ProjectDomainUpdated,
                "project.domain.verified" => GetWebhooksResponseVariant1ItemEvent.ProjectDomainVerified,
                "project.env-variable.created" => GetWebhooksResponseVariant1ItemEvent.ProjectEnvVariableCreated,
                "project.env-variable.deleted" => GetWebhooksResponseVariant1ItemEvent.ProjectEnvVariableDeleted,
                "project.env-variable.updated" => GetWebhooksResponseVariant1ItemEvent.ProjectEnvVariableUpdated,
                "project.removed" => GetWebhooksResponseVariant1ItemEvent.ProjectRemoved,
                "project.renamed" => GetWebhooksResponseVariant1ItemEvent.ProjectRenamed,
                "project.rolling-release.aborted" => GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseAborted,
                "project.rolling-release.approved" => GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseApproved,
                "project.rolling-release.completed" => GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseCompleted,
                "project.rolling-release.started" => GetWebhooksResponseVariant1ItemEvent.ProjectRollingReleaseStarted,
                "test-webhook" => GetWebhooksResponseVariant1ItemEvent.TestWebhook,
                "thread.resolved" => GetWebhooksResponseVariant1ItemEvent.ThreadResolved,
                "thread.unresolved" => GetWebhooksResponseVariant1ItemEvent.ThreadUnresolved,
                _ => null,
            };
        }
    }
}