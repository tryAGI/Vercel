
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ProjectSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ProjectSettingsNodeVersionJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsNodeVersion? NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ProjectSettingsFrameworkJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsFramework? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsSpeedInsights? SpeedInsights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ProjectSettings" /> class.
        /// </summary>
        /// <param name="nodeVersion"></param>
        /// <param name="buildCommand"></param>
        /// <param name="devCommand"></param>
        /// <param name="framework"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="installCommand"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="speedInsights"></param>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ProjectSettings(
            global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsNodeVersion? nodeVersion,
            string? buildCommand,
            string? devCommand,
            global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsFramework? framework,
            string? commandForIgnoringBuildStep,
            string? installCommand,
            string? outputDirectory,
            global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsSpeedInsights? speedInsights,
            global::Vercel.CreateDeploymentResponseVariant2ProjectSettingsWebAnalytics? webAnalytics)
        {
            this.NodeVersion = nodeVersion;
            this.BuildCommand = buildCommand;
            this.DevCommand = devCommand;
            this.Framework = framework;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.InstallCommand = installCommand;
            this.OutputDirectory = outputDirectory;
            this.SpeedInsights = speedInsights;
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ProjectSettings" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ProjectSettings()
        {
        }

    }
}