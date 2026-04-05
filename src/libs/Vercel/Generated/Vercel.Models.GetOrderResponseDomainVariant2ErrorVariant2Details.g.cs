
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant2ErrorVariant2Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedLanguageCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DetectedLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2ErrorVariant2Details" /> class.
        /// </summary>
        /// <param name="detectedLanguageCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant2ErrorVariant2Details(
            string detectedLanguageCode)
        {
            this.DetectedLanguageCode = detectedLanguageCode ?? throw new global::System.ArgumentNullException(nameof(detectedLanguageCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2ErrorVariant2Details" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant2ErrorVariant2Details()
        {
        }
    }
}