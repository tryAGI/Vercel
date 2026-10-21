
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared922c97954e29e8b6DaemonResources
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequests Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared922c97954e29e8b6DaemonResources" /> class.
        /// </summary>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared922c97954e29e8b6DaemonResources(
            global::Vercel.AutoSDKShared922c97954e29e8b6DaemonResourcesRequests requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared922c97954e29e8b6DaemonResources" /> class.
        /// </summary>
        public AutoSDKShared922c97954e29e8b6DaemonResources()
        {
        }

    }
}