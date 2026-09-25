
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiJobDefinitionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetVercelCiJobDefinitionResponseJobDefinition JobDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiJobDefinitionResponse" /> class.
        /// </summary>
        /// <param name="jobDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiJobDefinitionResponse(
            global::Vercel.GetVercelCiJobDefinitionResponseJobDefinition jobDefinition)
        {
            this.JobDefinition = jobDefinition ?? throw new global::System.ArgumentNullException(nameof(jobDefinition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiJobDefinitionResponse" /> class.
        /// </summary>
        public GetVercelCiJobDefinitionResponse()
        {
        }

    }
}