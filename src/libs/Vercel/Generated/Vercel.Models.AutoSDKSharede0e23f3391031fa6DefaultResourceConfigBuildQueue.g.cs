
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueue(
            global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueue" /> class.
        /// </summary>
        public AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildQueue()
        {
        }

    }
}