
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Without a question, checks every Boolean question.
    /// </summary>
    public sealed partial class AiGatewayEvaluationFallbackConditionVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilityBetween")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> ProbabilityBetween { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant2" /> class.
        /// </summary>
        /// <param name="probabilityBetween"></param>
        /// <param name="question"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayEvaluationFallbackConditionVariant2(
            global::System.Collections.Generic.IList<double> probabilityBetween,
            string? question)
        {
            this.ProbabilityBetween = probabilityBetween ?? throw new global::System.ArgumentNullException(nameof(probabilityBetween));
            this.Question = question;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant2" /> class.
        /// </summary>
        public AiGatewayEvaluationFallbackConditionVariant2()
        {
        }

    }
}