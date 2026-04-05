
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object contains information related to a Vercel NamedSandbox.
    /// </summary>
    public sealed partial class NamedSandbox
    {
        /// <summary>
        /// The unique identifier of the sandbox.<br/>
        /// Example: my-sandbox
        /// </summary>
        /// <example>my-sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Current snapshot ID that the named sandbox is pointing to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSnapshotId")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// Current session ID the sandbox is pointing to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentSessionId { get; set; }

        /// <summary>
        /// The status of the current sandbox.<br/>
        /// Example: running
        /// </summary>
        /// <example>running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.NamedSandboxStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.NamedSandboxStatus Status { get; set; }

        /// <summary>
        /// The time when the sandbox status was last updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusUpdatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusUpdatedAt { get; set; }

        /// <summary>
        /// Whether the sandbox persists its state across restarts via automatic snapshots.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Persistent { get; set; }

        /// <summary>
        /// The region the sandbox runs in.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Number of virtual CPUs allocated.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpus")]
        public double? Vcpus { get; set; }

        /// <summary>
        /// Memory allocated in MB.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// Runtime identifier.<br/>
        /// Example: node22
        /// </summary>
        /// <example>node22</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        /// Timeout in milliseconds.<br/>
        /// Example: 300000
        /// </summary>
        /// <example>300000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Default snapshot expiration time in milliseconds. 0 means no expiration.<br/>
        /// Example: 604800000
        /// </summary>
        /// <example>604800000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotExpiration")]
        public double? SnapshotExpiration { get; set; }

        /// <summary>
        /// Network policy configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        public global::Vercel.NamedSandboxNetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        /// Cumulative egress bytes across all sandbox runs.<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalEgressBytes")]
        public double? TotalEgressBytes { get; set; }

        /// <summary>
        /// Cumulative ingress bytes across all sandbox runs.<br/>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalIngressBytes")]
        public double? TotalIngressBytes { get; set; }

        /// <summary>
        /// Cumulative active CPU duration in milliseconds across all sandbox runs.<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalActiveCpuDurationMs")]
        public double? TotalActiveCpuDurationMs { get; set; }

        /// <summary>
        /// Cumulative wall-clock duration in milliseconds across all sandbox runs.<br/>
        /// Example: 60000
        /// </summary>
        /// <example>60000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDurationMs")]
        public double? TotalDurationMs { get; set; }

        /// <summary>
        /// The working directory of the sandbox.<br/>
        /// Example: /vercel/sandbox
        /// </summary>
        /// <example>/vercel/sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// Key-value tags attached to the named sandbox.<br/>
        /// Example: {"team":"hive","user":"bob"}
        /// </summary>
        /// <example>{"team":"hive","user":"bob"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// The time when the named sandbox was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The time when the named sandbox was last updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandbox" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique identifier of the sandbox.<br/>
        /// Example: my-sandbox
        /// </param>
        /// <param name="currentSessionId">
        /// Current session ID the sandbox is pointing to.
        /// </param>
        /// <param name="status">
        /// The status of the current sandbox.<br/>
        /// Example: running
        /// </param>
        /// <param name="statusUpdatedAt">
        /// The time when the sandbox status was last updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// The time when the named sandbox was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="updatedAt">
        /// The time when the named sandbox was last updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="currentSnapshotId">
        /// Current snapshot ID that the named sandbox is pointing to.
        /// </param>
        /// <param name="region">
        /// The region the sandbox runs in.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="vcpus">
        /// Number of virtual CPUs allocated.<br/>
        /// Example: 2
        /// </param>
        /// <param name="memory">
        /// Memory allocated in MB.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="runtime">
        /// Runtime identifier.<br/>
        /// Example: node22
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds.<br/>
        /// Example: 300000
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. 0 means no expiration.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="networkPolicy">
        /// Network policy configuration.
        /// </param>
        /// <param name="totalEgressBytes">
        /// Cumulative egress bytes across all sandbox runs.<br/>
        /// Example: 4096
        /// </param>
        /// <param name="totalIngressBytes">
        /// Cumulative ingress bytes across all sandbox runs.<br/>
        /// Example: 2048
        /// </param>
        /// <param name="totalActiveCpuDurationMs">
        /// Cumulative active CPU duration in milliseconds across all sandbox runs.<br/>
        /// Example: 5000
        /// </param>
        /// <param name="totalDurationMs">
        /// Cumulative wall-clock duration in milliseconds across all sandbox runs.<br/>
        /// Example: 60000
        /// </param>
        /// <param name="cwd">
        /// The working directory of the sandbox.<br/>
        /// Example: /vercel/sandbox
        /// </param>
        /// <param name="tags">
        /// Key-value tags attached to the named sandbox.<br/>
        /// Example: {"team":"hive","user":"bob"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedSandbox(
            string name,
            string currentSessionId,
            global::Vercel.NamedSandboxStatus status,
            double statusUpdatedAt,
            bool persistent,
            double createdAt,
            double updatedAt,
            string? currentSnapshotId,
            string? region,
            double? vcpus,
            double? memory,
            string? runtime,
            double? timeout,
            double? snapshotExpiration,
            global::Vercel.NamedSandboxNetworkPolicy? networkPolicy,
            double? totalEgressBytes,
            double? totalIngressBytes,
            double? totalActiveCpuDurationMs,
            double? totalDurationMs,
            string? cwd,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CurrentSnapshotId = currentSnapshotId;
            this.CurrentSessionId = currentSessionId ?? throw new global::System.ArgumentNullException(nameof(currentSessionId));
            this.Status = status;
            this.StatusUpdatedAt = statusUpdatedAt;
            this.Persistent = persistent;
            this.Region = region;
            this.Vcpus = vcpus;
            this.Memory = memory;
            this.Runtime = runtime;
            this.Timeout = timeout;
            this.SnapshotExpiration = snapshotExpiration;
            this.NetworkPolicy = networkPolicy;
            this.TotalEgressBytes = totalEgressBytes;
            this.TotalIngressBytes = totalIngressBytes;
            this.TotalActiveCpuDurationMs = totalActiveCpuDurationMs;
            this.TotalDurationMs = totalDurationMs;
            this.Cwd = cwd;
            this.Tags = tags;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandbox" /> class.
        /// </summary>
        public NamedSandbox()
        {
        }
    }
}