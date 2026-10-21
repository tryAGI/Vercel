
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueue(
            global::Vercel.AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildQueue()
        {
        }

    }
}