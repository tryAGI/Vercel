
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2Connection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Oauth2Connection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userConnection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? UserConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userPreference")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? UserPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userSudo")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? UserSudo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAuthn")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? WebAuthn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroup")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AccessGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiGatewayUsage")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AiGatewayUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertRules")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AlertRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasGlobal")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AliasGlobal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyticsSampling")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AnalyticsSampling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyticsUsage")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AnalyticsUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyAiGateway")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ApiKeyAiGateway { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyOwnedBySelf")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ApiKeyOwnedBySelf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2Application")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Oauth2Application { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelAppInstallation")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? VercelAppInstallation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelAppInstallationRequest")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? VercelAppInstallationRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auditLog")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AuditLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingAddress")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingInformation")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingInvoice")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingInvoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingInvoiceEmailRecipient")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingInvoiceEmailRecipient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingInvoiceLanguage")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingInvoiceLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlan")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPurchaseOrder")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingPurchaseOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingRefund")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingRefund { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingTaxId")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BillingTaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Blob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobStoreTokenSet")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BlobStoreTokenSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Budget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheArtifact")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? CacheArtifact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheArtifactUsageEvent")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? CacheArtifactUsageEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeChecks")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? CodeChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciInvocations")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? CiInvocations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ciLogs")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? CiLogs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentBuilds")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ConcurrentBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Connect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfiguration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ConnectConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connexClient")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ConnexClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connexClientProject")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ConnexClientProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connexToken")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ConnexToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachineDefault")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BuildMachineDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCacheBillingSettings")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DataCacheBillingSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDeploymentProtection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DefaultDeploymentProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainAcceptDelegation")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainAcceptDelegation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainAuthCodes")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainAuthCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainCertificate")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainCertificate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainCheckConfig")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainCheckConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainMove")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainMove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainPurchase")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainRecord")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainRecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainTransferIn")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DomainTransferIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drain")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Drain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfig")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? EdgeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigItem")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? EdgeConfigItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigSchema")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? EdgeConfigSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigToken")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? EdgeConfigToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointVerification")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? EndpointVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUpload")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? FileUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagsExplorerSubscription")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? FlagsExplorerSubscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepository")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? GitRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptimizationNewPrice")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ImageOptimizationNewPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Integration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationAccount")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfiguration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationProjects")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationConfigurationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationRole")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationConfigurationRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationTransfer")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationConfigurationTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationDeploymentAction")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationDeploymentAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationEvent")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationLog")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationResource")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationResourceData")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationResourceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationResourceReplCommand")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationResourceReplCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationResourceSecrets")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationResourceSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationSSOSession")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationSSOSession { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationStrict")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationStrict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationStoreTokenSet")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationStoreTokenSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationVercelConfigurationOverride")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationVercelConfigurationOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationPullRequest")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IntegrationPullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBlocking")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? IpBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobGlobal")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? JobGlobal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logDrain")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? LogDrain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplaceBillingData")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MarketplaceBillingData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplaceExperimentationEdgeConfigData")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MarketplaceExperimentationEdgeConfigData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplaceExperimentationItem")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MarketplaceExperimentationItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplaceInstallationMember")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MarketplaceInstallationMember { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplaceInvoice")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MarketplaceInvoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplaceSettings")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MarketplaceSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Monitoring")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Monitoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoringAlert")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MonitoringAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoringChart")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MonitoringChart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoringQuery")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MonitoringQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitoringSettings")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? MonitoringSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationCustomerBudget")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationCustomerBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDeploymentFailed")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDeploymentFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainConfiguration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainExpire")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainExpire { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainMoved")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainMoved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainPurchase")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainRenewal")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainRenewal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainTransfer")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationDomainUnverified")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationDomainUnverified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("NotificationMonitoringAlert")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationMonitoringAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationPaymentFailed")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationPaymentFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationPreferences")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationPreferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationStatementOfReasons")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationStatementOfReasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationUsageAlert")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? NotificationUsageAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityConfiguration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ObservabilityConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityFunnel")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ObservabilityFunnel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityNotebook")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ObservabilityNotebook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openTelemetryEndpoint")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? OpenTelemetryEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownEvent")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? OwnEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationDomain")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? OrganizationDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtectionInvoiceItem")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PasswordProtectionInvoiceItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethod")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Postgres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgresStoreTokenSet")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PostgresStoreTokenSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateCloudAccount")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PrivateCloudAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectTransferIn")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectTransferIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proTrialOnboarding")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProTrialOnboarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? RateLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redis")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Redis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redisStoreTokenSet")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? RedisStoreTokenSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? RemoteCaching { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samlConfig")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SamlConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitiveEnvironmentVariablePolicy")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SensitiveEnvironmentVariablePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedEnvVars")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SharedEnvVars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedEnvVarsProduction")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SharedEnvVarsProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceRun")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SpaceRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storeTransfer")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? StoreTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportCase")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SupportCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportCaseComment")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SupportCaseComment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamAccessRequest")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamAccessRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamFellowMembership")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamFellowMembership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamGitExclusivity")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamGitExclusivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamInvite")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamInvite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamInviteCode")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamInviteCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamJoin")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamJoin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamMemberMfaStatus")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamMemberMfaStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamMicrofrontends")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamMicrofrontends { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamOwnMembership")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamOwnMembership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamOwnMembershipDisconnectSAML")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TeamOwnMembershipDisconnectSAML { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolbarComment")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ToolbarComment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageCycle")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? UsageCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelRun")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? VercelRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpcPeeringConnection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? VpcPeeringConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalyticsPlan")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? WebAnalyticsPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook-event")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? WebhookEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasProject")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AliasProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasProtectionBypass")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? AliasProtectionBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulkRedirects")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BulkRedirects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachine")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? BuildMachine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationLink")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ConnectConfigurationLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCacheNamespace")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DataCacheNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Deployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentBuildLogs")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentBuildLogs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentCheck")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentCheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentCheckPreview")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentCheckPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentCheckReRunFromProductionBranch")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentCheckReRunFromProductionBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentProductionGit")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentProductionGit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentV0")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentV0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentPreview")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentPrivate")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentPrivate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentPromote")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentPromote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentRollback")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? DeploymentRollback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeCacheNamespace")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? EdgeCacheNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Logs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logsPreset")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? LogsPreset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityData")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ObservabilityData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onDemandBuild")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? OnDemandBuild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onDemandConcurrency")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? OnDemandConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? OptionsAllowlist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PasswordProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateLinkEndpoint")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PrivateLinkEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productionAliasProtectionBypass")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProductionAliasProtectionBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectAccessGroup")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectAccessGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectAnalyticsSampling")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectAnalyticsSampling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectAnalyticsUsage")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectAnalyticsUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectCheck")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectCheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectCheckRun")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectCheckRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDelegatedProtection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDelegatedProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDeploymentExpiration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDeploymentExpiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDeploymentHook")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDeploymentHook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDeploymentProtectionStrict")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDeploymentProtectionStrict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDomain")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDomainCheckConfig")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDomainCheckConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDomainMove")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectDomainMove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectEvent")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectEnvVars")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectEnvVars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectEnvVarsProduction")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectEnvVarsProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectEnvVarsUnownedByIntegration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectEnvVarsUnownedByIntegration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFlags")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectFlags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFlagsProduction")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectFlagsProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectFromV0")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectFromV0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIntegrationConfiguration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectIntegrationConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectLink")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectMember")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectMember { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectMonitoring")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectMonitoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectOIDCToken")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectOIDCToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectPermissions")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectProductionBranch")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectProductionBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectProtectionBypass")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectProtectionBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectRollingRelease")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectRollingRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSupportCase")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectSupportCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSupportCaseComment")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectSupportCaseComment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectTier")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectTransfer")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectTransferOut")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectTransferOut { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectUsage")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ProjectUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageIntegrity")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? PageIntegrity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seawallConfig")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SeawallConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityPlusConfiguration")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SecurityPlusConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareableLinkStrict")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ShareableLinkStrict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedEnvVarConnection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SharedEnvVarConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtection")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? SkewProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedIps")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TrustedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedSources")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? TrustedSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0Chat")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? V0Chat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::System.Collections.Generic.IList<global::Vercel.ACLAction>? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectPermissions" /> class.
        /// </summary>
        /// <param name="oauth2Connection"></param>
        /// <param name="organization"></param>
        /// <param name="user"></param>
        /// <param name="userConnection"></param>
        /// <param name="userPreference"></param>
        /// <param name="userSudo"></param>
        /// <param name="webAuthn"></param>
        /// <param name="accessGroup"></param>
        /// <param name="agent"></param>
        /// <param name="aiGatewayUsage"></param>
        /// <param name="alerts"></param>
        /// <param name="alertRules"></param>
        /// <param name="aliasGlobal"></param>
        /// <param name="analyticsSampling"></param>
        /// <param name="analyticsUsage"></param>
        /// <param name="apiKey"></param>
        /// <param name="apiKeyAiGateway"></param>
        /// <param name="apiKeyOwnedBySelf"></param>
        /// <param name="oauth2Application"></param>
        /// <param name="vercelAppInstallation"></param>
        /// <param name="vercelAppInstallationRequest"></param>
        /// <param name="auditLog"></param>
        /// <param name="billingAddress"></param>
        /// <param name="billingInformation"></param>
        /// <param name="billingInvoice"></param>
        /// <param name="billingInvoiceEmailRecipient"></param>
        /// <param name="billingInvoiceLanguage"></param>
        /// <param name="billingPlan"></param>
        /// <param name="billingPurchaseOrder"></param>
        /// <param name="billingRefund"></param>
        /// <param name="billingTaxId"></param>
        /// <param name="blob"></param>
        /// <param name="blobStoreTokenSet"></param>
        /// <param name="budget"></param>
        /// <param name="cacheArtifact"></param>
        /// <param name="cacheArtifactUsageEvent"></param>
        /// <param name="codeChecks"></param>
        /// <param name="ciInvocations"></param>
        /// <param name="ciLogs"></param>
        /// <param name="concurrentBuilds"></param>
        /// <param name="connect"></param>
        /// <param name="connectConfiguration"></param>
        /// <param name="connexClient"></param>
        /// <param name="connexClientProject"></param>
        /// <param name="connexToken"></param>
        /// <param name="buildMachineDefault"></param>
        /// <param name="dataCacheBillingSettings"></param>
        /// <param name="defaultDeploymentProtection"></param>
        /// <param name="domain"></param>
        /// <param name="domainAcceptDelegation"></param>
        /// <param name="domainAuthCodes"></param>
        /// <param name="domainCertificate"></param>
        /// <param name="domainCheckConfig"></param>
        /// <param name="domainMove"></param>
        /// <param name="domainPurchase"></param>
        /// <param name="domainRecord"></param>
        /// <param name="domainTransferIn"></param>
        /// <param name="drain"></param>
        /// <param name="edgeConfig"></param>
        /// <param name="edgeConfigItem"></param>
        /// <param name="edgeConfigSchema"></param>
        /// <param name="edgeConfigToken"></param>
        /// <param name="endpointVerification"></param>
        /// <param name="event"></param>
        /// <param name="fileUpload"></param>
        /// <param name="flagsExplorerSubscription"></param>
        /// <param name="gitRepository"></param>
        /// <param name="imageOptimizationNewPrice"></param>
        /// <param name="integration"></param>
        /// <param name="integrationAccount"></param>
        /// <param name="integrationConfiguration"></param>
        /// <param name="integrationConfigurationProjects"></param>
        /// <param name="integrationConfigurationRole"></param>
        /// <param name="integrationConfigurationTransfer"></param>
        /// <param name="integrationDeploymentAction"></param>
        /// <param name="integrationEvent"></param>
        /// <param name="integrationLog"></param>
        /// <param name="integrationResource"></param>
        /// <param name="integrationResourceData"></param>
        /// <param name="integrationResourceReplCommand"></param>
        /// <param name="integrationResourceSecrets"></param>
        /// <param name="integrationSSOSession"></param>
        /// <param name="integrationStrict"></param>
        /// <param name="integrationStoreTokenSet"></param>
        /// <param name="integrationVercelConfigurationOverride"></param>
        /// <param name="integrationPullRequest"></param>
        /// <param name="ipBlocking"></param>
        /// <param name="jobGlobal"></param>
        /// <param name="logDrain"></param>
        /// <param name="marketplaceBillingData"></param>
        /// <param name="marketplaceExperimentationEdgeConfigData"></param>
        /// <param name="marketplaceExperimentationItem"></param>
        /// <param name="marketplaceInstallationMember"></param>
        /// <param name="marketplaceInvoice"></param>
        /// <param name="marketplaceSettings"></param>
        /// <param name="monitoring"></param>
        /// <param name="monitoringAlert"></param>
        /// <param name="monitoringChart"></param>
        /// <param name="monitoringQuery"></param>
        /// <param name="monitoringSettings"></param>
        /// <param name="notificationCustomerBudget"></param>
        /// <param name="notificationDeploymentFailed"></param>
        /// <param name="notificationDomainConfiguration"></param>
        /// <param name="notificationDomainExpire"></param>
        /// <param name="notificationDomainMoved"></param>
        /// <param name="notificationDomainPurchase"></param>
        /// <param name="notificationDomainRenewal"></param>
        /// <param name="notificationDomainTransfer"></param>
        /// <param name="notificationDomainUnverified"></param>
        /// <param name="notificationMonitoringAlert"></param>
        /// <param name="notificationPaymentFailed"></param>
        /// <param name="notificationPreferences"></param>
        /// <param name="notificationStatementOfReasons"></param>
        /// <param name="notificationUsageAlert"></param>
        /// <param name="observabilityConfiguration"></param>
        /// <param name="observabilityFunnel"></param>
        /// <param name="observabilityNotebook"></param>
        /// <param name="openTelemetryEndpoint"></param>
        /// <param name="ownEvent"></param>
        /// <param name="organizationDomain"></param>
        /// <param name="passwordProtectionInvoiceItem"></param>
        /// <param name="paymentMethod"></param>
        /// <param name="permissions"></param>
        /// <param name="postgres"></param>
        /// <param name="postgresStoreTokenSet"></param>
        /// <param name="previewDeploymentSuffix"></param>
        /// <param name="privateCloudAccount"></param>
        /// <param name="projectTransferIn"></param>
        /// <param name="proTrialOnboarding"></param>
        /// <param name="rateLimit"></param>
        /// <param name="redis"></param>
        /// <param name="redisStoreTokenSet"></param>
        /// <param name="remoteCaching"></param>
        /// <param name="repository"></param>
        /// <param name="samlConfig"></param>
        /// <param name="secret"></param>
        /// <param name="sensitiveEnvironmentVariablePolicy"></param>
        /// <param name="sharedEnvVars"></param>
        /// <param name="sharedEnvVarsProduction"></param>
        /// <param name="space"></param>
        /// <param name="spaceRun"></param>
        /// <param name="storeTransfer"></param>
        /// <param name="supportCase"></param>
        /// <param name="supportCaseComment"></param>
        /// <param name="team"></param>
        /// <param name="teamAccessRequest"></param>
        /// <param name="teamFellowMembership"></param>
        /// <param name="teamGitExclusivity"></param>
        /// <param name="teamInvite"></param>
        /// <param name="teamInviteCode"></param>
        /// <param name="teamJoin"></param>
        /// <param name="teamMemberMfaStatus"></param>
        /// <param name="teamMicrofrontends"></param>
        /// <param name="teamOwnMembership"></param>
        /// <param name="teamOwnMembershipDisconnectSAML"></param>
        /// <param name="token"></param>
        /// <param name="toolbarComment"></param>
        /// <param name="usage"></param>
        /// <param name="usageCycle"></param>
        /// <param name="vercelRun"></param>
        /// <param name="vpcPeeringConnection"></param>
        /// <param name="webAnalyticsPlan"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEvent"></param>
        /// <param name="aliasProject"></param>
        /// <param name="aliasProtectionBypass"></param>
        /// <param name="bulkRedirects"></param>
        /// <param name="buildMachine"></param>
        /// <param name="connectConfigurationLink"></param>
        /// <param name="dataCacheNamespace"></param>
        /// <param name="deployment"></param>
        /// <param name="deploymentBuildLogs"></param>
        /// <param name="deploymentCheck"></param>
        /// <param name="deploymentCheckPreview"></param>
        /// <param name="deploymentCheckReRunFromProductionBranch"></param>
        /// <param name="deploymentProductionGit"></param>
        /// <param name="deploymentV0"></param>
        /// <param name="deploymentPreview"></param>
        /// <param name="deploymentPrivate"></param>
        /// <param name="deploymentPromote"></param>
        /// <param name="deploymentRollback"></param>
        /// <param name="edgeCacheNamespace"></param>
        /// <param name="environments"></param>
        /// <param name="job"></param>
        /// <param name="logs"></param>
        /// <param name="logsPreset"></param>
        /// <param name="observabilityData"></param>
        /// <param name="onDemandBuild"></param>
        /// <param name="onDemandConcurrency"></param>
        /// <param name="optionsAllowlist"></param>
        /// <param name="passwordProtection"></param>
        /// <param name="privateLinkEndpoint"></param>
        /// <param name="productionAliasProtectionBypass"></param>
        /// <param name="project"></param>
        /// <param name="projectAccessGroup"></param>
        /// <param name="projectAnalyticsSampling"></param>
        /// <param name="projectAnalyticsUsage"></param>
        /// <param name="projectCheck"></param>
        /// <param name="projectCheckRun"></param>
        /// <param name="projectDelegatedProtection"></param>
        /// <param name="projectDeploymentExpiration"></param>
        /// <param name="projectDeploymentHook"></param>
        /// <param name="projectDeploymentProtectionStrict"></param>
        /// <param name="projectDomain"></param>
        /// <param name="projectDomainCheckConfig"></param>
        /// <param name="projectDomainMove"></param>
        /// <param name="projectEvent"></param>
        /// <param name="projectEnvVars"></param>
        /// <param name="projectEnvVarsProduction"></param>
        /// <param name="projectEnvVarsUnownedByIntegration"></param>
        /// <param name="projectFlags"></param>
        /// <param name="projectFlagsProduction"></param>
        /// <param name="projectFromV0"></param>
        /// <param name="projectId"></param>
        /// <param name="projectIntegrationConfiguration"></param>
        /// <param name="projectLink"></param>
        /// <param name="projectMember"></param>
        /// <param name="projectMonitoring"></param>
        /// <param name="projectOIDCToken"></param>
        /// <param name="projectPermissions"></param>
        /// <param name="projectProductionBranch"></param>
        /// <param name="projectProtectionBypass"></param>
        /// <param name="projectRollingRelease"></param>
        /// <param name="projectRoutes"></param>
        /// <param name="projectSupportCase"></param>
        /// <param name="projectSupportCaseComment"></param>
        /// <param name="projectTier"></param>
        /// <param name="projectTransfer"></param>
        /// <param name="projectTransferOut"></param>
        /// <param name="projectUsage"></param>
        /// <param name="pageIntegrity"></param>
        /// <param name="seawallConfig"></param>
        /// <param name="securityPlusConfiguration"></param>
        /// <param name="shareableLinkStrict"></param>
        /// <param name="sharedEnvVarConnection"></param>
        /// <param name="skewProtection"></param>
        /// <param name="analytics"></param>
        /// <param name="trustedIps"></param>
        /// <param name="trustedSources"></param>
        /// <param name="v0Chat"></param>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectPermissions(
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? oauth2Connection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? organization,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? user,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? userConnection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? userPreference,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? userSudo,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? webAuthn,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? accessGroup,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? agent,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? aiGatewayUsage,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? alerts,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? alertRules,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? aliasGlobal,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? analyticsSampling,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? analyticsUsage,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? apiKey,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? apiKeyAiGateway,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? apiKeyOwnedBySelf,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? oauth2Application,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? vercelAppInstallation,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? vercelAppInstallationRequest,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? auditLog,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingAddress,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingInformation,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingInvoice,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingInvoiceEmailRecipient,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingInvoiceLanguage,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingPlan,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingPurchaseOrder,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingRefund,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? billingTaxId,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? blob,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? blobStoreTokenSet,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? budget,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? cacheArtifact,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? cacheArtifactUsageEvent,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? codeChecks,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ciInvocations,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ciLogs,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? concurrentBuilds,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? connect,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? connectConfiguration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? connexClient,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? connexClientProject,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? connexToken,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? buildMachineDefault,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? dataCacheBillingSettings,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? defaultDeploymentProtection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domain,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainAcceptDelegation,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainAuthCodes,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainCertificate,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainCheckConfig,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainMove,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainPurchase,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainRecord,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? domainTransferIn,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? drain,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? edgeConfig,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? edgeConfigItem,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? edgeConfigSchema,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? edgeConfigToken,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? endpointVerification,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? @event,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? fileUpload,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? flagsExplorerSubscription,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? gitRepository,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? imageOptimizationNewPrice,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationAccount,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationConfiguration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationConfigurationProjects,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationConfigurationRole,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationConfigurationTransfer,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationDeploymentAction,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationEvent,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationLog,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationResource,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationResourceData,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationResourceReplCommand,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationResourceSecrets,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationSSOSession,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationStrict,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationStoreTokenSet,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationVercelConfigurationOverride,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? integrationPullRequest,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ipBlocking,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? jobGlobal,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? logDrain,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? marketplaceBillingData,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? marketplaceExperimentationEdgeConfigData,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? marketplaceExperimentationItem,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? marketplaceInstallationMember,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? marketplaceInvoice,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? marketplaceSettings,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? monitoring,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? monitoringAlert,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? monitoringChart,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? monitoringQuery,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? monitoringSettings,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationCustomerBudget,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDeploymentFailed,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainConfiguration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainExpire,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainMoved,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainPurchase,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainRenewal,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainTransfer,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationDomainUnverified,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationMonitoringAlert,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationPaymentFailed,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationPreferences,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationStatementOfReasons,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? notificationUsageAlert,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? observabilityConfiguration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? observabilityFunnel,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? observabilityNotebook,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? openTelemetryEndpoint,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? ownEvent,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? organizationDomain,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? passwordProtectionInvoiceItem,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? paymentMethod,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? permissions,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? postgres,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? postgresStoreTokenSet,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? previewDeploymentSuffix,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? privateCloudAccount,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectTransferIn,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? proTrialOnboarding,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? rateLimit,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? redis,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? redisStoreTokenSet,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? remoteCaching,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? repository,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? samlConfig,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? secret,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? sensitiveEnvironmentVariablePolicy,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? sharedEnvVars,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? sharedEnvVarsProduction,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? space,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? spaceRun,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? storeTransfer,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? supportCase,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? supportCaseComment,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? team,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamAccessRequest,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamFellowMembership,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamGitExclusivity,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamInvite,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamInviteCode,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamJoin,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamMemberMfaStatus,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamMicrofrontends,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamOwnMembership,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? teamOwnMembershipDisconnectSAML,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? token,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? toolbarComment,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? usage,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? usageCycle,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? vercelRun,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? vpcPeeringConnection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? webAnalyticsPlan,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? webhook,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? webhookEvent,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? aliasProject,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? aliasProtectionBypass,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? bulkRedirects,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? buildMachine,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? connectConfigurationLink,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? dataCacheNamespace,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deployment,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentBuildLogs,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentCheck,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentCheckPreview,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentCheckReRunFromProductionBranch,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentProductionGit,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentV0,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentPreview,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentPrivate,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentPromote,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? deploymentRollback,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? edgeCacheNamespace,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? environments,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? job,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? logs,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? logsPreset,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? observabilityData,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? onDemandBuild,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? onDemandConcurrency,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? optionsAllowlist,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? passwordProtection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? privateLinkEndpoint,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? productionAliasProtectionBypass,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? project,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectAccessGroup,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectAnalyticsSampling,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectAnalyticsUsage,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectCheck,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectCheckRun,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDelegatedProtection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDeploymentExpiration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDeploymentHook,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDeploymentProtectionStrict,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDomain,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDomainCheckConfig,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectDomainMove,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectEvent,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectEnvVars,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectEnvVarsProduction,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectEnvVarsUnownedByIntegration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectFlags,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectFlagsProduction,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectFromV0,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectId,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectIntegrationConfiguration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectLink,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectMember,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectMonitoring,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectOIDCToken,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectPermissions,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectProductionBranch,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectProtectionBypass,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectRollingRelease,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectRoutes,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectSupportCase,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectSupportCaseComment,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectTier,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectTransfer,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectTransferOut,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? projectUsage,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? pageIntegrity,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? seawallConfig,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? securityPlusConfiguration,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? shareableLinkStrict,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? sharedEnvVarConnection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? skewProtection,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? analytics,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? trustedIps,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? trustedSources,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? v0Chat,
            global::System.Collections.Generic.IList<global::Vercel.ACLAction>? webAnalytics)
        {
            this.Oauth2Connection = oauth2Connection;
            this.Organization = organization;
            this.User = user;
            this.UserConnection = userConnection;
            this.UserPreference = userPreference;
            this.UserSudo = userSudo;
            this.WebAuthn = webAuthn;
            this.AccessGroup = accessGroup;
            this.Agent = agent;
            this.AiGatewayUsage = aiGatewayUsage;
            this.Alerts = alerts;
            this.AlertRules = alertRules;
            this.AliasGlobal = aliasGlobal;
            this.AnalyticsSampling = analyticsSampling;
            this.AnalyticsUsage = analyticsUsage;
            this.ApiKey = apiKey;
            this.ApiKeyAiGateway = apiKeyAiGateway;
            this.ApiKeyOwnedBySelf = apiKeyOwnedBySelf;
            this.Oauth2Application = oauth2Application;
            this.VercelAppInstallation = vercelAppInstallation;
            this.VercelAppInstallationRequest = vercelAppInstallationRequest;
            this.AuditLog = auditLog;
            this.BillingAddress = billingAddress;
            this.BillingInformation = billingInformation;
            this.BillingInvoice = billingInvoice;
            this.BillingInvoiceEmailRecipient = billingInvoiceEmailRecipient;
            this.BillingInvoiceLanguage = billingInvoiceLanguage;
            this.BillingPlan = billingPlan;
            this.BillingPurchaseOrder = billingPurchaseOrder;
            this.BillingRefund = billingRefund;
            this.BillingTaxId = billingTaxId;
            this.Blob = blob;
            this.BlobStoreTokenSet = blobStoreTokenSet;
            this.Budget = budget;
            this.CacheArtifact = cacheArtifact;
            this.CacheArtifactUsageEvent = cacheArtifactUsageEvent;
            this.CodeChecks = codeChecks;
            this.CiInvocations = ciInvocations;
            this.CiLogs = ciLogs;
            this.ConcurrentBuilds = concurrentBuilds;
            this.Connect = connect;
            this.ConnectConfiguration = connectConfiguration;
            this.ConnexClient = connexClient;
            this.ConnexClientProject = connexClientProject;
            this.ConnexToken = connexToken;
            this.BuildMachineDefault = buildMachineDefault;
            this.DataCacheBillingSettings = dataCacheBillingSettings;
            this.DefaultDeploymentProtection = defaultDeploymentProtection;
            this.Domain = domain;
            this.DomainAcceptDelegation = domainAcceptDelegation;
            this.DomainAuthCodes = domainAuthCodes;
            this.DomainCertificate = domainCertificate;
            this.DomainCheckConfig = domainCheckConfig;
            this.DomainMove = domainMove;
            this.DomainPurchase = domainPurchase;
            this.DomainRecord = domainRecord;
            this.DomainTransferIn = domainTransferIn;
            this.Drain = drain;
            this.EdgeConfig = edgeConfig;
            this.EdgeConfigItem = edgeConfigItem;
            this.EdgeConfigSchema = edgeConfigSchema;
            this.EdgeConfigToken = edgeConfigToken;
            this.EndpointVerification = endpointVerification;
            this.Event = @event;
            this.FileUpload = fileUpload;
            this.FlagsExplorerSubscription = flagsExplorerSubscription;
            this.GitRepository = gitRepository;
            this.ImageOptimizationNewPrice = imageOptimizationNewPrice;
            this.Integration = integration;
            this.IntegrationAccount = integrationAccount;
            this.IntegrationConfiguration = integrationConfiguration;
            this.IntegrationConfigurationProjects = integrationConfigurationProjects;
            this.IntegrationConfigurationRole = integrationConfigurationRole;
            this.IntegrationConfigurationTransfer = integrationConfigurationTransfer;
            this.IntegrationDeploymentAction = integrationDeploymentAction;
            this.IntegrationEvent = integrationEvent;
            this.IntegrationLog = integrationLog;
            this.IntegrationResource = integrationResource;
            this.IntegrationResourceData = integrationResourceData;
            this.IntegrationResourceReplCommand = integrationResourceReplCommand;
            this.IntegrationResourceSecrets = integrationResourceSecrets;
            this.IntegrationSSOSession = integrationSSOSession;
            this.IntegrationStrict = integrationStrict;
            this.IntegrationStoreTokenSet = integrationStoreTokenSet;
            this.IntegrationVercelConfigurationOverride = integrationVercelConfigurationOverride;
            this.IntegrationPullRequest = integrationPullRequest;
            this.IpBlocking = ipBlocking;
            this.JobGlobal = jobGlobal;
            this.LogDrain = logDrain;
            this.MarketplaceBillingData = marketplaceBillingData;
            this.MarketplaceExperimentationEdgeConfigData = marketplaceExperimentationEdgeConfigData;
            this.MarketplaceExperimentationItem = marketplaceExperimentationItem;
            this.MarketplaceInstallationMember = marketplaceInstallationMember;
            this.MarketplaceInvoice = marketplaceInvoice;
            this.MarketplaceSettings = marketplaceSettings;
            this.Monitoring = monitoring;
            this.MonitoringAlert = monitoringAlert;
            this.MonitoringChart = monitoringChart;
            this.MonitoringQuery = monitoringQuery;
            this.MonitoringSettings = monitoringSettings;
            this.NotificationCustomerBudget = notificationCustomerBudget;
            this.NotificationDeploymentFailed = notificationDeploymentFailed;
            this.NotificationDomainConfiguration = notificationDomainConfiguration;
            this.NotificationDomainExpire = notificationDomainExpire;
            this.NotificationDomainMoved = notificationDomainMoved;
            this.NotificationDomainPurchase = notificationDomainPurchase;
            this.NotificationDomainRenewal = notificationDomainRenewal;
            this.NotificationDomainTransfer = notificationDomainTransfer;
            this.NotificationDomainUnverified = notificationDomainUnverified;
            this.NotificationMonitoringAlert = notificationMonitoringAlert;
            this.NotificationPaymentFailed = notificationPaymentFailed;
            this.NotificationPreferences = notificationPreferences;
            this.NotificationStatementOfReasons = notificationStatementOfReasons;
            this.NotificationUsageAlert = notificationUsageAlert;
            this.ObservabilityConfiguration = observabilityConfiguration;
            this.ObservabilityFunnel = observabilityFunnel;
            this.ObservabilityNotebook = observabilityNotebook;
            this.OpenTelemetryEndpoint = openTelemetryEndpoint;
            this.OwnEvent = ownEvent;
            this.OrganizationDomain = organizationDomain;
            this.PasswordProtectionInvoiceItem = passwordProtectionInvoiceItem;
            this.PaymentMethod = paymentMethod;
            this.Permissions = permissions;
            this.Postgres = postgres;
            this.PostgresStoreTokenSet = postgresStoreTokenSet;
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
            this.PrivateCloudAccount = privateCloudAccount;
            this.ProjectTransferIn = projectTransferIn;
            this.ProTrialOnboarding = proTrialOnboarding;
            this.RateLimit = rateLimit;
            this.Redis = redis;
            this.RedisStoreTokenSet = redisStoreTokenSet;
            this.RemoteCaching = remoteCaching;
            this.Repository = repository;
            this.SamlConfig = samlConfig;
            this.Secret = secret;
            this.SensitiveEnvironmentVariablePolicy = sensitiveEnvironmentVariablePolicy;
            this.SharedEnvVars = sharedEnvVars;
            this.SharedEnvVarsProduction = sharedEnvVarsProduction;
            this.Space = space;
            this.SpaceRun = spaceRun;
            this.StoreTransfer = storeTransfer;
            this.SupportCase = supportCase;
            this.SupportCaseComment = supportCaseComment;
            this.Team = team;
            this.TeamAccessRequest = teamAccessRequest;
            this.TeamFellowMembership = teamFellowMembership;
            this.TeamGitExclusivity = teamGitExclusivity;
            this.TeamInvite = teamInvite;
            this.TeamInviteCode = teamInviteCode;
            this.TeamJoin = teamJoin;
            this.TeamMemberMfaStatus = teamMemberMfaStatus;
            this.TeamMicrofrontends = teamMicrofrontends;
            this.TeamOwnMembership = teamOwnMembership;
            this.TeamOwnMembershipDisconnectSAML = teamOwnMembershipDisconnectSAML;
            this.Token = token;
            this.ToolbarComment = toolbarComment;
            this.Usage = usage;
            this.UsageCycle = usageCycle;
            this.VercelRun = vercelRun;
            this.VpcPeeringConnection = vpcPeeringConnection;
            this.WebAnalyticsPlan = webAnalyticsPlan;
            this.Webhook = webhook;
            this.WebhookEvent = webhookEvent;
            this.AliasProject = aliasProject;
            this.AliasProtectionBypass = aliasProtectionBypass;
            this.BulkRedirects = bulkRedirects;
            this.BuildMachine = buildMachine;
            this.ConnectConfigurationLink = connectConfigurationLink;
            this.DataCacheNamespace = dataCacheNamespace;
            this.Deployment = deployment;
            this.DeploymentBuildLogs = deploymentBuildLogs;
            this.DeploymentCheck = deploymentCheck;
            this.DeploymentCheckPreview = deploymentCheckPreview;
            this.DeploymentCheckReRunFromProductionBranch = deploymentCheckReRunFromProductionBranch;
            this.DeploymentProductionGit = deploymentProductionGit;
            this.DeploymentV0 = deploymentV0;
            this.DeploymentPreview = deploymentPreview;
            this.DeploymentPrivate = deploymentPrivate;
            this.DeploymentPromote = deploymentPromote;
            this.DeploymentRollback = deploymentRollback;
            this.EdgeCacheNamespace = edgeCacheNamespace;
            this.Environments = environments;
            this.Job = job;
            this.Logs = logs;
            this.LogsPreset = logsPreset;
            this.ObservabilityData = observabilityData;
            this.OnDemandBuild = onDemandBuild;
            this.OnDemandConcurrency = onDemandConcurrency;
            this.OptionsAllowlist = optionsAllowlist;
            this.PasswordProtection = passwordProtection;
            this.PrivateLinkEndpoint = privateLinkEndpoint;
            this.ProductionAliasProtectionBypass = productionAliasProtectionBypass;
            this.Project = project;
            this.ProjectAccessGroup = projectAccessGroup;
            this.ProjectAnalyticsSampling = projectAnalyticsSampling;
            this.ProjectAnalyticsUsage = projectAnalyticsUsage;
            this.ProjectCheck = projectCheck;
            this.ProjectCheckRun = projectCheckRun;
            this.ProjectDelegatedProtection = projectDelegatedProtection;
            this.ProjectDeploymentExpiration = projectDeploymentExpiration;
            this.ProjectDeploymentHook = projectDeploymentHook;
            this.ProjectDeploymentProtectionStrict = projectDeploymentProtectionStrict;
            this.ProjectDomain = projectDomain;
            this.ProjectDomainCheckConfig = projectDomainCheckConfig;
            this.ProjectDomainMove = projectDomainMove;
            this.ProjectEvent = projectEvent;
            this.ProjectEnvVars = projectEnvVars;
            this.ProjectEnvVarsProduction = projectEnvVarsProduction;
            this.ProjectEnvVarsUnownedByIntegration = projectEnvVarsUnownedByIntegration;
            this.ProjectFlags = projectFlags;
            this.ProjectFlagsProduction = projectFlagsProduction;
            this.ProjectFromV0 = projectFromV0;
            this.ProjectId = projectId;
            this.ProjectIntegrationConfiguration = projectIntegrationConfiguration;
            this.ProjectLink = projectLink;
            this.ProjectMember = projectMember;
            this.ProjectMonitoring = projectMonitoring;
            this.ProjectOIDCToken = projectOIDCToken;
            this.ProjectPermissions = projectPermissions;
            this.ProjectProductionBranch = projectProductionBranch;
            this.ProjectProtectionBypass = projectProtectionBypass;
            this.ProjectRollingRelease = projectRollingRelease;
            this.ProjectRoutes = projectRoutes;
            this.ProjectSupportCase = projectSupportCase;
            this.ProjectSupportCaseComment = projectSupportCaseComment;
            this.ProjectTier = projectTier;
            this.ProjectTransfer = projectTransfer;
            this.ProjectTransferOut = projectTransferOut;
            this.ProjectUsage = projectUsage;
            this.PageIntegrity = pageIntegrity;
            this.SeawallConfig = seawallConfig;
            this.SecurityPlusConfiguration = securityPlusConfiguration;
            this.ShareableLinkStrict = shareableLinkStrict;
            this.SharedEnvVarConnection = sharedEnvVarConnection;
            this.SkewProtection = skewProtection;
            this.Analytics = analytics;
            this.TrustedIps = trustedIps;
            this.TrustedSources = trustedSources;
            this.V0Chat = v0Chat;
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectPermissions" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectPermissions()
        {
        }
    }
}