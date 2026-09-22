
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFlagSegmentResponseDataRuleCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagSegmentResponseDataRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagSegmentResponseDataRuleConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.CreateFlagSegmentResponseDataRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateFlagSegmentResponseDataRuleConditionLhsVariant1, global::Vercel.CreateFlagSegmentResponseDataRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CreateFlagSegmentResponseDataRuleConditionLhsVariant1, global::Vercel.CreateFlagSegmentResponseDataRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.CreateFlagSegmentResponseDataRuleConditionRhsVariant3, global::Vercel.CreateFlagSegmentResponseDataRuleConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.CreateFlagSegmentResponseDataRuleConditionRhsVariant3, global::Vercel.CreateFlagSegmentResponseDataRuleConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRuleCondition" /> class.
        /// </summary>
        /// <param name="cmp"></param>
        /// <param name="lhs"></param>
        /// <param name="cmpOptions"></param>
        /// <param name="rhs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentResponseDataRuleCondition(
            global::Vercel.CreateFlagSegmentResponseDataRuleConditionCmp cmp,
            global::Vercel.OneOf<global::Vercel.CreateFlagSegmentResponseDataRuleConditionLhsVariant1, global::Vercel.CreateFlagSegmentResponseDataRuleConditionLhsVariant2> lhs,
            global::Vercel.CreateFlagSegmentResponseDataRuleConditionCmpOptions? cmpOptions,
            global::Vercel.OneOf<string, double?, global::Vercel.CreateFlagSegmentResponseDataRuleConditionRhsVariant3, global::Vercel.CreateFlagSegmentResponseDataRuleConditionRhsVariant4, bool?>? rhs)
        {
            this.Cmp = cmp;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Rhs = rhs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRuleCondition" /> class.
        /// </summary>
        public CreateFlagSegmentResponseDataRuleCondition()
        {
        }

    }
}