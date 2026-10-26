
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared08ccbffba83732e3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared08ccbffba83732e3FrameworkJsonConverter))]
        public global::Vercel.AutoSDKShared08ccbffba83732e3Framework? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared08ccbffba83732e3NodeVersionJsonConverter))]
        public global::Vercel.AutoSDKShared08ccbffba83732e3NodeVersion? NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.AutoSDKShared08ccbffba83732e3SpeedInsights? SpeedInsights { get; set; }

        /// <summary>
        /// Vercel Flags activation metadata copied from the project at deployment creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelFlags")]
        public global::Vercel.AutoSDKShared08ccbffba83732e3VercelFlags? VercelFlags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.AutoSDKShared08ccbffba83732e3WebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared08ccbffba83732e3" /> class.
        /// </summary>
        /// <param name="buildCommand"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="devCommand"></param>
        /// <param name="framework"></param>
        /// <param name="installCommand"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="speedInsights"></param>
        /// <param name="vercelFlags">
        /// Vercel Flags activation metadata copied from the project at deployment creation.
        /// </param>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared08ccbffba83732e3(
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            string? devCommand,
            global::Vercel.AutoSDKShared08ccbffba83732e3Framework? framework,
            string? installCommand,
            global::Vercel.AutoSDKShared08ccbffba83732e3NodeVersion? nodeVersion,
            string? outputDirectory,
            global::Vercel.AutoSDKShared08ccbffba83732e3SpeedInsights? speedInsights,
            global::Vercel.AutoSDKShared08ccbffba83732e3VercelFlags? vercelFlags,
            global::Vercel.AutoSDKShared08ccbffba83732e3WebAnalytics? webAnalytics)
        {
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.DevCommand = devCommand;
            this.Framework = framework;
            this.InstallCommand = installCommand;
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.SpeedInsights = speedInsights;
            this.VercelFlags = vercelFlags;
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared08ccbffba83732e3" /> class.
        /// </summary>
        public AutoSDKShared08ccbffba83732e3()
        {
        }

    }
}