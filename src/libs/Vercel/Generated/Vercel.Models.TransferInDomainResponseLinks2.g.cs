
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferInDomainResponseLinks2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TransferInDomainResponseLinksMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TransferInDomainResponseLinksMethod Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInDomainResponseLinks2" /> class.
        /// </summary>
        /// <param name="href"></param>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferInDomainResponseLinks2(
            string href,
            global::Vercel.TransferInDomainResponseLinksMethod method)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInDomainResponseLinks2" /> class.
        /// </summary>
        public TransferInDomainResponseLinks2()
        {
        }
    }
}