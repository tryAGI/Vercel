
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonReplicasItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alive")]
        public bool? Alive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastCheckedAt")]
        public string? LastCheckedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMiB")]
        public double? MemoryMiB { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stoppedAt")]
        public string? StoppedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonReplicasItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="region"></param>
        /// <param name="startedAt"></param>
        /// <param name="alive"></param>
        /// <param name="image"></param>
        /// <param name="lastCheckedAt"></param>
        /// <param name="memoryMiB"></param>
        /// <param name="stoppedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonReplicasItem(
            string id,
            string region,
            string startedAt,
            bool? alive,
            string? image,
            string? lastCheckedAt,
            double? memoryMiB,
            string? stoppedAt)
        {
            this.Alive = alive;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Image = image;
            this.LastCheckedAt = lastCheckedAt;
            this.MemoryMiB = memoryMiB;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.StartedAt = startedAt ?? throw new global::System.ArgumentNullException(nameof(startedAt));
            this.StoppedAt = stoppedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonReplicasItem" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonReplicasItem()
        {
        }

    }
}