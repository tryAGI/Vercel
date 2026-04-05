
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Invoice discounts.
    /// </summary>
    public sealed partial class GetInvoiceResponseDiscount
    {
        /// <summary>
        /// Partner's billing plan ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingPlanId { get; set; }

        /// <summary>
        /// Partner's resource ID. If not specified, indicates installation-wide discount.
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
        /// Discount name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional discount details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Discount amount. A dollar-based decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponseDiscount" /> class.
        /// </summary>
        /// <param name="billingPlanId">
        /// Partner's billing plan ID.
        /// </param>
        /// <param name="name">
        /// Discount name.
        /// </param>
        /// <param name="amount">
        /// Discount amount. A dollar-based decimal string.
        /// </param>
        /// <param name="resourceId">
        /// Partner's resource ID. If not specified, indicates installation-wide discount.
        /// </param>
        /// <param name="start">
        /// Start and end are only needed if different from the period's start/end. ISO 8601 timestamp.
        /// </param>
        /// <param name="end">
        /// Start and end are only needed if different from the period's start/end. ISO 8601 timestamp.
        /// </param>
        /// <param name="details">
        /// Additional discount details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInvoiceResponseDiscount(
            string billingPlanId,
            string name,
            string amount,
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
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponseDiscount" /> class.
        /// </summary>
        public GetInvoiceResponseDiscount()
        {
        }
    }
}