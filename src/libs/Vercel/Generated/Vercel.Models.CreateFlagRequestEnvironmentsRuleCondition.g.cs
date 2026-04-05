
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagRequestEnvironmentsRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionLhsVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionLhsVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagRequestEnvironmentsRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagRequestEnvironmentsRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.CreateFlagRequestEnvironmentsRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironmentsRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequestEnvironmentsRuleCondition(
            global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionLhsVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionLhsVariant2> lhs,
            global::Vercel.CreateFlagRequestEnvironmentsRuleConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant1, global::Vercel.CreateFlagRequestEnvironmentsRuleConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.CreateFlagRequestEnvironmentsRuleConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironmentsRuleCondition" /> class.
        /// </summary>
        public CreateFlagRequestEnvironmentsRuleCondition()
        {
        }
    }
}