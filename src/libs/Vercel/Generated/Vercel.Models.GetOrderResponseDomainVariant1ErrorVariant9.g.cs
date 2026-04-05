
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant1ErrorVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant9CodeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant9" /> class.
        /// </summary>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant1ErrorVariant9(
            global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant9" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant1ErrorVariant9()
        {
        }
    }
}