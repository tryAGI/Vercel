
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0c2476a65d8295caDaemonResourcesRequests
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0c2476a65d8295caDaemonResourcesRequests" /> class.
        /// </summary>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0c2476a65d8295caDaemonResourcesRequests(
            global::Vercel.AutoSDKShared0c2476a65d8295caDaemonResourcesRequestsMemory memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0c2476a65d8295caDaemonResourcesRequests" /> class.
        /// </summary>
        public AutoSDKShared0c2476a65d8295caDaemonResourcesRequests()
        {
        }

    }
}