
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1Addresse> Addresses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType DeploymentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1" /> class.
        /// </summary>
        /// <param name="addresses"></param>
        /// <param name="deploymentType"></param>
        /// <param name="protectionMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1Addresse> addresses,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1DeploymentType deploymentType,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode protectionMode)
        {
            this.Addresses = addresses ?? throw new global::System.ArgumentNullException(nameof(addresses));
            this.DeploymentType = deploymentType;
            this.ProtectionMode = protectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1" /> class.
        /// </summary>
        public AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1()
        {
        }

    }
}