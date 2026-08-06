
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesByNameForkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateSandboxesByNameForkRequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesByNameForkRequestNetworkPolicyVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateSandboxesByNameForkRequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesByNameForkRequestNetworkPolicyVariant2>? NetworkPolicy { get; set; }

        /// <summary>
        /// Resources to define the VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.CreateSandboxesByNameForkRequestResources? Resources { get; set; }

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
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesByNameForkRequestMounts2>? Mounts { get; set; }

        /// <summary>
        /// Name for the forked sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores). A random name is generated when omitted.<br/>
        /// Example: my-sandbox-fork
        /// </summary>
        /// <example>my-sandbox-fork</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the sandbox persists its state across restarts via automatic snapshots. Defaults to the source sandbox setting.
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
        /// Protect the N most recent snapshots with different expiration/deletion behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepLastSnapshots")]
        public global::Vercel.CreateSandboxesByNameForkRequestKeepLastSnapshots? KeepLastSnapshots { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSandboxesByNameForkRequest" /> class.
        /// </summary>
        /// <param name="networkPolicy"></param>
        /// <param name="resources">
        /// Resources to define the VM
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
        /// <param name="name">
        /// Name for the forked sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores). A random name is generated when omitted.<br/>
        /// Example: my-sandbox-fork
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots. Defaults to the source sandbox setting.
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="keepLastSnapshots">
        /// Protect the N most recent snapshots with different expiration/deletion behavior.
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesByNameForkRequest(
            global::Vercel.OneOf<global::Vercel.CreateSandboxesByNameForkRequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesByNameForkRequestNetworkPolicyVariant2>? networkPolicy,
            global::Vercel.CreateSandboxesByNameForkRequestResources? resources,
            global::System.Collections.Generic.IList<int>? ports,
            string? image,
            int? timeout,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesByNameForkRequestMounts2>? mounts,
            string? name,
            bool? persistent,
            global::Vercel.OneOf<object, int?>? snapshotExpiration,
            global::Vercel.CreateSandboxesByNameForkRequestKeepLastSnapshots? keepLastSnapshots,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.NetworkPolicy = networkPolicy;
            this.Resources = resources;
            this.Ports = ports;
            this.Image = image;
            this.Timeout = timeout;
            this.Env = env;
            this.Mounts = mounts;
            this.Name = name;
            this.Persistent = persistent;
            this.SnapshotExpiration = snapshotExpiration;
            this.KeepLastSnapshots = keepLastSnapshots;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesByNameForkRequest" /> class.
        /// </summary>
        public CreateSandboxesByNameForkRequest()
        {
        }

    }
}