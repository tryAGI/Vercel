
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object contains information related to a Vercel Sandbox.
    /// </summary>
    public sealed partial class Sandbox
    {
        /// <summary>
        /// The unique identifier of the sandbox.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>sbx_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Memory allocated to this sandbox in MB.<br/>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Memory { get; set; }

        /// <summary>
        /// Number of vCPUs allocated to this sandbox.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Vcpus { get; set; }

        /// <summary>
        /// The region where the sandbox is hosted.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// The runtime of the sandbox.<br/>
        /// Example: node22
        /// </summary>
        /// <example>node22</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Runtime { get; set; }

        /// <summary>
        /// The maximum amount of time the sandbox will run for in milliseconds.<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timeout { get; set; }

        /// <summary>
        /// The status of the sandbox.<br/>
        /// Example: running
        /// </summary>
        /// <example>running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SandboxStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SandboxStatus Status { get; set; }

        /// <summary>
        /// The time when the sandbox was requested, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestedAt { get; set; }

        /// <summary>
        /// The time when the sandbox was started, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public double? StartedAt { get; set; }

        /// <summary>
        /// The working directory of the sandbox.<br/>
        /// Example: /vercel/sandbox
        /// </summary>
        /// <example>/vercel/sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cwd { get; set; }

        /// <summary>
        /// The time when the sandbox was requested to stop, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedStopAt")]
        public double? RequestedStopAt { get; set; }

        /// <summary>
        /// The time when the sandbox was stopped, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stoppedAt")]
        public double? StoppedAt { get; set; }

        /// <summary>
        /// The time when the sandbox was aborted, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("abortedAt")]
        public double? AbortedAt { get; set; }

        /// <summary>
        /// The duration of the sandbox in milliseconds.<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The unique identifier of the snapshot associated with this sandbox, if any.<br/>
        /// Example: snap_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>snap_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceSnapshotId")]
        public string? SourceSnapshotId { get; set; }

        /// <summary>
        /// The time when a snapshot was requested, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshottedAt")]
        public double? SnapshottedAt { get; set; }

        /// <summary>
        /// The time when the sandbox was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The last time the sandbox was updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// The network policy applied to this sandbox, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkPolicy")]
        public global::Vercel.SandboxNetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        /// The amount of CPU time the sandbox consumed, if available, in milliseconds. This value is only available once the sandbox is stopped, and only if it stopped successfully.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeCpuDurationMs")]
        public double? ActiveCpuDurationMs { get; set; }

        /// <summary>
        /// The quantity of data transfered to and from the sandbox, in bytes. This value is only available once the sandbox is stopped, and only if it stopped successfully.<br/>
        /// Example: {"in":12543852,"out":15368}
        /// </summary>
        /// <example>{"in":12543852,"out":15368}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkTransfer")]
        public global::Vercel.SandboxNetworkTransfer? NetworkTransfer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sandbox" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the sandbox.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="memory">
        /// Memory allocated to this sandbox in MB.<br/>
        /// Example: 2048
        /// </param>
        /// <param name="vcpus">
        /// Number of vCPUs allocated to this sandbox.<br/>
        /// Example: 2
        /// </param>
        /// <param name="region">
        /// The region where the sandbox is hosted.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="runtime">
        /// The runtime of the sandbox.<br/>
        /// Example: node22
        /// </param>
        /// <param name="timeout">
        /// The maximum amount of time the sandbox will run for in milliseconds.<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="status">
        /// The status of the sandbox.<br/>
        /// Example: running
        /// </param>
        /// <param name="requestedAt">
        /// The time when the sandbox was requested, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="cwd">
        /// The working directory of the sandbox.<br/>
        /// Example: /vercel/sandbox
        /// </param>
        /// <param name="createdAt">
        /// The time when the sandbox was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="updatedAt">
        /// The last time the sandbox was updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="startedAt">
        /// The time when the sandbox was started, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="requestedStopAt">
        /// The time when the sandbox was requested to stop, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="stoppedAt">
        /// The time when the sandbox was stopped, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="abortedAt">
        /// The time when the sandbox was aborted, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="duration">
        /// The duration of the sandbox in milliseconds.<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="sourceSnapshotId">
        /// The unique identifier of the snapshot associated with this sandbox, if any.<br/>
        /// Example: snap_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="snapshottedAt">
        /// The time when a snapshot was requested, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="networkPolicy">
        /// The network policy applied to this sandbox, if any.
        /// </param>
        /// <param name="activeCpuDurationMs">
        /// The amount of CPU time the sandbox consumed, if available, in milliseconds. This value is only available once the sandbox is stopped, and only if it stopped successfully.<br/>
        /// Example: 42
        /// </param>
        /// <param name="networkTransfer">
        /// The quantity of data transfered to and from the sandbox, in bytes. This value is only available once the sandbox is stopped, and only if it stopped successfully.<br/>
        /// Example: {"in":12543852,"out":15368}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sandbox(
            string id,
            double memory,
            double vcpus,
            string region,
            string runtime,
            double timeout,
            global::Vercel.SandboxStatus status,
            double requestedAt,
            string cwd,
            double createdAt,
            double updatedAt,
            double? startedAt,
            double? requestedStopAt,
            double? stoppedAt,
            double? abortedAt,
            double? duration,
            string? sourceSnapshotId,
            double? snapshottedAt,
            global::Vercel.SandboxNetworkPolicy? networkPolicy,
            double? activeCpuDurationMs,
            global::Vercel.SandboxNetworkTransfer? networkTransfer)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Memory = memory;
            this.Vcpus = vcpus;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Runtime = runtime ?? throw new global::System.ArgumentNullException(nameof(runtime));
            this.Timeout = timeout;
            this.Status = status;
            this.RequestedAt = requestedAt;
            this.StartedAt = startedAt;
            this.Cwd = cwd ?? throw new global::System.ArgumentNullException(nameof(cwd));
            this.RequestedStopAt = requestedStopAt;
            this.StoppedAt = stoppedAt;
            this.AbortedAt = abortedAt;
            this.Duration = duration;
            this.SourceSnapshotId = sourceSnapshotId;
            this.SnapshottedAt = snapshottedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NetworkPolicy = networkPolicy;
            this.ActiveCpuDurationMs = activeCpuDurationMs;
            this.NetworkTransfer = networkTransfer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sandbox" /> class.
        /// </summary>
        public Sandbox()
        {
        }
    }
}