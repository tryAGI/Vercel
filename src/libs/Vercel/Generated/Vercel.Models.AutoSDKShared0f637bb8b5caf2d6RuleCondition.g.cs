
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f637bb8b5caf2d6RuleCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0f637bb8b5caf2d6RuleConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant3, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant3, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f637bb8b5caf2d6RuleCondition" /> class.
        /// </summary>
        /// <param name="cmp"></param>
        /// <param name="lhs"></param>
        /// <param name="cmpOptions"></param>
        /// <param name="rhs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f637bb8b5caf2d6RuleCondition(
            global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionCmp cmp,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2> lhs,
            global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionCmpOptions? cmpOptions,
            global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant3, global::Vercel.AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4, bool?>? rhs)
        {
            this.Cmp = cmp;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Rhs = rhs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f637bb8b5caf2d6RuleCondition" /> class.
        /// </summary>
        public AutoSDKShared0f637bb8b5caf2d6RuleCondition()
        {
        }

    }
}