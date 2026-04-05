
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsRule
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
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestEnvironmentsRuleCondition> Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.UpdateFlagRequestEnvironmentsRuleOutcomeVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleOutcomeVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.UpdateFlagRequestEnvironmentsRuleOutcomeVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleOutcomeVariant2> Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRule" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conditions"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsRule(
            string id,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestEnvironmentsRuleCondition> conditions,
            global::Vercel.AnyOf<global::Vercel.UpdateFlagRequestEnvironmentsRuleOutcomeVariant1, global::Vercel.UpdateFlagRequestEnvironmentsRuleOutcomeVariant2> outcome)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRule" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsRule()
        {
        }
    }
}