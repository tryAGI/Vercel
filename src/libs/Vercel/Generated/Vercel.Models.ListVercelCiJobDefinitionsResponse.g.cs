
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiJobDefinitionsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListVercelCiJobDefinitionsResponseJobDefinition> JobDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiJobDefinitionsResponse" /> class.
        /// </summary>
        /// <param name="jobDefinitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiJobDefinitionsResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListVercelCiJobDefinitionsResponseJobDefinition> jobDefinitions)
        {
            this.JobDefinitions = jobDefinitions ?? throw new global::System.ArgumentNullException(nameof(jobDefinitions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiJobDefinitionsResponse" /> class.
        /// </summary>
        public ListVercelCiJobDefinitionsResponse()
        {
        }

    }
}