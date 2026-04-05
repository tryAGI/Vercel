
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagSegmentResponseDataRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant1, global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant1, global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2> Outcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataRuleCondition> Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRule" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="outcome"></param>
        /// <param name="conditions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentResponseDataRule(
            string id,
            global::Vercel.OneOf<global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant1, global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2> outcome,
            global::System.Collections.Generic.IList<global::Vercel.CreateFlagSegmentResponseDataRuleCondition> conditions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Outcome = outcome;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRule" /> class.
        /// </summary>
        public CreateFlagSegmentResponseDataRule()
        {
        }
    }
}