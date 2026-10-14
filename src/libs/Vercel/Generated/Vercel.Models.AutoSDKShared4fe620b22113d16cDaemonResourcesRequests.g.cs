
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared4fe620b22113d16cDaemonResourcesRequests
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cDaemonResourcesRequests" /> class.
        /// </summary>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4fe620b22113d16cDaemonResourcesRequests(
            global::Vercel.AutoSDKShared4fe620b22113d16cDaemonResourcesRequestsMemory memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cDaemonResourcesRequests" /> class.
        /// </summary>
        public AutoSDKShared4fe620b22113d16cDaemonResourcesRequests()
        {
        }

    }
}