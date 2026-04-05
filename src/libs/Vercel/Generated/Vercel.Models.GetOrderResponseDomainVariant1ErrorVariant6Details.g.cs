
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant1ErrorVariant6Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numDaysUntilTransferrable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumDaysUntilTransferrable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant6Details" /> class.
        /// </summary>
        /// <param name="numDaysUntilTransferrable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant1ErrorVariant6Details(
            double numDaysUntilTransferrable)
        {
            this.NumDaysUntilTransferrable = numDaysUntilTransferrable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1ErrorVariant6Details" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant1ErrorVariant6Details()
        {
        }
    }
}