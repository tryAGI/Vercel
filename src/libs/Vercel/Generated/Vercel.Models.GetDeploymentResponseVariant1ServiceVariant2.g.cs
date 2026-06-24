
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1ServiceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1ServiceVariant2SchemaJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Schema Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Path to the service root, relative to the project root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Root { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        /// Resolved entrypoint, relative to the service root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public string? Entrypoint { get; set; }

        /// <summary>
        /// Command override for `runtime: "container"` services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// Builder selected by the resolver.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Builder Builder { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreCommand")]
        public string? IgnoreCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        /// Caller-side bindings to other services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bindings")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Binding>? Bindings { get; set; }

        /// <summary>
        /// Function configuration scoped to this service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Functions2>? Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Header>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Redirect>? Redirects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewrites")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Rewrite>? Rewrites { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RouteVariant1, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RouteVariant2>>? Routes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanUrls")]
        public bool? CleanUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trailingSlash")]
        public bool? TrailingSlash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ServiceVariant2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="root">
        /// Path to the service root, relative to the project root.
        /// </param>
        /// <param name="builder">
        /// Builder selected by the resolver.
        /// </param>
        /// <param name="schema"></param>
        /// <param name="framework"></param>
        /// <param name="runtime"></param>
        /// <param name="entrypoint">
        /// Resolved entrypoint, relative to the service root.
        /// </param>
        /// <param name="command">
        /// Command override for `runtime: "container"` services.
        /// </param>
        /// <param name="installCommand"></param>
        /// <param name="buildCommand"></param>
        /// <param name="devCommand"></param>
        /// <param name="ignoreCommand"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="bindings">
        /// Caller-side bindings to other services.
        /// </param>
        /// <param name="functions">
        /// Function configuration scoped to this service.
        /// </param>
        /// <param name="headers"></param>
        /// <param name="redirects"></param>
        /// <param name="rewrites"></param>
        /// <param name="routes"></param>
        /// <param name="cleanUrls"></param>
        /// <param name="trailingSlash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1ServiceVariant2(
            string name,
            string root,
            global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Builder builder,
            global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Schema schema,
            string? framework,
            string? runtime,
            string? entrypoint,
            global::System.Collections.Generic.IList<string>? command,
            string? installCommand,
            string? buildCommand,
            string? devCommand,
            string? ignoreCommand,
            string? outputDirectory,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Binding>? bindings,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Functions2>? functions,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Header>? headers,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Redirect>? redirects,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2Rewrite>? rewrites,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RouteVariant1, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RouteVariant2>>? routes,
            bool? cleanUrls,
            bool? trailingSlash)
        {
            this.Schema = schema;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Framework = framework;
            this.Runtime = runtime;
            this.Entrypoint = entrypoint;
            this.Command = command;
            this.Builder = builder ?? throw new global::System.ArgumentNullException(nameof(builder));
            this.InstallCommand = installCommand;
            this.BuildCommand = buildCommand;
            this.DevCommand = devCommand;
            this.IgnoreCommand = ignoreCommand;
            this.OutputDirectory = outputDirectory;
            this.Bindings = bindings;
            this.Functions = functions;
            this.Headers = headers;
            this.Redirects = redirects;
            this.Rewrites = rewrites;
            this.Routes = routes;
            this.CleanUrls = cleanUrls;
            this.TrailingSlash = trailingSlash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ServiceVariant2" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1ServiceVariant2()
        {
        }

    }
}