
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentResponseDataRuleOutcomeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagSegmentResponseDataRuleOutcomeVariant1TypeJsonConverter))]
        public global::Vercel.UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseDataRuleOutcomeVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentResponseDataRuleOutcomeVariant1(
            global::Vercel.UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentResponseDataRuleOutcomeVariant1" /> class.
        /// </summary>
        public UpdateFlagSegmentResponseDataRuleOutcomeVariant1()
        {
        }
    }
}