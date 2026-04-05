
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagSegmentRequestDataRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateFlagSegmentRequestDataRuleConditionLhsVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.CreateFlagSegmentRequestDataRuleConditionLhsVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagSegmentRequestDataRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagSegmentRequestDataRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.CreateFlagSegmentRequestDataRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequestDataRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentRequestDataRuleCondition(
            global::Vercel.AnyOf<global::Vercel.CreateFlagSegmentRequestDataRuleConditionLhsVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionLhsVariant2> lhs,
            global::Vercel.CreateFlagSegmentRequestDataRuleConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.CreateFlagSegmentRequestDataRuleConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequestDataRuleCondition" /> class.
        /// </summary>
        public CreateFlagSegmentRequestDataRuleCondition()
        {
        }
    }
}