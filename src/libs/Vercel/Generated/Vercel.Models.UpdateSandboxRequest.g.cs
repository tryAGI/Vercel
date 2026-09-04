
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
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Set to null to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepLastSnapshots")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>))]
        public global::Vercel.OneOf<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>? KeepLastSnapshots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxRequestNetworkPolicyVariant2>))]
        public global::Vercel.OneOf<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxRequestNetworkPolicyVariant2>? NetworkPolicy { get; set; }

        /// <summary>
        /// The Vercel region in which to create the sandbox.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateSandboxRequestRegionJsonConverter))]
        public global::Vercel.UpdateSandboxRequestRegion? Region { get; set; }

        /// <summary>
        /// The regions the sandbox falls back to when it cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
        /// </summary>
        /// <example>[sfo1, cle1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        /// Drives to mount to the sandbox at the provided path. Replaces the current mounts; an empty object removes them all. Changes take effect when the next session starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounts")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateSandboxRequestMounts2>? Mounts { get; set; }

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
        /// <param name="keepLastSnapshots">
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Set to null to clear.
        /// </param>
        /// <param name="networkPolicy"></param>
        /// <param name="region">
        /// The Vercel region in which to create the sandbox.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="failoverRegions">
        /// The regions the sandbox falls back to when it cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
        /// </param>
        /// <param name="mounts">
        /// Drives to mount to the sandbox at the provided path. Replaces the current mounts; an empty object removes them all. Changes take effect when the next session starts.
        /// </param>
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
        public UpdateSandboxRequest(
            global::Vercel.UpdateSandboxRequestResources? resources,
            global::Vercel.UpdateSandboxRequestRuntime? runtime,
            int? timeout,
            bool? persistent,
            global::Vercel.OneOf<object, int?>? snapshotExpiration,
            global::Vercel.OneOf<string, global::Vercel.UpdateSandboxRequestKeepLastSnapshots>? keepLastSnapshots,
            global::Vercel.OneOf<global::Vercel.UpdateSandboxRequestNetworkPolicyVariant1, global::Vercel.UpdateSandboxRequestNetworkPolicyVariant2>? networkPolicy,
            global::Vercel.UpdateSandboxRequestRegion? region,
            global::System.Collections.Generic.IList<global::Vercel.UpdateSandboxRequestFailoverRegion>? failoverRegions,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateSandboxRequestMounts2>? mounts,
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
            this.Region = region;
            this.FailoverRegions = failoverRegions;
            this.Mounts = mounts;
            this.Env = env;
            this.Ports = ports;
            this.CurrentSnapshotId = currentSnapshotId;
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