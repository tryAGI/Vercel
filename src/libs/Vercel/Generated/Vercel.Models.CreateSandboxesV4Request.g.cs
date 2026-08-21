
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesV4Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesV4RequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesV4RequestNetworkPolicyVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateSandboxesV4RequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesV4RequestNetworkPolicyVariant2>? NetworkPolicy { get; set; }

        /// <summary>
        /// Resources to define the VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.CreateSandboxesV4RequestResources? Resources { get; set; }

        /// <summary>
        /// The source from which to initialize the sandbox filesystem. Can be a Git repository, a tarball URL, or an existing snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesV4RequestSourceVariant1, global::Vercel.CreateSandboxesV4RequestSourceVariant2, global::Vercel.CreateSandboxesV4RequestSourceVariant3>))]
        public global::Vercel.OneOf<global::Vercel.CreateSandboxesV4RequestSourceVariant1, global::Vercel.CreateSandboxesV4RequestSourceVariant2, global::Vercel.CreateSandboxesV4RequestSourceVariant3>? Source { get; set; }

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
        /// Image to use for the sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

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
        /// List of drives to mount to the sandbox at the provided path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounts")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesV4RequestMounts2>? Mounts { get; set; }

        /// <summary>
        /// The Vercel region in which to create the sandbox.<br/>
        /// Default Value: [iad1, sfo1, cle1, cdg1]<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateSandboxesV4RequestRegionJsonConverter))]
        public global::Vercel.CreateSandboxesV4RequestRegion? Region { get; set; }

        /// <summary>
        /// The regions the sandbox falls back to when it cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
        /// </summary>
        /// <example>[sfo1, cle1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV4RequestFailoverRegion>? FailoverRegions { get; set; }

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
        /// Default snapshot expiration time in milliseconds. Defaults to 7 days. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </summary>
        /// <example>604800000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotExpiration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>))]
        public global::Vercel.OneOf<object, int?>? SnapshotExpiration { get; set; }

        /// <summary>
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Persistent sandboxes default to keeping only the last snapshot (evicted snapshots are deleted). Set to null to disable the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepLastSnapshots")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots>))]
        public global::Vercel.OneOf<string, global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots>? KeepLastSnapshots { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSandboxesV4Request" /> class.
        /// </summary>
        /// <param name="networkPolicy"></param>
        /// <param name="resources">
        /// Resources to define the VM
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
        /// <param name="image">
        /// Image to use for the sandbox.
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
        /// <param name="mounts">
        /// List of drives to mount to the sandbox at the provided path.
        /// </param>
        /// <param name="region">
        /// The Vercel region in which to create the sandbox.<br/>
        /// Default Value: [iad1, sfo1, cle1, cdg1]<br/>
        /// Example: iad1
        /// </param>
        /// <param name="failoverRegions">
        /// The regions the sandbox falls back to when it cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
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
        /// Default snapshot expiration time in milliseconds. Defaults to 7 days. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="keepLastSnapshots">
        /// Protect the N most recent snapshots with different expiration/deletion behavior. Persistent sandboxes default to keeping only the last snapshot (evicted snapshots are deleted). Set to null to disable the limit.
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesV4Request(
            global::Vercel.OneOf<global::Vercel.CreateSandboxesV4RequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesV4RequestNetworkPolicyVariant2>? networkPolicy,
            global::Vercel.CreateSandboxesV4RequestResources? resources,
            global::Vercel.OneOf<global::Vercel.CreateSandboxesV4RequestSourceVariant1, global::Vercel.CreateSandboxesV4RequestSourceVariant2, global::Vercel.CreateSandboxesV4RequestSourceVariant3>? source,
            string? projectId,
            global::System.Collections.Generic.IList<int>? ports,
            string? image,
            int? timeout,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesV4RequestMounts2>? mounts,
            global::Vercel.CreateSandboxesV4RequestRegion? region,
            global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV4RequestFailoverRegion>? failoverRegions,
            string? name,
            bool? persistent,
            global::Vercel.OneOf<object, int?>? snapshotExpiration,
            global::Vercel.OneOf<string, global::Vercel.CreateSandboxesV4RequestKeepLastSnapshots>? keepLastSnapshots,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.NetworkPolicy = networkPolicy;
            this.Resources = resources;
            this.Source = source;
            this.ProjectId = projectId;
            this.Ports = ports;
            this.Image = image;
            this.Timeout = timeout;
            this.Env = env;
            this.Mounts = mounts;
            this.Region = region;
            this.FailoverRegions = failoverRegions;
            this.Name = name;
            this.Persistent = persistent;
            this.SnapshotExpiration = snapshotExpiration;
            this.KeepLastSnapshots = keepLastSnapshots;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesV4Request" /> class.
        /// </summary>
        public CreateSandboxesV4Request()
        {
        }

    }
}