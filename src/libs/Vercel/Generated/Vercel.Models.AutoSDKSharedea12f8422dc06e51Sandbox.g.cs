
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedea12f8422dc06e51Sandbox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedea12f8422dc06e51SandboxRegionJsonConverter))]
        public global::Vercel.AutoSDKSharedea12f8422dc06e51SandboxRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51Sandbox" /> class.
        /// </summary>
        /// <param name="failoverRegions"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedea12f8422dc06e51Sandbox(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedea12f8422dc06e51SandboxFailoverRegion>? failoverRegions,
            global::Vercel.AutoSDKSharedea12f8422dc06e51SandboxRegion? region)
        {
            this.FailoverRegions = failoverRegions;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51Sandbox" /> class.
        /// </summary>
        public AutoSDKSharedea12f8422dc06e51Sandbox()
        {
        }

    }
}