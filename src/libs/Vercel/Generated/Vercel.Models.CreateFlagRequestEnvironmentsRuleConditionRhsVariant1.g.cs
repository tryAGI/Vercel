
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagRequestEnvironmentsRuleConditionRhsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1ItemVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1ItemVariant2>> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironmentsRuleConditionRhsVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequestEnvironmentsRuleConditionRhsVariant1(
            global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type type,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1ItemVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1ItemVariant2>> items)
        {
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironmentsRuleConditionRhsVariant1" /> class.
        /// </summary>
        public CreateFlagRequestEnvironmentsRuleConditionRhsVariant1()
        {
        }
    }
}