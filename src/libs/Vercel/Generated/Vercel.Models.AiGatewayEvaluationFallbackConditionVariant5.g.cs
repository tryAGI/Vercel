
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayEvaluationFallbackConditionVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atLeast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayEvaluationFallbackConditionVariant5AtLeast AtLeast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant5" /> class.
        /// </summary>
        /// <param name="atLeast"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayEvaluationFallbackConditionVariant5(
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant5AtLeast atLeast)
        {
            this.AtLeast = atLeast ?? throw new global::System.ArgumentNullException(nameof(atLeast));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant5" /> class.
        /// </summary>
        public AiGatewayEvaluationFallbackConditionVariant5()
        {
        }

    }
}