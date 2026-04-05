
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseErrorVariant5Details
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainNames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DomainNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant5Details" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="domainNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseErrorVariant5Details(
            string message,
            global::System.Collections.Generic.IList<string> domainNames)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DomainNames = domainNames ?? throw new global::System.ArgumentNullException(nameof(domainNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant5Details" /> class.
        /// </summary>
        public GetOrderResponseErrorVariant5Details()
        {
        }
    }
}