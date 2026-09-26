
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayEvaluationFallbackConditionVariant5AtLeast
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AiGatewayEvaluationFallbackCondition> Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant5AtLeast" /> class.
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayEvaluationFallbackConditionVariant5AtLeast(
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayEvaluationFallbackCondition> conditions,
            double count)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant5AtLeast" /> class.
        /// </summary>
        public AiGatewayEvaluationFallbackConditionVariant5AtLeast()
        {
        }

    }
}