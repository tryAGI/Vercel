
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>> Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetOrderResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?, global::Vercel.GetOrderResponseError>))]
        public global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?, global::Vercel.GetOrderResponseError>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponse" /> class.
        /// </summary>
        /// <param name="orderId">
        /// A valid order ID
        /// </param>
        /// <param name="domains"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponse(
            string orderId,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>> domains,
            global::Vercel.GetOrderResponseStatus status,
            global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?, global::Vercel.GetOrderResponseError>? error)
        {
            this.OrderId = orderId ?? throw new global::System.ArgumentNullException(nameof(orderId));
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponse" /> class.
        /// </summary>
        public GetOrderResponse()
        {
        }
    }
}