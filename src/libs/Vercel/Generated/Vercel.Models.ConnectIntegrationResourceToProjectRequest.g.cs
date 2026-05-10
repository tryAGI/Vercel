
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectIntegrationResourceToProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVarEnvironments")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectIntegrationResourceToProjectRequestEnvVarEnvironment>? EnvVarEnvironments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("makeEnvVarsSensitive")]
        public bool? MakeEnvVarsSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectIntegrationResourceToProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="envVarEnvironments"></param>
        /// <param name="makeEnvVarsSensitive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectIntegrationResourceToProjectRequest(
            string projectId,
            global::System.Collections.Generic.IList<global::Vercel.ConnectIntegrationResourceToProjectRequestEnvVarEnvironment>? envVarEnvironments,
            bool? makeEnvVarsSensitive)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.EnvVarEnvironments = envVarEnvironments;
            this.MakeEnvVarsSensitive = makeEnvVarsSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectIntegrationResourceToProjectRequest" /> class.
        /// </summary>
        public ConnectIntegrationResourceToProjectRequest()
        {
        }

    }
}