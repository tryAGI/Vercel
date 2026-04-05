
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentRequestDataRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateFlagSegmentRequestDataRuleConditionLhsVariant1, global::Vercel.UpdateFlagSegmentRequestDataRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.UpdateFlagSegmentRequestDataRuleConditionLhsVariant1, global::Vercel.UpdateFlagSegmentRequestDataRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentRequestDataRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentRequestDataRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateFlagSegmentRequestDataRuleConditionRhsVariant1, global::Vercel.UpdateFlagSegmentRequestDataRuleConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.UpdateFlagSegmentRequestDataRuleConditionRhsVariant1, global::Vercel.UpdateFlagSegmentRequestDataRuleConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.UpdateFlagSegmentRequestDataRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestDataRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentRequestDataRuleCondition(
            global::Vercel.AnyOf<global::Vercel.UpdateFlagSegmentRequestDataRuleConditionLhsVariant1, global::Vercel.UpdateFlagSegmentRequestDataRuleConditionLhsVariant2> lhs,
            global::Vercel.UpdateFlagSegmentRequestDataRuleConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.UpdateFlagSegmentRequestDataRuleConditionRhsVariant1, global::Vercel.UpdateFlagSegmentRequestDataRuleConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.UpdateFlagSegmentRequestDataRuleConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestDataRuleCondition" /> class.
        /// </summary>
        public UpdateFlagSegmentRequestDataRuleCondition()
        {
        }
    }
}