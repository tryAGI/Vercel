
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSandboxRequest
    {
        /// <summary>
        /// Resources to define the VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.UpdateSandboxRequestResources? Resources { get; set; }

        /// <summary>
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Example: node24
        /// </summary>
        /// <example>node24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateSandboxRequestRuntimeJsonConverter))]
        public global::Vercel.UpdateSandboxRequestRuntime? Runtime { get; set; }

        /// <summary>
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </summary>
        /// <example>300000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Whether the sandbox persists its state across restarts via automatic snapshots.
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
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        public global::Vercel.UpdateSandboxRequestNetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </summary>
        /// <example>{"NODE_ENV":"production","HELLO":"world"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Key-value tags to associate with the sandbox. Replaces existing tags. Set to empty object to clear. Maximum 5 tags.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateSandboxRequest" /> class.
        /// </summary>
        /// <param name="resources">
        /// Resources to define the VM
        /// </param>
        /// <param name="runtime">
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Example: node24
        /// </param>
        /// <param name="timeout">
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots.
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="networkPolicy">
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </param>
        /// <param name="env">
        /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Replaces existing tags. Set to empty object to clear. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxRequest(
            global::Vercel.UpdateSandboxRequestResources? resources,
            global::Vercel.UpdateSandboxRequestRuntime? runtime,
            int? timeout,
            bool? persistent,
            global::Vercel.OneOf<object, int?>? snapshotExpiration,
            global::Vercel.UpdateSandboxRequestNetworkPolicy? networkPolicy,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.Resources = resources;
            this.Runtime = runtime;
            this.Timeout = timeout;
            this.Persistent = persistent;
            this.SnapshotExpiration = snapshotExpiration;
            this.NetworkPolicy = networkPolicy;
            this.Env = env;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxRequest" /> class.
        /// </summary>
        public UpdateSandboxRequest()
        {
        }
    }
}