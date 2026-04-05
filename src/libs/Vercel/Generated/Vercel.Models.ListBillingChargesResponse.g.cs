
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Extension of the base schema for Focus charges. Includes pricing information for all customers.
    /// </summary>
    public sealed partial class ListBillingChargesResponse
    {
        /// <summary>
        /// Charge amount serving as the basis for invoicing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("BilledCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BilledCost { get; set; }

        /// <summary>
        /// Currency used for billing (ISO 4217)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("BillingCurrency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListBillingChargesResponseBillingCurrencyJsonConverter))]
        public global::Vercel.ListBillingChargesResponseBillingCurrency BillingCurrency { get; set; }

        /// <summary>
        /// Classification of the charge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ChargeCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListBillingChargesResponseChargeCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListBillingChargesResponseChargeCategory ChargeCategory { get; set; }

        /// <summary>
        /// Inclusive start of the charge period (ISO 8601 UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ChargePeriodStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChargePeriodStart { get; set; }

        /// <summary>
        /// Exclusive end of the charge period (ISO 8601 UTC) - Required in v1.3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ChargePeriodEnd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChargePeriodEnd { get; set; }

        /// <summary>
        /// Volume of resource consumed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ConsumedQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConsumedQuantity { get; set; }

        /// <summary>
        /// Unit of measurement for consumed quantity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ConsumedUnit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumedUnit { get; set; }

        /// <summary>
        /// Amortized cost representation including discounts, pre-commitment credit purchase amount, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("EffectiveCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EffectiveCost { get; set; }

        /// <summary>
        /// Provider-assigned region identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("RegionId")]
        public string? RegionId { get; set; }

        /// <summary>
        /// Display name for the region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("RegionName")]
        public string? RegionName { get; set; }

        /// <summary>
        /// Display name for the service/product
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ServiceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceName { get; set; }

        /// <summary>
        /// High-level category of the service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ServiceCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListBillingChargesResponseServiceCategoryJsonConverter))]
        public global::Vercel.ListBillingChargesResponseServiceCategory? ServiceCategory { get; set; }

        /// <summary>
        /// Entity making the resource/service available for purchase (v1.3)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ServiceProviderName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceProviderName { get; set; }

        /// <summary>
        /// Charge metadata including the Vercel ProjectId and ProjectName information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Pricing model used for the charge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PricingCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListBillingChargesResponsePricingCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListBillingChargesResponsePricingCategory PricingCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PricingCurrency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListBillingChargesResponsePricingCurrencyJsonConverter))]
        public global::Vercel.ListBillingChargesResponsePricingCurrency PricingCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PricingQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricingQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PricingUnit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PricingUnit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBillingChargesResponse" /> class.
        /// </summary>
        /// <param name="billedCost">
        /// Charge amount serving as the basis for invoicing
        /// </param>
        /// <param name="chargeCategory">
        /// Classification of the charge
        /// </param>
        /// <param name="chargePeriodStart">
        /// Inclusive start of the charge period (ISO 8601 UTC)
        /// </param>
        /// <param name="chargePeriodEnd">
        /// Exclusive end of the charge period (ISO 8601 UTC) - Required in v1.3
        /// </param>
        /// <param name="consumedQuantity">
        /// Volume of resource consumed
        /// </param>
        /// <param name="consumedUnit">
        /// Unit of measurement for consumed quantity
        /// </param>
        /// <param name="effectiveCost">
        /// Amortized cost representation including discounts, pre-commitment credit purchase amount, etc.
        /// </param>
        /// <param name="serviceName">
        /// Display name for the service/product
        /// </param>
        /// <param name="serviceProviderName">
        /// Entity making the resource/service available for purchase (v1.3)
        /// </param>
        /// <param name="tags">
        /// Charge metadata including the Vercel ProjectId and ProjectName information
        /// </param>
        /// <param name="pricingCategory">
        /// Pricing model used for the charge.
        /// </param>
        /// <param name="pricingQuantity"></param>
        /// <param name="pricingUnit"></param>
        /// <param name="billingCurrency">
        /// Currency used for billing (ISO 4217)
        /// </param>
        /// <param name="regionId">
        /// Provider-assigned region identifier
        /// </param>
        /// <param name="regionName">
        /// Display name for the region
        /// </param>
        /// <param name="serviceCategory">
        /// High-level category of the service
        /// </param>
        /// <param name="pricingCurrency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBillingChargesResponse(
            double billedCost,
            global::Vercel.ListBillingChargesResponseChargeCategory chargeCategory,
            string chargePeriodStart,
            string chargePeriodEnd,
            double consumedQuantity,
            string consumedUnit,
            double effectiveCost,
            string serviceName,
            string serviceProviderName,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            global::Vercel.ListBillingChargesResponsePricingCategory pricingCategory,
            double pricingQuantity,
            string pricingUnit,
            global::Vercel.ListBillingChargesResponseBillingCurrency billingCurrency,
            string? regionId,
            string? regionName,
            global::Vercel.ListBillingChargesResponseServiceCategory? serviceCategory,
            global::Vercel.ListBillingChargesResponsePricingCurrency pricingCurrency)
        {
            this.BilledCost = billedCost;
            this.BillingCurrency = billingCurrency;
            this.ChargeCategory = chargeCategory;
            this.ChargePeriodStart = chargePeriodStart ?? throw new global::System.ArgumentNullException(nameof(chargePeriodStart));
            this.ChargePeriodEnd = chargePeriodEnd ?? throw new global::System.ArgumentNullException(nameof(chargePeriodEnd));
            this.ConsumedQuantity = consumedQuantity;
            this.ConsumedUnit = consumedUnit ?? throw new global::System.ArgumentNullException(nameof(consumedUnit));
            this.EffectiveCost = effectiveCost;
            this.RegionId = regionId;
            this.RegionName = regionName;
            this.ServiceName = serviceName ?? throw new global::System.ArgumentNullException(nameof(serviceName));
            this.ServiceCategory = serviceCategory;
            this.ServiceProviderName = serviceProviderName ?? throw new global::System.ArgumentNullException(nameof(serviceProviderName));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.PricingCategory = pricingCategory;
            this.PricingCurrency = pricingCurrency;
            this.PricingQuantity = pricingQuantity;
            this.PricingUnit = pricingUnit ?? throw new global::System.ArgumentNullException(nameof(pricingUnit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBillingChargesResponse" /> class.
        /// </summary>
        public ListBillingChargesResponse()
        {
        }
    }
}