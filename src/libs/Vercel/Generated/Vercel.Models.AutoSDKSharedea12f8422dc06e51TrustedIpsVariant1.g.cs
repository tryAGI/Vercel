
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1Addresse> Addresses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1DeploymentType DeploymentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1" /> class.
        /// </summary>
        /// <param name="addresses"></param>
        /// <param name="deploymentType"></param>
        /// <param name="protectionMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1Addresse> addresses,
            global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1DeploymentType deploymentType,
            global::Vercel.AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode protectionMode)
        {
            this.Addresses = addresses ?? throw new global::System.ArgumentNullException(nameof(addresses));
            this.DeploymentType = deploymentType;
            this.ProtectionMode = protectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1" /> class.
        /// </summary>
        public AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1()
        {
        }

    }
}