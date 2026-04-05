
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build resource configuration snapshot for this deployment.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1ConfigResourceConfigBuildQueue
    {
        /// <summary>
        /// Build resource configuration snapshot for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1ConfigResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant1ConfigResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ConfigResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration">
        /// Build resource configuration snapshot for this deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1ConfigResourceConfigBuildQueue(
            global::Vercel.GetDeploymentResponseVariant1ConfigResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ConfigResourceConfigBuildQueue" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1ConfigResourceConfigBuildQueue()
        {
        }
    }
}