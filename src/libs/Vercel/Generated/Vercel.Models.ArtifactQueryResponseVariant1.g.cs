
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactQueryResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskDurationMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TaskDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dirtyHash")]
        public string? DirtyHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactQueryResponseVariant1" /> class.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="taskDurationMs"></param>
        /// <param name="tag"></param>
        /// <param name="sha"></param>
        /// <param name="dirtyHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactQueryResponseVariant1(
            double size,
            double taskDurationMs,
            string? tag,
            string? sha,
            string? dirtyHash)
        {
            this.Size = size;
            this.TaskDurationMs = taskDurationMs;
            this.Tag = tag;
            this.Sha = sha;
            this.DirtyHash = dirtyHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactQueryResponseVariant1" /> class.
        /// </summary>
        public ArtifactQueryResponseVariant1()
        {
        }
    }
}