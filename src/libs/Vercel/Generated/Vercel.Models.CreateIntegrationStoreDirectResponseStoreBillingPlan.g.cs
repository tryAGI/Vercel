
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreBillingPlan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public string? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanDetail>? Details { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveDate")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightedDetails")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanHighlightedDetail>? HighlightedDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialCharge")]
        public string? InitialCharge { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximumAmount")]
        public string? MaximumAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximumAmountAutoPurchasePerPeriod")]
        public string? MaximumAmountAutoPurchasePerPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumAmount")]
        public string? MinimumAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethodRequired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PaymentMethodRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preauthorizationAmount")]
        public double? PreauthorizationAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanQuoteItem>? Quote { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreBillingPlanScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanScope Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreBillingPlanTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreBillingPlan" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="paymentMethodRequired"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="cost"></param>
        /// <param name="details"></param>
        /// <param name="disabled"></param>
        /// <param name="effectiveDate"></param>
        /// <param name="highlightedDetails"></param>
        /// <param name="initialCharge"></param>
        /// <param name="maximumAmount"></param>
        /// <param name="maximumAmountAutoPurchasePerPeriod"></param>
        /// <param name="minimumAmount"></param>
        /// <param name="preauthorizationAmount"></param>
        /// <param name="quote"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreBillingPlan(
            string description,
            string id,
            string name,
            bool paymentMethodRequired,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanScope scope,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanType type,
            string? cost,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanDetail>? details,
            bool? disabled,
            string? effectiveDate,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanHighlightedDetail>? highlightedDetails,
            string? initialCharge,
            string? maximumAmount,
            string? maximumAmountAutoPurchasePerPeriod,
            string? minimumAmount,
            double? preauthorizationAmount,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanQuoteItem>? quote)
        {
            this.Cost = cost;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Details = details;
            this.Disabled = disabled;
            this.EffectiveDate = effectiveDate;
            this.HighlightedDetails = highlightedDetails;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InitialCharge = initialCharge;
            this.MaximumAmount = maximumAmount;
            this.MaximumAmountAutoPurchasePerPeriod = maximumAmountAutoPurchasePerPeriod;
            this.MinimumAmount = minimumAmount;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PaymentMethodRequired = paymentMethodRequired;
            this.PreauthorizationAmount = preauthorizationAmount;
            this.Quote = quote;
            this.Scope = scope;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreBillingPlan" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreBillingPlan()
        {
        }

    }
}