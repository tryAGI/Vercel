
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede816b13e35b68c5a
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        /// Buildpack runtime slug (e.g. "ruby").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildpack")]
        public string? Buildpack { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle")]
        public bool? Bundle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bunVersion")]
        public string? BunVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public bool? Debug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeFiles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? ExcludeFiles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5f7d6053e0f466da>? Functions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helpers")]
        public bool? Helpers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import")]
        public global::System.Collections.Generic.Dictionary<string, string>? Import { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeFiles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? IncludeFiles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ldsflags")]
        public string? Ldsflags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLambdaSize")]
        public string? MaxLambdaSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleware")]
        public bool? Middleware { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middlewareMatcher")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? MiddlewareMatcher { get; set; }

        /// <summary>
        /// Enforced runtime for explicitly configured Routing Middleware.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middlewareRuntime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede816b13e35b68c5aMiddlewareRuntimeJsonConverter))]
        public global::Vercel.AutoSDKSharede816b13e35b68c5aMiddlewareRuntime? MiddlewareRuntime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        public string? NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSettings")]
        public global::Vercel.AutoSDKSharede816b13e35b68c5aProjectSettings? ProjectSettings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rust")]
        public string? Rust { get; set; }

        /// <summary>
        /// Owning service name; scopes per-function config such as the v2beta consumer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zeroConfig")]
        public bool? ZeroConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede816b13e35b68c5a" /> class.
        /// </summary>
        /// <param name="buildCommand"></param>
        /// <param name="buildpack">
        /// Buildpack runtime slug (e.g. "ruby").
        /// </param>
        /// <param name="bundle"></param>
        /// <param name="bunVersion"></param>
        /// <param name="debug"></param>
        /// <param name="devCommand"></param>
        /// <param name="excludeFiles"></param>
        /// <param name="framework"></param>
        /// <param name="functions"></param>
        /// <param name="helpers"></param>
        /// <param name="import"></param>
        /// <param name="includeFiles"></param>
        /// <param name="installCommand"></param>
        /// <param name="ldsflags"></param>
        /// <param name="maxLambdaSize"></param>
        /// <param name="middleware"></param>
        /// <param name="middlewareMatcher"></param>
        /// <param name="middlewareRuntime">
        /// Enforced runtime for explicitly configured Routing Middleware.
        /// </param>
        /// <param name="nodeVersion"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="projectSettings"></param>
        /// <param name="rust"></param>
        /// <param name="serviceName">
        /// Owning service name; scopes per-function config such as the v2beta consumer.
        /// </param>
        /// <param name="zeroConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede816b13e35b68c5a(
            string? buildCommand,
            string? buildpack,
            bool? bundle,
            string? bunVersion,
            bool? debug,
            string? devCommand,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? excludeFiles,
            string? framework,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5f7d6053e0f466da>? functions,
            bool? helpers,
            global::System.Collections.Generic.Dictionary<string, string>? import,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? includeFiles,
            string? installCommand,
            string? ldsflags,
            string? maxLambdaSize,
            bool? middleware,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? middlewareMatcher,
            global::Vercel.AutoSDKSharede816b13e35b68c5aMiddlewareRuntime? middlewareRuntime,
            string? nodeVersion,
            string? outputDirectory,
            global::Vercel.AutoSDKSharede816b13e35b68c5aProjectSettings? projectSettings,
            string? rust,
            string? serviceName,
            bool? zeroConfig)
        {
            this.BuildCommand = buildCommand;
            this.Buildpack = buildpack;
            this.Bundle = bundle;
            this.BunVersion = bunVersion;
            this.Debug = debug;
            this.DevCommand = devCommand;
            this.ExcludeFiles = excludeFiles;
            this.Framework = framework;
            this.Functions = functions;
            this.Helpers = helpers;
            this.Import = import;
            this.IncludeFiles = includeFiles;
            this.InstallCommand = installCommand;
            this.Ldsflags = ldsflags;
            this.MaxLambdaSize = maxLambdaSize;
            this.Middleware = middleware;
            this.MiddlewareMatcher = middlewareMatcher;
            this.MiddlewareRuntime = middlewareRuntime;
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.ProjectSettings = projectSettings;
            this.Rust = rust;
            this.ServiceName = serviceName;
            this.ZeroConfig = zeroConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede816b13e35b68c5a" /> class.
        /// </summary>
        public AutoSDKSharede816b13e35b68c5a()
        {
        }

    }
}