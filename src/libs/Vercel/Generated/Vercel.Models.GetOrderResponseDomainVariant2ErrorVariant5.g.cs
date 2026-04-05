
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant2ErrorVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant5CodeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2ErrorVariant5" /> class.
        /// </summary>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant2ErrorVariant5(
            global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2ErrorVariant5" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant2ErrorVariant5()
        {
        }
    }
}