
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseResourceConfigBuildQueue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.GetProjectResponseResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseResourceConfigBuildQueue(
            global::Vercel.GetProjectResponseResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseResourceConfigBuildQueue" /> class.
        /// </summary>
        public GetProjectResponseResourceConfigBuildQueue()
        {
        }
    }
}