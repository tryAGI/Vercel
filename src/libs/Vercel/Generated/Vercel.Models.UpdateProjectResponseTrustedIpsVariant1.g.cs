
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseTrustedIpsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseTrustedIpsVariant1DeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectResponseTrustedIpsVariant1DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseTrustedIpsVariant1Addresse> Addresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseTrustedIpsVariant1ProtectionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectResponseTrustedIpsVariant1ProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseTrustedIpsVariant1" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
        /// <param name="addresses"></param>
        /// <param name="protectionMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseTrustedIpsVariant1(
            global::Vercel.UpdateProjectResponseTrustedIpsVariant1DeploymentType deploymentType,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseTrustedIpsVariant1Addresse> addresses,
            global::Vercel.UpdateProjectResponseTrustedIpsVariant1ProtectionMode protectionMode)
        {
            this.DeploymentType = deploymentType;
            this.Addresses = addresses ?? throw new global::System.ArgumentNullException(nameof(addresses));
            this.ProtectionMode = protectionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseTrustedIpsVariant1" /> class.
        /// </summary>
        public UpdateProjectResponseTrustedIpsVariant1()
        {
        }
    }
}