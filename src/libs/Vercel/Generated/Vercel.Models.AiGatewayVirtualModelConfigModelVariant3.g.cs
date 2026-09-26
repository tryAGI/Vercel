
#nullable enable

namespace Vercel
{
    /// <summary>
    /// For kind=router: ordered candidates, bare slugs/references or `{ slug, ...attributes }`. For kind=alias: ordered fallback model slugs, optionally led by one conditional `{ model, when }` entry, used when the primary model's answers match `when`.
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigModelVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AiGatewayEvaluationFallbackConditionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AiGatewayEvaluationFallbackCondition When { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigModelVariant3" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="when"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigModelVariant3(
            string model,
            global::Vercel.AiGatewayEvaluationFallbackCondition when)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.When = when;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigModelVariant3" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigModelVariant3()
        {
        }

    }
}