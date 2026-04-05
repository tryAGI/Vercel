
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectRequest
    {
        /// <summary>
        /// Human-readable name for the storage resource<br/>
        /// Example: my-dev-database
        /// </summary>
        /// <example>my-dev-database</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of your integration configuration. Get this from GET /v1/integrations/configurations<br/>
        /// Example: icfg_cuwj0AdCdH3BwWT4LPijCC7t
        /// </summary>
        /// <example>icfg_cuwj0AdCdH3BwWT4LPijCC7t</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConfigurationId { get; set; }

        /// <summary>
        /// ID or slug of the integration product. Get available products from GET /v1/integrations/configuration/{id}/products<br/>
        /// Example: iap_postgres_db
        /// </summary>
        /// <example>iap_postgres_db</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationProductIdOrSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object IntegrationProductIdOrSlug { get; set; }

        /// <summary>
        /// Optional key-value pairs for resource metadata<br/>
        /// Example: {"environment":"development","project":"my-app","tags":["database","postgres"]}
        /// </summary>
        /// <example>{"environment":"development","project":"my-app","tags":["database","postgres"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Optional external identifier for tracking purposes<br/>
        /// Example: dev-db-001
        /// </summary>
        /// <example>dev-db-001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Protocol-specific configuration settings<br/>
        /// Example: {"experimentation":{"edgeConfigSyncingEnabled":true}}
        /// </summary>
        /// <example>{"experimentation":{"edgeConfigSyncingEnabled":true}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolSettings")]
        public object? ProtocolSettings { get; set; }

        /// <summary>
        /// Source of the store creation request<br/>
        /// Default Value: marketplace<br/>
        /// Example: marketplace
        /// </summary>
        /// <example>marketplace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectRequestSourceJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectRequestSource? Source { get; set; }

        /// <summary>
        /// ID of the billing plan for paid resources. Get available plans from GET /integrations/integration/{id}/products/{productId}/plans. If not provided, automatically discovers free billing plans.<br/>
        /// Example: bp_abc123def456
        /// </summary>
        /// <example>bp_abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        public string? BillingPlanId { get; set; }

        /// <summary>
        /// Payment method ID for paid resources. Optional - uses default payment method if not provided.<br/>
        /// Example: pm_1AbcDefGhiJklMno
        /// </summary>
        /// <example>pm_1AbcDefGhiJklMno</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethodId")]
        public string? PaymentMethodId { get; set; }

        /// <summary>
        /// Amount in cents for prepayment billing plans. Required only for prepayment plans with variable amounts.<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prepaymentAmountCents")]
        public double? PrepaymentAmountCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectRequest(
            string name,
            string integrationConfigurationId,
            object integrationProductIdOrSlug,
            object? metadata,
            string? externalId,
            object? protocolSettings,
            global::Vercel.CreateIntegrationStoreDirectRequestSource? source,
            string? billingPlanId,
            string? paymentMethodId,
            double? prepaymentAmountCents)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IntegrationConfigurationId = integrationConfigurationId ?? throw new global::System.ArgumentNullException(nameof(integrationConfigurationId));
            this.IntegrationProductIdOrSlug = integrationProductIdOrSlug;
            this.Metadata = metadata;
            this.ExternalId = externalId;
            this.ProtocolSettings = protocolSettings;
            this.Source = source;
            this.BillingPlanId = billingPlanId;
            this.PaymentMethodId = paymentMethodId;
            this.PrepaymentAmountCents = prepaymentAmountCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectRequest" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectRequest()
        {
        }
    }
}