
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskDefinitionsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskDefinitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinition> TaskDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskDefinitionsResponse" /> class.
        /// </summary>
        /// <param name="taskDefinitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskDefinitionsResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiTaskDefinitionsResponseTaskDefinition> taskDefinitions)
        {
            this.TaskDefinitions = taskDefinitions ?? throw new global::System.ArgumentNullException(nameof(taskDefinitions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskDefinitionsResponse" /> class.
        /// </summary>
        public ListVercelCiTaskDefinitionsResponse()
        {
        }

    }
}