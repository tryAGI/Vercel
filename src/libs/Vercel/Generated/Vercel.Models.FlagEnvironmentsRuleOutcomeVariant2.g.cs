
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlagEnvironmentsRuleOutcomeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagEnvironmentsRuleOutcomeVariant2TypeJsonConverter))]
        public global::Vercel.FlagEnvironmentsRuleOutcomeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagEnvironmentsRuleOutcomeVariant2Base Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Weights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagEnvironmentsRuleOutcomeVariant2" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="weights"></param>
        /// <param name="defaultVariantId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlagEnvironmentsRuleOutcomeVariant2(
            global::Vercel.FlagEnvironmentsRuleOutcomeVariant2Base @base,
            global::System.Collections.Generic.Dictionary<string, double> weights,
            string defaultVariantId,
            global::Vercel.FlagEnvironmentsRuleOutcomeVariant2Type type)
        {
            this.Type = type;
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Weights = weights ?? throw new global::System.ArgumentNullException(nameof(weights));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagEnvironmentsRuleOutcomeVariant2" /> class.
        /// </summary>
        public FlagEnvironmentsRuleOutcomeVariant2()
        {
        }
    }
}