
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagSegmentRequestDataRuleConditionRhsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagSegmentRequestDataRuleConditionRhsVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1ItemVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1ItemVariant2>> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequestDataRuleConditionRhsVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentRequestDataRuleConditionRhsVariant1(
            global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type type,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1ItemVariant1, global::Vercel.CreateFlagSegmentRequestDataRuleConditionRhsVariant1ItemVariant2>> items)
        {
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentRequestDataRuleConditionRhsVariant1" /> class.
        /// </summary>
        public CreateFlagSegmentRequestDataRuleConditionRhsVariant1()
        {
        }
    }
}