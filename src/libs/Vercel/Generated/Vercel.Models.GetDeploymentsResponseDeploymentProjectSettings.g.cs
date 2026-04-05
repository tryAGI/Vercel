
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The project settings which was used for this deployment
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeploymentProjectSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentProjectSettingsFrameworkJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsFramework? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitForkProtection")]
        public bool? GitForkProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerSupportCodeVisibility")]
        public bool? CustomerSupportCodeVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitLFS")]
        public bool? GitLFS { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentProjectSettingsNodeVersionJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsNodeVersion? NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicSource")]
        public bool? PublicSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFilesOutsideRootDirectory")]
        public bool? SourceFilesOutsideRootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsSpeedInsights? SpeedInsights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGitConnectDuringLink")]
        public bool? SkipGitConnectDuringLink { get; set; }

        /// <summary>
        /// Since June '23
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsGitComments? GitComments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentProjectSettings" /> class.
        /// </summary>
        /// <param name="framework"></param>
        /// <param name="gitForkProtection"></param>
        /// <param name="customerSupportCodeVisibility"></param>
        /// <param name="gitLFS"></param>
        /// <param name="devCommand"></param>
        /// <param name="installCommand"></param>
        /// <param name="buildCommand"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="publicSource"></param>
        /// <param name="rootDirectory"></param>
        /// <param name="sourceFilesOutsideRootDirectory"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="createdAt"></param>
        /// <param name="speedInsights"></param>
        /// <param name="webAnalytics"></param>
        /// <param name="skipGitConnectDuringLink"></param>
        /// <param name="gitComments">
        /// Since June '23
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeploymentProjectSettings(
            global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsFramework? framework,
            bool? gitForkProtection,
            bool? customerSupportCodeVisibility,
            bool? gitLFS,
            string? devCommand,
            string? installCommand,
            string? buildCommand,
            global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsNodeVersion? nodeVersion,
            string? outputDirectory,
            bool? publicSource,
            string? rootDirectory,
            bool? sourceFilesOutsideRootDirectory,
            string? commandForIgnoringBuildStep,
            double? createdAt,
            global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsSpeedInsights? speedInsights,
            global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsWebAnalytics? webAnalytics,
            bool? skipGitConnectDuringLink,
            global::Vercel.GetDeploymentsResponseDeploymentProjectSettingsGitComments? gitComments)
        {
            this.Framework = framework;
            this.GitForkProtection = gitForkProtection;
            this.CustomerSupportCodeVisibility = customerSupportCodeVisibility;
            this.GitLFS = gitLFS;
            this.DevCommand = devCommand;
            this.InstallCommand = installCommand;
            this.BuildCommand = buildCommand;
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.PublicSource = publicSource;
            this.RootDirectory = rootDirectory;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.CreatedAt = createdAt;
            this.SpeedInsights = speedInsights;
            this.WebAnalytics = webAnalytics;
            this.SkipGitConnectDuringLink = skipGitConnectDuringLink;
            this.GitComments = gitComments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeploymentProjectSettings" /> class.
        /// </summary>
        public GetDeploymentsResponseDeploymentProjectSettings()
        {
        }
    }
}