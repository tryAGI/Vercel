
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared922c97954e29e8b6DaemonResourcesRequests
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared922c97954e29e8b6DaemonResourcesRequests" /> class.
        /// </summary>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared922c97954e29e8b6DaemonResourcesRequests(
            global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequestsMemory memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared922c97954e29e8b6DaemonResourcesRequests" /> class.
        /// </summary>
        public AutoSDKShared922c97954e29e8b6DaemonResourcesRequests()
        {
        }

    }
}