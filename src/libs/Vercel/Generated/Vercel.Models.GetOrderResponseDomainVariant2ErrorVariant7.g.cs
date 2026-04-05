
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant2ErrorVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant7CodeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2ErrorVariant7" /> class.
        /// </summary>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant2ErrorVariant7(
            global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2ErrorVariant7" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant2ErrorVariant7()
        {
        }
    }
}