
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyDomainsResponse
    {
        /// <summary>
        /// A valid order ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.BuyDomainsResponseLinks2> Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDomainsResponse" /> class.
        /// </summary>
        /// <param name="orderId">
        /// A valid order ID
        /// </param>
        /// <param name="links"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyDomainsResponse(
            string orderId,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.BuyDomainsResponseLinks2> links)
        {
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDomainsResponse" /> class.
        /// </summary>
        public BuyDomainsResponse()
        {
        }
    }
}