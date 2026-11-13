
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f99f1735f329c6cSandbox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f99f1735f329c6cSandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0f99f1735f329c6cSandboxRegionJsonConverter))]
        public global::Vercel.AutoSDKShared0f99f1735f329c6cSandboxRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f99f1735f329c6cSandbox" /> class.
        /// </summary>
        /// <param name="failoverRegions"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f99f1735f329c6cSandbox(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f99f1735f329c6cSandboxFailoverRegion>? failoverRegions,
            global::Vercel.AutoSDKShared0f99f1735f329c6cSandboxRegion? region)
        {
            this.FailoverRegions = failoverRegions;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f99f1735f329c6cSandbox" /> class.
        /// </summary>
        public AutoSDKShared0f99f1735f329c6cSandbox()
        {
        }

    }
}