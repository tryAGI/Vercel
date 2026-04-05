
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitBillingDataRequestBilling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem2> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discounts")]
        public global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingDiscount>? Discounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestBilling" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="discounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitBillingDataRequestBilling(
            global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem2> items,
            global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingDiscount>? discounts)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Discounts = discounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBillingDataRequestBilling" /> class.
        /// </summary>
        public SubmitBillingDataRequestBilling()
        {
        }
    }
}