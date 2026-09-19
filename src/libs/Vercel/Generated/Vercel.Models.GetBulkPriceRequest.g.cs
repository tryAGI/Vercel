
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetBulkPriceRequest
    {
        /// <summary>
        /// an array of at most 50 item(s)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>
        /// The number of years to get the price for. If not provided, the minimum number of years for the TLD will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        public double? Years { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkPriceRequest" /> class.
        /// </summary>
        /// <param name="domains">
        /// an array of at most 50 item(s)
        /// </param>
        /// <param name="years">
        /// The number of years to get the price for. If not provided, the minimum number of years for the TLD will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBulkPriceRequest(
            global::System.Collections.Generic.IList<string> domains,
            double? years)
        {
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.Years = years;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkPriceRequest" /> class.
        /// </summary>
        public GetBulkPriceRequest()
        {
        }

    }
}