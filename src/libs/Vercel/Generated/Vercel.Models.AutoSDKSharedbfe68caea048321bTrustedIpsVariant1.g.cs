
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbfe68caea048321bTrustedIpsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1Addresse> Addresses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1DeploymentType DeploymentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bTrustedIpsVariant1" /> class.
        /// </summary>
        /// <param name="addresses"></param>
        /// <param name="deploymentType"></param>
        /// <param name="protectionMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbfe68caea048321bTrustedIpsVariant1(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1Addresse> addresses,
            global::Vercel.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1DeploymentType deploymentType,
            global::Vercel.AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode protectionMode)
        {
            this.Addresses = addresses ?? throw new global::System.ArgumentNullException(nameof(addresses));
            this.DeploymentType = deploymentType;
            this.ProtectionMode = protectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bTrustedIpsVariant1" /> class.
        /// </summary>
        public AutoSDKSharedbfe68caea048321bTrustedIpsVariant1()
        {
        }

    }
}