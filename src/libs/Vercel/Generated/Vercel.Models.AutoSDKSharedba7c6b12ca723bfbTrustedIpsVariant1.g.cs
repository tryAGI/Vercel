
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1Addresse> Addresses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1DeploymentType DeploymentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1" /> class.
        /// </summary>
        /// <param name="addresses"></param>
        /// <param name="deploymentType"></param>
        /// <param name="protectionMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1Addresse> addresses,
            global::Vercel.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1DeploymentType deploymentType,
            global::Vercel.AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode protectionMode)
        {
            this.Addresses = addresses ?? throw new global::System.ArgumentNullException(nameof(addresses));
            this.DeploymentType = deploymentType;
            this.ProtectionMode = protectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1" /> class.
        /// </summary>
        public AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1()
        {
        }

    }
}