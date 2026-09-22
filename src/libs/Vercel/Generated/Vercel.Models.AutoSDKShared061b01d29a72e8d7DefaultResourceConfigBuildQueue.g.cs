
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueue(
            global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildQueue()
        {
        }

    }
}