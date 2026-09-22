
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ServiceVariant2
    {
        /// <summary>
        /// Caller-side bindings to other services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bindings")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Binding>? Bindings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        /// Builder selected by the resolver.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Builder Builder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanUrls")]
        public bool? CleanUrls { get; set; }

        /// <summary>
        /// Command override for `runtime: "container"` services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        /// Resolved entrypoint, relative to the service root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public string? Entrypoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        /// Function configuration scoped to this service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Functions2>? Functions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Header>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreCommand")]
        public string? IgnoreCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Redirect>? Redirects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewrites")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Rewrite>? Rewrites { get; set; }

        /// <summary>
        /// Path to the service root, relative to the project root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Root { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RouteVariant2>>? Routes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ServiceVariant2SchemaJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Schema Schema { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2" /> class.
        /// </summary>
        /// <param name="builder">
        /// Builder selected by the resolver.
        /// </param>
        /// <param name="name"></param>
        /// <param name="root">
        /// Path to the service root, relative to the project root.
        /// </param>
        /// <param name="bindings">
        /// Caller-side bindings to other services.
        /// </param>
        /// <param name="buildCommand"></param>
        /// <param name="cleanUrls"></param>
        /// <param name="command">
        /// Command override for `runtime: "container"` services.
        /// </param>
        /// <param name="devCommand"></param>
        /// <param name="entrypoint">
        /// Resolved entrypoint, relative to the service root.
        /// </param>
        /// <param name="framework"></param>
        /// <param name="functions">
        /// Function configuration scoped to this service.
        /// </param>
        /// <param name="headers"></param>
        /// <param name="ignoreCommand"></param>
        /// <param name="installCommand"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="redirects"></param>
        /// <param name="rewrites"></param>
        /// <param name="routes"></param>
        /// <param name="runtime"></param>
        /// <param name="schema"></param>
        /// <param name="trailingSlash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ServiceVariant2(
            global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Builder builder,
            string name,
            string root,
            global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Binding>? bindings,
            string? buildCommand,
            bool? cleanUrls,
            global::System.Collections.Generic.IList<string>? command,
            string? devCommand,
            string? entrypoint,
            string? framework,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Functions2>? functions,
            global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Header>? headers,
            string? ignoreCommand,
            string? installCommand,
            string? outputDirectory,
            global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Redirect>? redirects,
            global::System.Collections.Generic.IList<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Rewrite>? rewrites,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RouteVariant1, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RouteVariant2>>? routes,
            string? runtime,
            global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2Schema schema,
            bool? trailingSlash)
        {
            this.Bindings = bindings;
            this.BuildCommand = buildCommand;
            this.Builder = builder ?? throw new global::System.ArgumentNullException(nameof(builder));
            this.CleanUrls = cleanUrls;
            this.Command = command;
            this.DevCommand = devCommand;
            this.Entrypoint = entrypoint;
            this.Framework = framework;
            this.Functions = functions;
            this.Headers = headers;
            this.IgnoreCommand = ignoreCommand;
            this.InstallCommand = installCommand;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputDirectory = outputDirectory;
            this.Redirects = redirects;
            this.Rewrites = rewrites;
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Routes = routes;
            this.Runtime = runtime;
            this.Schema = schema;
            this.TrailingSlash = trailingSlash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ServiceVariant2()
        {
        }

    }
}