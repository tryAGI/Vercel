
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project settings that will be applied to the deployment. It is required for the first deployment of a project and will be saved for any following deployments
    /// </summary>
    public sealed partial class CreateDeploymentRequestProjectSettings
    {
        /// <summary>
        /// The build command for this project. When `null` is used this value will be automatically detected<br/>
        /// Example: next build
        /// </summary>
        /// <example>next build</example>
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
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestProjectSettingsFrameworkJsonConverter))]
        public global::Vercel.CreateDeploymentRequestProjectSettingsFramework? Framework { get; set; }

        /// <summary>
        /// The install command for this project. When `null` is used this value will be automatically detected<br/>
        /// Example: pnpm install
        /// </summary>
        /// <example>pnpm install</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        /// Override the Node.js version that should be used for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestProjectSettingsNodeVersionJsonConverter))]
        public global::Vercel.CreateDeploymentRequestProjectSettingsNodeVersion? NodeVersion { get; set; }

        /// <summary>
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

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
        /// Opts-out of the message prompting a CLI user to connect a Git repository in `vercel link`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGitConnectDuringLink")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SkipGitConnectDuringLink { get; set; }

        /// <summary>
        /// Indicates if there are source files outside of the root directory, typically used for monorepos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFilesOutsideRootDirectory")]
        public bool? SourceFilesOutsideRootDirectory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestProjectSettings" /> class.
        /// </summary>
        /// <param name="buildCommand">
        /// The build command for this project. When `null` is used this value will be automatically detected<br/>
        /// Example: next build
        /// </param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="devCommand">
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="framework">
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </param>
        /// <param name="installCommand">
        /// The install command for this project. When `null` is used this value will be automatically detected<br/>
        /// Example: pnpm install
        /// </param>
        /// <param name="nodeVersion">
        /// Override the Node.js version that should be used for this deployment
        /// </param>
        /// <param name="outputDirectory">
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="rootDirectory">
        /// The name of a directory or relative path to the source code of your project. When `null` is used it will default to the project root
        /// </param>
        /// <param name="serverlessFunctionRegion">
        /// The region to deploy Serverless Functions in this project
        /// </param>
        /// <param name="sourceFilesOutsideRootDirectory">
        /// Indicates if there are source files outside of the root directory, typically used for monorepos
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestProjectSettings(
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            string? devCommand,
            global::Vercel.CreateDeploymentRequestProjectSettingsFramework? framework,
            string? installCommand,
            global::Vercel.CreateDeploymentRequestProjectSettingsNodeVersion? nodeVersion,
            string? outputDirectory,
            string? rootDirectory,
            string? serverlessFunctionRegion,
            bool? sourceFilesOutsideRootDirectory)
        {
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.DevCommand = devCommand;
            this.Framework = framework;
            this.InstallCommand = installCommand;
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.RootDirectory = rootDirectory;
            this.ServerlessFunctionRegion = serverlessFunctionRegion;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestProjectSettings" /> class.
        /// </summary>
        public CreateDeploymentRequestProjectSettings()
        {
        }
    }
}