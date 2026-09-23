
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueue(
            global::Vercel.AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildQueue()
        {
        }

    }
}