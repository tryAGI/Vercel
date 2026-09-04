
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object contains information related to a Vercel Sandbox Drive.
    /// </summary>
    public sealed partial class Drive
    {
        /// <summary>
        /// The unique drive ID.<br/>
        /// Example: drive_abc123
        /// </summary>
        /// <example>drive_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique drive name within the project.<br/>
        /// Example: workspace
        /// </summary>
        /// <example>workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The project that owns the drive.<br/>
        /// Example: prj_abc123
        /// </summary>
        /// <example>prj_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The maximum drive size in bytes.<br/>
        /// Example: 1099511627776L
        /// </summary>
        /// <example>1099511627776L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxSizeBytes { get; set; }

        /// <summary>
        /// The region where the drive is stored.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Current session ID the drive is attached to, if any.<br/>
        /// Example: sbx_123
        /// </summary>
        /// <example>sbx_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSessionId")]
        public string? CurrentSessionId { get; set; }

        /// <summary>
        /// Current sandbox name the drive is attached to, if any.<br/>
        /// Example: my-sandbox
        /// </summary>
        /// <example>my-sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentSandboxName")]
        public string? CurrentSandboxName { get; set; }

        /// <summary>
        /// The time when the drive was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </summary>
        /// <example>1750344501629L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The last time the drive was updated, in milliseconds since the epoch.<br/>
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
        /// Initializes a new instance of the <see cref="Drive" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique drive ID.<br/>
        /// Example: drive_abc123
        /// </param>
        /// <param name="name">
        /// The unique drive name within the project.<br/>
        /// Example: workspace
        /// </param>
        /// <param name="projectId">
        /// The project that owns the drive.<br/>
        /// Example: prj_abc123
        /// </param>
        /// <param name="maxSizeBytes">
        /// The maximum drive size in bytes.<br/>
        /// Example: 1099511627776L
        /// </param>
        /// <param name="region">
        /// The region where the drive is stored.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="createdAt">
        /// The time when the drive was created, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="updatedAt">
        /// The last time the drive was updated, in milliseconds since the epoch.<br/>
        /// Example: 1750344501629L
        /// </param>
        /// <param name="currentSessionId">
        /// Current session ID the drive is attached to, if any.<br/>
        /// Example: sbx_123
        /// </param>
        /// <param name="currentSandboxName">
        /// Current sandbox name the drive is attached to, if any.<br/>
        /// Example: my-sandbox
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Drive(
            string id,
            string name,
            string projectId,
            double maxSizeBytes,
            string region,
            double createdAt,
            double updatedAt,
            string? currentSessionId,
            string? currentSandboxName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.MaxSizeBytes = maxSizeBytes;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.CurrentSessionId = currentSessionId;
            this.CurrentSandboxName = currentSandboxName;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Drive" /> class.
        /// </summary>
        public Drive()
        {
        }

    }
}