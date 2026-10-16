
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared866bd5cb8fda1c51Sandbox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared866bd5cb8fda1c51SandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared866bd5cb8fda1c51SandboxRegionJsonConverter))]
        public global::Vercel.AutoSDKShared866bd5cb8fda1c51SandboxRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared866bd5cb8fda1c51Sandbox" /> class.
        /// </summary>
        /// <param name="failoverRegions"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared866bd5cb8fda1c51Sandbox(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared866bd5cb8fda1c51SandboxFailoverRegion>? failoverRegions,
            global::Vercel.AutoSDKShared866bd5cb8fda1c51SandboxRegion? region)
        {
            this.FailoverRegions = failoverRegions;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared866bd5cb8fda1c51Sandbox" /> class.
        /// </summary>
        public AutoSDKShared866bd5cb8fda1c51Sandbox()
        {
        }

    }
}