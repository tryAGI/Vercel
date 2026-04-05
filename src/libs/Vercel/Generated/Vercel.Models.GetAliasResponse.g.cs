
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAliasResponse
    {
        /// <summary>
        /// The alias name, it could be a `.vercel.app` subdomain or a custom domain<br/>
        /// Example: my-alias.vercel.app
        /// </summary>
        /// <example>my-alias.vercel.app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// The date when the alias was created<br/>
        /// Example: 2017-04-26T23:00:34.232Z
        /// </summary>
        /// <example>2017-04-26T23:00:34.232Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// The date when the alias was created in milliseconds since the UNIX epoch<br/>
        /// Example: 1540095775941L
        /// </summary>
        /// <example>1540095775941L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// Information of the user who created the alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::Vercel.GetAliasResponseCreator? Creator { get; set; }

        /// <summary>
        /// The date when the alias was deleted in milliseconds since the UNIX epoch<br/>
        /// Example: 1540095775941L
        /// </summary>
        /// <example>1540095775941L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// A map with the deployment ID, URL and metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::Vercel.GetAliasResponseDeployment? Deployment { get; set; }

        /// <summary>
        /// The deployment ID<br/>
        /// Example: dpl_5m8CQaRBm3FnWRW1od3wKTpaECPx
        /// </summary>
        /// <example>dpl_5m8CQaRBm3FnWRW1od3wKTpaECPx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// The unique identifier of the project<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </summary>
        /// <example>prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Target destination domain for redirect when the alias is a redirect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        /// Status code to be used on redirect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectStatusCode")]
        public double? RedirectStatusCode { get; set; }

        /// <summary>
        /// The unique identifier of the alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The date when the alias was updated in milliseconds since the UNIX epoch<br/>
        /// Example: 1540095775941L
        /// </summary>
        /// <example>1540095775941L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// The protection bypass for the alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionBypass")]
        public object? ProtectionBypass { get; set; }

        /// <summary>
        /// The microfrontends for the alias including the routing configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        public global::Vercel.GetAliasResponseMicrofrontends? Microfrontends { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponse" /> class.
        /// </summary>
        /// <param name="alias">
        /// The alias name, it could be a `.vercel.app` subdomain or a custom domain<br/>
        /// Example: my-alias.vercel.app
        /// </param>
        /// <param name="created">
        /// The date when the alias was created<br/>
        /// Example: 2017-04-26T23:00:34.232Z
        /// </param>
        /// <param name="uid">
        /// The unique identifier of the alias
        /// </param>
        /// <param name="createdAt">
        /// The date when the alias was created in milliseconds since the UNIX epoch<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="creator">
        /// Information of the user who created the alias
        /// </param>
        /// <param name="deletedAt">
        /// The date when the alias was deleted in milliseconds since the UNIX epoch<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="deployment">
        /// A map with the deployment ID, URL and metadata
        /// </param>
        /// <param name="deploymentId">
        /// The deployment ID<br/>
        /// Example: dpl_5m8CQaRBm3FnWRW1od3wKTpaECPx
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="redirect">
        /// Target destination domain for redirect when the alias is a redirect
        /// </param>
        /// <param name="redirectStatusCode">
        /// Status code to be used on redirect
        /// </param>
        /// <param name="updatedAt">
        /// The date when the alias was updated in milliseconds since the UNIX epoch<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="protectionBypass">
        /// The protection bypass for the alias
        /// </param>
        /// <param name="microfrontends">
        /// The microfrontends for the alias including the routing configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAliasResponse(
            string alias,
            global::System.DateTime created,
            string uid,
            double? createdAt,
            global::Vercel.GetAliasResponseCreator? creator,
            double? deletedAt,
            global::Vercel.GetAliasResponseDeployment? deployment,
            string? deploymentId,
            string? projectId,
            string? redirect,
            double? redirectStatusCode,
            double? updatedAt,
            object? protectionBypass,
            global::Vercel.GetAliasResponseMicrofrontends? microfrontends)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Created = created;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.DeletedAt = deletedAt;
            this.Deployment = deployment;
            this.DeploymentId = deploymentId;
            this.ProjectId = projectId;
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.UpdatedAt = updatedAt;
            this.ProtectionBypass = protectionBypass;
            this.Microfrontends = microfrontends;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAliasResponse" /> class.
        /// </summary>
        public GetAliasResponse()
        {
        }
    }
}