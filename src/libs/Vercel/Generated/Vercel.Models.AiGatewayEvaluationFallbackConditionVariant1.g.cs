
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayEvaluationFallbackConditionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceBelow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfidenceBelow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant1" /> class.
        /// </summary>
        /// <param name="confidenceBelow"></param>
        /// <param name="question"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayEvaluationFallbackConditionVariant1(
            double confidenceBelow,
            string question)
        {
            this.ConfidenceBelow = confidenceBelow;
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant1" /> class.
        /// </summary>
        public AiGatewayEvaluationFallbackConditionVariant1()
        {
        }

    }
}