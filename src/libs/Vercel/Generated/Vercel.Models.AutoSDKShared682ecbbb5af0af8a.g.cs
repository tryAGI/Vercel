
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared682ecbbb5af0af8a
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared682ecbbb5af0af8aFrameworkJsonConverter))]
        public global::Vercel.AutoSDKShared682ecbbb5af0af8aFramework? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared682ecbbb5af0af8aNodeVersionJsonConverter))]
        public global::Vercel.AutoSDKShared682ecbbb5af0af8aNodeVersion? NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.AutoSDKShared682ecbbb5af0af8aSpeedInsights? SpeedInsights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.AutoSDKShared682ecbbb5af0af8aWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared682ecbbb5af0af8a" /> class.
        /// </summary>
        /// <param name="buildCommand"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="devCommand"></param>
        /// <param name="framework"></param>
        /// <param name="installCommand"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="speedInsights"></param>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared682ecbbb5af0af8a(
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            string? devCommand,
            global::Vercel.AutoSDKShared682ecbbb5af0af8aFramework? framework,
            string? installCommand,
            global::Vercel.AutoSDKShared682ecbbb5af0af8aNodeVersion? nodeVersion,
            string? outputDirectory,
            global::Vercel.AutoSDKShared682ecbbb5af0af8aSpeedInsights? speedInsights,
            global::Vercel.AutoSDKShared682ecbbb5af0af8aWebAnalytics? webAnalytics)
        {
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.DevCommand = devCommand;
            this.Framework = framework;
            this.InstallCommand = installCommand;
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.SpeedInsights = speedInsights;
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared682ecbbb5af0af8a" /> class.
        /// </summary>
        public AutoSDKShared682ecbbb5af0af8a()
        {
        }

    }
}