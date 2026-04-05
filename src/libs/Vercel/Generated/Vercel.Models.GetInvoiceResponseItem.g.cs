
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Invoice items.
    /// </summary>
    public sealed partial class GetInvoiceResponseItem
    {
        /// <summary>
        /// Partner's billing plan ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingPlanId { get; set; }

        /// <summary>
        /// Partner's resource ID. If not specified, indicates installation-wide item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Start and end are only needed if different from the period's start/end. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public string? Start { get; set; }

        /// <summary>
        /// Start and end are only needed if different from the period's start/end. ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public string? End { get; set; }

        /// <summary>
        /// Invoice item name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional item details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Item price. A dollar-based decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Price { get; set; }

        /// <summary>
        /// Item quantity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Units for item's quantity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Units { get; set; }

        /// <summary>
        /// Item total. A dollar-based decimal string.
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
        /// Initializes a new instance of the <see cref="GetInvoiceResponseItem" /> class.
        /// </summary>
        /// <param name="billingPlanId">
        /// Partner's billing plan ID.
        /// </param>
        /// <param name="name">
        /// Invoice item name.
        /// </param>
        /// <param name="price">
        /// Item price. A dollar-based decimal string.
        /// </param>
        /// <param name="quantity">
        /// Item quantity.
        /// </param>
        /// <param name="units">
        /// Units for item's quantity.
        /// </param>
        /// <param name="total">
        /// Item total. A dollar-based decimal string.
        /// </param>
        /// <param name="resourceId">
        /// Partner's resource ID. If not specified, indicates installation-wide item.
        /// </param>
        /// <param name="start">
        /// Start and end are only needed if different from the period's start/end. ISO 8601 timestamp.
        /// </param>
        /// <param name="end">
        /// Start and end are only needed if different from the period's start/end. ISO 8601 timestamp.
        /// </param>
        /// <param name="details">
        /// Additional item details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInvoiceResponseItem(
            string billingPlanId,
            string name,
            string price,
            double quantity,
            string units,
            string total,
            string? resourceId,
            string? start,
            string? end,
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
        /// Initializes a new instance of the <see cref="GetInvoiceResponseItem" /> class.
        /// </summary>
        public GetInvoiceResponseItem()
        {
        }
    }
}