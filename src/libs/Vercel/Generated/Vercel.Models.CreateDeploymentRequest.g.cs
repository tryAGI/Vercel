
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentRequest
    {
        /// <summary>
        /// Deploy to a custom environment, which will override the default environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentSlugOrId")]
        public string? CustomEnvironmentSlugOrId { get; set; }

        /// <summary>
        /// An deployment id for an existing deployment to redeploy<br/>
        /// Example: dpl_2qn7PZrx89yxY34vEZPD31Y9XVj6
        /// </summary>
        /// <example>dpl_2qn7PZrx89yxY34vEZPD31Y9XVj6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// A list of objects with the files to be deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentRequestFileInlinedFile, global::Vercel.CreateDeploymentRequestFileUploadedFile>>? Files { get; set; }

        /// <summary>
        /// Populates initial git metadata for different git providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitMetadata")]
        public global::Vercel.CreateDeploymentRequestGitMetadata? GitMetadata { get; set; }

        /// <summary>
        /// Defines the Git Repository source to be deployed. This property can not be used in combination with `files`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateDeploymentRequestGitSourceVariant1, global::Vercel.CreateDeploymentRequestGitSourceVariant2, global::Vercel.CreateDeploymentRequestGitSourceVariant3, global::Vercel.CreateDeploymentRequestGitSourceVariant4, global::Vercel.CreateDeploymentRequestGitSourceVariant5, global::Vercel.CreateDeploymentRequestGitSourceVariant6, global::Vercel.CreateDeploymentRequestGitSourceVariant7, global::Vercel.CreateDeploymentRequestGitSourceVariant8>))]
        public global::Vercel.AnyOf<global::Vercel.CreateDeploymentRequestGitSourceVariant1, global::Vercel.CreateDeploymentRequestGitSourceVariant2, global::Vercel.CreateDeploymentRequestGitSourceVariant3, global::Vercel.CreateDeploymentRequestGitSourceVariant4, global::Vercel.CreateDeploymentRequestGitSourceVariant5, global::Vercel.CreateDeploymentRequestGitSourceVariant6, global::Vercel.CreateDeploymentRequestGitSourceVariant7, global::Vercel.CreateDeploymentRequestGitSourceVariant8>? GitSource { get; set; }

        /// <summary>
        /// An object containing the deployment's metadata. Multiple key-value pairs can be attached to a deployment<br/>
        /// Example: {"foo":"bar"}
        /// </summary>
        /// <example>{"foo":"bar"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::System.Collections.Generic.Dictionary<string, string>? Meta { get; set; }

        /// <summary>
        /// The monorepo manager that is being used for this deployment. When `null` is used no monorepo manager is selected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monorepoManager")]
        public string? MonorepoManager { get; set; }

        /// <summary>
        /// A string with the project name used in the deployment URL<br/>
        /// Example: my-instant-deployment
        /// </summary>
        /// <example>my-instant-deployment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The target project identifier in which the deployment will be created. When defined, this parameter overrides name<br/>
        /// Example: my-deployment-project
        /// </summary>
        /// <example>my-deployment-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Project settings that will be applied to the deployment. It is required for the first deployment of a project and will be saved for any following deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSettings")]
        public global::Vercel.CreateDeploymentRequestProjectSettings? ProjectSettings { get; set; }

        /// <summary>
        /// Either not defined, `staging`, `production`, or a custom environment identifier. If `staging`, a staging alias in the format `&lt;project&gt;-&lt;team&gt;.vercel.app` will be assigned. If `production`, any aliases defined in `alias` will be assigned. If omitted, the target will be `preview`.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// When `true` and `deploymentId` is passed in, the sha from the previous deployment's `gitSource` is removed forcing the latest commit to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withLatestCommit")]
        public bool? WithLatestCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A string with the project name used in the deployment URL<br/>
        /// Example: my-instant-deployment
        /// </param>
        /// <param name="customEnvironmentSlugOrId">
        /// Deploy to a custom environment, which will override the default environment
        /// </param>
        /// <param name="deploymentId">
        /// An deployment id for an existing deployment to redeploy<br/>
        /// Example: dpl_2qn7PZrx89yxY34vEZPD31Y9XVj6
        /// </param>
        /// <param name="files">
        /// A list of objects with the files to be deployed
        /// </param>
        /// <param name="gitMetadata">
        /// Populates initial git metadata for different git providers.
        /// </param>
        /// <param name="gitSource">
        /// Defines the Git Repository source to be deployed. This property can not be used in combination with `files`.
        /// </param>
        /// <param name="meta">
        /// An object containing the deployment's metadata. Multiple key-value pairs can be attached to a deployment<br/>
        /// Example: {"foo":"bar"}
        /// </param>
        /// <param name="monorepoManager">
        /// The monorepo manager that is being used for this deployment. When `null` is used no monorepo manager is selected
        /// </param>
        /// <param name="project">
        /// The target project identifier in which the deployment will be created. When defined, this parameter overrides name<br/>
        /// Example: my-deployment-project
        /// </param>
        /// <param name="projectSettings">
        /// Project settings that will be applied to the deployment. It is required for the first deployment of a project and will be saved for any following deployments
        /// </param>
        /// <param name="target">
        /// Either not defined, `staging`, `production`, or a custom environment identifier. If `staging`, a staging alias in the format `&lt;project&gt;-&lt;team&gt;.vercel.app` will be assigned. If `production`, any aliases defined in `alias` will be assigned. If omitted, the target will be `preview`.<br/>
        /// Example: production
        /// </param>
        /// <param name="withLatestCommit">
        /// When `true` and `deploymentId` is passed in, the sha from the previous deployment's `gitSource` is removed forcing the latest commit to be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequest(
            string name,
            string? customEnvironmentSlugOrId,
            string? deploymentId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentRequestFileInlinedFile, global::Vercel.CreateDeploymentRequestFileUploadedFile>>? files,
            global::Vercel.CreateDeploymentRequestGitMetadata? gitMetadata,
            global::Vercel.AnyOf<global::Vercel.CreateDeploymentRequestGitSourceVariant1, global::Vercel.CreateDeploymentRequestGitSourceVariant2, global::Vercel.CreateDeploymentRequestGitSourceVariant3, global::Vercel.CreateDeploymentRequestGitSourceVariant4, global::Vercel.CreateDeploymentRequestGitSourceVariant5, global::Vercel.CreateDeploymentRequestGitSourceVariant6, global::Vercel.CreateDeploymentRequestGitSourceVariant7, global::Vercel.CreateDeploymentRequestGitSourceVariant8>? gitSource,
            global::System.Collections.Generic.Dictionary<string, string>? meta,
            string? monorepoManager,
            string? project,
            global::Vercel.CreateDeploymentRequestProjectSettings? projectSettings,
            string? target,
            bool? withLatestCommit)
        {
            this.CustomEnvironmentSlugOrId = customEnvironmentSlugOrId;
            this.DeploymentId = deploymentId;
            this.Files = files;
            this.GitMetadata = gitMetadata;
            this.GitSource = gitSource;
            this.Meta = meta;
            this.MonorepoManager = monorepoManager;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Project = project;
            this.ProjectSettings = projectSettings;
            this.Target = target;
            this.WithLatestCommit = withLatestCommit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequest" /> class.
        /// </summary>
        public CreateDeploymentRequest()
        {
        }
    }
}