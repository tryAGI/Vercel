
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build resource configuration snapshot for this deployment.
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ConfigResourceConfig
    {
        /// <summary>
        /// Build resource configuration snapshot for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildQueue")]
        public global::Vercel.CreateDeploymentResponseVariant2ConfigResourceConfigBuildQueue? BuildQueue { get; set; }

        /// <summary>
        /// When elastic concurrency is used for this deployment, a value is set. The value tells the reason where the setting was coming from. - TEAM_SETTING: Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrencyJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency? ElasticConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachine")]
        public global::Vercel.CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachine? BuildMachine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ConfigResourceConfig" /> class.
        /// </summary>
        /// <param name="buildQueue">
        /// Build resource configuration snapshot for this deployment.
        /// </param>
        /// <param name="elasticConcurrency">
        /// When elastic concurrency is used for this deployment, a value is set. The value tells the reason where the setting was coming from. - TEAM_SETTING: Inherited from team settings - PROJECT_SETTING: Inherited from project settings - SKIP_QUEUE: Manually triggered by user to skip the queues
        /// </param>
        /// <param name="buildMachine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ConfigResourceConfig(
            global::Vercel.CreateDeploymentResponseVariant2ConfigResourceConfigBuildQueue? buildQueue,
            global::Vercel.CreateDeploymentResponseVariant2ConfigResourceConfigElasticConcurrency? elasticConcurrency,
            global::Vercel.CreateDeploymentResponseVariant2ConfigResourceConfigBuildMachine? buildMachine)
        {
            this.BuildQueue = buildQueue;
            this.ElasticConcurrency = elasticConcurrency;
            this.BuildMachine = buildMachine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ConfigResourceConfig" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ConfigResourceConfig()
        {
        }

    }
}