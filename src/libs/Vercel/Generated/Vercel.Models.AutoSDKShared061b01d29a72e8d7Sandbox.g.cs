
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared061b01d29a72e8d7Sandbox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared061b01d29a72e8d7SandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7SandboxRegionJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7SandboxRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7Sandbox" /> class.
        /// </summary>
        /// <param name="failoverRegions"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared061b01d29a72e8d7Sandbox(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared061b01d29a72e8d7SandboxFailoverRegion>? failoverRegions,
            global::Vercel.AutoSDKShared061b01d29a72e8d7SandboxRegion? region)
        {
            this.FailoverRegions = failoverRegions;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7Sandbox" /> class.
        /// </summary>
        public AutoSDKShared061b01d29a72e8d7Sandbox()
        {
        }

    }
}