
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentResponseDataRuleConditionRhsVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3ItemVariant1, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3ItemVariant2>> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseDataRuleConditionRhsVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentResponseDataRuleConditionRhsVariant3(
            global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type type,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3ItemVariant1, global::Vercel.UpdateFlagSegmentResponseDataRuleConditionRhsVariant3ItemVariant2>> items)
        {
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseDataRuleConditionRhsVariant3" /> class.
        /// </summary>
        public UpdateFlagSegmentResponseDataRuleConditionRhsVariant3()
        {
        }
    }
}