
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2ServiceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ServiceVariant1SchemaJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Schema Schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ServiceVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ServiceVariant1TriggerJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Trigger? Trigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Workspace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public string? Entrypoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Builder Builder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preDeployCommand")]
        public string? PreDeployCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routePrefix")]
        public string? RoutePrefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routePrefixSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSourceJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource? RoutePrefixSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subdomain")]
        public string? Subdomain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? Schedule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handlerFunction")]
        public string? HandlerFunction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item>>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item>>? Topics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Env2>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="workspace"></param>
        /// <param name="builder"></param>
        /// <param name="schema"></param>
        /// <param name="trigger"></param>
        /// <param name="group"></param>
        /// <param name="entrypoint"></param>
        /// <param name="framework"></param>
        /// <param name="runtime"></param>
        /// <param name="buildCommand"></param>
        /// <param name="installCommand"></param>
        /// <param name="preDeployCommand"></param>
        /// <param name="routePrefix"></param>
        /// <param name="routePrefixSource"></param>
        /// <param name="subdomain"></param>
        /// <param name="schedule"></param>
        /// <param name="handlerFunction"></param>
        /// <param name="topics"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2ServiceVariant1(
            string name,
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Type type,
            string workspace,
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Builder builder,
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Schema schema,
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Trigger? trigger,
            string? group,
            string? entrypoint,
            string? framework,
            string? runtime,
            string? buildCommand,
            string? installCommand,
            string? preDeployCommand,
            string? routePrefix,
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1RoutePrefixSource? routePrefixSource,
            string? subdomain,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? schedule,
            string? handlerFunction,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2ServiceVariant1TopicsVariant2Item>>? topics,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant2ServiceVariant1Env2>? env)
        {
            this.Schema = schema;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Trigger = trigger;
            this.Group = group;
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
            this.Entrypoint = entrypoint;
            this.Framework = framework;
            this.Builder = builder ?? throw new global::System.ArgumentNullException(nameof(builder));
            this.Runtime = runtime;
            this.BuildCommand = buildCommand;
            this.InstallCommand = installCommand;
            this.PreDeployCommand = preDeployCommand;
            this.RoutePrefix = routePrefix;
            this.RoutePrefixSource = routePrefixSource;
            this.Subdomain = subdomain;
            this.Schedule = schedule;
            this.HandlerFunction = handlerFunction;
            this.Topics = topics;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2ServiceVariant1()
        {
        }

    }
}