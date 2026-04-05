
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveProjectEnvResponseVariant2ContentHintVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RemoveProjectEnvResponseVariant2ContentHintVariant15TypeJsonConverter))]
        public global::Vercel.RemoveProjectEnvResponseVariant2ContentHintVariant15Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProjectEnvResponseVariant2ContentHintVariant15" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveProjectEnvResponseVariant2ContentHintVariant15(
            string projectId,
            global::Vercel.RemoveProjectEnvResponseVariant2ContentHintVariant15Type type)
        {
            this.Type = type;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProjectEnvResponseVariant2ContentHintVariant15" /> class.
        /// </summary>
        public RemoveProjectEnvResponseVariant2ContentHintVariant15()
        {
        }
    }
}