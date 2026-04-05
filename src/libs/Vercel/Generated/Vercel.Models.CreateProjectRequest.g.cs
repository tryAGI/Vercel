
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectRequest
    {
        /// <summary>
        /// Opt-in to preview toolbar on the project level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePreviewFeedback")]
        public bool? EnablePreviewFeedback { get; set; }

        /// <summary>
        /// Opt-in to production toolbar on the project level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableProductionFeedback")]
        public bool? EnableProductionFeedback { get; set; }

        /// <summary>
        /// Specifies whether preview deployments are disabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentsDisabled")]
        public bool? PreviewDeploymentsDisabled { get; set; }

        /// <summary>
        /// Custom domain suffix for preview deployments. Takes precedence over team-level suffix. Must be a domain owned by the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public string? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// The build command for this project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        /// Collection of ENV Variables the Project will use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestEnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectRequestFrameworkJsonConverter))]
        public global::Vercel.CreateProjectRequestFramework? Framework { get; set; }

        /// <summary>
        /// The Git Repository that will be connected to the project. When this is defined, any pushes to the specified connected Git Repository will be automatically deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepository")]
        public global::Vercel.CreateProjectRequestGitRepository? GitRepository { get; set; }

        /// <summary>
        /// The install command for this project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </summary>
        /// <example>a-project-name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Opts-out of the message prompting a CLI user to connect a Git repository in `vercel link`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGitConnectDuringLink")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SkipGitConnectDuringLink { get; set; }

        /// <summary>
        /// The Vercel Auth setting for the project (historically named \"SSO Protection\")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.CreateProjectRequestSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        /// Specifies whether the source code and logs of the deployments for this project should be public or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicSource")]
        public bool? PublicSource { get; set; }

        /// <summary>
        /// The name of a directory or relative path to the source code of your project. When `null` is used it will default to the project root
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        /// The region to deploy Serverless Functions in this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionRegion")]
        public string? ServerlessFunctionRegion { get; set; }

        /// <summary>
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionZeroConfigFailover")]
        public bool? ServerlessFunctionZeroConfigFailover { get; set; }

        /// <summary>
        /// OpenID Connect JSON Web Token generation configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.CreateProjectRequestOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        /// Opt-in to skip deployments when there are no changes to the root directory and its dependencies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAffectedProjectsDeployments")]
        public bool? EnableAffectedProjectsDeployments { get; set; }

        /// <summary>
        /// Specifies resource override configuration for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.CreateProjectRequestResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Opt-in to preview toolbar on the project level
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Opt-in to production toolbar on the project level
        /// </param>
        /// <param name="previewDeploymentsDisabled">
        /// Specifies whether preview deployments are disabled for this project.
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Custom domain suffix for preview deployments. Takes precedence over team-level suffix. Must be a domain owned by the team.
        /// </param>
        /// <param name="buildCommand">
        /// The build command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="devCommand">
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="environmentVariables">
        /// Collection of ENV Variables the Project will use
        /// </param>
        /// <param name="framework">
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </param>
        /// <param name="gitRepository">
        /// The Git Repository that will be connected to the project. When this is defined, any pushes to the specified connected Git Repository will be automatically deployed
        /// </param>
        /// <param name="installCommand">
        /// The install command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="ssoProtection">
        /// The Vercel Auth setting for the project (historically named \"SSO Protection\")
        /// </param>
        /// <param name="outputDirectory">
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="publicSource">
        /// Specifies whether the source code and logs of the deployments for this project should be public or not
        /// </param>
        /// <param name="rootDirectory">
        /// The name of a directory or relative path to the source code of your project. When `null` is used it will default to the project root
        /// </param>
        /// <param name="serverlessFunctionRegion">
        /// The region to deploy Serverless Functions in this project
        /// </param>
        /// <param name="serverlessFunctionZeroConfigFailover">
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </param>
        /// <param name="oidcTokenConfig">
        /// OpenID Connect JSON Web Token generation configuration.
        /// </param>
        /// <param name="enableAffectedProjectsDeployments">
        /// Opt-in to skip deployments when there are no changes to the root directory and its dependencies
        /// </param>
        /// <param name="resourceConfig">
        /// Specifies resource override configuration for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequest(
            string name,
            bool? enablePreviewFeedback,
            bool? enableProductionFeedback,
            bool? previewDeploymentsDisabled,
            string? previewDeploymentSuffix,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            string? devCommand,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestEnvironmentVariable>? environmentVariables,
            global::Vercel.CreateProjectRequestFramework? framework,
            global::Vercel.CreateProjectRequestGitRepository? gitRepository,
            string? installCommand,
            global::Vercel.CreateProjectRequestSsoProtection? ssoProtection,
            string? outputDirectory,
            bool? publicSource,
            string? rootDirectory,
            string? serverlessFunctionRegion,
            bool? serverlessFunctionZeroConfigFailover,
            global::Vercel.CreateProjectRequestOidcTokenConfig? oidcTokenConfig,
            bool? enableAffectedProjectsDeployments,
            global::Vercel.CreateProjectRequestResourceConfig? resourceConfig)
        {
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.EnableProductionFeedback = enableProductionFeedback;
            this.PreviewDeploymentsDisabled = previewDeploymentsDisabled;
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.DevCommand = devCommand;
            this.EnvironmentVariables = environmentVariables;
            this.Framework = framework;
            this.GitRepository = gitRepository;
            this.InstallCommand = installCommand;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SsoProtection = ssoProtection;
            this.OutputDirectory = outputDirectory;
            this.PublicSource = publicSource;
            this.RootDirectory = rootDirectory;
            this.ServerlessFunctionRegion = serverlessFunctionRegion;
            this.ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover;
            this.OidcTokenConfig = oidcTokenConfig;
            this.EnableAffectedProjectsDeployments = enableAffectedProjectsDeployments;
            this.ResourceConfig = resourceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        public CreateProjectRequest()
        {
        }
    }
}