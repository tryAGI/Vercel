
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueue(
            global::Vercel.AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKShared8d2a365a5da335dfResourceConfigBuildQueue()
        {
        }

    }
}