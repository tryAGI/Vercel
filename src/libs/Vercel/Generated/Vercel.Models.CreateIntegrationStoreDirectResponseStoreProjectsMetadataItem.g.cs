
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemFrameworkJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemFramework? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployment")]
        public string? LatestDeployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment> Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVarPrefix")]
        public string? EnvVarPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnvironmentVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeployments? Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="environments"></param>
        /// <param name="environmentVariables"></param>
        /// <param name="framework"></param>
        /// <param name="latestDeployment"></param>
        /// <param name="envVarPrefix"></param>
        /// <param name="deployments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem(
            string id,
            string projectId,
            string name,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment> environments,
            global::System.Collections.Generic.IList<string> environmentVariables,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemFramework? framework,
            string? latestDeployment,
            string? envVarPrefix,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeployments? deployments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Framework = framework;
            this.LatestDeployment = latestDeployment;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.EnvVarPrefix = envVarPrefix;
            this.EnvironmentVariables = environmentVariables ?? throw new global::System.ArgumentNullException(nameof(environmentVariables));
            this.Deployments = deployments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProjectsMetadataItem()
        {
        }
    }
}