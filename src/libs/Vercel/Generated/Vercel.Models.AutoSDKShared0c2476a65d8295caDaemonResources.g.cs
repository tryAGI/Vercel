
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0c2476a65d8295caDaemonResources
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0c2476a65d8295caDaemonResourcesRequests Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0c2476a65d8295caDaemonResources" /> class.
        /// </summary>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0c2476a65d8295caDaemonResources(
            global::Vercel.AutoSDKShared0c2476a65d8295caDaemonResourcesRequests requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0c2476a65d8295caDaemonResources" /> class.
        /// </summary>
        public AutoSDKShared0c2476a65d8295caDaemonResources()
        {
        }

    }
}