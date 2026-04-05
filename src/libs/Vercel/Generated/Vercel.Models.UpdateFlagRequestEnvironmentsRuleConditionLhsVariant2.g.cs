
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="kind"></param>
        /// <param name="attribute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2(
            object type,
            string kind,
            string attribute)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Attribute = attribute ?? throw new global::System.ArgumentNullException(nameof(attribute));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsRuleConditionLhsVariant2()
        {
        }
    }
}