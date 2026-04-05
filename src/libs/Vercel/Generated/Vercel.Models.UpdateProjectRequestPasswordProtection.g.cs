
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allows to protect project deployments with a password
    /// </summary>
    public sealed partial class UpdateProjectRequestPasswordProtection
    {
        /// <summary>
        /// Specify if the password will apply to every Deployment Target or just Preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestPasswordProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestPasswordProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// The password that will be used to protect Project Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestPasswordProtection" /> class.
        /// </summary>
        /// <param name="deploymentType">
        /// Specify if the password will apply to every Deployment Target or just Preview
        /// </param>
        /// <param name="password">
        /// The password that will be used to protect Project Deployments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestPasswordProtection(
            global::Vercel.UpdateProjectRequestPasswordProtectionDeploymentType deploymentType,
            string? password)
        {
            this.DeploymentType = deploymentType;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestPasswordProtection" /> class.
        /// </summary>
        public UpdateProjectRequestPasswordProtection()
        {
        }
    }
}