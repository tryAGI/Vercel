
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared4fe620b22113d16cDaemonResources
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared4fe620b22113d16cDaemonResourcesRequests Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cDaemonResources" /> class.
        /// </summary>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4fe620b22113d16cDaemonResources(
            global::Vercel.AutoSDKShared4fe620b22113d16cDaemonResourcesRequests requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cDaemonResources" /> class.
        /// </summary>
        public AutoSDKShared4fe620b22113d16cDaemonResources()
        {
        }

    }
}