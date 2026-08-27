
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectResponseProtectionConfigSandboxUrls
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inheritDeploymentProtection")]
        public bool? InheritDeploymentProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseProtectionConfigSandboxUrls" /> class.
        /// </summary>
        /// <param name="inheritDeploymentProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseProtectionConfigSandboxUrls(
            bool? inheritDeploymentProtection)
        {
            this.InheritDeploymentProtection = inheritDeploymentProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseProtectionConfigSandboxUrls" /> class.
        /// </summary>
        public UpdateProjectResponseProtectionConfigSandboxUrls()
        {
        }

    }
}