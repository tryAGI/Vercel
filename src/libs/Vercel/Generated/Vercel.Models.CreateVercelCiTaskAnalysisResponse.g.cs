
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVercelCiTaskAnalysisResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysisId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalysisId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskAnalysisResponse" /> class.
        /// </summary>
        /// <param name="analysisId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVercelCiTaskAnalysisResponse(
            string analysisId,
            string status)
        {
            this.AnalysisId = analysisId ?? throw new global::System.ArgumentNullException(nameof(analysisId));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskAnalysisResponse" /> class.
        /// </summary>
        public CreateVercelCiTaskAnalysisResponse()
        {
        }

    }
}