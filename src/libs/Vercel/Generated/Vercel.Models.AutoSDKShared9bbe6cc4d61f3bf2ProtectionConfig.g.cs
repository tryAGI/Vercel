
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxUrls")]
        public global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls? SandboxUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfig" /> class.
        /// </summary>
        /// <param name="sandboxUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfig(
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfigSandboxUrls? sandboxUrls)
        {
            this.SandboxUrls = sandboxUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfig" /> class.
        /// </summary>
        public AutoSDKShared9bbe6cc4d61f3bf2ProtectionConfig()
        {
        }

    }
}