
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseErrorVariant3Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpectedPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actualPrice")]
        public double? ActualPrice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant3Details" /> class.
        /// </summary>
        /// <param name="expectedPrice"></param>
        /// <param name="actualPrice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseErrorVariant3Details(
            double expectedPrice,
            double? actualPrice)
        {
            this.ExpectedPrice = expectedPrice;
            this.ActualPrice = actualPrice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant3Details" /> class.
        /// </summary>
        public GetOrderResponseErrorVariant3Details()
        {
        }
    }
}