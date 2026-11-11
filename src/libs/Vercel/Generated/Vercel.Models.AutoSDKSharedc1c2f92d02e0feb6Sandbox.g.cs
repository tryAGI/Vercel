
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc1c2f92d02e0feb6Sandbox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc1c2f92d02e0feb6SandboxRegionJsonConverter))]
        public global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SandboxRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6Sandbox" /> class.
        /// </summary>
        /// <param name="failoverRegions"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc1c2f92d02e0feb6Sandbox(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SandboxFailoverRegion>? failoverRegions,
            global::Vercel.AutoSDKSharedc1c2f92d02e0feb6SandboxRegion? region)
        {
            this.FailoverRegions = failoverRegions;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc1c2f92d02e0feb6Sandbox" /> class.
        /// </summary>
        public AutoSDKSharedc1c2f92d02e0feb6Sandbox()
        {
        }

    }
}