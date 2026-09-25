
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="projectId"></param>
        /// <param name="target"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2(
            string kind,
            string projectId,
            string target)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2" /> class.
        /// </summary>
        public ListVercelCiTaskDefinitionsResponseTaskDefinitionOperationVariant2()
        {
        }

    }
}