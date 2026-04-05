
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationResponseVariant1TransferRequestVariant1BillingPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScopeJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethodRequired")]
        public bool? PaymentMethodRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preauthorizationAmount")]
        public double? PreauthorizationAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant1TransferRequestVariant1BillingPlan" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scope"></param>
        /// <param name="paymentMethodRequired"></param>
        /// <param name="preauthorizationAmount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationResponseVariant1TransferRequestVariant1BillingPlan(
            string id,
            global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType type,
            string name,
            string description,
            global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope? scope,
            bool? paymentMethodRequired,
            double? preauthorizationAmount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Scope = scope;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PaymentMethodRequired = paymentMethodRequired;
            this.PreauthorizationAmount = preauthorizationAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant1TransferRequestVariant1BillingPlan" /> class.
        /// </summary>
        public GetConfigurationResponseVariant1TransferRequestVariant1BillingPlan()
        {
        }
    }
}