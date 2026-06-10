
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseProtectionConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxUrls")]
        public global::Vercel.GetProjectResponseProtectionConfigSandboxUrls? SandboxUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseProtectionConfig" /> class.
        /// </summary>
        /// <param name="sandboxUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseProtectionConfig(
            global::Vercel.GetProjectResponseProtectionConfigSandboxUrls? sandboxUrls)
        {
            this.SandboxUrls = sandboxUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseProtectionConfig" /> class.
        /// </summary>
        public GetProjectResponseProtectionConfig()
        {
        }

    }
}