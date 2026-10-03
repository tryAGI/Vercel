
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls
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
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls" /> class.
        /// </summary>
        /// <param name="inheritDeploymentProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls(
            bool? inheritDeploymentProtection)
        {
            this.InheritDeploymentProtection = inheritDeploymentProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls" /> class.
        /// </summary>
        public AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls()
        {
        }

    }
}