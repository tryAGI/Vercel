
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant1ErrorVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant10CodeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Details Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant10" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant1ErrorVariant10(
            global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Details details,
            global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code code)
        {
            this.Code = code;
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant10" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant1ErrorVariant10()
        {
        }
    }
}