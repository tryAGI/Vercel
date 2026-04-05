
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreBillingPlanTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("initialCharge")]
        public string? InitialCharge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumAmount")]
        public string? MinimumAmount { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public string? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanDetail>? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightedDetails")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanHighlightedDetail>? HighlightedDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanQuoteItem>? Quote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveDate")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreBillingPlan" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scope"></param>
        /// <param name="paymentMethodRequired"></param>
        /// <param name="preauthorizationAmount"></param>
        /// <param name="initialCharge"></param>
        /// <param name="minimumAmount"></param>
        /// <param name="maximumAmount"></param>
        /// <param name="maximumAmountAutoPurchasePerPeriod"></param>
        /// <param name="cost"></param>
        /// <param name="details"></param>
        /// <param name="highlightedDetails"></param>
        /// <param name="quote"></param>
        /// <param name="effectiveDate"></param>
        /// <param name="disabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreBillingPlan(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanType type,
            string description,
            string id,
            string name,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanScope scope,
            bool paymentMethodRequired,
            double? preauthorizationAmount,
            string? initialCharge,
            string? minimumAmount,
            string? maximumAmount,
            string? maximumAmountAutoPurchasePerPeriod,
            string? cost,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanDetail>? details,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanHighlightedDetail>? highlightedDetails,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreBillingPlanQuoteItem>? quote,
            string? effectiveDate,
            bool? disabled)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scope = scope;
            this.PaymentMethodRequired = paymentMethodRequired;
            this.PreauthorizationAmount = preauthorizationAmount;
            this.InitialCharge = initialCharge;
            this.MinimumAmount = minimumAmount;
            this.MaximumAmount = maximumAmount;
            this.MaximumAmountAutoPurchasePerPeriod = maximumAmountAutoPurchasePerPeriod;
            this.Cost = cost;
            this.Details = details;
            this.HighlightedDetails = highlightedDetails;
            this.Quote = quote;
            this.EffectiveDate = effectiveDate;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreBillingPlan" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreBillingPlan()
        {
        }
    }
}