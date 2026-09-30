
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2(
            global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2" /> class.
        /// </summary>
        public AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2()
        {
        }

    }
}