
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueue(
            global::Vercel.AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKShared94b26a5607c7a373ResourceConfigBuildQueue()
        {
        }

    }
}