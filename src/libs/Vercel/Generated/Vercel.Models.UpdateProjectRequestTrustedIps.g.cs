
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restricts access to deployments based on the incoming request IP address
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedIps
    {
        /// <summary>
        /// Specify if the Trusted IPs will apply to every Deployment Target or just Preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestTrustedIpsDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestTrustedIpsDeploymentType DeploymentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTrustedIpsAddresse> Addresses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedIps" /> class.
        /// </summary>
        /// <param name="deploymentType">
        /// Specify if the Trusted IPs will apply to every Deployment Target or just Preview
        /// </param>
        /// <param name="addresses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedIps(
            global::Vercel.UpdateProjectRequestTrustedIpsDeploymentType deploymentType,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestTrustedIpsAddresse> addresses)
        {
            this.DeploymentType = deploymentType;
            this.Addresses = addresses ?? throw new global::System.ArgumentNullException(nameof(addresses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedIps" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedIps()
        {
        }

    }
}