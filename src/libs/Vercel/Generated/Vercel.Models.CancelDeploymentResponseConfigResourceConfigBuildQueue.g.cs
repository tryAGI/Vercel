
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build resource configuration snapshot for this deployment.
    /// </summary>
    public sealed partial class CancelDeploymentResponseConfigResourceConfigBuildQueue
    {
        /// <summary>
        /// Build resource configuration snapshot for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseConfigResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.CancelDeploymentResponseConfigResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseConfigResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration">
        /// Build resource configuration snapshot for this deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseConfigResourceConfigBuildQueue(
            global::Vercel.CancelDeploymentResponseConfigResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseConfigResourceConfigBuildQueue" /> class.
        /// </summary>
        public CancelDeploymentResponseConfigResourceConfigBuildQueue()
        {
        }
    }
}