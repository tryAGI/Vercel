
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseErrorVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseErrorVariant2CodeJsonConverter))]
        public global::Vercel.GetOrderResponseErrorVariant2Code Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetOrderResponseErrorVariant2Details Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseErrorVariant2(
            global::Vercel.GetOrderResponseErrorVariant2Details details,
            global::Vercel.GetOrderResponseErrorVariant2Code code)
        {
            this.Code = code;
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant2" /> class.
        /// </summary>
        public GetOrderResponseErrorVariant2()
        {
        }
    }
}