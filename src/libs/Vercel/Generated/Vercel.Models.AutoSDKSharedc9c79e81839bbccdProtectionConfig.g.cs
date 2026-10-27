
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc9c79e81839bbccdProtectionConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxUrls")]
        public global::Vercel.AutoSDKSharedc9c79e81839bbccdProtectionConfigSandboxUrls? SandboxUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc9c79e81839bbccdProtectionConfig" /> class.
        /// </summary>
        /// <param name="sandboxUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc9c79e81839bbccdProtectionConfig(
            global::Vercel.AutoSDKSharedc9c79e81839bbccdProtectionConfigSandboxUrls? sandboxUrls)
        {
            this.SandboxUrls = sandboxUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc9c79e81839bbccdProtectionConfig" /> class.
        /// </summary>
        public AutoSDKSharedc9c79e81839bbccdProtectionConfig()
        {
        }

    }
}