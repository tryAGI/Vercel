
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2(
            global::Vercel.AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2DeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2" /> class.
        /// </summary>
        public AutoSDKShared0d52d5fc16437df8TrustedIpsVariant2()
        {
        }

    }
}