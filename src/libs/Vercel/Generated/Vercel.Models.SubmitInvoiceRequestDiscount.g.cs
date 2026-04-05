
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitInvoiceRequestDiscount
    {
        /// <summary>
        /// Partner's resource ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Partner's billing plan ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingPlanId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Currency amount as a decimal string.
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
        /// Initializes a new instance of the <see cref="SubmitInvoiceRequestDiscount" /> class.
        /// </summary>
        /// <param name="billingPlanId">
        /// Partner's billing plan ID.
        /// </param>
        /// <param name="name"></param>
        /// <param name="amount">
        /// Currency amount as a decimal string.
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
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitInvoiceRequestDiscount(
            string billingPlanId,
            string name,
            string amount,
            string? resourceId,
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? details)
        {
            this.ResourceId = resourceId;
            this.BillingPlanId = billingPlanId ?? throw new global::System.ArgumentNullException(nameof(billingPlanId));
            this.Start = start;
            this.End = end;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Details = details;
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceRequestDiscount" /> class.
        /// </summary>
        public SubmitInvoiceRequestDiscount()
        {
        }
    }
}