
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3ItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3ItemVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="label"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3ItemVariant1(
            double value,
            string? label,
            string? note)
        {
            this.Label = label;
            this.Note = note;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3ItemVariant1" /> class.
        /// </summary>
        public ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3ItemVariant1()
        {
        }
    }
}