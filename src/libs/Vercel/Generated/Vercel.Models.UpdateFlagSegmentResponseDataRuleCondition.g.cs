
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentResponseDataRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.UpdateFlagSegmentResponseDataRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant1, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant1, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentResponseDataRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentResponseDataRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseDataRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentResponseDataRuleCondition(
            global::Vercel.OneOf<global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant1, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionLhsVariant2> lhs,
            global::Vercel.UpdateFlagSegmentResponseDataRuleConditionCmp cmp,
            global::Vercel.OneOf<string, double?, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant4, bool?>? rhs,
            global::Vercel.UpdateFlagSegmentResponseDataRuleConditionCmpOptions? cmpOptions)
        {
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Cmp = cmp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseDataRuleCondition" /> class.
        /// </summary>
        public UpdateFlagSegmentResponseDataRuleCondition()
        {
        }
    }
}