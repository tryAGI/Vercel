
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSandboxesByNameRequest
    {
        /// <summary>
        /// Resources to define the VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.UpdateSandboxesByNameRequestResources? Resources { get; set; }

        /// <summary>
        /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
        /// Example: node24
        /// </summary>
        /// <example>node24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateSandboxesByNameRequestRuntimeJsonConverter))]
        public global::Vercel.UpdateSandboxesByNameRequestRuntime? Runtime { get; set; }

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
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Set to null to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepLastSnapshots")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.UpdateSandboxesByNameRequestKeepLastSnapshots>))]
        public global::Vercel.OneOf<string, global::Vercel.UpdateSandboxesByNameRequestKeepLastSnapshots>? KeepLastSnapshots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateSandboxesByNameRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxesByNameRequestNetworkPolicyVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UpdateSandboxesByNameRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxesByNameRequestNetworkPolicyVariant2>? NetworkPolicy { get; set; }

        /// <summary>
        /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </summary>
        /// <example>{"NODE_ENV":"production","HELLO":"world"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </summary>
        /// <example>[3000, 4000]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        public global::System.Collections.Generic.IList<int>? Ports { get; set; }

        /// <summary>
        /// The snapshot ID to set as the current snapshot. Must be active and belong to the same project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSnapshotId")]
        public string? CurrentSnapshotId { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateSandboxesByNameRequest" /> class.
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
        /// <param name="keepLastSnapshots">
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Set to null to clear.
        /// </param>
        /// <param name="networkPolicy"></param>
        /// <param name="env">
        /// Default environment variables for the sandbox. Set to empty object to clear.<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="ports">
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </param>
        /// <param name="currentSnapshotId">
        /// The snapshot ID to set as the current snapshot. Must be active and belong to the same project.
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Replaces existing tags. Set to empty object to clear. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxesByNameRequest(
            global::Vercel.UpdateSandboxesByNameRequestResources? resources,
            global::Vercel.UpdateSandboxesByNameRequestRuntime? runtime,
            int? timeout,
            bool? persistent,
            global::Vercel.OneOf<object, int?>? snapshotExpiration,
            global::Vercel.OneOf<string, global::Vercel.UpdateSandboxesByNameRequestKeepLastSnapshots>? keepLastSnapshots,
            global::Vercel.OneOf<global::Vercel.UpdateSandboxesByNameRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxesByNameRequestNetworkPolicyVariant2>? networkPolicy,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.IList<int>? ports,
            string? currentSnapshotId,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.Resources = resources;
            this.Runtime = runtime;
            this.Timeout = timeout;
            this.Persistent = persistent;
            this.SnapshotExpiration = snapshotExpiration;
            this.KeepLastSnapshots = keepLastSnapshots;
            this.NetworkPolicy = networkPolicy;
            this.Env = env;
            this.Ports = ports;
            this.CurrentSnapshotId = currentSnapshotId;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxesByNameRequest" /> class.
        /// </summary>
        public UpdateSandboxesByNameRequest()
        {
        }

    }
}