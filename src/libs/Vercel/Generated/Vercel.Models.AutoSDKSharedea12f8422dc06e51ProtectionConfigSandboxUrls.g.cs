
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedea12f8422dc06e51ProtectionConfigSandboxUrls
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51ProtectionConfigSandboxUrls" /> class.
        /// </summary>
        /// <param name="inheritDeploymentProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedea12f8422dc06e51ProtectionConfigSandboxUrls(
            bool? inheritDeploymentProtection)
        {
            this.InheritDeploymentProtection = inheritDeploymentProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51ProtectionConfigSandboxUrls" /> class.
        /// </summary>
        public AutoSDKSharedea12f8422dc06e51ProtectionConfigSandboxUrls()
        {
        }

    }
}