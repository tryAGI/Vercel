#nullable enable

namespace Vercel
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Create integration store (free and paid plans)<br/>
        /// Creates an integration store with automatic billing plan handling. For free resources, omit `billingPlanId` to auto-discover free plans. For paid resources, provide a `billingPlanId` from the billing plans endpoint.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateIntegrationStoreDirectResponse> CreateIntegrationStoreDirectAsync(

            global::Vercel.CreateIntegrationStoreDirectRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create integration store (free and paid plans)<br/>
        /// Creates an integration store with automatic billing plan handling. For free resources, omit `billingPlanId` to auto-discover free plans. For paid resources, provide a `billingPlanId` from the billing plans endpoint.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// Human-readable name for the storage resource<br/>
        /// Example: my-dev-database
        /// </param>
        /// <param name="integrationConfigurationId">
        /// ID of your integration configuration. Get this from GET /v1/integrations/configurations<br/>
        /// Example: icfg_cuwj0AdCdH3BwWT4LPijCC7t
        /// </param>
        /// <param name="integrationProductIdOrSlug">
        /// ID or slug of the integration product. Get available products from GET /v1/integrations/configuration/{id}/products<br/>
        /// Example: iap_postgres_db
        /// </param>
        /// <param name="metadata">
        /// Optional key-value pairs for resource metadata<br/>
        /// Example: {"environment":"development","project":"my-app","tags":["database","postgres"]}
        /// </param>
        /// <param name="externalId">
        /// Optional external identifier for tracking purposes<br/>
        /// Example: dev-db-001
        /// </param>
        /// <param name="protocolSettings">
        /// Protocol-specific configuration settings<br/>
        /// Example: {"experimentation":{"edgeConfigSyncingEnabled":true}}
        /// </param>
        /// <param name="source">
        /// Source of the store creation request<br/>
        /// Default Value: marketplace<br/>
        /// Example: marketplace
        /// </param>
        /// <param name="billingPlanId">
        /// ID of the billing plan for paid resources. Get available plans from GET /integrations/integration/{id}/products/{productId}/plans. If not provided, automatically discovers free billing plans.<br/>
        /// Example: bp_abc123def456
        /// </param>
        /// <param name="paymentMethodId">
        /// Payment method ID for paid resources. Optional - uses default payment method if not provided.<br/>
        /// Example: pm_1AbcDefGhiJklMno
        /// </param>
        /// <param name="prepaymentAmountCents">
        /// Amount in cents for prepayment billing plans. Required only for prepayment plans with variable amounts.<br/>
        /// Example: 5000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateIntegrationStoreDirectResponse> CreateIntegrationStoreDirectAsync(
            string name,
            string integrationConfigurationId,
            object integrationProductIdOrSlug,
            string? teamId = default,
            string? slug = default,
            object? metadata = default,
            string? externalId = default,
            object? protocolSettings = default,
            global::Vercel.CreateIntegrationStoreDirectRequestSource? source = default,
            string? billingPlanId = default,
            string? paymentMethodId = default,
            double? prepaymentAmountCents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}