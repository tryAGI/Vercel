
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionLhsVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionLhsVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagRequestEnvironmentsRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsRuleCondition(
            global::Vercel.AnyOf<global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionLhsVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2> lhs,
            global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.UpdateFlagRequestEnvironmentsRuleConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRuleCondition" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsRuleCondition()
        {
        }
    }
}