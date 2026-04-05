
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxRequest
    {
        /// <summary>
        /// Resources to define the VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.CreateSandboxRequestResources? Resources { get; set; }

        /// <summary>
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Default Value: node24<br/>
        /// Example: node24
        /// </summary>
        /// <example>node24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateSandboxRequestRuntimeJsonConverter))]
        public global::Vercel.CreateSandboxRequestRuntime? Runtime { get; set; }

        /// <summary>
        /// The source from which to initialize the sandbox filesystem. Can be a Git repository, a tarball URL, or an existing snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxRequestSourceVariant1, global::Vercel.CreateSandboxRequestSourceVariant2, global::Vercel.CreateSandboxRequestSourceVariant3>))]
        public global::Vercel.OneOf<global::Vercel.CreateSandboxRequestSourceVariant1, global::Vercel.CreateSandboxRequestSourceVariant2, global::Vercel.CreateSandboxRequestSourceVariant3>? Source { get; set; }

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
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        public global::Vercel.CreateSandboxRequestNetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </summary>
        /// <example>{"NODE_ENV":"production","HELLO":"world"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequest" /> class.
        /// </summary>
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
        /// <param name="networkPolicy">
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </param>
        /// <param name="env">
        /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxRequest(
            global::Vercel.CreateSandboxRequestResources? resources,
            global::Vercel.CreateSandboxRequestRuntime? runtime,
            global::Vercel.OneOf<global::Vercel.CreateSandboxRequestSourceVariant1, global::Vercel.CreateSandboxRequestSourceVariant2, global::Vercel.CreateSandboxRequestSourceVariant3>? source,
            string? projectId,
            global::System.Collections.Generic.IList<int>? ports,
            int? timeout,
            global::Vercel.CreateSandboxRequestNetworkPolicy? networkPolicy,
            global::System.Collections.Generic.Dictionary<string, string>? env)
        {
            this.Resources = resources;
            this.Runtime = runtime;
            this.Source = source;
            this.ProjectId = projectId;
            this.Ports = ports;
            this.Timeout = timeout;
            this.NetworkPolicy = networkPolicy;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequest" /> class.
        /// </summary>
        public CreateSandboxRequest()
        {
        }
    }
}