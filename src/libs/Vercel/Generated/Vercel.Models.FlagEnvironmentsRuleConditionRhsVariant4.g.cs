
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlagEnvironmentsRuleConditionRhsVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagEnvironmentsRuleConditionRhsVariant4TypeJsonConverter))]
        public global::Vercel.FlagEnvironmentsRuleConditionRhsVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Flags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagEnvironmentsRuleConditionRhsVariant4" /> class.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="flags"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlagEnvironmentsRuleConditionRhsVariant4(
            string pattern,
            string flags,
            global::Vercel.FlagEnvironmentsRuleConditionRhsVariant4Type type)
        {
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Flags = flags ?? throw new global::System.ArgumentNullException(nameof(flags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagEnvironmentsRuleConditionRhsVariant4" /> class.
        /// </summary>
        public FlagEnvironmentsRuleConditionRhsVariant4()
        {
        }
    }
}