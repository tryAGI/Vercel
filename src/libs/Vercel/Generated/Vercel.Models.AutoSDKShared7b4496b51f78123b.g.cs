
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared7b4496b51f78123b
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
        /// Set when this build produces the named daemon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daemon")]
        public global::Vercel.AutoSDKSharedb4706d78b2b82e72? Daemon { get; set; }

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
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3aee88dc9f99cb9b>? Functions { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared7b4496b51f78123bMiddlewareRuntimeJsonConverter))]
        public global::Vercel.AutoSDKShared7b4496b51f78123bMiddlewareRuntime? MiddlewareRuntime { get; set; }

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
        public global::Vercel.AutoSDKShared7b4496b51f78123bProjectSettings? ProjectSettings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rust")]
        public string? Rust { get; set; }

        /// <summary>
        /// Set when this build produces a function for schedule entrypoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduleFunction")]
        public global::Vercel.AutoSDKShared7b4496b51f78123bScheduleFunction? ScheduleFunction { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared7b4496b51f78123b" /> class.
        /// </summary>
        /// <param name="buildCommand"></param>
        /// <param name="buildpack">
        /// Buildpack runtime slug (e.g. "ruby").
        /// </param>
        /// <param name="bundle"></param>
        /// <param name="bunVersion"></param>
        /// <param name="daemon">
        /// Set when this build produces the named daemon.
        /// </param>
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
        /// <param name="scheduleFunction">
        /// Set when this build produces a function for schedule entrypoints.
        /// </param>
        /// <param name="serviceName">
        /// Owning service name; scopes per-function config such as the v2beta consumer.
        /// </param>
        /// <param name="zeroConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared7b4496b51f78123b(
            string? buildCommand,
            string? buildpack,
            bool? bundle,
            string? bunVersion,
            global::Vercel.AutoSDKSharedb4706d78b2b82e72? daemon,
            bool? debug,
            string? devCommand,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? excludeFiles,
            string? framework,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3aee88dc9f99cb9b>? functions,
            bool? helpers,
            global::System.Collections.Generic.Dictionary<string, string>? import,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? includeFiles,
            string? installCommand,
            string? ldsflags,
            string? maxLambdaSize,
            bool? middleware,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? middlewareMatcher,
            global::Vercel.AutoSDKShared7b4496b51f78123bMiddlewareRuntime? middlewareRuntime,
            string? nodeVersion,
            string? outputDirectory,
            global::Vercel.AutoSDKShared7b4496b51f78123bProjectSettings? projectSettings,
            string? rust,
            global::Vercel.AutoSDKShared7b4496b51f78123bScheduleFunction? scheduleFunction,
            string? serviceName,
            bool? zeroConfig)
        {
            this.BuildCommand = buildCommand;
            this.Buildpack = buildpack;
            this.Bundle = bundle;
            this.BunVersion = bunVersion;
            this.Daemon = daemon;
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
            this.ScheduleFunction = scheduleFunction;
            this.ServiceName = serviceName;
            this.ZeroConfig = zeroConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7b4496b51f78123b" /> class.
        /// </summary>
        public AutoSDKShared7b4496b51f78123b()
        {
        }

    }
}