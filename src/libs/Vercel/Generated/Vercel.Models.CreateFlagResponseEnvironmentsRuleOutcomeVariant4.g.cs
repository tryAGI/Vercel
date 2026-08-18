
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagResponseEnvironmentsRuleOutcomeVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagResponseEnvironmentsRuleOutcomeVariant4TypeJsonConverter))]
        public global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagResponseEnvironmentsRuleOutcomeVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagResponseEnvironmentsRuleOutcomeVariant4(
            global::Vercel.CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagResponseEnvironmentsRuleOutcomeVariant4" /> class.
        /// </summary>
        public CreateFlagResponseEnvironmentsRuleOutcomeVariant4()
        {
        }

    }
}