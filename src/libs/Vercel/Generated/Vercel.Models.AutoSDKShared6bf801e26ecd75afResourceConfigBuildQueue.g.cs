
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueue(
            global::Vercel.AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKShared6bf801e26ecd75afResourceConfigBuildQueue()
        {
        }

    }
}