
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesRequestNetworkPolicyVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesRequestNetworkPolicyVariant2>? NetworkPolicy { get; set; }

        /// <summary>
        /// List of forwarding rules for network requests. Each rule specifies a domain pattern to match and a proxy URL to forward matching requests to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__networkPolicyForwardRules")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesRequestNetworkPolicyForwardRule>? NetworkPolicyForwardRules { get; set; }

        /// <summary>
        /// Resources to define the VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.CreateSandboxesRequestResources? Resources { get; set; }

        /// <summary>
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Default Value: node24<br/>
        /// Example: node24
        /// </summary>
        /// <example>node24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateSandboxesRequestRuntimeJsonConverter))]
        public global::Vercel.CreateSandboxesRequestRuntime? Runtime { get; set; }

        /// <summary>
        /// The source from which to initialize the sandbox filesystem. Can be a Git repository, a tarball URL, or an existing snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesRequestSourceVariant1, global::Vercel.CreateSandboxesRequestSourceVariant2, global::Vercel.CreateSandboxesRequestSourceVariant3>))]
        public global::Vercel.OneOf<global::Vercel.CreateSandboxesRequestSourceVariant1, global::Vercel.CreateSandboxesRequestSourceVariant2, global::Vercel.CreateSandboxesRequestSourceVariant3>? Source { get; set; }

        /// <summary>
        /// The target project slug or ID in which the sandbox will be assigned to.<br/>
        /// Example: prj_abc123
        /// </summary>
        /// <example>prj_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </summary>
        /// <example>[3000, 4000]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        public global::System.Collections.Generic.IList<int>? Ports { get; set; }

        /// <summary>
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </summary>
        /// <example>300000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </summary>
        /// <example>{"NODE_ENV":"production","HELLO":"world"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </summary>
        /// <example>my-sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the sandbox persists its state across restarts via automatic snapshots. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        /// <summary>
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </summary>
        /// <example>604800000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotExpiration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>))]
        public global::Vercel.OneOf<object, int?>? SnapshotExpiration { get; set; }

        /// <summary>
        /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </summary>
        /// <example>{"env":"staging","team":"platform"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequest" /> class.
        /// </summary>
        /// <param name="networkPolicy"></param>
        /// <param name="networkPolicyForwardRules">
        /// List of forwarding rules for network requests. Each rule specifies a domain pattern to match and a proxy URL to forward matching requests to.
        /// </param>
        /// <param name="resources">
        /// Resources to define the VM
        /// </param>
        /// <param name="runtime">
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Default Value: node24<br/>
        /// Example: node24
        /// </param>
        /// <param name="source">
        /// The source from which to initialize the sandbox filesystem. Can be a Git repository, a tarball URL, or an existing snapshot.
        /// </param>
        /// <param name="projectId">
        /// The target project slug or ID in which the sandbox will be assigned to.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="ports">
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </param>
        /// <param name="timeout">
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </param>
        /// <param name="env">
        /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="name">
        /// Name for the sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores).<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesRequest(
            global::Vercel.OneOf<global::Vercel.CreateSandboxesRequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesRequestNetworkPolicyVariant2>? networkPolicy,
            global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesRequestNetworkPolicyForwardRule>? networkPolicyForwardRules,
            global::Vercel.CreateSandboxesRequestResources? resources,
            global::Vercel.CreateSandboxesRequestRuntime? runtime,
            global::Vercel.OneOf<global::Vercel.CreateSandboxesRequestSourceVariant1, global::Vercel.CreateSandboxesRequestSourceVariant2, global::Vercel.CreateSandboxesRequestSourceVariant3>? source,
            string? projectId,
            global::System.Collections.Generic.IList<int>? ports,
            int? timeout,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            string? name,
            bool? persistent,
            global::Vercel.OneOf<object, int?>? snapshotExpiration,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.NetworkPolicy = networkPolicy;
            this.NetworkPolicyForwardRules = networkPolicyForwardRules;
            this.Resources = resources;
            this.Runtime = runtime;
            this.Source = source;
            this.ProjectId = projectId;
            this.Ports = ports;
            this.Timeout = timeout;
            this.Env = env;
            this.Name = name;
            this.Persistent = persistent;
            this.SnapshotExpiration = snapshotExpiration;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequest" /> class.
        /// </summary>
        public CreateSandboxesRequest()
        {
        }

    }
}