
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The canonical reference-product billing period at intent creation. Omitted for historical intents.
    /// </summary>
    public sealed partial class AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod
    {
        /// <summary>
        /// The exclusive end of the reference billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// The inclusive start of the reference billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod" /> class.
        /// </summary>
        /// <param name="endDate">
        /// The exclusive end of the reference billing period.
        /// </param>
        /// <param name="startDate">
        /// The inclusive start of the reference billing period.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod(
            string endDate,
            string startDate)
        {
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod" /> class.
        /// </summary>
        public AutoSDKShareda15210bade0a7c46ReferenceBillingPeriod()
        {
        }

    }
}