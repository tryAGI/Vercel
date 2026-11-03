
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbfe68caea048321bProtectionConfigSandboxUrls
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bProtectionConfigSandboxUrls" /> class.
        /// </summary>
        /// <param name="inheritDeploymentProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbfe68caea048321bProtectionConfigSandboxUrls(
            bool? inheritDeploymentProtection)
        {
            this.InheritDeploymentProtection = inheritDeploymentProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bProtectionConfigSandboxUrls" /> class.
        /// </summary>
        public AutoSDKSharedbfe68caea048321bProtectionConfigSandboxUrls()
        {
        }

    }
}