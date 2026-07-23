
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monorepoManager")]
        public string? MonorepoManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoExposeSystemEnvs")]
        public bool? AutoExposeSystemEnvs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFilesOutsideRootDirectory")]
        public bool? SourceFilesOutsideRootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryListing")]
        public bool? DirectoryListing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitForkProtection")]
        public bool? GitForkProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings" /> class.
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="devCommand"></param>
        /// <param name="installCommand"></param>
        /// <param name="buildCommand"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="rootDirectory"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="monorepoManager"></param>
        /// <param name="createdAt"></param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="sourceFilesOutsideRootDirectory"></param>
        /// <param name="directoryListing"></param>
        /// <param name="gitForkProtection"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings(
            string? framework,
            string? devCommand,
            string? installCommand,
            string? buildCommand,
            string? outputDirectory,
            string? rootDirectory,
            string? nodeVersion,
            string? monorepoManager,
            double? createdAt,
            bool? autoExposeSystemEnvs,
            bool? sourceFilesOutsideRootDirectory,
            bool? directoryListing,
            bool? gitForkProtection,
            string? commandForIgnoringBuildStep)
        {
            this.Framework = framework;
            this.DevCommand = devCommand;
            this.InstallCommand = installCommand;
            this.BuildCommand = buildCommand;
            this.OutputDirectory = outputDirectory;
            this.RootDirectory = rootDirectory;
            this.NodeVersion = nodeVersion;
            this.MonorepoManager = monorepoManager;
            this.CreatedAt = createdAt;
            this.AutoExposeSystemEnvs = autoExposeSystemEnvs;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.DirectoryListing = directoryListing;
            this.GitForkProtection = gitForkProtection;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings()
        {
        }

    }
}