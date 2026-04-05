
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partnerCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCall> PartnerCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceTransferErrors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> ResourceTransferErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferredStoreIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TransferredStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestResponseVariant1" /> class.
        /// </summary>
        /// <param name="partnerCalls"></param>
        /// <param name="resourceTransferErrors"></param>
        /// <param name="transferredStoreIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestResponseVariant1(
            global::System.Collections.Generic.IList<global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCall> partnerCalls,
            global::System.Collections.Generic.IList<object> resourceTransferErrors,
            global::System.Collections.Generic.IList<string> transferredStoreIds)
        {
            this.PartnerCalls = partnerCalls ?? throw new global::System.ArgumentNullException(nameof(partnerCalls));
            this.ResourceTransferErrors = resourceTransferErrors ?? throw new global::System.ArgumentNullException(nameof(resourceTransferErrors));
            this.TransferredStoreIds = transferredStoreIds ?? throw new global::System.ArgumentNullException(nameof(transferredStoreIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestResponseVariant1" /> class.
        /// </summary>
        public AcceptProjectTransferRequestResponseVariant1()
        {
        }
    }
}