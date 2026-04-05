
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestResponseVariant1PartnerCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResult Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestResponseVariant1PartnerCall" /> class.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestResponseVariant1PartnerCall(
            string installationId,
            global::System.Collections.Generic.IList<string> resourceIds,
            global::Vercel.AcceptProjectTransferRequestResponseVariant1PartnerCallResult result)
        {
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestResponseVariant1PartnerCall" /> class.
        /// </summary>
        public AcceptProjectTransferRequestResponseVariant1PartnerCall()
        {
        }
    }
}