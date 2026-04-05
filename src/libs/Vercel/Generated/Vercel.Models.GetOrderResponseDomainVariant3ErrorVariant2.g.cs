
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant3ErrorVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant2CodeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Details Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant3ErrorVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant3ErrorVariant2(
            global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Details details,
            global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code code)
        {
            this.Code = code;
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant3ErrorVariant2" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant3ErrorVariant2()
        {
        }
    }
}