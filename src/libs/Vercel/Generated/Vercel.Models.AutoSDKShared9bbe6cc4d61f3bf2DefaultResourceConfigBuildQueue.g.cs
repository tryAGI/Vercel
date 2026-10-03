
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueue(
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildQueue()
        {
        }

    }
}