
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf5934c240f4382f7Sandbox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedf5934c240f4382f7SandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf5934c240f4382f7SandboxRegionJsonConverter))]
        public global::Vercel.AutoSDKSharedf5934c240f4382f7SandboxRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7Sandbox" /> class.
        /// </summary>
        /// <param name="failoverRegions"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf5934c240f4382f7Sandbox(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedf5934c240f4382f7SandboxFailoverRegion>? failoverRegions,
            global::Vercel.AutoSDKSharedf5934c240f4382f7SandboxRegion? region)
        {
            this.FailoverRegions = failoverRegions;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf5934c240f4382f7Sandbox" /> class.
        /// </summary>
        public AutoSDKSharedf5934c240f4382f7Sandbox()
        {
        }

    }
}