
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Ensures visitors to your Preview Deployments are logged into Vercel and have a minimum of Viewer access on your team
    /// </summary>
    public sealed partial class UpdateProjectRequestSsoProtection
    {
        /// <summary>
        /// Specify if the Vercel Authentication (SSO Protection) will apply to every Deployment Target or just Preview<br/>
        /// Default Value: preview
        /// </summary>
        /// <default>global::Vercel.UpdateProjectRequestSsoProtectionDeploymentType.Preview</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestSsoProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestSsoProtectionDeploymentType DeploymentType { get; set; } = global::Vercel.UpdateProjectRequestSsoProtectionDeploymentType.Preview;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestSsoProtection" /> class.
        /// </summary>
        /// <param name="deploymentType">
        /// Specify if the Vercel Authentication (SSO Protection) will apply to every Deployment Target or just Preview<br/>
        /// Default Value: preview
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestSsoProtection(
            global::Vercel.UpdateProjectRequestSsoProtectionDeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestSsoProtection" /> class.
        /// </summary>
        public UpdateProjectRequestSsoProtection()
        {
        }
    }
}