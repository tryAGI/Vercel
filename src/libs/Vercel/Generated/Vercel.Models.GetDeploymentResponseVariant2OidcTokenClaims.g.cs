
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2OidcTokenClaims
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Iss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aud")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Aud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_environment_id")]
        public string? CustomEnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2OidcTokenClaims" /> class.
        /// </summary>
        /// <param name="iss"></param>
        /// <param name="sub"></param>
        /// <param name="scope"></param>
        /// <param name="aud"></param>
        /// <param name="owner"></param>
        /// <param name="ownerId"></param>
        /// <param name="project"></param>
        /// <param name="projectId"></param>
        /// <param name="environment"></param>
        /// <param name="customEnvironmentId"></param>
        /// <param name="plan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2OidcTokenClaims(
            string iss,
            string sub,
            string scope,
            string aud,
            string owner,
            string ownerId,
            string project,
            string projectId,
            string environment,
            string? customEnvironmentId,
            string? plan)
        {
            this.Iss = iss ?? throw new global::System.ArgumentNullException(nameof(iss));
            this.Sub = sub ?? throw new global::System.ArgumentNullException(nameof(sub));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Aud = aud ?? throw new global::System.ArgumentNullException(nameof(aud));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.CustomEnvironmentId = customEnvironmentId;
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2OidcTokenClaims" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2OidcTokenClaims()
        {
        }
    }
}