
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
    /// </summary>
    public sealed partial class AutoSDKSharedd60af9eb328d9316
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba8564203445c393 Builder { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public string? Entrypoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedd60af9eb328d9316Env2>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        public string? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handlerFunction")]
        public string? HandlerFunction { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd60af9eb328d9316RoutePrefixSourceJsonConverter))]
        public global::Vercel.AutoSDKSharedd60af9eb328d9316RoutePrefixSource? RoutePrefixSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? Schedule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd60af9eb328d9316SchemaJsonConverter))]
        public global::Vercel.AutoSDKSharedd60af9eb328d9316Schema Schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subdomain")]
        public string? Subdomain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd60af9eb328d9316TopicsVariant2Item>>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd60af9eb328d9316TopicsVariant2Item>>? Topics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd60af9eb328d9316TriggerJsonConverter))]
        public global::Vercel.AutoSDKSharedd60af9eb328d9316Trigger? Trigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd60af9eb328d9316TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd60af9eb328d9316Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd60af9eb328d9316" /> class.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="workspace"></param>
        /// <param name="buildCommand"></param>
        /// <param name="entrypoint"></param>
        /// <param name="env"></param>
        /// <param name="framework"></param>
        /// <param name="group"></param>
        /// <param name="handlerFunction"></param>
        /// <param name="installCommand"></param>
        /// <param name="preDeployCommand"></param>
        /// <param name="routePrefix"></param>
        /// <param name="routePrefixSource"></param>
        /// <param name="runtime"></param>
        /// <param name="schedule"></param>
        /// <param name="schema"></param>
        /// <param name="subdomain"></param>
        /// <param name="topics"></param>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd60af9eb328d9316(
            global::Vercel.AutoSDKSharedba8564203445c393 builder,
            string name,
            global::Vercel.AutoSDKSharedd60af9eb328d9316Type type,
            string workspace,
            string? buildCommand,
            string? entrypoint,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedd60af9eb328d9316Env2>? env,
            string? framework,
            string? group,
            string? handlerFunction,
            string? installCommand,
            string? preDeployCommand,
            string? routePrefix,
            global::Vercel.AutoSDKSharedd60af9eb328d9316RoutePrefixSource? routePrefixSource,
            string? runtime,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? schedule,
            global::Vercel.AutoSDKSharedd60af9eb328d9316Schema schema,
            string? subdomain,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd60af9eb328d9316TopicsVariant2Item>>? topics,
            global::Vercel.AutoSDKSharedd60af9eb328d9316Trigger? trigger)
        {
            this.BuildCommand = buildCommand;
            this.Builder = builder ?? throw new global::System.ArgumentNullException(nameof(builder));
            this.Entrypoint = entrypoint;
            this.Env = env;
            this.Framework = framework;
            this.Group = group;
            this.HandlerFunction = handlerFunction;
            this.InstallCommand = installCommand;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreDeployCommand = preDeployCommand;
            this.RoutePrefix = routePrefix;
            this.RoutePrefixSource = routePrefixSource;
            this.Runtime = runtime;
            this.Schedule = schedule;
            this.Schema = schema;
            this.Subdomain = subdomain;
            this.Topics = topics;
            this.Trigger = trigger;
            this.Type = type;
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd60af9eb328d9316" /> class.
        /// </summary>
        public AutoSDKSharedd60af9eb328d9316()
        {
        }

    }
}