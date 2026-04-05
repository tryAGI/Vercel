
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestRequestPaidFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentBuilds")]
        public int? ConcurrentBuilds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public bool? PasswordProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public bool? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequestPaidFeatures" /> class.
        /// </summary>
        /// <param name="concurrentBuilds"></param>
        /// <param name="passwordProtection"></param>
        /// <param name="previewDeploymentSuffix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestRequestPaidFeatures(
            int? concurrentBuilds,
            bool? passwordProtection,
            bool? previewDeploymentSuffix)
        {
            this.ConcurrentBuilds = concurrentBuilds;
            this.PasswordProtection = passwordProtection;
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequestPaidFeatures" /> class.
        /// </summary>
        public AcceptProjectTransferRequestRequestPaidFeatures()
        {
        }
    }
}