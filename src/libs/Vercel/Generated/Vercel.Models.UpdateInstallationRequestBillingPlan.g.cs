
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateInstallationRequestBillingPlan
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateInstallationRequestBillingPlanTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateInstallationRequestBillingPlanType Type { get; set; }

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
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethodRequired")]
        public bool? PaymentMethodRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public string? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateInstallationRequestBillingPlanDetail>? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightedDetails")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateInstallationRequestBillingPlanHighlightedDetail>? HighlightedDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveDate")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInstallationRequestBillingPlan" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="paymentMethodRequired"></param>
        /// <param name="cost"></param>
        /// <param name="details"></param>
        /// <param name="highlightedDetails"></param>
        /// <param name="effectiveDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInstallationRequestBillingPlan(
            string id,
            global::Vercel.UpdateInstallationRequestBillingPlanType type,
            string name,
            string? description,
            bool? paymentMethodRequired,
            string? cost,
            global::System.Collections.Generic.IList<global::Vercel.UpdateInstallationRequestBillingPlanDetail>? details,
            global::System.Collections.Generic.IList<global::Vercel.UpdateInstallationRequestBillingPlanHighlightedDetail>? highlightedDetails,
            string? effectiveDate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.PaymentMethodRequired = paymentMethodRequired;
            this.Cost = cost;
            this.Details = details;
            this.HighlightedDetails = highlightedDetails;
            this.EffectiveDate = effectiveDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInstallationRequestBillingPlan" /> class.
        /// </summary>
        public UpdateInstallationRequestBillingPlan()
        {
        }
    }
}