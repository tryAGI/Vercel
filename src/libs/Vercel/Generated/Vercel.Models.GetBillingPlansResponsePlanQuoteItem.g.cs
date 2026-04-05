
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBillingPlansResponsePlanQuoteItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Line { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="GetBillingPlansResponsePlanQuoteItem" /> class.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="amount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBillingPlansResponsePlanQuoteItem(
            string line,
            string amount)
        {
            this.Line = line ?? throw new global::System.ArgumentNullException(nameof(line));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingPlansResponsePlanQuoteItem" /> class.
        /// </summary>
        public GetBillingPlansResponsePlanQuoteItem()
        {
        }
    }
}