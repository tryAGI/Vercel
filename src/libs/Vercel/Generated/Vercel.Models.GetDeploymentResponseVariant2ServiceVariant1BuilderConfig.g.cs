
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2ServiceVariant1BuilderConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bunVersion")]
        public string? BunVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLambdaSize")]
        public string? MaxLambdaSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeFiles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? IncludeFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeFiles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? ExcludeFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle")]
        public bool? Bundle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ldsflags")]
        public string? Ldsflags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helpers")]
        public bool? Helpers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rust")]
        public string? Rust { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public bool? Debug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroConfig")]
        public bool? ZeroConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import")]
        public global::System.Collections.Generic.Dictionary<string, string>? Import { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctions2>? Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSettings")]
        public global::Vercel.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings? ProjectSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleware")]
        public bool? Middleware { get; set; }

        /// <summary>
        /// Owning service name; scopes per-function config such as the v2beta consumer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1BuilderConfig" /> class.
        /// </summary>
        /// <param name="bunVersion"></param>
        /// <param name="maxLambdaSize"></param>
        /// <param name="includeFiles"></param>
        /// <param name="excludeFiles"></param>
        /// <param name="bundle"></param>
        /// <param name="ldsflags"></param>
        /// <param name="helpers"></param>
        /// <param name="rust"></param>
        /// <param name="debug"></param>
        /// <param name="zeroConfig"></param>
        /// <param name="import"></param>
        /// <param name="functions"></param>
        /// <param name="projectSettings"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="installCommand"></param>
        /// <param name="buildCommand"></param>
        /// <param name="devCommand"></param>
        /// <param name="framework"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="middleware"></param>
        /// <param name="serviceName">
        /// Owning service name; scopes per-function config such as the v2beta consumer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2ServiceVariant1BuilderConfig(
            string? bunVersion,
            string? maxLambdaSize,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? includeFiles,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? excludeFiles,
            bool? bundle,
            string? ldsflags,
            bool? helpers,
            string? rust,
            bool? debug,
            bool? zeroConfig,
            global::System.Collections.Generic.Dictionary<string, string>? import,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctions2>? functions,
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigProjectSettings? projectSettings,
            string? outputDirectory,
            string? installCommand,
            string? buildCommand,
            string? devCommand,
            string? framework,
            string? nodeVersion,
            bool? middleware,
            string? serviceName)
        {
            this.BunVersion = bunVersion;
            this.MaxLambdaSize = maxLambdaSize;
            this.IncludeFiles = includeFiles;
            this.ExcludeFiles = excludeFiles;
            this.Bundle = bundle;
            this.Ldsflags = ldsflags;
            this.Helpers = helpers;
            this.Rust = rust;
            this.Debug = debug;
            this.ZeroConfig = zeroConfig;
            this.Import = import;
            this.Functions = functions;
            this.ProjectSettings = projectSettings;
            this.OutputDirectory = outputDirectory;
            this.InstallCommand = installCommand;
            this.BuildCommand = buildCommand;
            this.DevCommand = devCommand;
            this.Framework = framework;
            this.NodeVersion = nodeVersion;
            this.Middleware = middleware;
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1BuilderConfig" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2ServiceVariant1BuilderConfig()
        {
        }

    }
}