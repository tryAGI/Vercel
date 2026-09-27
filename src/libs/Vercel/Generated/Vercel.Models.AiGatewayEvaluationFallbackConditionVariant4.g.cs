
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewayEvaluationFallbackConditionVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AiGatewayEvaluationFallbackCondition> All { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant4" /> class.
        /// </summary>
        /// <param name="all"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayEvaluationFallbackConditionVariant4(
            global::System.Collections.Generic.IList<global::Vercel.AiGatewayEvaluationFallbackCondition> all)
        {
            this.All = all ?? throw new global::System.ArgumentNullException(nameof(all));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayEvaluationFallbackConditionVariant4" /> class.
        /// </summary>
        public AiGatewayEvaluationFallbackConditionVariant4()
        {
        }

    }
}