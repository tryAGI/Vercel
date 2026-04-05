
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagResponseEnvironmentsRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionLhsVariant1, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionLhsVariant1, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseEnvironmentsRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseEnvironmentsRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagResponseEnvironmentsRuleCondition(
            global::Vercel.OneOf<global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionLhsVariant1, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2> lhs,
            global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmp cmp,
            global::Vercel.OneOf<string, double?, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3, global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4, bool?>? rhs,
            global::Vercel.UpdateFlagResponseEnvironmentsRuleConditionCmpOptions? cmpOptions)
        {
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Cmp = cmp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseEnvironmentsRuleCondition" /> class.
        /// </summary>
        public UpdateFlagResponseEnvironmentsRuleCondition()
        {
        }
    }
}