
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagSegmentResponseDataRuleOutcomeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagSegmentResponseDataRuleOutcomeVariant1TypeJsonConverter))]
        public global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRuleOutcomeVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentResponseDataRuleOutcomeVariant1(
            global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRuleOutcomeVariant1" /> class.
        /// </summary>
        public CreateFlagSegmentResponseDataRuleOutcomeVariant1()
        {
        }
    }
}