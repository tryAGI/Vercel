
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant1ErrorVariant10Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField? InvalidField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant10Details" /> class.
        /// </summary>
        /// <param name="invalidField"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant1ErrorVariant10Details(
            global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField? invalidField)
        {
            this.InvalidField = invalidField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant10Details" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant1ErrorVariant10Details()
        {
        }
    }
}