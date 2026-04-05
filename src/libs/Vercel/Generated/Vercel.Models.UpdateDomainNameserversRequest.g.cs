
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDomainNameserversRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameservers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Nameservers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainNameserversRequest" /> class.
        /// </summary>
        /// <param name="nameservers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDomainNameserversRequest(
            global::System.Collections.Generic.IList<string> nameservers)
        {
            this.Nameservers = nameservers ?? throw new global::System.ArgumentNullException(nameof(nameservers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDomainNameserversRequest" /> class.
        /// </summary>
        public UpdateDomainNameserversRequest()
        {
        }
    }
}