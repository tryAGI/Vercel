
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFlagVersionsResponseVersionDataEnvironmentsRuleCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp Cmp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataEnvironmentsRuleCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFlagVersionsResponseVersionDataEnvironmentsRuleCondition(
            global::Vercel.OneOf<global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant2> lhs,
            global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmp cmp,
            global::Vercel.OneOf<string, double?, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3, global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4, bool?>? rhs,
            global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionCmpOptions? cmpOptions)
        {
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Cmp = cmp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataEnvironmentsRuleCondition" /> class.
        /// </summary>
        public ListFlagVersionsResponseVersionDataEnvironmentsRuleCondition()
        {
        }
    }
}