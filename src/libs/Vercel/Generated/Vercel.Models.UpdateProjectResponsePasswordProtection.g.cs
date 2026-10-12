
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Password protection settings returned without the secret password hash.
    /// </summary>
    public sealed partial class UpdateProjectResponsePasswordProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponsePasswordProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectResponsePasswordProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponsePasswordProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponsePasswordProtection(
            global::Vercel.UpdateProjectResponsePasswordProtectionDeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponsePasswordProtection" /> class.
        /// </summary>
        public UpdateProjectResponsePasswordProtection()
        {
        }

    }
}