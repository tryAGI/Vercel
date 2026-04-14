
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Base
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseTypeJsonConverter))]
        public global::Vercel.UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Base" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="attribute"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Base(
            string kind,
            string attribute,
            global::Vercel.UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType type)
        {
            this.Type = type;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Attribute = attribute ?? throw new global::System.ArgumentNullException(nameof(attribute));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Base" /> class.
        /// </summary>
        public UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Base()
        {
        }
    }
}