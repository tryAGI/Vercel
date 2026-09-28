
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda223f19b9c37327fProtectionConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxUrls")]
        public global::Vercel.AutoSDKShareda223f19b9c37327fProtectionConfigSandboxUrls? SandboxUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda223f19b9c37327fProtectionConfig" /> class.
        /// </summary>
        /// <param name="sandboxUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda223f19b9c37327fProtectionConfig(
            global::Vercel.AutoSDKShareda223f19b9c37327fProtectionConfigSandboxUrls? sandboxUrls)
        {
            this.SandboxUrls = sandboxUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda223f19b9c37327fProtectionConfig" /> class.
        /// </summary>
        public AutoSDKShareda223f19b9c37327fProtectionConfig()
        {
        }

    }
}