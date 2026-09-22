
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f637bb8b5caf2d6Rule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleCondition> Conditions { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant2> Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f637bb8b5caf2d6Rule" /> class.
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="id"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f637bb8b5caf2d6Rule(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleCondition> conditions,
            string id,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant2> outcome)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f637bb8b5caf2d6Rule" /> class.
        /// </summary>
        public AutoSDKShared0f637bb8b5caf2d6Rule()
        {
        }

    }
}