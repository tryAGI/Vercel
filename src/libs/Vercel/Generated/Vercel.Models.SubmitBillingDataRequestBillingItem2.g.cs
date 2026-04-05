
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitBillingDataRequestBillingItem2
    {
        /// <summary>
        /// Partner's billing plan ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingPlanId { get; set; }

        /// <summary>
        /// Partner's resource ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Start and end are only needed if different from the period's start/end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// Start and end are only needed if different from the period's start/end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Line item name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Line item details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Price per unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Price { get; set; }

        /// <summary>
        /// Quantity of units.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Units of the quantity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Units { get; set; }

        /// <summary>
        /// Total amount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestBillingItem2" /> class.
        /// </summary>
        /// <param name="billingPlanId">
        /// Partner's billing plan ID.
        /// </param>
        /// <param name="name">
        /// Line item name.
        /// </param>
        /// <param name="price">
        /// Price per unit.
        /// </param>
        /// <param name="quantity">
        /// Quantity of units.
        /// </param>
        /// <param name="units">
        /// Units of the quantity.
        /// </param>
        /// <param name="total">
        /// Total amount.
        /// </param>
        /// <param name="resourceId">
        /// Partner's resource ID.
        /// </param>
        /// <param name="start">
        /// Start and end are only needed if different from the period's start/end.
        /// </param>
        /// <param name="end">
        /// Start and end are only needed if different from the period's start/end.
        /// </param>
        /// <param name="details">
        /// Line item details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitBillingDataRequestBillingItem2(
            string billingPlanId,
            string name,
            string price,
            double quantity,
            string units,
            string total,
            string? resourceId,
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? details)
        {
            this.BillingPlanId = billingPlanId ?? throw new global::System.ArgumentNullException(nameof(billingPlanId));
            this.ResourceId = resourceId;
            this.Start = start;
            this.End = end;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Details = details;
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Quantity = quantity;
            this.Units = units ?? throw new global::System.ArgumentNullException(nameof(units));
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestBillingItem2" /> class.
        /// </summary>
        public SubmitBillingDataRequestBillingItem2()
        {
        }
    }
}